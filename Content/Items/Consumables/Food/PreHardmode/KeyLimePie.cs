﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Polarities.Content.Items.Consumables.Food.PreHardmode
{
    public class KeyLimePie : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = (10);

            // Tooltip.SetDefault(Lang.GetTooltip(ItemID.GoldenDelight).GetLine(0));

            DrawAnimationVertical animation = new DrawAnimationVertical(1, 3)
            {
                NotActuallyAnimating = true
            };
            Main.RegisterItemAnimation(Type, animation);

            ItemID.Sets.FoodParticleColors[Type] = new Color[] { Color.Lime, Color.LimeGreen, Color.White };
            ItemID.Sets.IsFood[Type] = true;
        }

        public override void SetDefaults()
        {
            Item.width = 38;
            Item.height = 30;
            Item.maxStack = 9999;
            Item.value = Item.sellPrice(silver: 40);
            Item.rare = ItemRarityID.Orange;
            Item.consumable = true;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useTurn = true;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.UseSound = SoundID.Item2;
            Item.buffType = BuffID.WellFed3;
            Item.buffTime = 28800;
        }
    }
}