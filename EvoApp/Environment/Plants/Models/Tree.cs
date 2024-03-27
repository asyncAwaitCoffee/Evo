using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
    public class Tree(string name, int category, Predicate<LiveState> evolvePredicate)
		: Plant(name, category, evolvePredicate)
	{
    }
}
