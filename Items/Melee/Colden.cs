using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using PowerClasses.Items.Magic;
using Microsoft.Xna.Framework;

namespace PowerClasses.Items.Melee
{
    public class Colden : ModItem
    {
        float KillCount;        
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The Scythe of power... You must have journeyed far");
        }

        public override void SetDefaults()
        {
            Item.damage = 105;
            Item.DamageType = DamageClass.Melee;
            Item.width = 50;
            Item.height = 50;
            Item.useTime = 60;
            Item.useAnimation = 30;
            Item.useStyle = 1;
            Item.knockBack = 10;
            Item.value = 0000;
            Item.rare = 6;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.scale = 2f;
            Item.shoot = ModContent.ProjectileType<ChainedProjectile>();
            Item.shootSpeed = 7;
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if(player.altFunctionUse == 2)
            {
                type = ModContent.ProjectileType<ChainedProjectile>();
            }
            else
            {
                type = 0;
            }
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
            
        }

        public override void HoldItem(Player player)
        {
                player.AddBuff(BuffID.Ironskin, 0);
        }

        public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
            if (target.life - damage <= 0)
            {                
                //Main.NewText("We are Keeping Count", 255, 255, 255);               
                KillCount = KillCount + 1;
                if(KillCount == 5)
                {
                    Main.NewText("Your body is starting to get Cold. . .", 54, 139, 193);
                }
                if(KillCount == 7)
                {
                    Main.NewText("You are Feeling pain", 54, 139, 193);
                    player.AddBuff(BuffID.Slow, 960);
                }
                if(KillCount > 10)
                {
                    Main.NewText("The pain is too much. . .", 54, 139, 193);
                    player.AddBuff(BuffID.Weak, 280);
                    KillCount = 0;
                }
            }
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddTile(TileID.MythrilAnvil);
           // recipe.AddIngredient(ModContent.ItemType<Items.Material.CursedEfrifShard>(), 5);
            recipe.AddIngredient(ItemID.Ectoplasm, 3);
            recipe.AddIngredient(ItemID.Ruby, 5);
            recipe.Register();
        }
    }
}

