using EvoApp.Interfaces;

namespace EvoApp.Models
{
	public class Tree(string name, int tyleX, int tyleY)
		: WorldObject(name, tyleX, tyleY), ILive
	{
		public void Grow()
		{
            Console.WriteLine($"I'm {Name} and I'm growing at {Coordinates}!");
        }
	}
}
