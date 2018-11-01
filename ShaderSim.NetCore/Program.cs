using RaymarchingScenes;
using System;

namespace ShaderSim.NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = Examples.SphereSubBox(6.5, Math.PI * 2 - 0.5);

            var scene = new RaymarchScene(model);
        }
    }
}
