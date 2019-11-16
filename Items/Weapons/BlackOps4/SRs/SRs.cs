using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace CallOfDutyPlus.Items.Weapons.BlackOps4.SRs
{
    public class Koshka : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Koshka");
            Tooltip.SetDefault("[c/b22222:       -Sniper Rifle-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 360;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useAnimation = 15;
            item.useTime = 15;
            item.reuseDelay = 220;
            item.useStyle = 5;
            item.knockBack = 15.5f;
            item.value = 10000;
            item.rare = -11;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 13.4f;
            item.crit = 75;
            item.noMelee = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BulletHighVelocity, damage, knockBack, player.whoAmI, 0f, 0f);
            return false; //We dont want the initial bullet
        }
    }

    public class Locus : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Locus");
            Tooltip.SetDefault("[c/b22222:       -Sniper Rifle-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 190;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 15;
            item.useAnimation = 15;
            item.reuseDelay = 195;
            item.useStyle = 5;
            item.knockBack = 9.7f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 12.9f;
            item.crit = 50;
            item.noMelee = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BulletHighVelocity, damage, knockBack, player.whoAmI, 0f, 0f);
            return false; //We dont want the initial bullet
        }
    }

    public class OutlawSR : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Outlaw");
            Tooltip.SetDefault("[c/b22222:       -Sniper Rifle-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 425;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 15;
            item.useAnimation = 15;
            item.reuseDelay = 280;
            item.useStyle = 5;
            item.knockBack = 9.7f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item31;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 17.9f;
            item.crit = 25;
            item.noMelee = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BulletHighVelocity, damage, knockBack, player.whoAmI, 0f, 0f);
            return false; //We dont want the initial bullet
        }
    }

    public class PaladinHB50 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Paladin HB50");
            Tooltip.SetDefault("[c/b22222:       -Sniper Rifle-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 155;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useAnimation = 15;
            item.useTime = 5;
            item.reuseDelay = 180;
            item.useStyle = 5;
            item.knockBack = 2.7f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item31;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 14.4f;
            item.crit = 95;
            item.noMelee = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BulletHighVelocity, damage, knockBack, player.whoAmI, 0f, 0f);
            return false; //We dont want the initial bullet
        }
    }

    public class SDM : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SDM");
            Tooltip.SetDefault("[c/b22222:       -Sniper Rifle-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 85;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 5;
            item.reuseDelay = 75;
            item.knockBack = 0.1f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 9.9f;
            item.scale = 0.45f;
            item.noMelee = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BulletHighVelocity, damage, knockBack, player.whoAmI, 0f, 0f);
            return false; //We dont want the initial bullet
        }
    }

    public class VendettaSR : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vendetta");
            Tooltip.SetDefault("[c/b22222:       -Sniper Rifle-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 30;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 14;
            item.useAnimation = 14;
            item.useStyle = 5;
            item.reuseDelay = 30;
            item.knockBack = 0f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 8.5f;
            item.scale = 0.5f;
            item.noMelee = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BulletHighVelocity, damage, knockBack, player.whoAmI, 0f, 0f);
            return false; //We dont want the initial bullet
        }
    }
}