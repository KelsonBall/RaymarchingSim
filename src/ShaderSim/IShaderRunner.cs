using Kelson.Common.Vectors;
using System.Drawing;

namespace ShaderSim
{
    public interface IShaderRunner
    {
        int Width { get; }
        int Height { get; }
        vec4[,] ToBuffer(IShader shader);        
        void LoadBitmap(IShader shader, ref Bitmap image);
    }
}
