using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
    public class Tree(string name, int category, Func<LiveState, string?, bool> evolvePredicate)
		: Plant(name, category, evolvePredicate)
	{
    }
}
