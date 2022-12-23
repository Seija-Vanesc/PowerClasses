using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace PowerClasses.Buffs
{
    public class HighTime : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("High Time!!");
            Description.SetDefault("Hey, I think you need some air");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        // needs limit
        /*public override void Update(Player player, ref int buffIndex)
        {
            player.velocity.Y -= 0.5f;
            player.velocity.X = 0;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.velocity.Y -= 0.1f;
            npc.velocity.X = 0;
        }*/
    }
}

