using EvoApp.DTOs;
using EvoApp.Interfaces;
using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
	public abstract class Plant(string name, int category)
        : WorldObject(name), ILive
    {
        public int Category { get; set; } = category;
		public override LiveState LiveState { get; init; } = new LiveState();
		public override EvolveState EvolveState { get; init; } = new EvolveState();
		public override GatherContent GatherContent { get; init; }
		public void AddEvolveSchema(Func<WorldObject, object?> evolveSchema)
		{
			EvolveState.EvolveSchemas.Add(evolveSchema);
		}

		public override string FullName { get
			{
				return $"{EvolveState.Prefix} {_name} {EvolveState.Postfix}";
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