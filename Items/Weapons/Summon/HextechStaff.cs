using Runeterraria.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Runeterraria.Items.Weapons.Summon
{
	public class HextechStaff : ModItem
	{
    public override void SetStaticDefaults()
    {
			DisplayName.SetDefault("HextechStaff");
			Tooltip.SetDefault("Summons an H-28G Evolution Turret to fight along side you");
			ItemID.Sets.GamepadWholeScreenUseRange[item.type] = true; // This lets the player target anywhere on the whole screen while using a controller.
			ItemID.Sets.LockOnIgnoresCollision[item.type] = true;
		}

		public override void SetDefaults() {
			item.damage = 30;
			item.knockBack = 3f;
			item.mana = 10;
			item.width = 32;
			item.height = 32;
			item.useTime = 36;
			item.useAnimation = 36;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.buyPrice(2000);
			item.rare = 1;
			item.UseSound = SoundID.Item44;

			item.noMelee = true;
			item.summon = true;
			item.buffType = ModContent.BuffType<ExampleMinionBuff>();

			item.shoot = ModContent.ProjectileType<ExampleMinion>();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
			player.AddBuff(item.buffType, 2);

			position = Main.MouseWorld;
			return true;
		}
  }
}
