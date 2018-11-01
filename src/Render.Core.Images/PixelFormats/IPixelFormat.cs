namespace Render.Core.Images.PixelFormats
{
    public interface IPixelFormatRgb<T> : IRedChannel<T>, IGreenChannel<T>, IBlueChannel<T> where T : struct
    {
        IPixelFormatRgb<T> WithRed(T r);
        IPixelFormatRgb<T> WithGreen(T g);
        IPixelFormatRgb<T> WithBlue(T b);        
    }

    public interface IPixelFormatRgba<T> : IRedChannel<T>, IGreenChannel<T>, IBlueChannel<T>, IAlphaChannel<T> where T : struct
    {
        IPixelFormatRgba<T> WithRed(T r);
        IPixelFormatRgba<T> WithGreen(T g);
        IPixelFormatRgba<T> WithBlue(T b);
        IPixelFormatRgba<T> WithAlpha(T a);        
    }    

    public interface IRedChannel<T> where T : struct
    {
        T R { get; }
    }

    public interface IGreenChannel<T> where T : struct
    {
        T G { get; }
    }

    public interface IBlueChannel<T> where T : struct
    {
        T B { get; }
    }

    public interface IAlphaChannel<T> where T : struct
    {
        T A { get; }
    }
}
