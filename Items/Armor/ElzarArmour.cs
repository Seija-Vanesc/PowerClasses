//using System;
//using Terraria;
//using Terraria.ModLoader;
//using Terraria.ID;
//namespace PowerClasses
//{
//    public class ElzarianHelm : ModItem
//    {
//        float playerHealth;
//        public bool healthBonus;
//        public override void SetStaticDefaults()
//        {
//            Tooltip.SetDefault("Decreases Speed by one sixth \n Regeneration increased slightly \n Adds temperary hearts when you take damage");
//        }
//        public override void SetDefaults()
//        {
//            Item.wornArmor = true;
//            Item.defense = 8;
//        }

//        public override void UpdateArmorSet(Player player)
//        {
//            player.maxRunSpeed /= 6;
//            player.lifeRegen += 2;
//            player.setBonus = "";
//            if (healthBonus)
//            {
//                playerHealth = player.statLifeMax2;
//                player.statLifeMax2 += 40;
//                if (player.statLifeMax2 < playerHealth)
//                {
//                    healthBonus = false;
//                }
//            }
//        }

//        public override void AddRecipes()
//        {

//        }
//    }
//    public class ElzarianBreastplate : ModItem
//    {
//        public override void SetStaticDefaults()
//        {
//            Tooltip.SetDefault("Grants player extra health \n Grants player quicker mana regeneration \n Causes a chance of a random effect");
//        }
//        public override void SetDefaults()
//        {
//            Item.wornArmor = true;
//            Item.defense = 9;
//        }
//        public override void UpdateAccessory(Player player, bool hideVisual)
//        {
//            player.manaRegen += 4;
//        }p
//        public override void AddRecipes()
//        {

//        }
//    }
//    public class ElzarianGreaves : ModItem
//    {

//    }
//}

