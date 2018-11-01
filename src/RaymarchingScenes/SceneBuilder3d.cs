using System.Collections.Generic;

namespace RaymarchingScenes
{
    public class SceneBuilder3d
    {
        private readonly List<SdfOp3d> nodes = new List<SdfOp3d>();
        public IEnumerable<SdfOp3d> Nodes => nodes;
        private int nodeId = 0;
        public int NextNodeId() => nodeId++;

        private readonly List<SdfMatrix> matricies = new List<SdfMatrix>();
        public IEnumerable<SdfMatrix> Matricies => matricies;
        private int matrixId = 0;
        public int NextMatrixId() => matrixId++;

        private readonly List<SdfVec3> vec3s = new List<SdfVec3>();
        public IEnumerable<SdfVec3> Vec3s => vec3s;
        private int vec3Id = 0;
        public int NextVec3Id() => vec3Id++;

        private readonly List<SdfDouble> doubles = new List<SdfDouble>();
        public IEnumerable<SdfDouble> Doubles => doubles;
        private int doubleId = 0;
        public int NextDoubleId() => doubleId++;

        public void AddVec3(SdfVec3 vec) => vec3s.Add(vec);

        public void AddNode(SdfOp3d node) => nodes.Add(node);

        public void AddMatrix(SdfMatrix matrix) => matricies.Add(matrix);

        public void AddDouble(SdfDouble value) => doubles.Add(value);
    }
}
