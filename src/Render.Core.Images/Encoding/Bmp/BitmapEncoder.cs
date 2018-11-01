using Render.Core.Images.PixelFormats;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Render.Core.Images.Encoding
{
    public static class BitmapEncoder
    {
        public class Bitmap : IImage
        {
            public readonly BmpFileHeader FileData;
            public readonly BmpImageHeader ImageData;
            private readonly ByteBGRA[,] pixels;

            public Bitmap(BmpFileHeader fileHeader, BmpImageHeader imageHeader, ByteBGRA[,] pixels)
            {
                FileData = fileHeader;
                ImageData = imageHeader;
                this.pixels = pixels;
            }

            public int Width => (int)ImageData.Width;
            public int Height => (int)ImageData.Height;
            public IPixelFormatRgba<byte> this[int x, int y] => pixels[x, y];

            public IEnumerator<IPixelFormatRgba<byte>> GetEnumerator()
            {
                IEnumerable<IPixelFormatRgba<byte>> enumerate()
                {
                    for (int x = 0; x < Width; x++)
                        for (int y = 0; y < Height; y++)
                            yield return pixels[x, y];
                }

                return enumerate().GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            public void WithDataPtr(Action<IntPtr> action)
            {
                var handle = GCHandle.Alloc(this.pixels, GCHandleType.Pinned);
                action(handle.AddrOfPinnedObject());
                handle.Free();
            }
        }

        public static unsafe Bitmap DecodeBitmap(this byte[] data)
        {
            BmpFileHeader fileData = default;
            BmpImageHeader imageData = default;
            fixed (byte* fileHeaderStart = &data[0])
                fileData = *(BmpFileHeader*)fileHeaderStart;
            fixed (byte* imageHeaderStart = &data[14])
                imageData = *(BmpImageHeader*)imageHeaderStart;
            int width = (int)imageData.Width;
            int height = (int)imageData.Height;
            var pixels = new ByteBGRA[width, height];
            int offset = (int)fileData.FileOffsetToPixelArray;
            for (int i = 0; i < width * height * 3; i += 3)
                fixed (byte* pixel = &data[i + offset])
                    pixels[(i / 3) % width, height - 1 - (i / 3) / width] = new ByteBGRA(pixel[1], pixel[0], pixel[2], 0xFF);

            return new Bitmap(fileData, imageData, pixels);
        }

        public static IEnumerable<byte> EncodeAsBitmap(this IImage image)
        {
            throw new NotImplementedException();
        }
    }    

    [StructLayout(LayoutKind.Explicit)]
    public struct BmpFileHeader
    {
        [FieldOffset(0)]
        public ushort Signature;
        [FieldOffset(2)]
        public uint FileSize;
        [FieldOffset(6)]
        public uint Reserved;
        [FieldOffset(10)]
        public uint FileOffsetToPixelArray;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BmpImageHeader
    {
        [FieldOffset(0)]
        public uint HeaderSize;
        [FieldOffset(4)]
        public uint Width;
        [FieldOffset(8)]
        public uint Height;
        [FieldOffset(12)]
        public ushort ImagePlanes;
        [FieldOffset(14)]
        public ushort BitsPerPixel;
        [FieldOffset(16)]
        public uint Compression;
        [FieldOffset(24)]
        public uint SizeImage;
        [FieldOffset(28)]
        public uint XPelsPerMeter;
        [FieldOffset(32)]
        public uint YPelsPerMeter;
    }
}
