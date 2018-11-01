using System;
using System.Runtime.CompilerServices;

namespace Kelson.Common.Vectors
{
    public readonly ref struct SpanVector2f
    {
        private readonly ReadOnlySpan<float> data;

        public double X => data[0];
        public double Y => data[1];

        public SpanVector2f(in ReadOnlySpan<float> data) => this.data = data;
        
        public static implicit operator vec2(SpanVector2f v) => new vec2(v.X, v.Y);

        public override string ToString() => $"<{data[0]},{data[1]}>";
    }
}
