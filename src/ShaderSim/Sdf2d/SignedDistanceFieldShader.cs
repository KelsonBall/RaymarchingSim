using System;
using Kelson.Common.Vectors;

namespace ShaderSim.Sdf2d
{
    public struct SignedDistanceFieldShader : IShader
    {
        private readonly ref struct MarchResult
        {
            public readonly double Value;
            public readonly vec3 Color;

            public MarchResult(double value, vec3 color)
                => (Value, Color) = (value, color);
        }

        private readonly SdfScene scene;

        public SignedDistanceFieldShader(SdfScene scene)
        {
            this.scene = scene;
        }

        MarchResult Sdf_March(vec2 position, int node)
        {
            var entity = scene.Entities[node];
            MarchResult left_result;
            MarchResult right_result;
            switch (entity.Operation)
            {
                case OpType.Color:
                    left_result = Sdf_March(position, entity.LeftOpId);
                    if (left_result.Color == new vec3(0, 0, 0))
                        return new MarchResult(Sdf_March(position, entity.LeftOpId).Value, entity.Parameter);
                    else
                        return left_result;
                case OpType.Union:
                    left_result = Sdf_March(position, entity.LeftOpId);
                    right_result = Sdf_March(position, entity.RightOpId);
                    if (left_result.Value < right_result.Value)
                        return left_result;
                    else
                        return right_result;
                case OpType.Intersect:
                    left_result = Sdf_March(position, entity.LeftOpId);
                    right_result = Sdf_March(position, entity.RightOpId);
                    if (left_result.Value > right_result.Value)
                        return left_result;
                    else
                        return right_result;
                case OpType.Subtract:
                    left_result = Sdf_March(position, entity.LeftOpId);
                    right_result = Sdf_March(position, entity.RightOpId);
                    right_result = new MarchResult(-right_result.Value, right_result.Color);
                    if (left_result.Value > right_result.Value)
                        return left_result;
                    else
                        return right_result;
                case OpType.ShapeCircle:
                    return new MarchResult((entity.Offset - position).Magnitude() - entity.Parameter.X, (0, 0, 0));                    
                case OpType.ShapeRectangle:
                    var d = (entity.Offset - position);
                    d = new vec2(Math.Abs(d.X), Math.Abs(d.Y)) - (entity.Parameter.X, entity.Parameter.Y);
                    var inside = Math.Min(Math.Max(d.X, d.Y), 0);
                    var outside = new vec2(Math.Max(d.X, 0), Math.Max(d.Y, 0)).Magnitude();
                    return new MarchResult(inside + outside, (0, 0, 0));                    
                default:
                    throw new InvalidOperationException();
            }
        }
        
        public vec4 Run(vec2 xy, vec2 wh)
        {
            var result = Sdf_March(xy, 1);
            if (result.Value < 0)
                return new vec4(result.Color, 1);
            else if (((int)result.Value) % 10 == 0)
                return new vec4(0, 0, 0, 1);
            else if (((int)result.Value) % 10 == 1 || ((int)result.Value) % 10 == 9)
                return new vec4(0.8, 0.8, 0.8, 1);
            else
                return new vec4(1, 1, 1, 1);
        }
    }
}
