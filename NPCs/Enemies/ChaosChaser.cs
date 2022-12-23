//using Terraria;
//using Terraria.ID;
//using Terraria.ModLoader;
//using Terraria.ModLoader.Utilities;
//using Terraria.GameContent.ItemDropRules;
//using Microsoft.Xna.Framework;
//using System;


//namespace PowerClasses.NPCs.Enemies
//{
//    public class ChaosChaser : ModNPC
//    {
//        Player target;
//        bool targetSet;
//        float shortDistance;
//        float speed = 2;
//        Vector2 Velocity;
//        Vector2 hoverPoint1;
//        Vector2 hoverPoint2;
//        bool toPoint1;
//        bool atkPlayer;
//        float lastAttack;
//        float attackBuffer;
//        Vector2 attackPoint;
//        bool bufferSet;
//        bool toPoint2;

//        public override void SetStaticDefaults()
//        {
//            DisplayName.SetDefault("Chaos Chaser");
//            Main.npcFrameCount[NPC.type] = 4;
//        }

//        public override void SetDefaults()
//        {
//            NPC.lifeMax = 26;
//            NPC.damage = 28;
//            NPC.knockBackResist = 32;
//            NPC.width = 36;
//            NPC.height = 34;
//            NPC.aiStyle = -1;
//            NPC.value = 25f;
//            NPC.buffImmune[BuffID.OnFire] = true;
//            NPC.buffImmune[BuffID.Confused] = false;
//            NPC.HitSound = SoundID.NPCHit1;
//            NPC.DeathSound = SoundID.NPCDeath1;
//            NPC.noTileCollide = true;
//            NPC.noGravity = true;
//        }
//        public override float SpawnChance(NPCSpawnInfo spawnInfo)
//        {
//            // we would like this npc to spawn in the overworld.
//            return SpawnCondition.Corruption.Chance * 0.1f;
//        }
//        public override void HitEffect(int hitDirection, double damage)
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                int dustType = Main.rand.Next(139, 143);
//                int dustIndex = Dust.NewDust(NPC.position, NPC.width, NPC.height, dustType);
//                Dust dust = Main.dust[dustIndex];
//                dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
//                dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
//                dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
//            }
//        }
//        public override void ModifyNPCLoot(NPCLoot npcLoot)
//        {
//            npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsCorruption(), ModContent.ItemType<Items.Material.ChaosOrb>(), 4, 1, 1, 10));
//        }
//        public override void AI()
//        {
//            // Follow player
//            // swoop at player in an arch
//            // repeat
//            Main.NewText("ATK Buffer: " + attackBuffer);
//            if (!atkPlayer)
//            {
//                attackBuffer--;
//            }
//            if (targetSet)
//            {
//                if (!bufferSet)
//                {
//                    attackBuffer = Main.rand.Next(60, 141);
//                    bufferSet = true;
//                }
//                if (Vector2.Distance(target.position, NPC.position) > 600)
//                {
//                    target = null;
//                    targetSet = false;
//                }
//                else //Target found *Cloaker sounds*
//                {
//                    attackPoint.X = target.position.X + 25;
//                    hoverPoint1.X = target.position.X - 80;
//                    hoverPoint1.Y = target.position.Y - 80;
//                    hoverPoint2.X = target.position.X + 80;
//                    hoverPoint2.Y = target.position.Y - 80;


//                    if (attackBuffer < 0)
//                    {
//                        atkPlayer = true;
//                        toPoint1 = false;
//                        toPoint2 = false;
//                    }
//                    if (atkPlayer)
//                    {
//                        Main.NewText("Coming in for a landing");
//                        NPC.velocity = Vector2.Clamp(attackPoint - NPC.position, -Vector2.One, Vector2.One) * speed;
//                        if (Vector2.Distance(attackPoint, NPC.position) < 5 && Vector2.Distance(attackPoint, NPC.position) > -5)
//                        {
//                            attackBuffer = Main.rand.Next(60, 141);
//                            atkPlayer = false;
//                        }
//                    }
//                    if (toPoint1)
//                    {
//                        NPC.velocity = Vector2.Clamp(hoverPoint1 - NPC.position, -Vector2.One, Vector2.One) * speed;
//                        if (Vector2.Distance(hoverPoint1, NPC.position) < 5 && Vector2.Distance(hoverPoint1, NPC.position) > -5)
//                        {
//                            toPoint1 = false;
//                            toPoint2 = true;
//                        }
//                    }
//                    if (toPoint2)
//                    {
//                        NPC.velocity = Vector2.Clamp(hoverPoint2 - NPC.position, -Vector2.One, Vector2.One) * speed;
//                        if (Vector2.Distance(hoverPoint2, NPC.position) < 5 && Vector2.Distance(hoverPoint2, NPC.position) > -5)
//                        {
//                            toPoint2 = false;
//                            toPoint1 = true;
//                        }
//                    }
//                }
//            }
//            else
//            {
//                shortDistance = 600;
//                foreach (Player pl in Main.player)
//                {
//                    if (pl.active)
//                    {
//                        if (Vector2.Distance(pl.position, NPC.position) < shortDistance)
//                        {
//                            shortDistance = Vector2.Distance(pl.position, NPC.position);
//                            target = pl;
//                            targetSet = true;
//                        }
//                    }
//                }
//            }
//            if (Vector2.Distance(Main.LocalPlayer.position, NPC.position) > 200)
//            {
//                Main.NewText("Hey you too far");
//            }
//        }
//    }
//}

