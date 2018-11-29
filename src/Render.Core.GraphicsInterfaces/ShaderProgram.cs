using Kelson.Common.Transforms;
using Kelson.Common.Vectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Render.Core.GraphicsInterface
{
    public class ShaderProgram : IManagedAssetHandle
    {
        internal Transform viewTransform;

        internal ShaderProgram(ManagedGraphicsService graphics, string vertexSource, string fragmentSource)
        {
            this.graphics = graphics;
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
        }

        private void SetViewTransform(int x, int y)
        {
            viewTransform = Transform.Identity().Multiply(Transform.Translation((-1f, -1f, 0f))).Multiply(Transform.Scale(2.0 / x, 2.0 / y, 1.0));
        }

        private readonly ManagedGraphicsService graphics;
        public ManagedGraphicsService GraphicsService => throw new NotImplementedException();

        private readonly int handle;
        public int Handle => handle;

        public AssetBinding Binding()
        {
            graphics.gl.UseProgram(handle);
            int loc = graphics.gl.GetUniformLocation(handle, "view");
            var data = viewTransform.AsSpan().ToArray();
            graphics.gl.UniformMatrix4(loc, 1, false, data);
            return new AssetBinding(() => graphics.gl.UseProgram(0));
        }

        public void SetUniformFloat(string name, float value)
        {
            using (Binding())
            {
                int loc = graphics.gl.GetUniformLocation(handle, name);
                graphics.gl.Uniform1(loc, value);
            }
        }

        public void SetUniformDouble(string name, double value)
        {
            using (Binding())
            {
                int loc = graphics.gl.GetUniformLocation(handle, name);
                graphics.gl.Uniform1(loc, value);
            }
        }

        public void SetUniformInteger(string name, int value)
        {
            using (Binding())
            {
                int loc = graphics.gl.GetUniformLocation(handle, name);
                graphics.gl.Uniform1(loc, value);
            }
        }

        public void SetUniformUint(string name, uint value)
        {
            using (Binding())
            {
                int loc = graphics.gl.GetUniformLocation(handle, name);
                graphics.gl.Uniform1(loc, value);
            }
        }

        public void SetUniformTransform(string name, Transform transform)
        {
            using (Binding())
            {
                int loc = graphics.gl.GetUniformLocation(handle, name);
                var data = transform.AsSpan().ToArray();
                graphics.gl.UniformMatrix4(loc, 1, false, data);
            }
        }

        public void SetUniformVector(string name, vec4 vector)
        {
            using (Binding())
            {
                int loc = graphics.gl.GetUniformLocation(handle, name);
                graphics.gl.Uniform4(loc, 1, vector.AsSpan().ToArray());
            }
        }

        public void SetUniformVector(string name, vec3 vector)
        {
            using (Binding())
            {
                int loc = graphics.gl.GetUniformLocation(handle, name);
                graphics.gl.Uniform3(loc, 1, vector.AsSpan().ToArray());
            }
        }

        public void SetUniformVector(string name, vec2 vector)
        {
            using (Binding())
            {
                int loc = graphics.gl.GetUniformLocation(handle, name);
                graphics.gl.Uniform2(loc, 1, vector.AsSpan().ToArray());
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

        //public void SetUniformStruct<T>(string name, T value) where T : struct
        //{
        //    string field_name = getFirstElementName<T>();
        //    using (Binding())
        //    {
        //        int loc = graphics.gl.GetUniformLocation(handle, $"{name}.{field_name}");
        //        graphics.gl.Uniform1(loc, value);
        //    }
        //}

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
            graphics.gl.DeleteProgram(handle);
            graphics.ProgramHandles.Remove(handle);
        }
    }
}
