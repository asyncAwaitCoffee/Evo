using EvoApp.Enums;
using EvoApp.Environment.Plants;

namespace EvoApp.Environment
{
	public class WorldObjectFabric
	{
		private readonly IPlantFabric _grasslandPlantFabric;
		private readonly IPlantFabric _waterPlantFabric;

		public WorldObjectFabric(
			[FromKeyedServices("Grassland")] IPlantFabric grasslandPlantFabric,
			[FromKeyedServices("Water")] IPlantFabric waterPlantFabric
			)
        {
			_grasslandPlantFabric = grasslandPlantFabric;
			_waterPlantFabric = waterPlantFabric;
		}
        public IPlantFabric GetPlantFabric(LandTypes type)
		{
			return type switch
			{
				LandTypes.Grass => _grasslandPlantFabric,
				LandTypes.Water => _waterPlantFabric,
				_ => throw new NotImplementedException()
			};
		}
	}
}
