using System;
using PowerClasses.Items.Lootbags;
using PowerClasses.System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PowerClasses.Buffs;
using Microsoft.Xna.Framework;
using Terraria.GameInput;
using PowerClasses;

namespace PowerClassesStart
{
    public class PowerClassesStartPlayer : ModPlayer
    {
        //public ElzarianHelm elzarianHelm;
        public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath){
        return new Item[] {
            new Item(ModContent.ItemType<StartingLootbag>(), 1, 0)
        };
        }

        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (target.HasBuff<Chained>())
            {
                Player.GetDamage(DamageClass.Melee) *= 2;
            }
        }

        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (KeyBinds.IncreaseDifficulty.JustPressed)
            {
                Main.NewText("Increasing Difficulty", 214, 0, 0);
                PowerClasses.ModEnemyAgain.Increased = true;
            }
            if (KeyBinds.DecreaseDifficulty.JustPressed)
            {
                Main.NewText("Decreasing Difficulty", 214, 0, 0);
                PowerClasses.ModEnemyAgain.Increased = false;
                Main.NewText("Coward", 83, 92, 93);

            }
        }

        public override void PostUpdateEquips()
        {
            if (Main.CurrentFrameFlags.AnyActiveBossNPC)
            {
                Player.AddBuff(ModContent.BuffType<QuiteLands>(), 5);
                Player.GetDamage(DamageClass.Magic) += Player.statManaMax2 / 95;
                Player.GetDamage(DamageClass.Melee) += Player.statLifeMax2 / 99;
            }
        }

        //public override void OnHitByNPC(NPC npc, int damage, bool crit)
        //{
        //    elzarianHelm.healthBonus = true;
        //}
    }
}