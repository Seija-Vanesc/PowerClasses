using System;
using Terraria;
using Terraria.ModLoader;

namespace PowerClasses.Buffs
{
    public class Chained : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Description.SetDefault("Next hit is doubled");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            if (!npc.boss)
            {
                npc.velocity *= 0.5f;
            }
        }
    }
}

