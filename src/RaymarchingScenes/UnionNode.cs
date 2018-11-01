namespace RaymarchingScenes
{
    public class UnionNode : Node3d
    {
        public override OpType3d Operation => OpType3d.CsgUnion;

        public override ParameterTypes ParameterType => ParameterTypes.None;

        protected override int? AddParameter(SceneBuilder3d builder) => null;

        public UnionNode(Node3d left, Node3d right) => (Left, Right) = (left, right);
    }
}
