using System;
using Terraria;
using Terraria.ModLoader;
namespace PowerClasses.System
{
    public class KeyBinds : ModSystem
    {

        public static ModKeybind EmergencyOnly { get; private set; }
        public static ModKeybind IncreaseDifficulty { get; private set; }
        public static ModKeybind DecreaseDifficulty { get; private set; }

        public override void Load()
        {
           EmergencyOnly = KeybindLoader.RegisterKeybind(Mod, "EmergencyOnly", "/");
           IncreaseDifficulty = KeybindLoader.RegisterKeybind(Mod, "IncreaseDifficulty", "F5");
           DecreaseDifficulty = KeybindLoader.RegisterKeybind(Mod, "DecreaseDifficulty", "F4");
        }
    }
}

