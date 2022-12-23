using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PowerClasses.Items;

namespace PowerClasses.Items.Melee
{
	public class Efrig : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Efrif Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Can be used to make a multitude of weapons");
		}

		public override void SetDefaults()
		{
			Item.damage = 31;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 20;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 2150;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}
			//Add Movement buff [Questioning]
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Bone, 10);
			recipe.AddIngredient(ModContent.ItemType<SoulsofEfrif>(), 5);
			//recipe.AddIngredient(ItemID.Emerald, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}