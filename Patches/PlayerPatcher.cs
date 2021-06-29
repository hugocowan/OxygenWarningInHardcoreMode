using HarmonyLib;

namespace OxygenWarningInHardcoreMode
{
    [HarmonyPatch(typeof(Player))]
    class PlayerPatcher
    {

        public static bool isPermaDeath = false;


        [HarmonyPostfix]
        [HarmonyPatch(nameof(Player.Awake))]
        public static void AwakePostfix()
        {
            if (GameModeUtils.IsOptionActive(GameModeOption.Permadeath))
            {
                isPermaDeath = true;
                GameModeUtils.currentGameMode = GameModeOption.Survival;
            }
        }

        [HarmonyPrefix]
        [HarmonyPatch(nameof(Player.OnKill))]
        public static void OnKillPrefix()
        {
            if (isPermaDeath)
            {
                GameModeUtils.currentGameMode = GameModeOption.Permadeath;
            }
        }
    }
}
