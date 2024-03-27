using EvoApp.Enums;
using EvoApp.Environment.Plants;

namespace EvoApp.Environment
{
	public class WorldObjectFabric
	{
		private readonly IPlantFabric _grasslandPlantFabric;
		private readonly IPlantFabric _waterPlantFabric;
		private readonly IPlantFabric _mudPlantFabric;

		public WorldObjectFabric(
			[FromKeyedServices("Grassland")] IPlantFabric grasslandPlantFabric,
			[FromKeyedServices("Water")] IPlantFabric waterPlantFabric,
			[FromKeyedServices("Mud")] IPlantFabric mudPlantFabric
			)
        {
			_grasslandPlantFabric = grasslandPlantFabric;
			_waterPlantFabric = waterPlantFabric;
			_mudPlantFabric = mudPlantFabric;
		}
        public IPlantFabric GetPlantFabric(LandTypes type)
		{
			return type switch
			{
				LandTypes.Grass => _grasslandPlantFabric,
				LandTypes.Water => _waterPlantFabric,
				LandTypes.Mud => _mudPlantFabric,
				_ => throw new NotImplementedException()
			};
		}
	}
}
