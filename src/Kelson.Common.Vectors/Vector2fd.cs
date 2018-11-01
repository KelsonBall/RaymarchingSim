using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Kelson.Common.Vectors
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public readonly partial struct vec2 : IVector<vec2>
    {
        //[FieldOffset(0)]
        public readonly float x;
        public double X => x;

        //[FieldOffset(4)]
        public readonly float y;
        public double Y => y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec2(double x, double y) : this((float)x, (float)y) { }

        public vec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double MagnitudeSquared() => Dot(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double Magnitude() => Math.Sqrt(Dot(this));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double Dot(in vec2 other) => (X * other.X) + (Y * other.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec2 Add(in vec2 other) => new vec2(X + other.X, Y + other.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec2 Sub(in vec2 other) => new vec2(X - other.X, Y - other.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec2 Scale(double scalar) => new vec2(X * scalar, Y * scalar);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec2 Unit() => Scale(1d / Magnitude());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double AngularMagnitude(in vec2 other) => Math.Acos(Dot(other) / (Magnitude() * other.Magnitude()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double Angle(in vec2 other) => Math.Atan2(other.Y, other.X) - Math.Atan2(Y, X);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator vec2(in (double x, double y) t) => new vec2(t.x, t.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator vec2(in (float x, float y) t) => new vec2(t.x, t.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator vec2(Tuple<double, double> t) => new vec2(t.Item1, t.Item2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator vec2(Tuple<float, float> t) => new vec2(t.Item1, t.Item2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator vec2(double[] t)
        {
            if (t.Length != 2)
                throw new InvalidOperationException("Array length must be 2 to cast to Vector2fd");
            return new vec2(t[0], t[1]);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator vec2(float[] t)
        {
            if (t.Length != 2)
                throw new InvalidOperationException("Array length must be 2 to cast to Vector2fd");
            return new vec2(t[0], t[1]);
        }

        public unsafe ReadOnlySpan<float> AsSpan()
        {            
            fixed (vec2* data = &this)            
                return new ReadOnlySpan<float>(data, 2);            
        }

        public static vec2 operator -(vec2 a, vec2 b) => a.Sub(b);
        public static vec2 operator -(vec2 a) => a.Scale(-1);
        public static vec2 operator +(vec2 a, vec2 b) => a.Add(b);
        public static double operator *(vec2 a, vec2 b) => a.Dot(b);
        public static vec2 operator *(vec2 a, double s) => a.Scale(s);
        public static vec2 operator *(double s, vec2 b) => b.Scale(s);
        public static vec2 operator /(vec2 a, double s) => a.Scale(1 / s);

        public override string ToString() => $"<{x},{y}>";
    }
}
