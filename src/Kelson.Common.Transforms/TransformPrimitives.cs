using Kelson.Common.Vectors;
using System;

namespace Kelson.Common.Transforms
{
    public readonly partial struct Transform
    {
        public static Transform Identity() =>
            new Transform(1, 0, 0, 0,
                          0, 1, 0, 0,
                          0, 0, 1, 0,
                          0, 0, 0, 1);

        public static Transform Zero() =>
            new Transform(0, 0, 0, 0,
                          0, 0, 0, 0,
                          0, 0, 0, 0,
                          0, 0, 0, 0);

        public static Transform Translation(vec3 t)
        {
            var (x, y, z) = (t.X, t.Y, t.Z);
            return new Transform(1, 0, 0, 0,
                          0, 1, 0, 0,
                          0, 0, 1, 0,
                          x, y, z, 1);
        }

        public static Transform Translation(double x, double y, double z) =>
            new Transform(1, 0, 0, 0,
                          0, 1, 0, 0,
                          0, 0, 1, 0,
                          x, y, z, 1);

        public static Transform RotationX(double theta)
        {
            var c = Math.Cos(theta);
            var s = Math.Sin(theta);
            return new Transform(
                          1, 0, 0, 0,
                          0, c, s, 0,
                          0,-s, c, 0,
                          0, 0, 0, 1);
        }

        public static Transform RotationY(double theta)
        {
            var c = Math.Cos(theta);
            var s = Math.Sin(theta);
            return new Transform(
                          c, 0,-s, 0,
                          0, 1, 0, 0,
                          s, 0, c, 0,
                          0, 0, 0, 1);
        }

        public static Transform RotationZ(double theta)
        {
            var c = Math.Cos(theta);
            var s = Math.Sin(theta);
            return new Transform(
                          c, s, 0, 0,
                         -s, c, 0, 0,
                          0, 0, 1, 0,
                          0, 0, 0, 1);
        }

        public static Transform Scale(double s) =>
            new Transform(s, 0, 0, 0,
                          0, s, 0, 0,
                          0, 0, s, 0,
                          0, 0, 0, 1);

        public static Transform Scale(vec3 s) =>
            new Transform(s.X, 0, 0, 0,
                          0, s.Y, 0, 0,
                          0, 0, s.Z, 0,
                          0, 0, 0, 1 );

        public static Transform Scale(double x, double y, double z) =>
            new Transform(x, 0, 0, 0,
                          0, y, 0, 0,
                          0, 0, z, 0,
                          0, 0, 0, 1);

        public static Transform LookAt(vec3 target, vec3 from, vec3 up)
        {
            var z = (from - target).Unit();
            var x = up.Cross(z).Unit();
            var y = z.Cross(x);
            var tx = x.Dot(from);
            var ty = y.Dot(from);
            var tz = z.Dot(from);

            return new Transform(
                i1: x.X, j1: x.Z, k1: x.Y, w1: 0,
                i2: y.X, j2: y.Z, k2: y.Y, w2: 0,
                i3: z.X, j3: z.Z, k3: z.Y, w3: 0,
                i4:  tx, j4:  tz, k4:  ty, w4: 1);
        }
    }
}
