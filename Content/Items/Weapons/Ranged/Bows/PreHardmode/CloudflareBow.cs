﻿using Microsoft.Xna.Framework;
using Polarities.Content.Items.Materials.PreHardmode;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Polarities.Content.Items.Weapons.Ranged.Bows.PreHardmode
{
    public class CloudflareBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = (1);
        }

        public override void SetDefaults()
        {
            Item.damage = 12;
            Item.DamageType = DamageClass.Ranged;
            Item.useAmmo = AmmoID.Arrow;

            Item.width = 30;
            Item.height = 46;

            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 3;
            Item.UseSound = SoundID.Item5;
            Item.shoot = ProjectileID.PurificationPowder;
            Item.shootSpeed = 10f;

            Item.value = Item.sellPrice(gold: 1);
            Item.rare = ItemRarityID.Green;
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            position = player.Center + (new Vector2(0, Main.rand.NextFloat(-100, 0))).RotatedByRandom(Math.PI / 2);
            velocity = (Main.MouseWorld - position).SafeNormalize(Vector2.Zero) * velocity.Length();

            for (int i = 0; i < 6; i++)
            {
                int dust = Dust.NewDust(position, 0, 0, DustID.Cloud, Scale: 1.5f);
                Main.dust[dust].velocity *= 0.5f;
            }

            SoundEngine.PlaySound(SoundID.DoubleJump, position);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Cloud, 30)
                .AddIngredient(ItemType<StormChunk>(), 5)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}