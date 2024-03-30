using EvoApp.DTOs;
using EvoApp.Enums;
using EvoApp.Interfaces;
using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
	public class Plant : WorldObject, ILive
    {
        public int Category { get; set; }
		public override LiveState LiveState { get; init; } = new LiveState();
		public override EvolveState EvolveState { get; init; } = new EvolveState();
		public override GatherContent GatherContent { get; init; } = new GatherContent();
		public void AddEvolveSchema(Func<WorldObject, object?> evolveSchema)
		{
			EvolveState.EvolveSchemas.Add(evolveSchema);
		}

        private Plant(string name, int category) : base(name)
		{
			Category = category;
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

		public static Plant CreatePlant(string name, int category)
		{
			return new Plant(name, category);
		}
	}
}