using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Runeterraria.Items.Accessories
{
  public class DoransShield : ModItem
  {
    public override void SetStaticDefaults()
    {
			Tooltip.SetDefault("Crafted by the once great smith, Doran. Gives you 20 max life an 4% damage reduction");
    }

    public override void SetDefaults()
    {
      item.width = 20;
      item.height = 20;
      item.value = Item.buyPrice(2000);
      item.accessory = true;
      item.rare = 1;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
      player.statLifeMax2 += 20;
      player.endurance += 0.04f;
    }
  }
}
