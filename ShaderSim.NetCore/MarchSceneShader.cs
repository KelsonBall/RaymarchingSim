using Kelson.Common.Transforms;
using Kelson.Common.Vectors;
using RaymarchingScenes;
using Render.Core.GraphicsInterface;
using Render.Core.GraphicsInterfaces;
using System;
using System.Collections.Generic;

namespace ShaderSim.NetCore
{
    public class MarchSceneShader : Quad
    {
        const int MAX_ENTITY_COUNT = 30;

        [Uniform]
        public vec4 BackgroundColor { get; set; }

        [Uniform]
        public double DrawDistance { get; set; } = 30;

        [Uniform]
        public double MinStepLength { get; set; } = 0.025;

        [Uniform]
        public double NormalEpsilon { get; set; } = 0.1;

        public double FieldOfView { set => _halfTanFov = Math.Tan(value) / 2; }

        private double _halfTanFov;    
        [Uniform]
        public double HalfTanFoV { get => _halfTanFov; }

        [Uniform]
        public int MarchLimit { get; set; } = 100;

        [Uniform(nameof(MAX_ENTITY_COUNT))]
        public SdfOp3d[] NodeEntities { get; private set; }

        [Uniform(nameof(MAX_ENTITY_COUNT))]
        public Transform[] MatrixEntities { get; private set; }

        [Uniform(nameof(MAX_ENTITY_COUNT))]
        public vec3[] Vector3Entities { get; private set; }

        [Uniform(nameof(MAX_ENTITY_COUNT))]
        public double[] DoubleEntities { get; private set; }

        protected override IEnumerable<UniformTypeHandeler> TypeHandelers()
        {
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(SdfOp3d[]) },
                ShaderTypeName = "Node",
                SetUniform = input =>
                {
                    SdfOp3d[] data = (SdfOp3d[])input.get.DynamicInvoke();
                    input.Quad.Program.SetUniformStructArray(
                        input.property.Name,
                        nameof(SdfOp3d.EntityId),
                        data,
                        op => op.EntityId,
                        input.Quad.Program.SetUniformUint);

                    input.Quad.Program.SetUniformStructArray(
                        input.property.Name,
                        nameof(SdfOp3d.Left),
                        data,
                        op => op.Left,
                        input.Quad.Program.SetUniformUint);

                    input.Quad.Program.SetUniformStructArray(
                        input.property.Name,
                        nameof(SdfOp3d.Right),
                        data,
                        op => op.Right,
                        input.Quad.Program.SetUniformUint);

                    input.Quad.Program.SetUniformStructArray(
                        input.property.Name,
                        nameof(SdfOp3d.Operation),
                        data,
                        op => (uint)op.Operation,
                        input.Quad.Program.SetUniformUint);

                    input.Quad.Program.SetUniformStructArray(
                        input.property.Name,
                        nameof(SdfOp3d.Parent),
                        data,
                        op => op.Parameter,
                        input.Quad.Program.SetUniformUint);

                    input.Quad.Program.SetUniformStructArray(
                        input.property.Name,
                        nameof(SdfOp3d.Parameter),
                        data,
                        op => op.Parameter,
                        input.Quad.Program.SetUniformUint);
                }
            };

            foreach (var handeler in base.TypeHandelers())
                yield return handeler;
        }

        public MarchSceneShader(ManagedGraphicsService graphics, RaymarchScene world) : base(graphics)
        {
            FieldOfView = Math.PI / 3.5;
            BackgroundColor = (1, 1, 1, 1);
            Origin = (0, 0);
            Resolution = (graphics.Width, graphics.Height);
            Size = (graphics.Width, graphics.Height);

            NodeEntities = world.NodeEntities;
            MatrixEntities = world.MatrixEntities;
            Vector3Entities = world.Vector3Entities;            
            DoubleEntities = world.DoubleEntities;
        }

        public override void Update(TimeSpan time)
        {
            Resolution = (graphics.Width, graphics.Height);
            Size = (graphics.Width, graphics.Height);
        }
    }
}
