using ShaderSim.Sdf2d;
using System;

namespace SdfFields
{
    class Program
    {
        static void Main(string[] args)
        {
            var scene =
                Model.Color((0, 0, 1),
                    Model.Subtract(
                        Model.Color((1, 0, 0),
                            Model.Rectangle((50, 50), (100, 100))),
                        Model.Color((0, 1, 0),
                            Model.Union(
                                Model.Circle((30, 30), 10),
                                Model.Rectangle((35, 35), (10, 10))
                            ))));

            var sdf_scene = new SdfScene(scene);
            
        }
    }
}
