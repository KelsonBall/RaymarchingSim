namespace RaymarchingScenes
{
    public class IntersectNode : Node3d
    {
        public override OpType3d Operation => OpType3d.CsgIntersect;

        public override ParameterTypes ParameterType => ParameterTypes.None;

        protected override int? AddParameter(SceneBuilder3d builder) => null;

        public IntersectNode(Node3d left, Node3d right) => (Left, Right) = (left, right);
    }
}
