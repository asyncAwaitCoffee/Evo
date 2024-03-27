using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
    public class Herb(string name, int category, Predicate<LiveState> evolvePredicate)
		: Plant(name, category, evolvePredicate)
	{
    }
}
