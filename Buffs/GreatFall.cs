using System;
using Terraria;
using Terraria.ModLoader;
namespace PowerClasses.Buffs
{
    public class GreatFall : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Great Fall");
            Description.SetDefault("Fall, with style");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        // Needs a max
        /*public override void Update(Player player, ref int buffIndex)
        {
            player.velocity.Y += 0.5f;
            player.noFallDmg = true;
        }*/
    }
}

