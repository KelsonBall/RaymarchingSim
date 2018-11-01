using System.Runtime.InteropServices;

namespace Render.Core.Images.PixelFormats
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct ByteRGB : IPixelFormatRgb<byte>
    {
        [FieldOffset(0)]
        private readonly byte r;
        [FieldOffset(1)]
        private readonly byte g;
        [FieldOffset(2)]
        private readonly byte b;        

        public byte R => r;
        public byte G => g;
        public byte B => b;

        public ByteRGB(byte r, byte g, byte b) => (this.r, this.g, this.b) = (r, g, b);

        public IPixelFormatRgb<byte> WithBlue(byte b)  => new ByteRGB(r, g, b);
        public IPixelFormatRgb<byte> WithGreen(byte g) => new ByteRGB(r, g, b);
        public IPixelFormatRgb<byte> WithRed(byte r)   => new ByteRGB(r, g, b);
    }    

    [StructLayout(LayoutKind.Explicit)]
    public readonly struct ByteBGR : IPixelFormatRgb<byte>
    {        
        [FieldOffset(0)]
        private readonly byte b;
        [FieldOffset(1)]
        private readonly byte g;
        [FieldOffset(2)]
        private readonly byte r;

        public byte R => r;
        public byte G => g;
        public byte B => b;

        public ByteBGR(byte b, byte g, byte r) => (this.r, this.g, this.b) = (r, g, b);

        public IPixelFormatRgb<byte> WithBlue(byte b)  => new ByteBGR(b, g, r);
        public IPixelFormatRgb<byte> WithGreen(byte g) => new ByteBGR(b, g, r);
        public IPixelFormatRgb<byte> WithRed(byte r)   => new ByteBGR(b, g, r);
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly struct ByteGBR : IPixelFormatRgb<byte>
    {
        [FieldOffset(0)]
        private readonly byte g;        
        [FieldOffset(1)]
        private readonly byte b;
        [FieldOffset(2)]
        private readonly byte r;

        public byte R => r;
        public byte G => g;
        public byte B => b;

        public ByteGBR(byte g, byte b, byte r) => (this.r, this.g, this.b) = (r, g, b);

        public IPixelFormatRgb<byte> WithBlue(byte b)  => new ByteGBR(g, b, r);
        public IPixelFormatRgb<byte> WithGreen(byte g) => new ByteGBR(g, b, r);
        public IPixelFormatRgb<byte> WithRed(byte r)   => new ByteGBR(g, b, r);
    }
}
