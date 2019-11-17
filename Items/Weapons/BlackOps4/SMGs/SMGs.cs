using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CallOfDutyPlus.Items.Weapons.BlackOps4.SMGs
{
    public class MP5 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MP5");
            Tooltip.SetDefault("[c/b22222:           -Submachine Gun-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 16;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useStyle = 5;
            item.useTime = 6;
            item.useAnimation = 6;
            item.knockBack = 0.12f;
            item.value = 10000;
            item.rare = 7;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.useAmmo = AmmoID.Bullet;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 16.66f;
            item.scale = 0.25f;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-12, 5);
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(14));
                speedX = perturbedSpeed.X;
                speedY = perturbedSpeed.Y;
            }
            return true;
        }
    }
    public class MP5Silenced : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MP5-SD");
            Tooltip.SetDefault("[c/b22222:           -Submachine Gun-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 11;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useStyle = 5;
            item.useTime = 8;
            item.useAnimation = 8;
            item.knockBack = 0.01f;
            item.value = 10000;
            item.rare = 7;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.useAmmo = AmmoID.Bullet;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 16.66f;
            item.scale = 0.25f;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-12, 5);
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5));
                speedX = perturbedSpeed.X;
                speedY = perturbedSpeed.Y;
            }
            return true;
        }
        public class P90 : ModItem
        {
            public override void SetStaticDefaults()
            {
                DisplayName.SetDefault("P90");
                Tooltip.SetDefault("[c/b22222:           -Submachine Gun-]" +
                    "\n[c/ff8c00:Call of Duty - Black Ops 4]");
            }
            public override void SetDefaults()
            {
                item.damage = 19;
                item.ranged = true;
                item.width = 38;
                item.height = 38;
                item.useStyle = 5;
                item.useTime = 7;
                item.useAnimation = 7;
                item.knockBack = 0.23f;
                item.value = 10000;
                item.rare = 7;
                item.UseSound = SoundID.Item11;
                item.autoReuse = true;
                item.useAmmo = AmmoID.Bullet;
                item.shoot = ProjectileID.Bullet;
                item.shootSpeed = 16.66f;
                item.scale = 0.25f;
            }
            public override Vector2? HoldoutOffset()
            {
                return new Vector2(-28, 3);
            }
            public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
            {
                for (int i = 0; i < 1; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(9));
                    speedX = perturbedSpeed.X;
                    speedY = perturbedSpeed.Y;
                }
                return true;
            }
        }
        public class Thompson : ModItem
        {
            public override void SetStaticDefaults()
            {
                DisplayName.SetDefault("Thompson");
                Tooltip.SetDefault("[c/b22222:           -Submachine Gun-]" +
                    "\n[c/ff8c00:Call of Duty - Black Ops 4]");
            }
            public override void SetDefaults()
            {
                item.damage = 26;
                item.ranged = true;
                item.width = 38;
                item.height = 38;
                item.useStyle = 5;
                item.useTime = 9;
                item.useAnimation = 9;
                item.knockBack = 0.55f;
                item.value = 10000;
                item.rare = 7;
                item.UseSound = SoundID.Item11;
                item.autoReuse = true;
                item.useAmmo = AmmoID.Bullet;
                item.shoot = ProjectileID.Bullet;
                item.shootSpeed = 16.66f;
                item.scale = 0.25f;
            }
            public override Vector2? HoldoutOffset()
            {
                return new Vector2(-15, 6);
            }
            public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
            {
                for (int i = 0; i < 1; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(7));
                    speedX = perturbedSpeed.X;
                    speedY = perturbedSpeed.Y;
                }
                return true;
            }
        }
    }
}
