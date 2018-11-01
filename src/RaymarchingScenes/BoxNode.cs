namespace RaymarchingScenes
{
    public class BoxNode : Node3d
    {
        public override OpType3d Operation => OpType3d.ShapeBox;

        public override int NodeCount => 1; // this

        public override int MatrixCount => 0; // none

        public override int Vec3Count => 0; // none

        public override int DoubleCount => 1; // size

        public override ParameterTypes ParameterType => ParameterTypes.Double;

        public double SideLength { get; }

        public BoxNode(double sideLength) => SideLength = sideLength;

        protected override int? AddParameter(SceneBuilder3d builder)
        {
            int id = builder.NextDoubleId();
            builder.AddDouble(new SdfDouble(id, SideLength));
            return id;
        }
    }
}
