using Terraria;
using Terraria.ModLoader;

namespace FlyingMinionsIgnoreTerrain
{
    /* makes all flying minions ignore terrain */
    class MyGlobalProjectile : GlobalProjectile
    {
        public override void PostAI(Projectile projectile)
        {
            base.PostAI(projectile);

            if (projectile.minion && (projectile.ignoreWater || projectile.aiStyle==54) && projectile.aiStyle != 26 && projectile.minionSlots>0) projectile.tileCollide = false;
        }
    }
}
