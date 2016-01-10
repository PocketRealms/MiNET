using MiNET.Utils;

namespace MiNET.Blocks
{
	public class Bookshelf : Block
	{
		public Bookshelf() : base(47)
		{
			FuelEfficiency = 15;
		}
		
		public override ItemStack GetDrops()
		{
			return new ItemStack(340, 2); //TODO: Make random between 2 - 4
		}
	}
}
