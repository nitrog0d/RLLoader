using RLLoader.Shared;

namespace RLLoader.Core;

public class Module {
    public Logger Logger { get; set; }

    public string Name { get; set; } = "Unnamed";
    public int Index { get; set; } = 0;
    public bool ShouldTick { get; set; } = true;
    public bool ShouldRender { get; set; } = false;
    public bool IsSelected => ModuleManager.SelectedModule == Index;

    public virtual void OnLoad() { }
    public virtual void OnTick() { }
    public virtual void OnDraw() { }
    public virtual void OnDrawExternal() { }

}
