using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using PowerClasses.Items;
using PowerClasses.Items.Magic;
using PowerClasses.Dusts;

namespace PowerClasses.Items.Magic
{
    public class Chaosbook : ModItem 
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Chaos Devotion");
			Tooltip.SetDefault("Shoots damaging orbs at enemies");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 23;
			Item.DamageType = DamageClass.Magic; // Makes the damage register as magic. If your item does not have any damage type, it becomes true damage (which means that damage scalars will not affect it). Be sure to have a damage type.
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Shoot; // Makes the player use a 'Shoot' use style for the Item.
			Item.noMelee = true; // Makes the item not do damage with it's melee hitbox.
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item8;
			Item.autoReuse = false;
			Item.shoot = ModContent.ProjectileType<ChaosDevotion>(); 
			Item.shootSpeed = 7; // How fast the item shoots the projectile.
			Item.crit = 32; // The percent chance at hitting an enemy with a crit, plus the default amount of 4.
			Item.mana = 12; // This is how much mana the item uses.
		}
    }
}

