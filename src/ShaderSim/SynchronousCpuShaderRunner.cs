using System.Drawing;
using Kelson.Common.Vectors;

namespace ShaderSim
{
    public class SynchronousCpuShaderRunner : IShaderRunner
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public SynchronousCpuShaderRunner(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public vec4[,] ToBuffer(IShader shader)
        {
            var buffer = new vec4[Width, Height];
            var wh = new vec2(Width, Height);
            for (int x = 0; x < Width; x++)
                for (int y = 0; y < Height; y++)                
                    buffer[x, y] = shader.Run((x, y), wh);
            return buffer;
        }               

        public void LoadBitmap(IShader shader, ref Bitmap image)
        {
            var wh = new vec2(Width, Height);
            for (int x = 0; x < Width; x++)
                for (int y = 0; y < Height; y++)
                {
                    var color = shader.Run((x, y), wh);
                    var (r, g, b, a) = ((int)(color.X * 0xFF), (int)(color.Y * 0xFF), (int)(color.Z * 0xFF), (int)(color.W * 0xFF));
                    image.SetPixel(x, y, Color.FromArgb(a, r, g, b));                    
                }            
        }
    }    
}
