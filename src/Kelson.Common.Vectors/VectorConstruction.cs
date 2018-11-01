using System;

namespace Kelson.Common.Vectors
{
    public readonly partial struct vec2
    {
        public static vec2 FromPolar(double theta, double radius)
            => new vec2(Math.Cos(theta) * radius, Math.Sin(theta) * radius);
    }

    public readonly partial struct vec3
    {
        public vec3(in vec2 xy, double z) : this(xy.X, xy.Y, z) { }
        public vec3(double x, in vec2 yz) : this(x, yz.X, yz.Y) { }        
    }

    public readonly partial struct vec4
    {
        public vec4(in vec2 xy, in vec2 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }
        public vec4(double x, in vec2 yz, double w) : this(x, yz.X, yz.Y, w) { }
        public vec4(double x, in vec3 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }
        public vec4(in vec3 xyz, double w) : this(xyz.X, xyz.Y, xyz.Z, w) { }
    }
}
