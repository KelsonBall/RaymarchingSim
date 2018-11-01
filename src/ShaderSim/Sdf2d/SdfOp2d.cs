using Kelson.Common.Vectors;

namespace ShaderSim.Sdf2d
{
    public readonly struct SdfOp2d
    {
        public readonly ushort EntityId;

        public readonly OpType Operation;

        public readonly ushort LeftOpId;
        public readonly ushort RightOpId;

        public readonly vec2 Offset;
        public readonly vec3 Parameter;

        public SdfOp2d(int entity, OpType type, int? leftId = null, int? rightId = null, vec2? offset = null, vec3? parameter = null)
        {
            EntityId = (ushort)entity;
            Operation = type;
            LeftOpId = leftId.HasValue ? (ushort)leftId : (ushort)0;
            RightOpId = rightId.HasValue ? (ushort)rightId : (ushort)0;
            Offset = offset ?? default;
            Parameter = parameter ?? default;
        }

        public override string ToString() => $"[{EntityId}] {Operation} {Offset} {Parameter}";
    }
}
