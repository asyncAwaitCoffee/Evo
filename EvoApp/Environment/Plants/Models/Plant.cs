using EvoApp.Interfaces;
using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
	public abstract class Plant(string name, int category, Predicate<LiveState> evolvePredicate) : WorldObject(name), ILive
    {
        public int Category { get; set; } = category;
		public LiveState State { get; init; } = new() { EvolveSchema = evolvePredicate };
	}
}