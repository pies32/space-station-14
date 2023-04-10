using Content.Shared.CartridgeLoader.Cartridges;
using Content.Shared.Atmos.Components;

namespace Content.Server.CartridgeLoader.Cartridges;

[RegisterComponent]
public sealed class GasAnalyzerCartridgeComponent : Component
{
    [ViewVariables] public EntityUid? Target;
    [ViewVariables] public EntityUid User;
}


