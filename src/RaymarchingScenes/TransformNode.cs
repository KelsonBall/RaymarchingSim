using Kelson.Common.Transforms;
using System;

namespace RaymarchingScenes
{
    public class TransformNode : Node3d
    {
        public override OpType3d Operation => OpType3d.SpatialTransform;
        public override ParameterTypes ParameterType => ParameterTypes.Matrix4;
        public override int NodeCount => Left.NodeCount + 1;
        public override int MatrixCount => Left.MatrixCount + 1;
        public override int Vec3Count => Left.Vec3Count;
        public override int DoubleCount => Left.DoubleCount;

        public Transform Matrix { get; set; }

        public TransformNode(Transform matrix, Node3d child) => (Matrix, Left) = (matrix, child);

        protected override int? AddParameter(SceneBuilder3d builder)
        {
            int id = builder.NextMatrixId();
            builder.AddMatrix(new SdfMatrix(id, Matrix));
            return id;
        }
    }
}
