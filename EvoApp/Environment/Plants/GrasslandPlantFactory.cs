using EvoApp.DTOs;
using EvoApp.Enums;
using EvoApp.Environment.Plants.Models;
using EvoApp.Repositories;
using EvoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace EvoApp.Environment.Plants
{
    public class GrasslandPlantFactory([FromServices] EvolveShemas evolveShemas, [FromServices] IWorldItemsRepo worldItems)
		: PlantFactoryBase(evolveShemas, worldItems)
	{
		public override Plant TierOne(int subtypeId)
		{
			PlantData plantData = _worldItems.GetPlantData(LandTypes.Grass, 1, subtypeId);
			return new Herb(plantData.Name, subtypeId, _evolveShemas.Age(10));
		}

		public override Plant TierTwo(int subtypeId)
		{
			PlantData plantData = _worldItems.GetPlantData(LandTypes.Grass, 2, subtypeId);
			return new Bush(plantData.Name, subtypeId, _evolveShemas.Age(20));
		}

		public override Plant TierThree(int subtypeId)
		{
			PlantData plantData = _worldItems.GetPlantData(LandTypes.Grass, 3, subtypeId);
			return new Tree(plantData.Name, subtypeId, _evolveShemas.Age(30));
		}
	}
}
