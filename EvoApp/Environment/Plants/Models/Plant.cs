﻿using EvoApp.DTOs;
using EvoApp.Models;

namespace EvoApp.Environment.Plants.Models
{
	public class Plant : LivingSpecie
    {
        public int Category { get; set; }
		public override required LiveState LiveState { get; init; }
		public override required EvolveState EvolveState { get; init; }
		public override required GatherContent GatherContent { get; init; }
		public override void AddEvolveSchema(Func<LivingSpecie, object?> evolveSchema)
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
			return new Plant(name, category) {
				LiveState = new(),
				EvolveState = new(),
				GatherContent = new()
			};
		}
	}
}