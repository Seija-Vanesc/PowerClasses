using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using PowerClasses.Items.Accessories;
using Microsoft.Xna.Framework;
using PowerClassesStart;

namespace PowerClasses.Items.Accessories
{

    public class BerzerkerToken : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Grants higher Attack power and Attack speed the less health you have\nReduces health regeneration by half");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = 00000;
            Item.rare = 2;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Melee) += (player.statLifeMax2 - player.statLife) / 50;
            player.lifeRegen /= 2;
            //player.AddBuff(ModContent.BuffType<Buffs.HighTime>(), 180);
        }
    }
}