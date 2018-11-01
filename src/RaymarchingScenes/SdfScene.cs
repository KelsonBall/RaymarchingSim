using Kelson.Common.Transforms;
using Kelson.Common.Vectors;

namespace RaymarchingScenes
{
    public readonly struct RaymarchScene
    {
        public readonly SdfOp3d[] NodeEntities;
        public readonly Transform[] MatrixEntities;
        public readonly vec3[] Vector3Entities;
        public readonly double[] DoubleEntities;

        public RaymarchScene(Node3d model)
        {
            var builder = new SceneBuilder3d();
            NodeEntities = new SdfOp3d[model.NodeCount];
            MatrixEntities = new Transform[model.MatrixCount];
            Vector3Entities = new vec3[model.Vec3Count];
            DoubleEntities = new double[model.DoubleCount];

            model.Build(builder);

            foreach (var node in builder.Nodes)
                NodeEntities[node.EntityId] = node;

            foreach (var node in builder.Matricies)
                MatrixEntities[node.EntityId] = node.Transform;

            foreach (var node in builder.Vec3s)
                Vector3Entities[node.EntityId] = node.Vector;

            foreach (var node in builder.Doubles)
                DoubleEntities[node.EntityId] = node.Value;

        }
    }
}
