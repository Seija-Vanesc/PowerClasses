using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PowerClasses.Items.Berzurker
{
    public class BezerkerBane : ModItem
    {
		bool enemyKill;
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A sword ment for the fray");
		}

		public override void SetDefaults()
		{
			Item.damage = 67;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 15;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 10;
			Item.value = 45000;
			Item.rare = 6;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.scale = 1.0005f;
		}

		//Add Effect after kill (Strangth, 15)
		public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit){
			if (target.life - damage <= 0){

				enemyKill = true;
			}
			if (enemyKill)
			{
				damage *= (5 / 4);
				enemyKill = false;
			}
        }

        public override void AddRecipes()
		{
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddIngredient(ItemID.Ruby, 5);
            recipe.AddIngredient(ItemID.Emerald, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }

    }
}