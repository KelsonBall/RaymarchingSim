using Kelson.Common.Transforms;
using Kelson.Common.Vectors;
using RaymarchingScenes;
using Render.Core.GraphicsInterface;
using Render.Core.GraphicsInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShaderSim.NetCore
{
    public class Scene : Quad
    {
        [Uniform]
        public vec4 BackgroundColor { get; set; }

        [Uniform]
        public double DrawDistance { get; set; }

        [Uniform]
        public double MinStepLength { get; set; }

        [Uniform]
        public double NormalEpsilon { get; set; }

        public double FieldOfView { set => _halfTanFov = Math.Tan(value) / 2; }

        private double _halfTanFov;

        [Uniform]
        public double HalfTanFoV { get => _halfTanFov; }

        [Uniform]
        public int MarchLimit { get; set; }

        [Uniform]
        public SdfOp3d[] NodeEntities { get; private set; }

        [Uniform]
        public Transform[] MatrixEntities { get; private set; }

        [Uniform]
        public vec3[] Vector3Entities { get; private set; }

        [Uniform]
        public double[] DoubleEntities { get; private set; }

        public Scene(ManagedGraphicsService graphics) : base(graphics)
        {
        }
    }
}
