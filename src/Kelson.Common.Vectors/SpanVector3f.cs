using System;
using System.Runtime.CompilerServices;

namespace Kelson.Common.Vectors
{
    public readonly ref struct SpanVector3f
    {
        private readonly ReadOnlySpan<float> data;

        public double X => data[0];
        public double Y => data[1];
        public double Z => data[2];

        public SpanVector3f(in ReadOnlySpan<float> data) => this.data = data;        

        public static implicit operator vec3(SpanVector3f v) => new vec3(v.X, v.Y, v.Z);

        public override string ToString() => $"<{data[0]},{data[1]},{data[2]}>";
    }
}
