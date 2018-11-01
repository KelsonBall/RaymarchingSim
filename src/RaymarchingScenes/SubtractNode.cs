namespace RaymarchingScenes
{
    public class SubtractNode : Node3d
    {
        public override OpType3d Operation => OpType3d.CsgSubtract;

        public override ParameterTypes ParameterType => ParameterTypes.None;

        protected override int? AddParameter(SceneBuilder3d builder) => null;

        public SubtractNode(Node3d left, Node3d right) => (Left, Right) = (left, right);
    }
}
