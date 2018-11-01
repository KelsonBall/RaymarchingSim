using System.Runtime.InteropServices;

namespace Render.Core.Images.Encoding.Png
{
    [StructLayout(LayoutKind.Explicit)]
    internal readonly struct PngChunkHeader
    {
        [FieldOffset(0)]
        internal readonly int ChunkLength;

        [FieldOffset(4)]
        internal readonly int ChunkType;

        internal enum ChunkTypes
        {
            /// <summary>
            /// Header https://www.w3.org/TR/2003/REC-PNG-20031110/#11IHDR
            /// </summary>
            Ihdr = 73 << 24 | 72 << 16 | 68 << 8 | 82,
            /// <summary>
            /// Palette https://www.w3.org/TR/2003/REC-PNG-20031110/#11PLTE
            /// </summary>
            Plte = 80 << 24 | 76 << 16 | 84 << 8 | 69,
            /// <summary>
            /// Data https://www.w3.org/TR/2003/REC-PNG-20031110/#11IDAT
            /// </summary>
            IDat = 73 << 24 | 68 << 16 | 65 << 8 | 84,
            /// <summary>
            /// End of file https://www.w3.org/TR/2003/REC-PNG-20031110/#11IEND
            /// </summary>
            IEnd = 73 << 24 | 69 << 16 | 78 << 8 | 68,
        }
    }
}
