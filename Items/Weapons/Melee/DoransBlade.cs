using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Runeterraria.Items.Weapons.Melee
{
  public class DoransBlade : ModItem
  {
    public override void SetStaticDefaults() {
			Tooltip.SetDefault("Crafted by the once great smith, Doran");
    }

    public override void SetDefaults()
    {
      item.damage = 8; // The damage your item deals
      item.melee = true; // Whether your item is part of the melee class
      item.width = 30; // The item texture's width
      item.height = 30; // The item texture's height
      item.useTime = 17; // The time span of using the weapon. Remember in terraria, 60 frames is a second.
      item.useAnimation = 17; // The time span of the using animation of the weapon, suggest setting it the same as useTime.
      item.knockBack = 3; // The force of knockback of the weapon. Maximum is 20
      item.value = Item.buyPrice(450); // The value of the weapon in copper coins
      item.rare = 1; // The rarity of the weapon, from -1 to 13. You can also use ItemRarityID.TheColorRarity
      item.UseSound = SoundID.Item1; // The sound when the weapon is being used
      item.autoReuse = true; // Whether the weapon can be used more than once automatically by holding the use button
      item.crit = 4; // The critical strike chance the weapon has. The player, by default, has 4 critical strike chance
      item.useStyle = 3;
    }
  }
}
