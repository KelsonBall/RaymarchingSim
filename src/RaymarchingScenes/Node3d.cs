namespace RaymarchingScenes
{
    public abstract class Node3d
    {
        public abstract OpType3d Operation { get; }

        public virtual int NodeCount => Left.NodeCount + Right.NodeCount + 1;
        public virtual int MatrixCount => Left.MatrixCount + Right.MatrixCount;
        public virtual int Vec3Count => Left.Vec3Count + Right.Vec3Count;
        public virtual int DoubleCount => Left.DoubleCount + Right.DoubleCount;

        public Node3d Left { get; protected set; }
        public Node3d Right { get; protected set; }        

        public abstract ParameterTypes ParameterType { get; }

        protected abstract int? AddParameter(SceneBuilder3d builder);

        public void Build(SceneBuilder3d builder)
        {
            int my_id = builder.NextNodeId();

            int left_id = 0;
            if (Left != null)
                Left.Build(builder, my_id, out left_id);

            int right_id = 0;
            if (Right != null)
                Right.Build(builder, my_id, out right_id);

            int? parameter_id = AddParameter(builder);

            builder.AddNode(new SdfOp3d(my_id, 0, Operation, left_id, right_id, parameter_id));
        }

        public void Build(SceneBuilder3d builder, int parent, out int my_id)
        {
            my_id = builder.NextNodeId();

            int left_id = 0;
            if (Left != null)
                Left.Build(builder, my_id, out left_id);

            int right_id = 0;
            if (Right != null)
                Right.Build(builder, my_id, out right_id);

            int? parameter_id = AddParameter(builder);

            builder.AddNode(new SdfOp3d(my_id, parent, Operation, left_id, right_id, parameter_id));
        }
    }
}
