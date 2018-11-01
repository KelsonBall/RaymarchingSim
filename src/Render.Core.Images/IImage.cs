using Render.Core.Images.PixelFormats;
using System;
using System.Collections.Generic;

namespace Render.Core.Images
{
    public interface IImage : IEnumerable<IPixelFormatRgba<byte>>
    {
        int Width { get; }
        int Height { get; }
        IPixelFormatRgba<byte> this[int x, int y] { get; }
        void WithDataPtr(Action<IntPtr> action);
    }
}
