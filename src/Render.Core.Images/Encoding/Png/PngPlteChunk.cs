using System.Runtime.InteropServices;

namespace Render.Core.Images.Encoding.Png
{
    /// <summary>
    /// Palette https://www.w3.org/TR/2003/REC-PNG-20031110/#11PLTE
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    internal readonly struct PngPlteChunk
    {
        [FieldOffset(0)]
        internal readonly PngPlteEntry[] Entries;
    }

    [StructLayout(LayoutKind.Explicit)]
    internal readonly struct PngPlteEntry
    {
        [FieldOffset(0)]
        internal readonly byte R;

        [FieldOffset(1)]
        internal readonly byte G;

        [FieldOffset(2)]
        internal readonly byte B;
    }
}
