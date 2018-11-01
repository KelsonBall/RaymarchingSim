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
            State = new byte[scene.NodeEntities.Length];
            Value = new double[scene.NodeEntities.Length];
            Color = new vec3[scene.NodeEntities.Length];
            Position = new vec3[scene.NodeEntities.Length];
            BackgroundColor = backgroundColor;
        }

        protected readonly byte[] State;

        protected readonly double[] Value;

        protected readonly vec3[] Color;

        protected readonly vec3[] Position;

        protected int Index;
        protected int Next;

        const byte DONE = 0xFF;

        protected void ClearState()
        {
            for (int i = 0; i < State.Length; i++)
                State[i] = 0;
            // no need to clear Value or Color, past runs shouldn't effect Value or Color state
        }

        protected void HandleColorOp()
        {
            var node = scene.NodeEntities[Index];
            var state = State[Index];
            
            if (state == 0)
            {
                State[Index] = 1;
                Color[Index] = scene.Vector3Entities[node.ParameterId];
                Position[node.Left] = Position[Index];
                Next = node.Left;
            }
            else if (state == 1) 
            {
                Value[Index] = Value[node.Left];
                State[Index] = DONE;
                Next = node.Parent;
            }            
        }

        protected void HandleUnionOp()
        {
            var node = scene.NodeEntities[Index];
            var state = State[Index];
            
            if (state == 0)
            {
                State[Index] = 1;
                Position[node.Left] = Position[Index];
                Next = node.Left;
            }
            else if (state == 1)
            {
                State[Index] = 2;
                Position[node.Right] = Position[Index];
                Next = node.Right;
            }
            else if (state == 2)
            {                
                if (Value[node.Left] < Value[node.Right])
                {
                    Value[Index] = Value[node.Left];
                    Color[Index] = Color[node.Left];
                }
                else
                {
                    Value[Index] = Value[node.Right];
                    Color[Index] = Color[node.Right];
                }
                State[Index] = DONE;
                Next = node.Parent;
            }
        }

        protected void HandleIntersectionOp()
        {
            var node = scene.NodeEntities[Index];
            var state = State[Index];

            if (state == 0)
            {
                State[Index] = 1;
                Position[node.Left] = Position[Index];
                Next = node.Left;
            }
            else if (state == 1)
            {
                State[Index] = 2;
                Position[node.Right] = Position[Index];
                Next = node.Right;
            }
            else if (state == 2)
            {
                if (Value[node.Left] > Value[node.Right])
                {
                    Value[Index] = Value[node.Left];
                    Color[Index] = Color[node.Left];
                }
                else
                {
                    Value[Index] = Value[node.Right];
                    Color[Index] = Color[node.Right];
                }
                State[Index] = DONE;
                Next = node.Parent;
            }            
        }

        protected void HandleSubtractionOp()
        {
            var node = scene.NodeEntities[Index];
            var state = State[Index];

            if (state == 0)
            {
                State[Index] = 1;
                Position[node.Left] = Position[Index];
                Next = node.Left;
            }
            else if (state == 1)
            {
                State[Index] = 2;
                Position[node.Right] = Position[Index];
                Next = node.Right;
            }
            else if (state == 2)
            {
                if (Value[node.Left] > -Value[node.Right])
                {
                    Value[Index] = Value[node.Left];
                    Color[Index] = Color[node.Left];
                }
                else
                {
                    Value[Index] = -Value[node.Right];
                    Color[Index] = Color[node.Right];
                }
                State[Index] = DONE;
                Next = node.Parent;
            }            
        }

        protected void HandleTransformOp()
        {
            var node = scene.NodeEntities[Index];
            var state = State[Index];

            if (state == 0)
            { 
                State[Index] = 1;
                var mat = scene.MatrixEntities[node.ParameterId];
                var pos = Position[Index];
                Position[node.Left] = mat.AppliedTo(pos);
                Next = node.Left;
            }
            else if (state == 1)
            {
                State[Index] = DONE;
                Value[Index] = Value[node.Left];
                Color[Index] = Color[node.Left];
                Next = node.Parent;
            }
        }

        protected void HandleTranslationOp()
        {
            var node = scene.NodeEntities[Index];
            var state = State[Index];

            if (state == 0)
            {
                State[Index] = 1;
                var vec = scene.Vector3Entities[node.ParameterId];
                var pos = Position[Index];
                Position[node.Left] = pos + vec;
                Next = node.Left;
            }
            else if (state == 1)
            {
                State[Index] = DONE;
                Value[Index] = Value[node.Left];
                Color[Index] = Color[node.Left];
                Next = node.Parent;
            }
        }

        protected void HandleSphereOp()
        {
            var node = scene.NodeEntities[Index];            

            Value[Index] = Position[Index].Magnitude() - scene.DoubleEntities[node.ParameterId];

            Next = node.Parent;            
        }

        protected void HandleBoxOp()
        {
            var node = scene.NodeEntities[Index];

            var position = Position[Index];
            var size = scene.DoubleEntities[node.ParameterId];
            var d = new vec3(Math.Abs(position.X), Math.Abs(position.Y), Math.Abs(position.Z)) - (size, size, size);
            var inside = Math.Min(Math.Max(d.X, Math.Max(d.Y, d.Z)), 0);
            var outside = new vec3(Math.Max(d.X, 0), Math.Max(d.Y, 0), Math.Max(d.Z, 0)).Magnitude();
            Value[Index] = inside + outside;

            Next = node.Parent;
        }
        
        protected MarchResult Sdf_March(vec3 initial)
        {
            ClearState();
            Index = 0;
            Position[Index] = initial;
            while (true)
            {
                switch (scene.NodeEntities[Index].Operation)
                {
                    case OpType3d.Color:
                        HandleColorOp();
                        break;
                    case OpType3d.CsgUnion:
                        HandleUnionOp();
                        break;
                    case OpType3d.CsgIntersect:
                        HandleIntersectionOp();
                        break;
                    case OpType3d.CsgSubtract:
                        HandleSubtractionOp();
                        break;
                    case OpType3d.SpatialTransform:
                        HandleTransformOp();
                        break;
                    case OpType3d.SpatialTranslation:
                        HandleTranslationOp();
                        break;
                    case OpType3d.ShapeSphere:
                        HandleSphereOp();
                        break;
                    case OpType3d.ShapeBox:
                        HandleBoxOp();
                        break;
                    default:
                        throw new InvalidOperationException();
                }
                Index = Next;
                if (Index == 0 && State[Index] == 0xFF)
                    break;
            }

            return new MarchResult(Value[Index], Color[Index]);
        }

        protected const double FieldOfView = Math.PI / 3.5;
        protected const int MarchLimit = 250;
        protected const double DrawDistance = 30;
        protected const double MinStepLength = 0.025;
        protected const double NormalEpsilon = 0.01;

        protected vec3 getUvRay(double fov, vec2 uv, vec2 size)
        {
            vec2 xy = uv - (size / 2);
            var z = size.y / (Math.Tan(fov) / 2);
            return new vec3(xy, -z).Unit();
        }

        protected vec3 estimateNormal(vec3 p)
        {
            return new vec3(
                Sdf_March(new vec3(p.X + NormalEpsilon, p.Y, p.Z)).Value - Sdf_March(new vec3(p.X - NormalEpsilon, p.Y, p.Z)).Value,
                Sdf_March(new vec3(p.X, p.Y + NormalEpsilon, p.Z)).Value - Sdf_March(new vec3(p.X, p.Y - NormalEpsilon, p.Z)).Value,
                Sdf_March(new vec3(p.X, p.Y, p.Z + NormalEpsilon)).Value - Sdf_March(new vec3(p.X, p.Y, p.Z - NormalEpsilon)).Value
            ).Unit();
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
