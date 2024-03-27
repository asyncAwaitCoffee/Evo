using EvoApp.DTOs;
using EvoApp.Enums;

namespace EvoApp.Repositories
{
	public interface IWorldItemsRepo
	{
		PlantDataDTO GetPlantData(LandTypes landType, int tier, int subcategory);
		public IEnumerable<KeyValuePair<int, PlantDataDTO>> GetLandPlantsByTier(LandTypes landType, int tier);
	}
}