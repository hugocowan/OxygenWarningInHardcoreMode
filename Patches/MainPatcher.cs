using HarmonyLib;
using QModManager.API.ModLoading;

namespace OxygenWarningInHardcoreMode
{
    [QModCore]
    public class MainPatcher
    {
        [QModPatch]
        public static void Patch()
        {
            Harmony harmony = new Harmony("com.boogaliwoogali.subnautica.OxygenWarningInHardcoreMode");
            harmony.PatchAll();
        }
    }
}
