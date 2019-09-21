using ShaderSim;
using System;
using System.Windows.Forms;
using RaymarchingScenes;

namespace RaymarchingSim
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            

            Application.Run(new Window { ShaderSource = CreateFrameShader });
        }

        static double theta;
        
        static IShader CreateFrameShader()
        {
            theta += 0.1;
            //var model =
            //new TranslationNode(
            //    (-3, 0, 20),                    
            //    new SphereNode(3));
            var model = Examples.SphereSubBox(6.5, theta);
            //    //new ColorNode((0.5, 0.5, 0),
            //    //    new TranslationNode((0, 0, 30),
            //    //        new SphereNode(5)));

            var scene = new RaymarchScene(model);

            //return new RayMarchingShader(scene, backgroundColor: (1, 1, 1));
            return new RayMarchStateMachineShader(scene, backgroundColor: (1, 1, 1));
        }
    }
}
