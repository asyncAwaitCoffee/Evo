using EvoApp.DTOs;
using EvoApp.Interfaces;
using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
	public abstract class Plant(string name, int category, Func<WorldObject, string?, object?> evolvePredicate)
        : WorldObject(name), ILive
    {
        public int Category { get; set; } = category;
		public override LiveState LiveState { get; init; } = new LiveState();
		public override EvolveState EvolveState { get; init; } = new EvolveState() { EvolveSchema = evolvePredicate };
		
		public override string FullName { get
			{
				return $"{(EvolveState.Evolved ? EvolveState.Prefix : "")} {_name}";
			}
		}
		public override AdvancedDataDTO AdvanceInTime()
		{
			LiveState.Age++;
			var evolveResult = EvolveState.TryEvolve(this);

			return new AdvancedDataDTO(Coordinates, new { LiveState.Age, evolveResult });
		}
	}
}