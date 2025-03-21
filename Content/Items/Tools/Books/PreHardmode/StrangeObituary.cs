﻿using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Polarities.Content.Items.Tools.Books.PreHardmode
{
    public class StrangeObituary : BookBase
    {
        public override int BuffType => BuffType<StrangeObituaryBuff>();
        public override int BookIndex => 1;
    }

    public class StrangeObituaryBuff : ModBuff
    {
        public override string Texture => "Polarities/Content/Items/Tools/Books/BookBuff";

        public override void SetStaticDefaults()
        {
            Main.buffNoTimeDisplay[Type] = true;
            Main.persistentBuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<PolaritiesPlayer>().strangeObituary = true;
            player.buffTime[buffIndex] = 2;
        }
    }
}