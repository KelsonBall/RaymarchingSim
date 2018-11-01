using Kelson.Common.Vectors;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Render.Core.GraphicsInterface
{
    public class VertexBufferObject : IManagedAssetHandle
    {
        public readonly float[] Data;

        internal VertexBufferObject(ManagedGraphicsService graphics, IEnumerable<vec3> vectors)
        {
            this.graphics = graphics;
            Data = vectors.SelectMany(v => new float[] { (float)v.X, (float)v.Y, (float)v.Z }).ToArray();
            handle = graphics.gl.GenBuffer();
            graphics.gl.BindBuffer(BufferTarget.ArrayBuffer, handle);
            graphics.gl.BufferData(BufferTarget.ArrayBuffer, Data.Length * sizeof(float), Data, BufferUsageHint.DynamicDraw);
            graphics.gl.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
            graphics.gl.EnableVertexAttribArray(0);
        }

        private readonly ManagedGraphicsService graphics;
        public ManagedGraphicsService GraphicsService => throw new NotImplementedException();

        private readonly int handle;
        public int Handle => handle;

        public AssetBinding Binding()
        {
            graphics.gl.BindBuffer(BufferTarget.ArrayBuffer, handle);
            return new AssetBinding(() => graphics.gl.BindBuffer(BufferTarget.ArrayBuffer, 0));
        }

        public void Dispose()
        {
            graphics.gl.DeleteBuffer(handle);
            graphics.VertexBufferHandles.Remove(handle);
        }
    }
}
