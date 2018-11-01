using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Kelson.Common.Vectors
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly partial struct vec4 : IVector<vec4>
    {
        //[FieldOffset(0)]
        private readonly float x;
        public double X => x;

        //[FieldOffset(4)]
        private readonly float y;
        public double Y => y;

        //[FieldOffset(8)]
        private readonly float z;
        public double Z => z;

        //[FieldOffset(12)]
        private readonly float w;
        public double W => w;

        public vec4(double x, double y, double z, double w) : this((float)x, (float)y, (float)z, (float)w) { }

        public vec4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double MagnitudeSquared() => Dot(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double Magnitude() => Math.Sqrt(Dot(this));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double Dot(in vec4 other) => (X * other.X) + (Y * other.Y) + (Z * other.Z) + (W * other.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec4 Add(in vec4 other) => new vec4(X + other.X, Y + other.Y, Z + other.Z, W + other.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec4 Sub(in vec4 other) => new vec4(X - other.X, Y - other.Y, Z - other.Z, W - other.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec4 Scale(double scalar) => new vec4(X * scalar, Y * scalar, Z * scalar, W * scalar);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec4 Unit() => Scale(1d / Magnitude());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double AngularMagnitude(in vec4 other) => Math.Acos(Dot(other) / (Magnitude() * other.Magnitude()) );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator vec4(in (float x, float y, float z, float w) t) => new vec4(t.x, t.y, t.z, t.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator vec4(Tuple<double, double, double, double> t) => new vec4(t.Item1, t.Item2, t.Item3, t.Item4);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator vec4(Tuple<float, float, float, float> t) => new vec4(t.Item1, t.Item2, t.Item3, t.Item4);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator vec4(double[] t)
        {
            if (t.Length != 4)
                throw new InvalidOperationException($"Array length must be 4 to cast to {nameof(vec4)}");
            return new vec4(t[0], t[1], t[2], t[3]);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator vec4(float[] t)
        {
            if (t.Length != 4)
                throw new InvalidOperationException($"Array length must be 4 to cast to {nameof(vec4)}");
            return new vec4(t[0], t[1], t[2], t[3]);
        }

        public unsafe ReadOnlySpan<float> AsSpan()
        {
            fixed (vec4* data = &this)
                return new ReadOnlySpan<float>(data, 4);
        }

        public static vec4 operator -(vec4 a, vec4 b) => a.Sub(b);
        public static vec4 operator -(vec4 a) => a.Scale(-1);
        public static vec4 operator +(vec4 a, vec4 b) => a.Add(b);
        public static double operator *(vec4 a, vec4 b) => a.Dot(b);
        public static vec4 operator *(vec4 a, double s) => a.Scale(s);
        public static vec4 operator *(double s, vec4 b) => b.Scale(s);
        public static vec4 operator /(vec4 a, double s) => a.Scale(1 / s);

        public override string ToString() => $"<{x},{y},{z},{w}>";
    }
}
