using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace CallOfDutyPlus.Items.Weapons.BlackOps4.Pistols
{
    public class Annihilator : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Annihilator");
            Tooltip.SetDefault("[c/b22222:           -Pistol-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 28;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useStyle = 5;
            item.useTime = 20;
            item.useAnimation = 20;
            item.reuseDelay = 15;
            item.knockBack = 9.7f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 24f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(4));
                speedX = perturbedSpeed.X;
                speedY = perturbedSpeed.Y;
            }
            return true;
        }
    }

    public class KAP45 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("KAP-45");
            Tooltip.SetDefault("[c/b22222:           -Pistol-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 3;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 5;
            item.knockBack = 0.1f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 9.0f;
            item.autoReuse = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(21));
                speedX = perturbedSpeed.X;
                speedY = perturbedSpeed.Y;
            }
            return true;
        }
    }

    public class Mozu : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mozu");
            Tooltip.SetDefault("[c/b22222:           -Pistol-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 55;
            item.ranged = true;
            item.width = 36;
            item.height = 22;
            item.useTime = 20;
            item.useAnimation = 20;
            item.reuseDelay = 25;
            item.useStyle = 5;
            item.knockBack = 0.34f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 12.4f;
        }
    }

    public class RK7Garrison : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("RK 7 Garrison");
            Tooltip.SetDefault("[c/b22222:           -Pistol-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 7;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 4;
            item.useAnimation = 12;
            item.reuseDelay = 15;
            item.useStyle = 5;
            item.knockBack = 0.99f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item31;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 8.9f;
            item.scale = 0.47f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(6));
                speedX = perturbedSpeed.X;
                speedY = perturbedSpeed.Y;
            }
            return true;
        }
    }

    public class Strife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Strife");
            Tooltip.SetDefault("[c/b22222:           -Pistol-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 9;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 1;
            item.useAnimation = 1;
            item.useStyle = 5;
            item.knockBack = 0f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 10.3f;
            item.scale = 0.47f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(1));
                speedX = perturbedSpeed.X;
                speedY = perturbedSpeed.Y;
            }
            return true;
        }
    }

    public class Webley : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("[c/b22222:           -Pistol-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 16;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 15;
            item.useAnimation = 15;
            item.reuseDelay = 5;
            item.useStyle = 5;
            item.knockBack = 0.11f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 13.4f;
            item.scale = 0.47f;
        }
    }
}