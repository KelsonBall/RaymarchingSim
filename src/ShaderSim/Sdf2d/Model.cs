using Kelson.Common.Vectors;
using System;

namespace ShaderSim.Sdf2d
{
    public class Model
    {
        public OpType Operation { get; private set; }

        public int Count { get; private set; } = 1;

        public Model Left { get; private set; }
        public Model Right { get; private set; }

        public vec2 Offset { get; private set; }
        public vec3 Parameter { get; private set; }

        public void ToOpRecord(ref int id, Action<SdfOp2d> add)
        {
            int my_id = id;
            int? left_id = null;
            int? right_id = null;
            if (Left != null)
            {
                id++;
                left_id = id;
                Left.ToOpRecord(ref id, add);
            }

            if (Right != null)
            {
                id++;
                right_id = id;
                Right.ToOpRecord(ref id, add);
            }

            add(new SdfOp2d(my_id, Operation, left_id, right_id, Offset, Parameter));
        }

        public static Model Subtract(Model left, Model right)
        {
            return new Model
            {
                Operation = OpType.Subtract,
                Left = left,
                Right = right,
                Count = 1 + left.Count + right.Count
            };
        }

        public static Model Intersect(Model left, Model right)
        {
            return new Model
            {
                Operation = OpType.Intersect,
                Left = left,
                Right = right,
                Count = 1 + left.Count + right.Count,
            };
        }

        public static Model Union(Model left, Model right)
        {
            return new Model
            {
                Operation = OpType.Union,
                Left = left,
                Right = right,
                Count = 1 + left.Count + right.Count
            };
        }

        public static Model Circle(vec2 position, double size)
        {
            return new Model
            {
                Operation = OpType.ShapeCircle,
                Offset = position,
                Parameter = new vec3(size, 0, 0),
                Count = 1,
            };
        }

        public static Model Rectangle(vec2 position, vec2 size)
        {
            return new Model
            {
                Operation = OpType.ShapeRectangle,
                Offset = position,
                Parameter = new vec3(size, 0),
                Count = 1,
            };

        }

        public static Model Color(vec3 color, Model left)
        {
            return new Model
            {
                Operation = OpType.Color,
                Left = left,
                Parameter = color,
                Count = 1 + left.Count,
            };
        }
    }
}
