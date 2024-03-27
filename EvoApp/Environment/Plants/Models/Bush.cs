using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
    public class Bush(string name, int category, Predicate<LiveState> evolvePredicate)
		: Plant(name, category, evolvePredicate)
	{
    }
}
