using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace PowerClasses.Items.Accessories
{
    public class AnonymousToken : ModItem
    {
        bool help;
        float choose;
        bool hasChosen;
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Helps you or helps the creature near you. . . Be causous");
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
            if (!hasChosen)
            {
                choose = Main.rand.Next(0, 2);
                if (choose == 1)
                {
                    help = true;
                }
                if (help)
                {
                    Main.NewText("The Gods have agreed to assist in your endevers");
                    Main.NewText("Defense increased by 10 \n Mana inceased by 20 \n Life increased by 10");
                }
                else
                {
                    Main.NewText("The God have agreed to assist your enemies \n Be causious");
                    Main.NewText("Defense decreased by 5 \n Mana reduced by 20 \n Life reduced by 10");
                }
                hasChosen = true;
            }
            if (help)
            {
                player.statDefense += 10;
                player.statManaMax2 += 20;
                player.statLifeMax2 += 10;
            }
            else
            {
                player.statDefense -= 5;
                player.statManaMax2 -= 20;
                player.statLifeMax2 -= 10;
            }
        }
        public override void AddRecipes()
        {
           Recipe recipe = CreateRecipe();
           recipe.AddIngredient(ItemID.Bone, 10);
           recipe.AddIngredient(ItemID.MeteoriteBar, 6);
           recipe.AddIngredient(ModContent.ItemType<SoulsofEfrif>(), 10);
           recipe.AddIngredient(ItemID.SoulofFright, 10);
           recipe.AddTile(TileID.MythrilAnvil);
           recipe.Register();
        }
    }
}

