using Kelson.Common.Vectors;
using ShaderSim;
using System;
using System.Drawing;

namespace ShaderSim
{
    public static class IShaderRunnerExtensions
    {
        public static Bitmap ToBitmap(this IShaderRunner runner, IShader shader)
        {
            var image = new Bitmap(runner.Width, runner.Height);            
            var buffer = runner.ToBuffer(shader);
            for (int x = 0; x < runner.Width; x++)
                for (int y = 0; y < runner.Height; y++)
                {
                    var color = buffer[x, y];
                    var (r, g, b, a) = ((int)(Math.Min(1, color.X) * 0xFF), (int)(Math.Min(1, color.Y) * 0xFF), (int)(Math.Min(1, color.Z) * 0xFF), (int)(Math.Min(1, color.W) * 0xFF));
                    image.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            return image;
        }

        public static Bitmap ToBitmap(this IShaderRunner runner, IShader shader, Bitmap image)
        {            
            var buffer = runner.ToBuffer(shader);
            for (int x = 0; x < runner.Width; x++)
                for (int y = 0; y < runner.Height; y++)
                {
                    var color = buffer[x, y];
                    var (r, g, b, a) = ((int)(color.X * 0xFF), (int)(color.Y * 0xFF), (int)(color.Z * 0xFF), (int)(color.W * 0xFF));
                    image.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            return image;
        }

        public static Bitmap ToBitmap(this vec4[,] buffer, Bitmap image)
        {
            for (int x = 0; x < image.Width; x++)
                for (int y = 0; y < image.Height; y++)
                {
                    var color = buffer[x, y];
                    var (r, g, b, a) = ((int)(color.X * 0xFF), (int)(color.Y * 0xFF), (int)(color.Z * 0xFF), (int)(color.W * 0xFF));
                    image.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            return image;
        }
    }
}
