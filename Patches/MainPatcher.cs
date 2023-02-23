using BepInEx;
using HarmonyLib;

[BepInPlugin("OxygenWarningInHardcoreMode", "OxygenWarningInHardcoreMode", "1.1")]
public class MyPlugin : BaseUnityPlugin
{
    private void Start()
    {
        var harmony = new Harmony("OxygenWarningInHardcoreMode");
        harmony.PatchAll();
    }
}