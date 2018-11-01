using Kelson.Common.Vectors;

namespace ShaderSim
{
    public interface IShader
    {
        vec4 Run(vec2 xy, vec2 wh);
    }
}
