using Kelson.Common.Transforms;
using Kelson.Common.Vectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Render.Core.GraphicsInterfaces
{
    public abstract partial class Quad
    {
        public class UniformTypeHandeler
        {
            public HashSet<Type> Types { get; set; }
            public string ShaderTypeName { get; set; }
            public Action<ShaderInput> SetUniform { get; set; }
        }

        internal static IEnumerable<UniformTypeHandeler> DefaultTypeHandlers()
        {
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(float) },
                ShaderTypeName = "float",
                SetUniform = s =>
                {
                    var value = (float)s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformFloat(s.property.Name, value);
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(float[]) },
                ShaderTypeName = "float",
                SetUniform = s =>
                {
                    var data = (float[])s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformArray(s.property.Name, data, s.Quad.Program.SetUniformFloat);                    
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(double) },
                ShaderTypeName = "double",
                SetUniform = s =>
                {
                    var value = (double)s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformDouble(s.property.Name, value);
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(double[]) },
                ShaderTypeName = "double",
                SetUniform = s =>
                {
                    var data = (double[])s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformArray(s.property.Name, data, s.Quad.Program.SetUniformDouble);
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(int), typeof(short), typeof(sbyte) },
                ShaderTypeName = "int",
                SetUniform = s =>
                {
                    var value = (int)s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformInteger(s.property.Name, value);
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(int[]) },
                ShaderTypeName = "int",
                SetUniform = s =>
                {
                    var data = (int[])s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformArray(
                        s.property.Name, data, s.Quad.Program.SetUniformInteger);
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(uint), typeof(ushort), typeof(byte) },
                ShaderTypeName = "uint",
                SetUniform = s =>
                {
                    var value = (uint)s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformUint(s.property.Name, value);
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(uint[]) },
                ShaderTypeName = "uint",
                SetUniform = s =>
                {
                    var data = (uint[])s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformArray(
                        s.property.Name, data, s.Quad.Program.SetUniformUint);
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(vec2) },
                ShaderTypeName = "vec2",
                SetUniform = s =>
                {
                    var vec = (vec2)s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformVector(s.property.Name, vec);
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(vec2[]) },
                ShaderTypeName = "vec2",
                SetUniform = s =>
                {
                    var data = (vec2[])s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformArray(s.property.Name, data, s.Quad.Program.SetUniformVector);
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(vec3) },
                ShaderTypeName = "vec3",
                SetUniform = s =>
                {
                    var vec = (vec3)s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformVector(s.property.Name, vec);
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(vec3[]) },
                ShaderTypeName = "vec3",
                SetUniform = s =>
                {
                    var data = (vec3[])s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformArray(s.property.Name, data, s.Quad.Program.SetUniformVector);
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(vec4) },
                ShaderTypeName = "vec4",
                SetUniform = s =>
                {
                    var vec = (vec4)s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformVector(s.property.Name, vec);
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(vec4[]) },
                ShaderTypeName = "vec4",
                SetUniform = s =>
                {
                    var data = (vec4[])s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformArray(s.property.Name, data, s.Quad.Program.SetUniformVector);
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(Transform) },
                ShaderTypeName = "mat4",
                SetUniform = s =>
                {
                    var mat = (Transform)s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformTransform(s.property.Name, mat);
                },
            };
            yield return new UniformTypeHandeler
            {
                Types = new HashSet<Type> { typeof(Transform[]) },
                ShaderTypeName = "mat4",
                SetUniform = s =>
                {
                    var data = (Transform[])s.get.DynamicInvoke();
                    s.Quad.Program.SetUniformArray(
                        s.property.Name,
                        data,
                        s.Quad.Program.SetUniformTransform);
                }
            };
        }

        protected virtual IEnumerable<UniformTypeHandeler> TypeHandelers()
        {
            foreach (var handler in DefaultTypeHandlers())
                yield return handler;
        }

        public class ShaderInput
        {
            public readonly PropertyInfo property;

            public Type ClrType => property.PropertyType;

            public readonly Quad Quad;

            public readonly Delegate get;

            public readonly UniformTypeHandeler handler;

            public readonly string ArrayLength;

            public ShaderInput(Quad quad, PropertyInfo property, UniformAttribute attribute)
            {
                this.Quad = quad;
                this.property = property;
                this.handler = quad.TypeHandelers().FirstOrDefault(t => t.Types.Contains(ClrType));
                if (handler == null)
                    throw new NotSupportedException($"Uniform type {ClrType} does not have a handler. Override Quad.TypeHandlers to provide a UniformTypeHandler source. Include handlers from base implementation to include default handlers.");
                this.get = property.GetGetMethod().CreateDelegate(typeof(Func<>).MakeGenericType(property.PropertyType), quad);
                ArrayLength = attribute.ArrayLength?.ToString() ?? attribute.ArrayLengthConstant;
            }

            public void Set() => handler.SetUniform(this);

            public string ShaderSource()
            {
                if (!string.IsNullOrEmpty(ArrayLength))
                    return $"uniform {handler.ShaderTypeName} {property.Name}[{ArrayLength}];";
                else
                    return $"uniform {handler.ShaderTypeName} {property.Name};";
            }
        }

    }
}
