using System;
using System.Diagnostics;
using Kelson.Common.Vectors;
using RaymarchingScenes;

namespace ShaderSim
{
    public class RayMarchStateMachineShader : IShader
    {
        protected readonly ref struct MarchResult
        {
            public readonly double Value;
            public readonly vec3 Color;

            public MarchResult(double value, vec3 color)
                => (Value, Color) = (value, color);
        }

        protected readonly RaymarchScene scene;

        public vec3 BackgroundColor { get; set; }

        public RayMarchStateMachineShader(RaymarchScene scene, vec3 backgroundColor = default)
        {
            this.scene = scene;            
            BackgroundColor = backgroundColor;
        }


        protected struct MarchStep
        {
            public uint Index;
            public uint Next;
            public uint State;
            public double Value;
            public double LeftValue;
            public double RightValue;
            public vec3 Color;
            public vec3 LeftColor;
            public vec3 RightColor;
            public vec3 Position;
            public vec3 LeftPosition;
            public vec3 RightPosition;            
        }

        const byte DONE = 0xFF;
       
        protected void HandleColorOp(ref MarchStep step)
        {
            var node = scene.NodeEntities[step.Index];
            
            if (step.State == 0)
            {
                step.State = 1;
                step.Color = scene.Vector3Entities[node.Parameter];
                step.LeftPosition = step.Position;
                step.Next = node.Left;
            }
            else if (step.State == 1) 
            {
                step.Value = step.LeftValue;
                step.State = DONE;
                step.Next = node.Parent;
            }            
        }

        protected void HandleUnionOp(ref MarchStep step)
        {
            var node = scene.NodeEntities[step.Index];
            
            
            if (step.State == 0)
            {
                step.State = 1;
                step.LeftPosition = step.Position;
                step.Next = node.Left;
            }
            else if (step.State == 1)
            {
                step.State = 2;
                step.RightPosition = step.Position;
                step.Next = node.Right;
            }
            else if (step.State == 2)
            {                
                if (step.LeftValue < step.RightValue)
                {
                    step.Value = step.LeftValue;
                    step.Color = step.LeftColor;
                }
                else
                {
                    step.Value = step.RightValue;
                    step.Color = step.RightColor;
                }
                step.State = DONE;
                step.Next = node.Parent;
            }
        }

        protected void HandleIntersectionOp(ref MarchStep step)
        {
            var node = scene.NodeEntities[step.Index];
            

            if (step.State == 0)
            {
                step.State = 1;
                step.LeftPosition = step.Position;
                step.Next = node.Left;
            }
            else if (step.State == 1)
            {
                step.State = 2;
                step.RightPosition = step.Position;
                step.Next = node.Right;
            }
            else if (step.State == 2)
            {
                if (step.LeftValue > step.RightValue)
                {
                    step.Value = step.LeftValue;
                    step.Color = step.LeftColor;
                }
                else
                {
                    step.Value = step.RightValue;
                    step.Color = step.RightColor;
                }
                step.State = DONE;
                step.Next = node.Parent;
            }            
        }

        protected void HandleSubtractionOp(ref MarchStep step)
        {
            var node = scene.NodeEntities[step.Index];
            

            if (step.State == 0)
            {
                step.State = 1;
                step.LeftPosition = step.Position;
                step.Next = node.Left;
            }
            else if (step.State == 1)
            {
                step.State = 2;
                step.RightPosition = step.Position;
                step.Next = node.Right;
            }
            else if (step.State == 2)
            {
                if (step.LeftValue > -step.RightValue)
                {
                    step.Value = step.LeftValue;
                    step.Color = step.LeftColor;
                }
                else
                {
                    step.Value = -step.RightValue;
                    step.Color = step.RightColor;
                }
                step.State = DONE;
                step.Next = node.Parent;
            }            
        }

        protected void HandleTransformOp(ref MarchStep step)
        {
            var node = scene.NodeEntities[step.Index];
            

            if (step.State == 0)
            { 
                step.State = 1;
                var mat = scene.MatrixEntities[node.Parameter];
                var pos = step.Position;
                step.LeftPosition = mat.AppliedTo(pos);
                step.Next = node.Left;
            }
            else if (step.State == 1)
            {
                step.State = DONE;
                step.Value = step.LeftValue;
                step.Color = step.LeftColor;
                step.Next = node.Parent;
            }
        }

        protected void HandleTranslationOp(ref MarchStep step)
        {
            var node = scene.NodeEntities[step.Index];
            

            if (step.State == 0)
            {
                step.State = 1;
                var vec = scene.Vector3Entities[node.Parameter];
                var pos = step.Position;
                step.LeftPosition = pos + vec;
                step.Next = node.Left;
            }
            else if (step.State == 1)
            {
                step.State = DONE;
                step.Value = step.LeftValue;
                step.Color = step.LeftColor;
                step.Next = node.Parent;
            }
        }

        protected void HandleSphereOp(ref MarchStep step)
        {
            var node = scene.NodeEntities[step.Index];            

            step.Value = step.Position.Magnitude() - scene.DoubleEntities[node.Parameter];

            step.Next = node.Parent;            
        }

        protected void HandleBoxOp(ref MarchStep step)
        {
            var node = scene.NodeEntities[step.Index];

            var position = step.Position;
            var size = scene.DoubleEntities[node.Parameter];
            var d = new vec3(Math.Abs(position.X), Math.Abs(position.Y), Math.Abs(position.Z)) - (size, size, size);
            var inside = Math.Min(Math.Max(d.X, Math.Max(d.Y, d.Z)), 0);
            var outside = new vec3(Math.Max(d.X, 0), Math.Max(d.Y, 0), Math.Max(d.Z, 0)).Magnitude();
            step.Value = inside + outside;

            step.Next = node.Parent;
        }
        
        protected MarchResult Sdf_March(vec3 initial)
        {
            var steps = new MarchStep[scene.NodeEntities.Length];
            
            steps[0].Position = initial;
            uint index = 0;            

            while (true)
            {
                var node = scene.NodeEntities[index];

                if (node.Left > 0)
                {
                    steps[index].LeftValue = steps[node.Left].Value;
                    steps[index].LeftColor = steps[node.Left].Color;
                }

                if (node.Right > 0)
                {
                    steps[index].RightValue = steps[node.Right].Value;
                    steps[index].RightColor = steps[node.Right].Color;
                }


                steps[index].Index = index;
                switch (scene.NodeEntities[index].Operation)
                {
                    case OpType3d.Color:
                        HandleColorOp(ref steps[index]);
                        break;
                    case OpType3d.CsgUnion:
                        HandleUnionOp(ref steps[index]);
                        break;
                    case OpType3d.CsgIntersect:
                        HandleIntersectionOp(ref steps[index]);
                        break;
                    case OpType3d.CsgSubtract:
                        HandleSubtractionOp(ref steps[index]);
                        break;
                    case OpType3d.SpatialTransform:
                        HandleTransformOp(ref steps[index]);
                        break;
                    case OpType3d.SpatialTranslation:
                        HandleTranslationOp(ref steps[index]);
                        break;
                    case OpType3d.ShapeSphere:
                        HandleSphereOp(ref steps[index]);
                        break;
                    case OpType3d.ShapeBox:
                        HandleBoxOp(ref steps[index]);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
                
                if (node.Left > 0)                
                    steps[node.Left].Position = steps[index].LeftPosition;
                    
                if (node.Right > 0)                
                    steps[node.Right].Position = steps[index].RightPosition;                                    

                index = steps[index].Next;

                if (index == 0 && steps[index].State == 0xFF)
                    break;
            }

            return new MarchResult(steps[0].Value, steps[0].Color);
        }

        protected const double FieldOfView = Math.PI / 3.5;
        protected const int MarchLimit = 250;
        protected const double DrawDistance = 30;
        protected const double MinStepLength = 0.025;
        protected const double NormalEpsilon = 0.1;

        protected vec3 getUvRay(double fov, vec2 uv, vec2 size)
        {
            vec2 xy = uv - (size / 2);
            var z = size.y / (Math.Tan(fov) / 2);
            return new vec3(xy, -z).Unit();
        }

        protected vec3 estimateNormal(vec3 p)
        {
            var dir = new vec3(
                Sdf_March(new vec3(p.X + NormalEpsilon, p.Y, p.Z)).Value - Sdf_March(new vec3(p.X - NormalEpsilon, p.Y, p.Z)).Value,
                Sdf_March(new vec3(p.X, p.Y + NormalEpsilon, p.Z)).Value - Sdf_March(new vec3(p.X, p.Y - NormalEpsilon, p.Z)).Value,
                Sdf_March(new vec3(p.X, p.Y, p.Z + NormalEpsilon)).Value - Sdf_March(new vec3(p.X, p.Y, p.Z - NormalEpsilon)).Value
            );
            var normal = dir.Unit();

            return normal;
        }

        public virtual vec4 Run(vec2 xy, vec2 wh)
        {
            var ray = getUvRay(FieldOfView, xy, wh);

            //if (xy.X == 89 && xy.Y == 77)
            //    Debugger.Break();

            vec3 position = (0, 0, 0);
            var last_result = Sdf_March(position);
            double traveled = 0;

            for (int marches = 0; marches < MarchLimit; marches++)
            {
                if (last_result.Value < MinStepLength)
                {
                    var normal = estimateNormal(position);
                    var value = (normal - (0, 1, 0)).Magnitude() - 0.8;

                    return new vec4(last_result.Color * Math.Min(Math.Max(value, 0), 1), 1.0);
                }

                if (traveled > DrawDistance)
                    break;

                var distance = last_result.Value;
                position += ray * distance;
                traveled += distance;

                last_result = Sdf_March(position);
            }

            return new vec4(BackgroundColor, 1.0);
        }
    }
}
