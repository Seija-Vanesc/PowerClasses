using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
namespace PowerClasses.Items.Accessories
{
	public class RangerToken : ModItem
	{
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases ranged damage \n Increases speed slightly");
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
            player.GetDamage(DamageClass.Ranged) *= 1.25f;
            player.moveSpeed *= 1.15f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Cobweb, 5);
            recipe.AddIngredient(ItemID.WoodenBow, 1);
            recipe.AddIngredient(ItemID.StoneBlock, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();

        }
    }
}

