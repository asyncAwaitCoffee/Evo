using EvoApp.Enums;
using EvoApp.Environment.Plants.Models;
using EvoApp.Repositories;
using EvoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace EvoApp.Environment.Plants
{
	public class WaterPlantFactory([FromServices] EvolveSchemas evolveShemas, [FromServices] IWorldItemsRepo worldItems)
		: PlantFactoryBase(evolveShemas, worldItems)
	{
		public override Plant TierOne(int subtypeId)
		{
			var (name, info, _, _, _) = _worldItems.GetPlantData(LandTypes.Water, 1, subtypeId);
			return Plant.CreatePlant(name, subtypeId);
		}

		public override Plant TierTwo(int subtypeId)
		{
			var (name, info, _, _, _) = _worldItems.GetPlantData(LandTypes.Water, 2, subtypeId);
			return Plant.CreatePlant(name, subtypeId);
		}

		public override Plant TierThree(int subtypeId)
		{
			var (name, info, _, _, _) = _worldItems.GetPlantData(LandTypes.Water, 3, subtypeId);
			return Plant.CreatePlant(name, subtypeId);
		}
	}
}
