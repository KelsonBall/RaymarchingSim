using Kelson.Common.Vectors;

namespace RaymarchingScenes
{
    public class ColorNode : Node3d
    {
        public override OpType3d Operation => OpType3d.Color;
        public override ParameterTypes ParameterType => ParameterTypes.Vector3;
        public override int NodeCount => Left.NodeCount + 1; 
        public override int MatrixCount => Left.MatrixCount;
        public override int Vec3Count => Left.Vec3Count + 1; 
        public override int DoubleCount => Left.DoubleCount;

        public vec3 Color { get; }

        public ColorNode(vec3 color, Node3d child) => (Color, Left) = (color, child);

        protected override int? AddParameter(SceneBuilder3d builder)
        {
            int id = builder.NextVec3Id();
            builder.AddVec3(new SdfVec3(id, Color));
            return id;
        }
    }
}
