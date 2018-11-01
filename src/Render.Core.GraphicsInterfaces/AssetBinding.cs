using System;

namespace Render.Core.GraphicsInterface
{
    public readonly struct AssetBinding : IDisposable
    {
        private readonly Action dispose;

        public AssetBinding(Action dispose)
            => this.dispose = dispose;

        public void Dispose() => dispose();
    }
}
