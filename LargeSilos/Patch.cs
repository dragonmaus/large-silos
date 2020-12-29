using Harmony;
using StardewValley;

namespace LargeSilos
{
    [HarmonyPatch(typeof(Utility))]
    [HarmonyPatch("numSilos")]
    class Patch
    {
        static void Postfix(ref int __result) => __result *= 100;
    }
}
