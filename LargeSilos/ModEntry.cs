using Harmony;
using StardewModdingAPI;
using StardewValley;
using System.Reflection;

namespace LargeSilos
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            HarmonyInstance harmony = HarmonyInstance.Create("us.dragonma.patch");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }

    [HarmonyPatch(typeof(Utility))]
    [HarmonyPatch("numSilos")]
    class Patch
    {
        static void Postfix(ref int __result)
        {
            __result *= 100;
        }
    }
}
