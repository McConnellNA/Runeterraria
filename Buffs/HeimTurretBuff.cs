using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Runeterraria.Projectiles.Minions;
using Runeterraria.Buffs;

namespace Runeterraria.Buffs
{
  public class HeimTurretBuff : ModBuff
  {
    public override void SetDefaults()
    {
			DisplayName.SetDefault("H-28G Evolution Turret");
			Description.SetDefault("The H-28G Evolution Turret will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
    {
			if (player.ownedProjectileCounts[ModContent.ProjectileType<HeimTurret>()] > 0)
      {
				player.buffTime[buffIndex] = 18000;
			}
			else {
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
  }
}
