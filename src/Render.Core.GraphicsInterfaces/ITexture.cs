using Render.Core.Images;

namespace Render.Core.GraphicsInterface
{
    public interface ITexture : IManagedAssetHandle, IImage
    {
        OpenTK.Graphics.OpenGL.TextureBufferTarget BufferTarget { get; }
        OpenTK.Graphics.OpenGL.TextureMagFilter MagFilter { get; }
        OpenTK.Graphics.OpenGL.TextureMinFilter MinFilter { get; }
        OpenTK.Graphics.OpenGL.TextureTarget Target { get; }
        OpenTK.Graphics.OpenGL.TextureUnit Unit { get; }
        OpenTK.Graphics.OpenGL.TextureWrapMode WrapMode { get; }
    }
}
