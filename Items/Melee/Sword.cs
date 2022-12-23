using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PowerClasses.Items;

namespace PowerClasses.Items.Melee
{
    public class Sword : ModItem 
    {
        int damageAmount;
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("");
            Tooltip.SetDefault("Right Click to reveal it's true devistation")
        }

        public override void SetDefaults()
        {
            Item.damage = damageAmount;
            Item.DamageType = DamageClass.Melee;
        }
    }
}