using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace CustomizableDefense
{
    class MyPlayer : ModPlayer
    {
        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            customDamage = true;
            damage = (int)(damage - this.player.statDefense * ( Main.expertMode ? Config.ExpertDefenseMultiplier : Config.NormalDefenseMultiplier ) );
            if (damage < -Config.NoDamageThreshold)
                damage = 0;
            else if (damage < 1)
                damage = 1;
            return base.PreHurt(pvp, quiet, ref damage, ref hitDirection, ref crit, ref customDamage, ref playSound, ref genGore, ref damageSource);
        }
    }
}
