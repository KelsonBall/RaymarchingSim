using OpenTK.Graphics.OpenGL;
using Render.Core.GraphicsInterfaces;
using Render.Core.Images;
using Render.Core.Images.PixelFormats;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Render.Core.GraphicsInterface
{
    public class Texture : ITexture
    {
        private readonly IImage image;

        internal Texture(ManagedGraphicsService graphics, IImage image)
        {

        }

        public IPixelFormatRgba<byte> this[int x, int y] => throw new NotImplementedException();

        public TextureBufferTarget BufferTarget => throw new NotImplementedException();

        public TextureMagFilter MagFilter => throw new NotImplementedException();

        public TextureMinFilter MinFilter => throw new NotImplementedException();

        public TextureTarget Target => throw new NotImplementedException();

        public TextureUnit Unit => throw new NotImplementedException();

        public TextureWrapMode WrapMode => throw new NotImplementedException();

        public ManagedGraphicsService GraphicsService => throw new NotImplementedException();

        public int Handle => throw new NotImplementedException();

        public int Width => throw new NotImplementedException();

        public int Height => throw new NotImplementedException();

        public AssetBinding Binding()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IPixelFormatRgba<byte>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void WithDataPtr(Action<IntPtr> action)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
