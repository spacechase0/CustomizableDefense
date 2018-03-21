using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.IO;

namespace CustomizableDefense
{
    public static class Config
    {
        internal static string ConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "CustomizableDefense.json");
        internal static Preferences prefs = new Preferences(ConfigPath);

        public static double NormalDefenseMultiplier = 0.5;
        public static double ExpertDefenseMultiplier = 0.75;
        public static int NoDamageThreshold = 50;

        internal static void Load()
        {
            if (prefs.Load())
            {
                prefs.Get("NormalDefenseMultiplier", ref NormalDefenseMultiplier);
                prefs.Get("ExpertDefenseMultiplier", ref ExpertDefenseMultiplier);
                prefs.Get("NoDamageThreshold", ref NoDamageThreshold);
            }
            prefs.Put("NormalDefenseMultiplier", NormalDefenseMultiplier);
            prefs.Put("ExpertDefenseMultiplier", ExpertDefenseMultiplier);
            prefs.Put("NoDamageThreshold", NoDamageThreshold);
            prefs.Save();
        }
    }
}
