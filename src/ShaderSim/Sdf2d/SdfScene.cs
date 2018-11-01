namespace ShaderSim.Sdf2d
{
    public readonly struct SdfScene
    {
        public readonly SdfOp2d[] Entities;

        public SdfScene(Model model)
        {
            var entities = new SdfOp2d[model.Count + 1];
            int entity_id = 1;
            model.ToOpRecord(ref entity_id, op => entities[op.EntityId] = op);
            Entities = entities;
        }
    }
}
