using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace PowerClasses.Items.Material
{
    public class ChaosOrb : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It seems to be a unique crafting martirial \n The core of Chaos formed Chasers");
        }
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 999;
        }
    }
}

