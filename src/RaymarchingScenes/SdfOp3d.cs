using Kelson.Common.Transforms;
using Kelson.Common.Vectors;

namespace RaymarchingScenes
{
    public readonly struct SdfDouble
    {
        public readonly ushort EntityId;
        public readonly double Value;

        public SdfDouble(int id, double value)
            => (EntityId, Value) = ((ushort)id, value);
    }

    public readonly struct SdfMatrix
    {
        public readonly ushort EntityId;
        public readonly Transform Transform;

        public SdfMatrix(int id, Transform transform)
            => (EntityId, Transform) = ((ushort)id, transform);
    }

    public readonly struct SdfVec3
    {
        public readonly ushort EntityId;
        public readonly vec3 Vector;

        public SdfVec3(int id, vec3 vector)
            => (EntityId, Vector) = ((ushort)id, vector);
    }

    public enum ParameterTypes : byte
    {
        None = 0,
        Double = 1,
        Vector2 = 2,
        Vector3 = 3,
        Vector4 = 4,
        Matrix4 = 5,
    }

    public readonly struct SdfOp3d
    {
        public readonly ushort EntityId;

        public readonly OpType3d Operation;

        public readonly ushort Left;
        public readonly ushort Right;

        public readonly ushort Parent;

        //public ParameterTypes ParameterType;
        public readonly ushort ParameterId;

        public SdfOp3d(int entity, int parent, OpType3d type, int? leftId = null, int? rightId = null, int? parameterId = null)
        {
            EntityId = (ushort)entity;
            Operation = type;
            Parent = (ushort)parent;
            Left = leftId.HasValue ? (ushort)leftId : (ushort)0;
            Right = rightId.HasValue ? (ushort)rightId : (ushort)0;
            ParameterId = parameterId.HasValue ? (ushort)parameterId : (ushort)0;
        }

        public override string ToString() => $"[{EntityId}] {Operation} {ParameterId}";
    }
}
