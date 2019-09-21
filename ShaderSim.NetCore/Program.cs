using OpenTK;
using OpenTK.Graphics;
using RaymarchingScenes;
using Render.Core.GraphicsInterface;
using System;

namespace ShaderSim.NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var window = new Window())
                window.Run();
        }
    }

    class Window : GameWindow
    {
        private readonly ManagedGraphicsService graphics;

        private readonly MarchSceneShader Scene;

        public Window() : base(300, 300, new GraphicsMode(), "Dotnet Core")
        {
            this.graphics = new ManagedGraphicsService(new DebugGraphicsInterface());

            //var model = Examples.SphereSubBox(6.5, Math.PI * 2 - 0.5);

            var model = 
                new TranslationNode(
                    (-3, 0, 20),                     
                    new SphereNode(3));

            var world = new RaymarchScene(model);

            Scene = new MarchSceneShader(graphics, world);
        }

        protected override void OnLoad(EventArgs e)
        {
            graphics.Load(this);
            base.OnLoad(e);
        }

        protected override void OnResize(EventArgs e)
        {
            graphics.SetViewport(ClientRectangle.Width, ClientRectangle.Height);
            base.OnResize(e);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            var time = TimeSpan.FromSeconds(e.Time);
            Scene.Update(time);
            //spinningGrid.Update(time);
            base.OnUpdateFrame(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            graphics.Clear();

            Scene.Draw();
            
            SwapBuffers();
            base.OnRenderFrame(e);
        }
    }
}
