using EvoApp.Enums;
using EvoApp.Environment.Plants.Models;
using EvoApp.Repositories;
using EvoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace EvoApp.Environment.Plants
{
	public class MudPlantFactory([FromServices] EvolveSchemas evolveShemas, [FromServices] IWorldItemsRepo worldItems)
		: PlantFactoryBase(evolveShemas, worldItems)
	{
        public override Plant TierOne(int subtypeId)
		{
			var (name, info, _, _, _, price) = _worldItems.GetPlantData(LandTypes.Mud, 1, subtypeId);
			return Plant.CreatePlant(name, subtypeId, price);
		}

		public override Plant TierTwo(int subtypeId)
		{
			var (name, info, _, _, _, price) = _worldItems.GetPlantData(LandTypes.Mud, 2, subtypeId);
			return Plant.CreatePlant(name, subtypeId, price);
		}

		public override Plant TierThree(int subtypeId)
		{
			var (name, info, _, _, _, price) = _worldItems.GetPlantData(LandTypes.Mud, 3, subtypeId);
			return Plant.CreatePlant(name, subtypeId, price);
		}
	}
}
