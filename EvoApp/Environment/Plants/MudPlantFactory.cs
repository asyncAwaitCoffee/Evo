using EvoApp.DTOs;
using EvoApp.Enums;
using EvoApp.Environment.Plants.Models;
using EvoApp.Repositories;
using EvoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace EvoApp.Environment.Plants
{
	public class MudPlantFactory([FromServices] EvolveShemas evolveShemas, [FromServices] IWorldItemsRepo worldItems)
		: PlantFactoryBase(evolveShemas, worldItems)
	{
        public override Plant TierOne(int subtypeId)
		{
			PlantData plantData = _worldItems.GetPlantData(LandTypes.Mud, 1, subtypeId);
			return new MudPlantain(plantData.Name, subtypeId, _evolveShemas.Age(10));
		}

		public override Plant TierTwo(int subtypeId)
		{
			PlantData plantData = _worldItems.GetPlantData(LandTypes.Mud, 2, subtypeId);
			return new MudPlantain(plantData.Name, subtypeId, _evolveShemas.Age(20));
		}

		public override Plant TierThree(int subtypeId)
		{
			PlantData plantData = _worldItems.GetPlantData(LandTypes.Mud, 3, subtypeId);
			return new MudPlantain(plantData.Name, subtypeId, _evolveShemas.Age(30));
		}
	}
}
