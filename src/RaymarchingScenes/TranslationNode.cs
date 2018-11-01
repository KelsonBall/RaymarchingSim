using Kelson.Common.Vectors;

namespace RaymarchingScenes
{
    public class TranslationNode : Node3d
    {
        public override OpType3d Operation => OpType3d.SpatialTranslation;
        public override ParameterTypes ParameterType => ParameterTypes.Vector3;
        public override int NodeCount => Left.NodeCount + 1;
        public override int MatrixCount => Left.MatrixCount;
        public override int Vec3Count => Left.Vec3Count + 1;
        public override int DoubleCount => Left.DoubleCount;

        public vec3 Translation { get; }

        public TranslationNode(vec3 translation, Node3d child) => (Translation, Left) = (translation, child);

        protected override int? AddParameter(SceneBuilder3d builder)
        {
            int id = builder.NextVec3Id();
            builder.AddVec3(new SdfVec3(id, Translation));
            return id;
        }
    }
}
