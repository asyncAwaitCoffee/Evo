using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
    public class Bush(string name, int category, Func<WorldObject, string?, object?> evolvePredicate)
		: Plant(name, category, evolvePredicate)
	{
    }
}
