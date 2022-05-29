using System;
using HarmonyLib;

namespace BookDropRateChanger
{
    public class BookDropRateChangerInitializer : ModInitializer
    {
        public override void OnInitializeMod()
        {
            try
            {
                var harmony = new Harmony("BookDropRateChanger");
                harmony.PatchAll();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
