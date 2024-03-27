using EvoApp.Interfaces;
using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
	public abstract class Plant(string name, int category) : WorldObject(name), ILive
    {
        public int Category { get; set; } = category;
        public int Age { get; set; }
		public LiveState State { get; init; } = new() { TryEvolve = (liveState) => liveState.Age > 10 };
	}
}
