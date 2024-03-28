using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
    public class Herb(string name, int category, Func<WorldObject, object?> evolvePredicate)
		: Plant(name, category, evolvePredicate)
	{
    }
}
