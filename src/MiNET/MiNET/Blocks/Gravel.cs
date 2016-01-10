using MiNET.Utils;

namespace MiNET.Blocks
{
	public class Gravel : Block
	{
		public Gravel() : base(13)
		{
		}
		
		public override ItemStack GetDrops()
		{
			return new ItemStack(318, 1); //TODO: Add a random chance of drop
		}
	}
}
