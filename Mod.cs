using Terraria;
using Terraria.ModLoader;
using System;
using System.Runtime.CompilerServices;

namespace CustomizableDefense
{
    public class Mod : Terraria.ModLoader.Mod
    {
        internal static Mod instance;

        public Mod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true,
                AutoloadBackgrounds = true
            };
        }

        public override void Load()
        {
            instance = this;
            Config.Load();
        }

        public override void Unload()
        {
            instance = null;
        }
    }
}

