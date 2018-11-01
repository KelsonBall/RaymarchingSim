using Render.Core.GraphicsInterfaces;
using System;

namespace Render.Core.GraphicsInterface
{
    public interface IManagedAssetHandle : IDisposable
    {
        ManagedGraphicsService GraphicsService { get; }
        int Handle { get; }
        AssetBinding Binding();
    }
}
