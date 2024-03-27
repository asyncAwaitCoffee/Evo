using EvoApp.DTOs;
using EvoApp.Enums;

namespace EvoApp.Repositories
{
	public interface IWorldItemsRepo
	{
		PlantDataDTO GetPlantData(LandTypes landType, int tier, int subcategory);
		public IEnumerable<PlantDataDTO> GetPlants();
    }
}