namespace RaymarchingScenes
{
    public enum OpType3d : uint
    {
        Empty = 0,

        CsgUnion = 1,
        CsgIntersect = 2,
        CsgSubtract = 3,

        ShapeSphere = 11,
        ShapeBox = 12,

        SpatialTranslation = 21,
        SpatialTransform = 22,        

        Color = 31,
    }
}
