using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
	public class MudPlantain(string name, int category, Predicate<LiveState> evolvePredicate)
		: Plant(name, category, evolvePredicate)
	{
	}
}
