using System.Runtime.InteropServices;

namespace Render.Core.Images.PixelFormats
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct ByteRGBA : IPixelFormatRgba<byte>
    {
        [FieldOffset(0)]
        private readonly byte r;
        [FieldOffset(1)]
        private readonly byte g;
        [FieldOffset(2)]
        private readonly byte b;
        [FieldOffset(3)]
        private readonly byte a;

        public ByteRGBA(byte r, byte g, byte b, byte a) => (this.r, this.g, this.b, this.a) = (r, g, b, a);

        public byte R => r;
        public byte G => g;
        public byte B => b;
        public byte A => a;

        public IPixelFormatRgba<byte> WithBlue(byte b)  => new ByteRGBA(r, g, b, a);
        public IPixelFormatRgba<byte> WithGreen(byte g) => new ByteRGBA(r, g, b, a);
        public IPixelFormatRgba<byte> WithRed(byte r)   => new ByteRGBA(r, g, b, a);
        public IPixelFormatRgba<byte> WithAlpha(byte a) => new ByteRGBA(r, g, b, a);        
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly struct ByteARGB : IPixelFormatRgba<byte>
    {
        [FieldOffset(0)]
        private readonly byte a;
        [FieldOffset(1)]
        private readonly byte r;
        [FieldOffset(2)]
        private readonly byte g;
        [FieldOffset(3)]
        private readonly byte b;

        public ByteARGB(byte a, byte r, byte g, byte b) => (this.r, this.g, this.b, this.a) = (r, g, b, a);

        public byte R => r;
        public byte G => g;
        public byte B => b;
        public byte A => a;

        public IPixelFormatRgba<byte> WithBlue(byte b) =>  new ByteARGB(a, r, g, b);
        public IPixelFormatRgba<byte> WithGreen(byte g) => new ByteARGB(a, r, g, b);
        public IPixelFormatRgba<byte> WithRed(byte r) =>   new ByteARGB(a, r, g, b);
        public IPixelFormatRgba<byte> WithAlpha(byte a) => new ByteARGB(a, r, g, b);

        public static implicit operator ByteARGB((byte a, byte r, byte g, byte b) c) => new ByteARGB(c.a, c.r, c.g, c.b);
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly struct ByteABGR : IPixelFormatRgba<byte>
    {
        [FieldOffset(0)]
        private readonly byte a;
        [FieldOffset(1)]
        private readonly byte b;        
        [FieldOffset(2)]
        private readonly byte g;
        [FieldOffset(3)]
        private readonly byte r;

        public ByteABGR(byte a, byte g, byte b, byte r) => (this.r, this.g, this.b, this.a) = (r, g, b, a);

        public byte R => r;
        public byte G => g;
        public byte B => b;
        public byte A => a;

        public IPixelFormatRgba<byte> WithBlue(byte b) => new ByteABGR(a, b, g, r);
        public IPixelFormatRgba<byte> WithGreen(byte g) => new ByteABGR(a, b, g, r);
        public IPixelFormatRgba<byte> WithRed(byte r) => new ByteABGR(a, b, g, r);
        public IPixelFormatRgba<byte> WithAlpha(byte a) => new ByteABGR(a, b, g, r);
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly struct ByteBGRA : IPixelFormatRgba<byte>
    {
        [FieldOffset(0)]
        private readonly byte b;
        [FieldOffset(1)]        
        private readonly byte g;
        [FieldOffset(2)]        
        private readonly byte r;
        [FieldOffset(3)]        
        private readonly byte a;

        public ByteBGRA(byte b, byte g, byte r, byte a) => (this.r, this.g, this.b, this.a) = (r, g, b, a);

        public byte R => r;
        public byte G => g;
        public byte B => b;
        public byte A => a;

        public IPixelFormatRgba<byte> WithBlue(byte b) => new ByteBGRA(b, g, r, a);
        public IPixelFormatRgba<byte> WithGreen(byte g) => new ByteBGRA(b, g, r, a);
        public IPixelFormatRgba<byte> WithRed(byte r) => new ByteBGRA(b, g, r, a);
        public IPixelFormatRgba<byte> WithAlpha(byte a) => new ByteBGRA(b, g, r, a);
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly struct ByteGBRA : IPixelFormatRgba<byte>
    {
        [FieldOffset(0)]
        private readonly byte g;
        [FieldOffset(1)]
        private readonly byte b;
        [FieldOffset(2)]
        private readonly byte r;
        [FieldOffset(3)]
        private readonly byte a;

        public ByteGBRA(byte g, byte b, byte r, byte a) => (this.r, this.g, this.b, this.a) = (r, g, b, a);

        public byte R => r;
        public byte G => g;
        public byte B => b;
        public byte A => a;

        public IPixelFormatRgba<byte> WithBlue(byte b) => new ByteGBRA(g, b, r, a);
        public IPixelFormatRgba<byte> WithGreen(byte g) => new ByteGBRA(g, b, r, a);
        public IPixelFormatRgba<byte> WithRed(byte r) => new ByteGBRA(g, b, r, a);
        public IPixelFormatRgba<byte> WithAlpha(byte a) => new ByteGBRA(g, b, r, a);
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly struct ByteAGBR : IPixelFormatRgba<byte>
    {
        [FieldOffset(0)]
        private readonly byte a;
        [FieldOffset(1)]
        private readonly byte g;
        [FieldOffset(2)]
        private readonly byte b;
        [FieldOffset(3)]
        private readonly byte r;

        public ByteAGBR(byte a, byte g, byte b, byte r) => (this.r, this.g, this.b, this.a) = (r, g, b, a);

        public byte R => r;
        public byte G => g;
        public byte B => b;
        public byte A => a;

        public IPixelFormatRgba<byte> WithBlue(byte b) => new ByteAGBR(a, g, b, r);
        public IPixelFormatRgba<byte> WithGreen(byte g) => new ByteAGBR(a, g, b, r);
        public IPixelFormatRgba<byte> WithRed(byte r) => new ByteAGBR(a, g, b, r);
        public IPixelFormatRgba<byte> WithAlpha(byte a) => new ByteAGBR(a, g, b, r);
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly struct FloatARGB : IPixelFormatRgba<float>
    {
        [FieldOffset(0)]
        private readonly float a;
        [FieldOffset(4)]
        private readonly float r;
        [FieldOffset(8)]
        private readonly float g;
        [FieldOffset(12)]
        private readonly float b;

        public FloatARGB(float a, float r, float g, float b) =>
            (this.a, this.r, this.g, this.b) = (a, r, g, b);

        public FloatARGB(IPixelFormatRgba<byte> byteColor) =>
            (a, r, g, b) = FromBytes(byteColor);

        private static (float a, float r, float g, float b) FromBytes(IPixelFormatRgba<byte> color)
            => ( ((float)color.A) / 255, ((float) color.R) / 255,((float) color.G) / 255,((float) color.B) / 255 );

        public float R => r;
        public float G => g;
        public float B => b;
        public float A => a;

        public IPixelFormatRgba<float> WithBlue(float b) => new FloatARGB(a, r, g, b);
        public IPixelFormatRgba<float> WithGreen(float g) => new FloatARGB(a, r, g, b);
        public IPixelFormatRgba<float> WithRed(float r) => new FloatARGB(a, r, g, b);
        public IPixelFormatRgba<float> WithAlpha(float a) => new FloatARGB(a, r, g, b);

        public static implicit operator FloatARGB((float a, float r, float g, float b) c) => new FloatARGB(c.a, c.r, c.g, c.b);
    }
}
