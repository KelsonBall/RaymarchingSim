using System.Runtime.InteropServices;

namespace Render.Core.Images.Encoding.Png
{
    [StructLayout(LayoutKind.Explicit)]
    internal readonly struct PngHeader
    {
        [FieldOffset(0)]
        internal readonly long Signature;

        [FieldOffset(8)]
        internal readonly PngChunkHeader IdhrChunkHeader;
    }
}
