using EvoApp.Enums;
using EvoApp.Environment.Plants;

namespace EvoApp.Environment
{
	public class WorldObjectFabric
	{
		private readonly IPlantFactory _grasslandPlantFabric;
		private readonly IPlantFactory _waterPlantFabric;
		private readonly IPlantFactory _mudPlantFabric;

		public WorldObjectFabric(
			[FromKeyedServices("Grassland")] IPlantFactory grasslandPlantFabric,
			[FromKeyedServices("Water")] IPlantFactory waterPlantFabric,
			[FromKeyedServices("Mud")] IPlantFactory mudPlantFabric
			)
        {
			_grasslandPlantFabric = grasslandPlantFabric;
			_waterPlantFabric = waterPlantFabric;
			_mudPlantFabric = mudPlantFabric;
		}
        public IPlantFactory GetPlantFabric(LandTypes type)
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
