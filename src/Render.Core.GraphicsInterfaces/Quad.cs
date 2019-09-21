using Kelson.Common.Transforms;
using Kelson.Common.Vectors;
using Render.Core.GraphicsInterface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Render.Core.GraphicsInterfaces
{   
    public abstract partial class Quad
    {
        /// <summary>
        /// Pixel coordinates of to-left of Quad
        /// </summary>
        [Uniform]
        public vec2 Origin { get; set; }

        /// <summary>
        /// Pixel Width and Height of quad
        /// </summary>
        [Uniform]        
        public vec2 Size { get; set; }

        /// <summary>
        /// Pixel Width and Height of screen
        /// </summary>
        [Uniform]
        public vec2 Resolution { get; set; }                
        
        const string VERTEX_SHADER_SOURCE = @"
in vec3 position;
uniform vec2 Origin;
uniform vec2 Size;
uniform vec2 Resolution;

void main()
{
    float scale_x = Size.x / (Resolution.x / 2);
    float scale_y = Size.y / (Resolution.y / 2);
    float origin_x = (Origin.x / Resolution.x) * 2;
    float origin_y = (Origin.y / Resolution.y) * 2;
    gl_Position = vec4(vec2(position.x * scale_x + origin_x, position.y * scale_y + origin_y) - vec2(1, 1), 0, 1);
}
";

        public virtual async Task<string> Source()
        {
            string shader_source = GetType().FullName + ".glsl";
            using (var stream = GetType().Assembly.GetManifestResourceStream(shader_source))
            {
                if (stream == null)
                    throw new Exception($"Could not find embeded resource {shader_source}");
                using (var reader = new StreamReader(stream))
                    return await reader.ReadToEndAsync();
            }
        }


        protected readonly ManagedGraphicsService graphics;

        public readonly ShaderProgram Program;

        private readonly VertexArrayObject array;
        private readonly VertexBufferObject buffer;

        private readonly List<ShaderInput> uniforms = new List<ShaderInput>();

        public Quad(ManagedGraphicsService graphics)
        {
            var sourceTask = Source();
            uniforms.AddRange(
                GetType()
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Select(p => (p, p.GetCustomAttribute<UniformAttribute>()))
                    .Where(pu => pu.Item2 != null)
                    .Select(pu => new ShaderInput(this, pu.p, pu.Item2)));
            this.graphics = graphics;
            array = graphics.CreateVertexArray();
            using (array.Binding())
            {
                buffer = graphics.CreateVertexBuffer(new vec2[] { (0f, 0f), (0f, 1f), (1f, 1f), (1f, 0f) });
                string source = sourceTask.Result;
                foreach (var input in uniforms.Select(i => i.ShaderSource()))
                    if (!source.Contains(input))
                        throw new Exception($"Shader source did not contain required uniform {input}");
                Program = graphics.CreateProgram(VERTEX_SHADER_SOURCE, source);
            }
        }

        public virtual void Update(TimeSpan time)
        {

        }

        public virtual void SetUniforms()
        {
            foreach (var uniform in uniforms)
                uniform.Set();
        }

        public void Draw()
        {
            Resolution = (graphics.Width, graphics.Height);
            SetUniforms();

            using (array.Binding())
            using (buffer.Binding())
            using (Program.Binding())
                graphics.gl.DrawArrays(OpenTK.Graphics.OpenGL.PrimitiveType.Quads, 0, 4);
        }
    }
}
