using Content.Shared.CartridgeLoader;
using Content.Shared.CartridgeLoader.Cartridges;
using Content.Shared.Popups;
using Content.Shared.Interaction.Events;
using Content.Shared.Interaction;
using Robust.Server.GameObjects;
using Robust.Shared.Player;
using Content.Server.Atmos.EntitySystems;


namespace Content.Server.CartridgeLoader.Cartridges;

public sealed class GasAnalyzerCartridgeSystem : EntitySystem
{
    [Dependency] private readonly CartridgeLoaderSystem? _cartridgeLoaderSystem = default!;
    [Dependency] private readonly GasAnalyzerSystem? _gasAnalyzerSystem = default!;

    public override void Initialize()
    {
        base.Initialize();
        
    }

}

