using System;
using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using Terraria.ID;

namespace CallOfDutyPlus.Items.Weapons.BlackOps4.Shotguns
{
    public class Argus : ModItem
    {
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Argus");
            Tooltip.SetDefault("[c/b22222:         -Shotgun-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 64;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useAnimation = 18;
            item.useTime = 18;
            item.reuseDelay = 30;
            item.useStyle = 5;
            item.knockBack = 1.8f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item36;
            item.autoReuse = false;
            item.useAmmo = AmmoID.Bullet;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 8.6f;
            item.crit = 20;
            item.noMelee = true; //Makes sure that the shotgun does not physically damage.
        }
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.damage = 39;
                item.shootSpeed = 12.4f;
                item.crit = 50;
                item.autoReuse = false;
            }
            else
            {
                item.damage = 64;
                item.shootSpeed = 8.6f;
                item.crit = 20;
            }
            return base.CanUseItem(player);
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (player.altFunctionUse == 2)
            {
                int numberProjectiles = 10; //this gun's number of pellets
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(3)); // 3 degree spread.
                                                                                                                   // If you want to randomize the speed to stagger the projectiles
                                                                                                                   // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                   // perturbedSpeed = perturbedSpeed * scale; 
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                }
            }
            else
            {
                int numberProjectiles = 10; //this gun's number of pellets
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(16)); // 9 degree spread.
                                                                                                                   // If you want to randomize the speed to stagger the projectiles
                                                                                                                   // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                   // perturbedSpeed = perturbedSpeed * scale; 
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                }
            }            
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }

    public class M1897TrenchGun : ModItem
    {
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("M1897 Trench Gun");
            Tooltip.SetDefault("[c/b22222:         -Shotgun-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 107;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useAnimation = 30;
            item.useTime = 30;
            item.reuseDelay = 60;
            item.useStyle = 5;
            item.knockBack = 1.5f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item36;
            item.autoReuse = false;
            item.useAmmo = AmmoID.Bullet;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 8.6f;
            item.crit = 20;
        }
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.damage = 64;
                item.shootSpeed = 16.2f;
                item.crit = 50;
                item.autoReuse = false;
            }
            else
            {
                item.damage = 107;
                item.shootSpeed = 8.6f;
                item.crit = 20;
            }
            return base.CanUseItem(player);
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (player.altFunctionUse == 2)
            {
                int numberProjectiles = 8;
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(6)); // 16 degree spread.
                                                                                                                    // Please, for the love of god, if you are inspecting the code illegally, for the love of god, do not scream at the developers for making this weapon so god damn insane. 
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                }
            }
            else
            {
                int numberProjectiles = 8;
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(8)); // 16 degree spread.
                                                                                                                    // Please, for the love of god, if you are inspecting the code illegally, for the love of god, do not scream at the developers for making this weapon so god damn insane. 
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                }
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }

    public class MOG12 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MOG 12");
            Tooltip.SetDefault("[c/b22222:         -Shotgun-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 61;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 15;
            item.useAnimation = 15;
            item.reuseDelay = 12;
            item.useStyle = 5;
            item.knockBack = 0.9f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item36;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 8.6f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5; // 5 bullets, compensating for high fire rate
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(14)); // High spread to compensate for fire rate.
                                                                                                                // Dont mind the weapon, it can still be insane.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }

    public class Rampage : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rampage");
            Tooltip.SetDefault("[c/b22222:         -Shotgun-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 29;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 10;
            item.useAnimation = 10;
            item.reuseDelay = 20;
            item.useStyle = 5;
            item.knockBack = 0.3f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item36;
            item.autoReuse = true;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 7.7f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 6; // 6 bullets
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread because of balancing.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }

    public class SG12 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SG-12");
            Tooltip.SetDefault("[c/b22222:         -Shotgun-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 52;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 13;
            item.useAnimation = 13;
            item.useStyle = 5;
            item.knockBack = 1.2f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item36;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 9.5f;
            item.scale = 0.45f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 4; // 4 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20)); // 20 degree spread.
                                                                                                                // This is mainly to be a balance between the Rampage and MOG12.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }
}