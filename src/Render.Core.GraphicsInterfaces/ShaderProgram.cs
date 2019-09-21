using Kelson.Common.Transforms;
using Kelson.Common.Vectors;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Render.Core.GraphicsInterface
{
    public class ShaderBufferObject : IManagedAssetHandle
    {
        public ManagedGraphicsService GraphicsService { get; }

        public int Handle { get; }

        public int LayoutQualifier { get; }

        protected ShaderBufferObject(ManagedGraphicsService graphics, int layoutQualifier)
        {
            GraphicsService = graphics;
            LayoutQualifier = layoutQualifier;
            Handle = graphics.gl.GenBuffer();
        }

        public AssetBinding Binding()
        {
            GraphicsService.gl.BindBuffer(BufferTarget.ShaderStorageBuffer, Handle);
            return new AssetBinding(() => GraphicsService.gl.BindBuffer(BufferTarget.ShaderStorageBuffer, 0));
        }

        public void Dispose()
        {
            GraphicsService.gl.DeleteBuffer(Handle);
            GraphicsService.ShaderBufferHandles.Remove(Handle);
        }
    }

    public class ShaderBufferObject<TData> : ShaderBufferObject where TData : struct
    {        
        public ReadOnlyMemory<TData> Data { get; }

        public ShaderBufferObject(ManagedGraphicsService graphics, int layoutQualifier, TData[] data) : base(graphics, layoutQualifier)
        {
            Data = data;
            graphics.gl.BindBuffer(BufferTarget.ShaderStorageBuffer, Handle);
            graphics.gl.BufferData(BufferTarget.ShaderStorageBuffer, Marshal.SizeOf<TData>() * data.Length, data, BufferUsageHint.DynamicRead);
            graphics.gl.BindBufferBase(BufferRangeTarget.ShaderStorageBuffer, layoutQualifier, Handle);
            graphics.gl.BindBuffer(BufferTarget.ShaderStorageBuffer, 0);
        }        
    }

    public class ShaderProgram : IManagedAssetHandle
    {
        internal Transform viewTransform;

        internal ShaderProgram(ManagedGraphicsService graphics, string vertexSource, string fragmentSource)
        {
            GraphicsService = graphics;
            var vert = graphics.CreateVertexShader(vertexSource);
            var frag = graphics.CreateFragmentShader(fragmentSource);

            graphics.ViewportChanged += SetViewTransform;
            SetViewTransform(graphics.Width, graphics.Height);
            SetViewTransform(graphics.Width, graphics.Height);
            handle = graphics.gl.CreateProgram();
            graphics.gl.AttachShader(handle, vert.Handle);
            graphics.gl.AttachShader(handle, frag.Handle);
            graphics.gl.LinkProgram(handle);
            graphics.gl.BindFragDataLocation(handle, 0, "outColor");
            string log = graphics.gl.GetProgramInfoLog(handle);
            if (!string.IsNullOrEmpty(log))
                throw new Exception(log);
        }

        private void SetViewTransform(int x, int y)
        {
            viewTransform = Transform.Identity().Multiply(Transform.Translation((-1f, -1f, 0f))).Multiply(Transform.Scale(2.0 / x, 2.0 / y, 1.0));
        }
        
        public ManagedGraphicsService GraphicsService { get; }

        private readonly int handle;
        public int Handle => handle;

        public AssetBinding Binding()
        {
            GraphicsService.gl.UseProgram(handle);
            int loc = GraphicsService.gl.GetUniformLocation(handle, "view");
            var data = viewTransform.AsSpan().ToArray();
            GraphicsService.gl.UniformMatrix4(loc, 1, false, data);
            return new AssetBinding(() => GraphicsService.gl.UseProgram(0));
        }

        public void SetUniformFloat(string name, float value)
        {
            using (Binding())
            {
                int loc = GraphicsService.gl.GetUniformLocation(handle, name);
                GraphicsService.gl.Uniform1(loc, value);
            }
        }

        public void SetUniformDouble(string name, double value)
        {
            using (Binding())
            {
                int loc = GraphicsService.gl.GetUniformLocation(handle, name);
                GraphicsService.gl.Uniform1(loc, value);
            }
        }

        public void SetUniformArray<T>(string name, T[] data, Action<string, T> set)
        {
            for (int i = 0; i < data.Length; i++)
                set($"{name}[{i}]", data[i]);
        }

        public void SetUniformStructArray<TData, TField>(string name, string field, TData[] data, Func<TData, TField> selector, Action<string, TField> set)
            where TData : struct
        {
            for (int i = 0; i < data.Length; i++)
                set($"{name}[{i}].{field}", selector(data[i]));
        }

        public void SetUniformInteger(string name, int value)
        {
            using (Binding())
            {
                int loc = GraphicsService.gl.GetUniformLocation(handle, name);
                GraphicsService.gl.Uniform1(loc, value);
            }
        }

        public void SetUniformUint(string name, uint value)
        {
            using (Binding())
            {
                int loc = GraphicsService.gl.GetUniformLocation(handle, name);
                GraphicsService.gl.Uniform1(loc, value);
            }
        }

        public void SetUniformTransform(string name, Transform transform)
        {
            using (Binding())
            {
                int loc = GraphicsService.gl.GetUniformLocation(handle, name);
                var data = transform.AsSpan().ToArray();
                GraphicsService.gl.UniformMatrix4(loc, 1, false, data);
            }
        }

        public void SetUniformVector(string name, vec4 vector)
        {
            using (Binding())
            {
                int loc = GraphicsService.gl.GetUniformLocation(handle, name);
                GraphicsService.gl.Uniform4(loc, 1, vector.AsSpan().ToArray());
            }
        }

        public void SetUniformVector(string name, vec3 vector)
        {
            using (Binding())
            {
                int loc = GraphicsService.gl.GetUniformLocation(handle, name);
                GraphicsService.gl.Uniform3(loc, 1, vector.AsSpan().ToArray());
            }
        }

        public void SetUniformVector(string name, vec2 vector)
        {
            using (Binding())
            {
                int loc = GraphicsService.gl.GetUniformLocation(handle, name);
                GraphicsService.gl.Uniform2(loc, 1, vector.AsSpan().ToArray());
            }
        }

        private static readonly Dictionary<Type, string> firstElementNames = new Dictionary<Type, string>();

        private string getFirstElementName<T>() where T : struct
        {
            var t = typeof(T);
            if (firstElementNames.ContainsKey(t))
                return firstElementNames[t];

            var fields = t.GetFields();

            var layout = (StructLayoutAttribute)t.GetCustomAttributes(typeof(StructLayoutAttribute), false).Single();

            if (layout.Value == LayoutKind.Sequential)
                firstElementNames[t] = fields.First().Name;
            else if (layout.Value == LayoutKind.Explicit)
                firstElementNames[t] =
                    fields.OrderBy(f =>
                        ((FieldOffsetAttribute)f.GetCustomAttributes(typeof(FieldOffsetAttribute), false).Single()).Value)
                        .First()
                        .Name;
            else
                throw new InvalidOperationException("Uniform structs must have sequential or explicit layout");

            return firstElementNames[t];
        }        

        //public void SetUniformTexture(string name, Texture texture)
        //{
        //    int loc = graphics.gl.GetUniformLocation(handle, name);
        //    graphics.gl.ActiveTexture(TextureUnit.Texture0);
        //    using (texture.Binding())
        //    {
        //        graphics.gl.
        //        graphics.gl.BindSampler(0, )
        //    }
        //}

        public void Dispose()
        {
            GraphicsService.gl.DeleteProgram(handle);
            GraphicsService.ProgramHandles.Remove(handle);
        }
    }
}
