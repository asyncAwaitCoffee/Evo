using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
    public class Tree(string name, int category, Func<WorldObject, string?, object?> evolvePredicate)
		: Plant(name, category, evolvePredicate)
	{
    }
}
