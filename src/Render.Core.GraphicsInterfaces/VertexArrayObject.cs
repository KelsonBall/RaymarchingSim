using OpenTK.Graphics.OpenGL;
using System;

namespace Render.Core.GraphicsInterface
{
    public class VertexArrayObject : IManagedAssetHandle
    {
        public readonly float[] Data;

        internal VertexArrayObject(ManagedGraphicsService graphics)
        {
            this.graphics = graphics;
            handle = graphics.gl.GenVertexArray();
        }

        private readonly ManagedGraphicsService graphics;
        public ManagedGraphicsService GraphicsService => throw new NotImplementedException();

        private readonly int handle;
        public int Handle => handle;

        public AssetBinding Binding()
        {
            graphics.gl.BindVertexArray(handle);
            return new AssetBinding(() => graphics.gl.BindVertexArray(0));
        }

        public void Dispose()
        {
            graphics.gl.DeleteVertexArray(handle);
            graphics.VertexArrayHandles.Remove(handle);
        }
    }
}
