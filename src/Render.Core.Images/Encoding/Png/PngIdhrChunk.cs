using System.Runtime.InteropServices;

namespace Render.Core.Images.Encoding.Png
{
    /// <summary>
    /// Header Chunk https://www.w3.org/TR/2003/REC-PNG-20031110/#11IHDR
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    internal readonly struct PngIdhrChunk
    {        
        [FieldOffset(0)]
        internal readonly int Width;

        [FieldOffset(4)]
        internal readonly int Height;

        [FieldOffset(8)]
        internal readonly BitDepths BitDepth;

        [FieldOffset(9)]
        internal readonly ColorTypes ColorType;

        [FieldOffset(10)]
        internal readonly byte CompressionMethod;

        [FieldOffset(11)]
        internal readonly byte FilterMethod;

        [FieldOffset(22)]
        public readonly byte InterlaceMethod;

        internal enum BitDepths : byte
        {
            One = 1,
            Two = 2,
            Four = 4,
            Eight = 8,
            Sixteen = 16,
        }

        internal enum ColorTypes : byte
        {
            Grayscale = 0,
            Truecolor = 2,
            Indexed = 3,
            GreyscaleAlpha = 4,
            TruecolorAlpha = 6,
        }
    }
}
