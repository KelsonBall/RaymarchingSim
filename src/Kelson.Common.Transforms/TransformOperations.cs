using Kelson.Common.Vectors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kelson.Common.Transforms
{
    public readonly partial struct Transform
    {
        public Transform Inverse()
        {
            var m = this;
            var s0 = m.i1 * m.j2 - m.i2 * m.j1;
            var s1 = m.i1 * m.k2 - m.i2 * m.k1;
            var s2 = m.i1 * m.w2 - m.i2 * m.w1;
            var s3 = m.j1 * m.k2 - m.j2 * m.k1;
            var s4 = m.j1 * m.w2 - m.j2 * m.w1;
            var s5 = m.k1 * m.w2 - m.k2 * m.w1;
            var c5 = m.k3 * m.w4 - m.k4 * m.w3;
            var c4 = m.j3 * m.w4 - m.j4 * m.w3;
            var c3 = m.j3 * m.k4 - m.j4 * m.k3;
            var c2 = m.i3 * m.w4 - m.i4 * m.w3;
            var c1 = m.i3 * m.k4 - m.i4 * m.k3;
            var c0 = m.i3 * m.j4 - m.i4 * m.j3;
            var d = 1.0 / (s0 * c5 - s1 * c4 + s2 * c3 + s3 * c2 - s4 * c1 + s5 * c0);

            return new Transform(
                i1: (m.j2 * c5 - m.k2 * c4 + m.w2 * c3) * d,
                j1: (-m.j1 * c5 + m.k1 * c4 - m.w1 * c3) * d,
                k1: (m.j4 * s5 - m.k4 * s4 + m.w4 * s3) * d,
                w1: (-m.j3 * s5 + m.k3 * s4 - m.w3 * s3) * d,
                i2: (-m.i2 * c5 + m.k2 * c2 - m.w2 * c1) * d,
                j2: (m.i1 * c5 - m.k1 * c2 + m.w1 * c1) * d,
                k2: (-m.i4 * s5 + m.k4 * s2 - m.w4 * s1) * d,
                w2: (m.i3 * s5 - m.k3 * s2 + m.w3 * s1) * d,
                i3: (m.i2 * c4 - m.j2 * c2 + m.w2 * c0) * d,
                j3: (-m.i1 * c4 + m.j1 * c2 - m.w1 * c0) * d,
                k3: (m.i4 * s4 - m.j4 * s2 + m.w4 * s0) * d,
                w3: (-m.i3 * s4 + m.j3 * s2 - m.w3 * s0) * d,
                i4: (-m.i2 * c3 + m.j2 * c1 - m.k2 * c0) * d,
                j4: (m.i1 * c3 - m.j1 * c1 + m.k1 * c0) * d,
                k4: (-m.i4 * s3 + m.j4 * s1 - m.k4 * s0) * d,
                w4: (m.i3 * s3 - m.j3 * s1 + m.k3 * s0) * d);
        }

        public Transform Transpose() =>
            new Transform(
                i1: _i1, j1: _i2, k1: _i3, w1: _i4,
                i2: _j1, j2: _j2, k2: _j3, w2: _j4,
                i3: _k1, j3: _k2, k3: _k3, w3: _k4,
                i4: _w1, j4: _w2, k4: _w3, w4: _w4);

        public Transform Multiply(in Transform m)
        {
            var c1 = ColumnVector(0);
            var c2 = ColumnVector(1);
            var c3 = ColumnVector(2);
            var c4 = ColumnVector(3);
            var r1 = m.RowVector(0);
            var r2 = m.RowVector(1);
            var r3 = m.RowVector(2);
            var r4 = m.RowVector(3);

            return new Transform(
                i1: c1.Dot(r1), j1: c2.Dot(r1), k1: c3.Dot(r1), w1: c4.Dot(r1),
                i2: c1.Dot(r2), j2: c2.Dot(r2), k2: c3.Dot(r2), w2: c4.Dot(r2),
                i3: c1.Dot(r3), j3: c2.Dot(r3), k3: c3.Dot(r3), w3: c4.Dot(r3),
                i4: c1.Dot(r4), j4: c2.Dot(r4), k4: c3.Dot(r4), w4: c4.Dot(r4));
        }

        public vec3 AppliedTo(in vec3 v)
        {
            var a = new vec4(v, 1);
            return new vec3(ColumnVector(0).Dot(a), ColumnVector(1).Dot(a), ColumnVector(2).Dot(a));
        }
    }
}
