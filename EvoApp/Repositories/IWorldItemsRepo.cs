using EvoApp.DTOs;
using EvoApp.Enums;

namespace EvoApp.Repositories
{
	public interface IWorldItemsRepo
	{
		PlantData GetPlantData(LandTypes landType, int tier, int subcategory);
	}
}