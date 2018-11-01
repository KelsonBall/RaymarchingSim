using System;
using System.Runtime.CompilerServices;

namespace Kelson.Common.Vectors
{
    public readonly ref struct SpanVector4f
    {
        private readonly ReadOnlySpan<float> data;

        public double X => data[0];
        public double Y => data[1];
        public double Z => data[2];
        public double W => data[3];

        public SpanVector4f(in ReadOnlySpan<float> data) => this.data = data;

        public static implicit operator vec4(SpanVector4f v) => new vec4(v.X, v.Y, v.Z, v.W);

        public override string ToString() => $"<{data[0]},{data[1]},{data[2]},{data[3]}>";    
    }
}
