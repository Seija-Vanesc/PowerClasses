using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PowerClasses.Items;
using PowerClasses.Items.Magic;
//complete
namespace PowerClasses.Items.Openables
{
    public class UnknownSpellBook : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Unknown Spell Book");
            Tooltip.SetDefault("<right> to define");

        }

        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.width = 20;
            Item.height = 20;
            Item.rare = 3;

        }

        public override bool CanRightClick() {
            return true;
        }

        public override void RightClick(Player player)
        {
            var source = player.GetSource_OpenItem(Type);
            if (player.whoAmI == Main.myPlayer)
            {
                var Num = Main.rand.Next(21);
                if (Num < 20)
                {
                    var Nums = Main.rand.Next(10);
                    if (Nums <= 3)
                    {
                        player.QuickSpawnItem(source, ModContent.ItemType<Chaosbook>());
                    }
                    else
                    {
                        if (Nums <= 7 && Nums > 3)
                        {
                            player.QuickSpawnItem(source, ModContent.ItemType<BlazeBurn>());
                        }
                        else
                        {
                            if (Nums <= 9 && Nums > 7)
                            {
                                player.QuickSpawnItem(source, ModContent.ItemType<EfrifMysticDagger>());
                            }
                        }
                    }

                }
            }
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Book, 1);
            recipe.AddIngredient(ItemID.Chain, 1);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddTile(TileID.Bookcases);
            recipe.Register();
        }
        
    }

}