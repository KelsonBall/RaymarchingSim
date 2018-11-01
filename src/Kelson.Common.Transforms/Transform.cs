using Kelson.Common.Vectors;
using System;
using System.Runtime.InteropServices;

namespace Kelson.Common.Transforms
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct Transform
    {
        [FieldOffset(0)]
        private readonly float _i1;
        [FieldOffset(4)]
        private readonly float _j1;
        [FieldOffset(8)]
        private readonly float _k1;
        [FieldOffset(12)]
        private readonly float _w1;
        [FieldOffset(16)]
        private readonly float _i2;
        [FieldOffset(20)]
        private readonly float _j2;
        [FieldOffset(24)]
        private readonly float _k2;
        [FieldOffset(28)]
        private readonly float _w2;
        [FieldOffset(32)]
        private readonly float _i3;
        [FieldOffset(36)]
        private readonly float _j3;
        [FieldOffset(40)]
        private readonly float _k3;
        [FieldOffset(44)]
        private readonly float _w3;
        [FieldOffset(48)]
        private readonly float _i4;
        [FieldOffset(52)]
        private readonly float _j4;
        [FieldOffset(56)]
        private readonly float _k4;
        [FieldOffset(60)]
        private readonly float _w4;

        private double i1 => _i1;
        private double j1 => _j1;
        private double k1 => _k1;
        private double w1 => _w1;
        private double i2 => _i2;
        private double j2 => _j2;
        private double k2 => _k2;
        private double w2 => _w2;
        private double i3 => _i3;
        private double j3 => _j3;
        private double k3 => _k3;
        private double w3 => _w3;
        private double i4 => _i4;
        private double j4 => _j4;
        private double k4 => _k4;
        private double w4 => _w4;

        public unsafe double this[int index]
        {
            get
            {
                fixed (Transform* t = &this)
                    return *((float*)((void*)t) + index);
            }
        }

        public vec4 RowVector(int index)
        {
            switch (index)
            {
                case 0:
                    return new vec4(_i1, _j1, _k1, _w1);
                case 1:
                    return new vec4(_i2, _j2, _k2, _w2);
                case 2:
                    return new vec4(_i3, _j3, _k3, _w3);
                case 3:
                    return new vec4(_i4, _j4, _k4, _w4);
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        public vec4 ColumnVector(int index)
        {
            switch (index)
            {
                case 0:
                    return new vec4(_i1, _i2, _i3, _i4);
                case 1:
                    return new vec4(_j1, _j2, _j3, _j4);
                case 2:
                    return new vec4(_k1, _k2, _k3, _k4);
                case 3:
                    return new vec4(_w1, _w2, _w3, _w4);
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        public static Transform FromRowMajorArray(double[] row_major_array) =>
            new Transform(
                i1: row_major_array[0], j1: row_major_array[1], k1: row_major_array[2], w1: row_major_array[3],
                i2: row_major_array[4], j2: row_major_array[5], k2: row_major_array[6], w2: row_major_array[7],
                i3: row_major_array[8], j3: row_major_array[9], k3: row_major_array[10], w3: row_major_array[11],
                i4: row_major_array[12], j4: row_major_array[13], k4: row_major_array[14], w4: row_major_array[15]);

        public static Transform FromRowMajorArray(float[] row_major_array) =>
            new Transform(
                i1: row_major_array[0], j1: row_major_array[1], k1: row_major_array[2], w1: row_major_array[3],
                i2: row_major_array[4], j2: row_major_array[5], k2: row_major_array[6], w2: row_major_array[7],
                i3: row_major_array[8], j3: row_major_array[9], k3: row_major_array[10], w3: row_major_array[11],
                i4: row_major_array[12], j4: row_major_array[13], k4: row_major_array[14], w4: row_major_array[15]);

        public Transform(
                double i1, double j1, double k1, double w1,
                double i2, double j2, double k2, double w2,
                double i3, double j3, double k3, double w3,
                double i4, double j4, double k4, double w4)
            : this(
                i1: (float)i1, j1: (float)j1, k1: (float)k1, w1: (float)w1,
                i2: (float)i2, j2: (float)j2, k2: (float)k2, w2: (float)w2,
                i3: (float)i3, j3: (float)j3, k3: (float)k3, w3: (float)w3,
                i4: (float)i4, j4: (float)j4, k4: (float)k4, w4: (float)w4)
        {
        }


        public Transform(
            float i1, float j1, float k1, float w1,
            float i2, float j2, float k2, float w2,
            float i3, float j3, float k3, float w3,
            float i4, float j4, float k4, float w4)
        {
            _i1 = i1; _j1 = j1; _k1 = k1; _w1 = w1;
            _i2 = i2; _j2 = j2; _k2 = k2; _w2 = w2;
            _i3 = i3; _j3 = j3; _k3 = k3; _w3 = w3;
            _i4 = i4; _j4 = j4; _k4 = k4; _w4 = w4;
        }

        public unsafe ReadOnlySpan<float> AsSpan()
        {
            fixed (Transform* t = &this)
                return new ReadOnlySpan<float>(t, 16);
        }
    }
}

