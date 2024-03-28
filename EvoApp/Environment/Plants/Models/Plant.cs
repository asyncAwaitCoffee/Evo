using EvoApp.Interfaces;
using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
	public abstract class Plant(string name, int category, Func<LiveState, string?, bool> evolvePredicate)
        : WorldObject(name), ILive
    {
        public int Category { get; set; } = category;
		public override LiveState State { get; init; } = new LiveState() { EvolveSchema = evolvePredicate };
		public override string FullName { get
			{
				return $"{(State.Evolved ? State.Prefix : "")} {_name}";
			}
		}
		public override void AdvanceInTime()
		{
			State.Age++;
		}
	}
}