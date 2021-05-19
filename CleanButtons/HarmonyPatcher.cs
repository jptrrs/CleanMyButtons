using HarmonyLib;
using Verse;

namespace CleanButtons
{
    [StaticConstructorOnStartup]
    public class HarmonyPatcher
    {
        static HarmonyPatcher()
        {
            var harmony = new Harmony("JPT.CleanButtons");
            harmony.PatchAll();
        }
    }
}