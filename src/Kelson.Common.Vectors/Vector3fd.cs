using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Kelson.Common.Vectors
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly partial struct vec3 : IVector<vec3>
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

        public vec3(double x, double y, double z) : this((float)x, (float)y, (float)z) { }

        public vec3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double MagnitudeSquared() => Dot(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double Magnitude() => Math.Sqrt(Dot(this));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec3 Cross(in vec3 other)
            => new vec3(Y * other.Z - Z * other.Y,
                            Z * other.X - X * other.Z,
                            X * other.Y - Y * other.X);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double Dot(in vec3 other) => (X * other.X) + (Y * other.Y) + (Z * other.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec3 Add(in vec3 other) => new vec3(X + other.X, Y + other.Y, Z + other.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec3 Sub(in vec3 other) => new vec3(X - other.X, Y - other.Y, Z - other.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec3 Scale(double scalar) => new vec3(X * scalar, Y * scalar, Z * scalar);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec3 Unit() => Scale(1d / Magnitude());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double AngularMagnitude(in vec3 other) => Math.Acos(Dot(other) / (Magnitude() * other.Magnitude()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double Angle(in vec3 other, in vec3 normal)
        {
            if (normal.Cross(this).Dot(other) > 0)
                return AngularMagnitude(other);
            else
                return -AngularMagnitude(other);
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator vec3(in (double x, double y, double z) t) => new vec3(t.x, t.y, t.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator vec3(in (float x, float y, float z) t) => new vec3(t.x, t.y, t.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator vec3(Tuple<double, double, double> t) => new vec3(t.Item1, t.Item2, t.Item3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator vec3(Tuple<float, float, float> t) => new vec3(t.Item1, t.Item2, t.Item3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator vec3(double[] t)
        {
            if (t.Length != 3)
                throw new InvalidOperationException($"Array length must be 3 to cast to {nameof(vec3)}");
            return new vec3(t[0], t[1], t[2]);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator vec3(float[] t)
        {
            if (t.Length != 3)
                throw new InvalidOperationException($"Array length must be 3 to cast to {nameof(vec3)}");
            return new vec3(t[0], t[1], t[2]);
        }

        public unsafe ReadOnlySpan<float> AsSpan()
        {
            fixed (vec3* data = &this)
                return new ReadOnlySpan<float>(data, 3);
        }

        public static vec3 operator -(vec3 a, vec3 b) => a.Sub(b);
        public static vec3 operator -(vec3 a) => a.Scale(-1);
        public static vec3 operator +(vec3 a, vec3 b) => a.Add(b);
        public static double operator *(vec3 a, vec3 b) => a.Dot(b);
        public static vec3 operator *(vec3 a, double s) => a.Scale(s);
        public static vec3 operator *(double s, vec3 b) => b.Scale(s);
        public static vec3 operator /(vec3 a, double s) => a.Scale(1 / s);

        public static bool operator ==(vec3 a, vec3 b) => a.X == b.X && a.Y == b.Y && a.Z == b.Z;

        public static bool operator !=(vec3 a, vec3 b) => a.X != b.X || a.Y != b.Y || a.Z != b.Z;

        public override string ToString() => $"<{x},{y},{z}>";
    }
}
