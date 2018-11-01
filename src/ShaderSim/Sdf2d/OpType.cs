namespace ShaderSim.Sdf2d
{
    public enum OpType : byte
    {
        Empty = 0,
        Union = 1,
        Intersect = 2,
        Subtract = 3,

        ShapeCircle = 11,
        ShapeRectangle = 12,

        TransformTranslate = 21,
        TransformRotate = 22,
        TransformScale = 23,

        Color = 31,
    }
}
