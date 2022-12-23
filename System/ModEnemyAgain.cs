using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.ID;

namespace PowerClasses
{
    public class ModEnemyAgain : GlobalNPC
    {
        private static bool _increased;

        private static void IncreasedDifficultyOn(NPC npc)
        {
            //Increase Enemy and Boss health seperately
            if (!npc.boss && !npc.townNPC)
            {
                npc.lifeMax *= (5 / 4);
                npc.lifeMax += 25;
                npc.damage *= (5 / 4);
            }
            if (npc.boss)
            {
                npc.lifeMax *= (3 / 2);
                npc.lifeMax += 250;
                npc.damage *= (3 / 2);
            }
            npc.buffImmune[BuffID.Confused] = true;
            npc.buffImmune[BuffID.OnFire] = true;
        }

        private static void IncreasedDifficultyOff(NPC npc)
        {
            //Decrease Enemy and Boss health seperately
            if (!npc.boss && !npc.townNPC)
            {
                npc.lifeMax /= (5 / 4);
                npc.lifeMax -= 25;
                npc.life = Math.Min(npc.life, npc.lifeMax);
                npc.damage /= (3 / 2);
            }
            if (npc.boss)
            {
                npc.lifeMax /= (3 / 2);
                npc.lifeMax -= 250;
                npc.life = Math.Min(npc.life, npc.lifeMax);
                npc.damage /= (3 / 2);
            }
            npc.buffImmune[BuffID.Confused] = false;
            npc.buffImmune[BuffID.OnFire] = false;

        }
        public static bool Increased
        {
            get => _increased;
            set
            {
                if (_increased == value)
                {
                    return;
                }

                _increased = value;

                Action<NPC> apply = _increased ? IncreasedDifficultyOn : IncreasedDifficultyOff;
                for (int i = 0; i < Main.maxNPCs; i++)
                {
                    if (Main.npc[i].active)
                    {
                        apply(Main.npc[i]);
                    }
                }
            }
        }

        public override void OnSpawn(NPC npc, IEntitySource source)
        {
            if (Increased)
            {
                IncreasedDifficultyOn(npc);
            }
        }
    }
}

