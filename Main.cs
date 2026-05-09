using BepInEx;
using BepInEx.Unity.IL2CPP;

[BepInPlugin("com.wis.addon", "wis", "1.0.2.0")]
public class Main : BasePlugin
{
    public override void Load()
    {
        Hori.Core.PatchManager.Init();
    }
}