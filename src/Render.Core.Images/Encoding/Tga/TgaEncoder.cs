using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Render.Core.Images.PixelFormats;

namespace Render.Core.Images.Encoding
{
    public static class TgaEncoder
    {
        public class TgaImage : IImage
        {            
            private readonly ImageHeader Header;
            private readonly ByteBGRA[,] pixels;

            public TgaImage(ImageHeader header, ByteBGRA[,] pixels)
            {
                Header = header;
                this.pixels = pixels;                                
            }

            public int Width => Header.Width;
            public int Height => Header.Height;            

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

        [StructLayout(LayoutKind.Explicit)]
        public struct ImageHeader
        {
            [Flags]
            public enum Desciptor : byte
            {

                Attr_Zero = 0,
                Attr_One = 1,
                Attr_Two = 2,
                Attr_Three = 3,
                Attr_Four = 4,
                // . . .

                ScreenOriginLower = 0b0000_0000,
                ScreenOriginUpper = 0b0001_0000,

                NonInterleaved = 0b0000_0000,
                TwoWayInterleave = 0b0010_0000,
                FourWayInterleave = 0b0100_0000,
                Reserved = 0b0110_0000,

            }

            int AttributeBits(Desciptor descriptor) => ((byte)descriptor) & 0b1111;

            [FieldOffset(0)]
            public byte IdLength;
            [FieldOffset(1)]
            public byte ColorMapType;
            [FieldOffset(2)]
            public byte ImageType;
            [FieldOffset(3)]
            public ushort ColorMapStart;
            [FieldOffset(5)]
            public ushort ColorMapLength;
            [FieldOffset(7)]
            public byte ColorMapDepth;
            [FieldOffset(8)]
            public ushort XOrigin;
            [FieldOffset(10)]
            public ushort YOrigin;
            [FieldOffset(12)]
            public ushort Width;
            [FieldOffset(14)]
            public ushort Height;
            [FieldOffset(16)]
            public byte PixelDepth;
            [FieldOffset(17)]
            public Desciptor ImageDescriptor;
        }
    }
}
