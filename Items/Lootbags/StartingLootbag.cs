using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PowerClasses.Items.Lootbags
{
    public class StartingLootbag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Welcome to Power Classes Mod");
            Tooltip.SetDefault("<right> to open");
        }
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.rare = 1;
        }
        public override bool CanRightClick(){
            return true;
        }
        public override void RightClick(Player player) {
            var source = player.GetSource_OpenItem(Type);
                if (player.whoAmI == Main.myPlayer){
                    if(Main.rand.Next(1) == 0){
                        player.QuickSpawnItem(source, ItemID.Bookcase);
                        player.QuickSpawnItem(source, ModContent.ItemType<Items.Melee.Efrig>());
                        player.QuickSpawnItem(source, ItemID.GrapplingHook);
                        player.QuickSpawnItem(source, ItemID.FallenStar);
                        player.QuickSpawnItem(source, ItemID.Chain);
                        player.QuickSpawnItem(source, ItemID.Book);
                        player.QuickSpawnItem(source, ModContent.ItemType<Accessories.BerzerkerToken>());
                        player.QuickSpawnItem(source, ModContent.ItemType<Accessories.MageToken>());
                        player.QuickSpawnItem(source, ModContent.ItemType<Accessories.RangerToken>());
                    }
                }

        }
    }
}