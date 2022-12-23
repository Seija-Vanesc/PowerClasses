using Terraria.ModLoader;
using Terraria;
namespace PowerClasses.Buffs
{
	public class QuiteLands : ModBuff
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Quiet Lands");
            Description.SetDefault("It is eirally quiet");
            Main.buffNoSave[Type] = true;
        }
        //Needs to be fixed
        public override void Update(NPC npc, ref int buffIndex)
        {
            if (!npc.boss || !npc.townNPC || !npc.CountsAsACritter)
            {
                npc.life = 0;
            }
        }
    }
}

