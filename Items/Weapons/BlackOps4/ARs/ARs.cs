using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace CallOfDutyPlus.Items.Weapons.BlackOps4.ARs
{
    /*public class Galil : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("[c/b22222:       -Assualt Rifle-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 18;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useAnimation = 15;
            item.useTime = 5;
            item.reuseDelay = 20;
            item.useStyle = 5;
            item.knockBack = 1.2f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item31;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 8.9f;
        }
    }

    public class HitchcockM9 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hitchcock M9");
            Tooltip.SetDefault("[c/b22222:       -Assualt Rifle-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 18;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useAnimation = 15;
            item.useTime = 5;
            item.reuseDelay = 20;
            item.useStyle = 5;
            item.knockBack = 1.2f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item31;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 8.9f;
        }
    }*/

    public class ICR7 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ICR-7");
            Tooltip.SetDefault("[c/b22222:       -Assualt Rifle-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 25;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.knockBack = 0.5f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 10.5f;
        }
    }

    /*public class KN57 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("KN-57");
            Tooltip.SetDefault("[c/b22222:       -Assualt Rifle-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 18;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useAnimation = 15;
            item.useTime = 5;
            item.reuseDelay = 20;
            item.useStyle = 5;
            item.knockBack = 1.2f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item31;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 8.9f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
                speedX = perturbedSpeed.X;
                speedY = perturbedSpeed.Y;
            }
            return true;
        }
    }

    public class Peacekeeper : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("[c/b22222:       -Assualt Rifle-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 25;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.knockBack = 1.2f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 9.5f;
            item.scale = 0.47f;
        }
    }

    public class Rampart17 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rampart 17");
            Tooltip.SetDefault("[c/b22222:       -Assualt Rifle-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 25;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.knockBack = 1.2f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 9.5f;
            item.scale = 0.5f;
        }
    }
    public class SwatRFT : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swat RFT");
            Tooltip.SetDefault("[c/b22222:       -Assualt Rifle-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 25;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.knockBack = 1.2f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 9.5f;
            item.scale = 0.5f;
        }
    }
    public class VaprXKG : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vapr-XKG");
            Tooltip.SetDefault("[c/b22222:       -Assualt Rifle-]" +
                "\n[c/ff8c00:Call of Duty - Black Ops 4]");
        }
        public override void SetDefaults()
        {
            item.damage = 25;
            item.ranged = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.knockBack = 1.2f;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.useAmmo = 97;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 9.5f;
            item.scale = 0.5f;
        }
    }*/
}