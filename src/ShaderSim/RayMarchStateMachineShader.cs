using System;
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

        protected MarchStep HandleColorOp(MarchStep step)
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

            return step;
        }

        protected MarchStep HandleUnionOp(MarchStep step)
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

            return step;
        }

        protected MarchStep HandleIntersectionOp(MarchStep step)
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

            return step;
        }

        protected MarchStep HandleSubtractionOp(MarchStep step)
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

            return step;
        }

        protected MarchStep HandleTransformOp(MarchStep step)
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

            return step;
        }

        protected MarchStep HandleTranslationOp(MarchStep step)
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

            return step;
        }

        protected MarchStep HandleSphereOp(MarchStep step)
        {
            var node = scene.NodeEntities[step.Index];

            step.Value = step.Position.Magnitude() - scene.DoubleEntities[node.Parameter];
            step.Next = node.Parent;

            return step;
        }

        protected MarchStep HandleBoxOp(MarchStep step)
        {
            var node = scene.NodeEntities[step.Index];

            var position = step.Position;
            var size = scene.DoubleEntities[node.Parameter];
            var d = new vec3(Math.Abs(position.X), Math.Abs(position.Y), Math.Abs(position.Z)) - (size, size, size);
            var inside = Math.Min(Math.Max(d.X, Math.Max(d.Y, d.Z)), 0);
            var outside = new vec3(Math.Max(d.X, 0), Math.Max(d.Y, 0), Math.Max(d.Z, 0)).Magnitude();
            step.Value = inside + outside;

            step.Next = node.Parent;

            return step;
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
                        steps[index] = HandleColorOp(steps[index]);
                        break;
                    case OpType3d.CsgUnion:
                        steps[index] = HandleUnionOp(steps[index]);
                        break;
                    case OpType3d.CsgIntersect:
                        steps[index] = HandleIntersectionOp(steps[index]);
                        break;
                    case OpType3d.CsgSubtract:
                        steps[index] = HandleSubtractionOp(steps[index]);
                        break;
                    case OpType3d.SpatialTransform:
                        steps[index] = HandleTransformOp(steps[index]);
                        break;
                    case OpType3d.SpatialTranslation:
                        steps[index] = HandleTranslationOp(steps[index]);
                        break;
                    case OpType3d.ShapeSphere:
                        steps[index] = HandleSphereOp(steps[index]);
                        break;
                    case OpType3d.ShapeBox:
                        steps[index] = HandleBoxOp(steps[index]);
                        break;
                    default:
                        throw new InvalidOperationException();
                }

                if (node.Left > 0)
                    steps[node.Left].Position = steps[index].LeftPosition;

                if (node.Right > 0)
                    steps[node.Right].Position = steps[index].RightPosition;

                index = steps[index].Next;

                if (index == 0 && steps[index].State == DONE)
                    break;
            }

            return new MarchResult(steps[0].Value, steps[0].Color);
        }

        protected const double FieldOfView = Math.PI / 3.5;
        protected const int MarchLimit = 100;
        protected const double DrawDistance = 30;
        protected const double MinStepLength = 0.025;
        protected const double NormalEpsilon = 0.1;

        protected vec3 getUvRay(double fov, vec2 uv, vec2 size)
        {
            var HalfTanFov = Math.Tan(fov) / 2;
            vec2 xy = uv - (size / 2);
            var z = size.y / HalfTanFov;
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

            vec3 position = (0, 0, 0);
           
            var last_result = Sdf_March(position + (ray * 5));
            
            double traveled = 0;

            for (int marches = 0; marches < MarchLimit && traveled < DrawDistance; marches++)
            {
                if (last_result.Value < MinStepLength)
                {                    
                    return new vec4(1.0, 1.0, 1.0, 1.0);
                }
                
                var distance = last_result.Value;
                position += ray * distance;
                traveled += distance;

                last_result = Sdf_March(position);
            }

            return new vec4((ray / 2) + (0.5, 0.5, 0.5), 1.0);
        }
    }
}
