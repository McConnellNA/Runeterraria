using ExampleMod.Projectiles;
using ExampleMod.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExampleMod.Items.Weapons
{
	public class ExampleStaff : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Crafted by the once great artificer, Doran");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults() {
			item.damage = 15;
			item.magic = true;
			item.mana = 5;
			item.width = 5;
			item.height = 5;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 2.8;
			item.value = Item.buyPrice(400);
			item.rare = 1;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<SparklingBall>();
			item.shootSpeed = 16f;
		}
  }
}
