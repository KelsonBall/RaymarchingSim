namespace RaymarchingScenes
{
    public class SphereNode : Node3d
    {
        public override OpType3d Operation => OpType3d.ShapeSphere;

        public override int NodeCount => 1; // this

        public override int MatrixCount => 0; // none

        public override int Vec3Count => 0; // none

        public override int DoubleCount => 1; // size

        public override ParameterTypes ParameterType => ParameterTypes.Double;

        public double Radius { get; }

        public SphereNode(double radius) => Radius = radius;

        protected override int? AddParameter(SceneBuilder3d builder)
        {
            int id = builder.NextDoubleId();
            builder.AddDouble(new SdfDouble(id, Radius));
            return id;
        }
    }
}
