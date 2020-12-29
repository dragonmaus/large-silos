using Harmony;
using StardewModdingAPI;

namespace LargeSilos
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            HarmonyInstance harmony = HarmonyInstance.Create("us.dragonma.patch");
            harmony.PatchAll();
        }
    }
}
