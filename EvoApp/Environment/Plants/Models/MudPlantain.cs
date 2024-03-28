using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
	public class MudPlantain(string name, int category, Func<WorldObject, object?> evolvePredicate)
		: Plant(name, category, evolvePredicate)
	{
	}
}
