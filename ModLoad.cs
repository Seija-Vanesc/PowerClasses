using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace PowerClasses
{
	public class ModLoad : ModSystem
	{
        public override void PostSetupContent()
        {
            List<int> debuffs = new();
            for (int i = 0; i < BuffLoader.BuffCount; i++)
            {
                if (Main.debuff[i])
                {
                    debuffs.Add(i);
                }
            }
        }
    }
}

