using Terraria.ModLoader;

namespace FlyingMinionsIgnoreTerrain
{
	class FlyingMinionsIgnoreTerrain : Mod
	{
		public FlyingMinionsIgnoreTerrain()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
