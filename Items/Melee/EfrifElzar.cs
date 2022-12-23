using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PowerClasses.Items;
using PowerClasses.Items.Magic;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;

namespace PowerClasses.Items.Melee
{
	public class EfrifElzar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Efrif Elzar");
			Tooltip.SetDefault("Causes a powerful shockwave damaging enemies");
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
			Item.shoot = ModContent.ProjectileType<ChaosDevotion>();
            Item.shootSpeed = 7;
			Item.reuseDelay = 28;
		}


        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			return player.CheckMana(15, true);
        }

			
		public override void AddRecipes()
		{
            ModLoader.TryGetMod("CalamityMod", out Mod calamity);
            Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<Items.SoulsofEfrif>(), 3);
			recipe.AddIngredient(ItemID.Bone);
			recipe.Register();
		}
	}
}