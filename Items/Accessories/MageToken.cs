using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
namespace PowerClasses.Items.Accessories
{
	public class MageToken : ModItem
	{
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Reduces mana usage \n Increases number of minions");
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
            player.manaCost -= player.manaCost / 6;
            player.maxMinions += 2;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddIngredient(ItemID.WandofSparking, 1);
            recipe.AddIngredient(ItemID.StoneBlock, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();

        }
    }
}