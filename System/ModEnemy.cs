using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameInput;

namespace PowerClasses
{
    public class ModEnemy : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {   //Adds a drop to a vanilla enemy
                if (npc.type == NPCID.Zombie)
                {
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsHardmode(), ModContent.ItemType<Items.SoulsofEfrif>(), 10, 1, 1, 4));
                }
        }

        public override void PostAI(NPC npc)
        {  
            
        }

        public override void OnHitByItem(NPC npc, Player player, Item item, int damage, float knockback, bool crit)
        {   
            
        }

        public override void OnHitPlayer(NPC npc, Player target, int damage, bool crit)
        {

        }

    }
}

