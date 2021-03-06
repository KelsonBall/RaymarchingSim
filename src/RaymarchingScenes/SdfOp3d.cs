﻿using Kelson.Common.Transforms;
using Kelson.Common.Vectors;
using System.Runtime.InteropServices;

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

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct SdfOp3d
    {        
        public readonly uint EntityId;     
        public readonly OpType3d Operation;        
        public readonly uint Left;        
        public readonly uint Right;        
        public readonly uint Parent;
        public readonly uint Parameter;

        public SdfOp3d(int entity, int parent, OpType3d type, int? leftId = null, int? rightId = null, int? parameterId = null)
        {
            EntityId = (uint)entity;
            Operation = type;
            Parent = (uint)parent;
            Left = leftId.HasValue ? (uint)leftId : 0;
            Right = rightId.HasValue ? (uint)rightId : 0;
            Parameter = parameterId.HasValue ? (uint)parameterId : 0;
        }

        public override string ToString() => $"[{EntityId}] {Operation} {Parameter}";
    }
}
