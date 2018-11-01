using Kelson.Common.Vectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaderSim
{
    public class Buffer
    {
        public int Width { get; }
        public int Height { get; }

        public vec4[,] Data { get; }
    }
}
