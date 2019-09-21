using Kelson.Common.Vectors;
using System;
using System.Collections.Generic;
using System.Linq;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Render.Core.GraphicsInterface
{
    public class ManagedGraphicsService : IDisposable
    {
        public event Action<int, int> ViewportChanged;

        public int Width { get; private set; }
        public int Height { get; private set; }

        public void SetViewport(int width, int height)
        {
            Width = width;
            Height = height;
            ViewportChanged?.Invoke(width, height);
            gl.Viewport(0, 0, width, height);
        }

        public readonly IGraphicsInterface gl;
        private readonly List<IManagedAssetHandle> assets = new List<IManagedAssetHandle>();

        public ManagedGraphicsService(IGraphicsInterface graphics)
        {
            gl = graphics;
        }

        public void Load(GameWindow window)
        {
            SetViewport(window.ClientRectangle.Width, window.ClientRectangle.Height);
            gl.ClearColor(0f, 0f, 0f, 0f);
            gl.Enable(EnableCap.Blend);
        }

        public void Clear()
        {
            gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            gl.ClearColor(0.2f, 0.3f, 0.4f, 1f);
            gl.MatrixMode(MatrixMode.Modelview);
            gl.LoadIdentity();
            gl.BindVertexArray(0);
            gl.BindBuffer(BufferTarget.ArrayBuffer, 0);
        }

        internal readonly Dictionary<int, ShaderProgram> ProgramHandles = new Dictionary<int, ShaderProgram>();
        public ShaderProgram CreateProgram(string vertexShader = null, string fragmentShader = null)
        {
            var program = new ShaderProgram(this, vertexShader, fragmentShader);
            ProgramHandles.Add(program.Handle, program);
            assets.Add(program);
            return program;
        }

        internal readonly Dictionary<int, VertShader> VertexShaderHandles = new Dictionary<int, VertShader>();
        public VertShader CreateVertexShader(string source = null)
        {
            var shader = new VertShader(this, program: source);
            VertexShaderHandles.Add(shader.Handle, shader);
            assets.Add(shader);
            return shader;
        }

        internal readonly Dictionary<int, FragShader> FragmentShaderHandles = new Dictionary<int, FragShader>();
        public FragShader CreateFragmentShader(string source = null)
        {
            var shader = new FragShader(this, program: source);
            FragmentShaderHandles.Add(shader.Handle, shader);
            assets.Add(shader);
            return shader;
        }

        internal readonly Dictionary<int, VertexBufferObject> VertexBufferHandles = new Dictionary<int, VertexBufferObject>();
        public VertexBufferObject CreateVertexBuffer(IEnumerable<vec3> vectors)
        {
            var buffer = new VertexBufferObject(this, vectors);
            VertexBufferHandles.Add(buffer.Handle, buffer);
            assets.Add(buffer);
            return buffer;
        }

        public VertexBufferObject CreateVertexBuffer(IEnumerable<vec2> vectors)
        {
            var buffer = new VertexBufferObject(this, vectors.Select(v => new vec3(v, 0f)));
            VertexBufferHandles.Add(buffer.Handle, buffer);
            assets.Add(buffer);
            return buffer;
        }

        internal readonly Dictionary<int, VertexArrayObject> VertexArrayHandles = new Dictionary<int, VertexArrayObject>();
        public VertexArrayObject CreateVertexArray()
        {
            var array = new VertexArrayObject(this);
            VertexArrayHandles.Add(array.Handle, array);
            assets.Add(array);
            return array;
        }

        internal readonly Dictionary<int, ShaderBufferObject> ShaderBufferHandles = new Dictionary<int, ShaderBufferObject>();        
        public ShaderBufferObject<TData> CreateShaderBufferObject<TData>(int layoutQualifier, TData[] data) where TData : struct
        {
            var buffer = new ShaderBufferObject<TData>(this, layoutQualifier, data);
            ShaderBufferHandles.Add(buffer.Handle, buffer);
            assets.Add(buffer);
            return buffer;
        }

        public void Dispose()
        {
            foreach (var asset in assets)
                asset.Dispose();
            //foreach (var kvp in VertexShaderHandles.ToList())
            //    kvp.Value.Dispose();
            //foreach (var kvp in FragmentShaderHandles.ToList())
            //    kvp.Value.Dispose();
            //foreach (var kvp in ProgramHandles.ToList())
            //    kvp.Value.Dispose();
            //foreach (var kvp in VertexBufferHandles.ToList())
            //    kvp.Value.Dispose();
            //foreach (var kvp in VertexArrayHandles.ToList())
            //    kvp.Value.Dispose();
        }
    }
}
