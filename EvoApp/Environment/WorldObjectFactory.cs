using EvoApp.Enums;
using EvoApp.Environment.Plants;

namespace EvoApp.Environment
{
	public class WorldObjectFactory
	{
		private readonly PlantFactoryBase _grasslandPlantFabric;
		private readonly PlantFactoryBase _waterPlantFabric;
		private readonly PlantFactoryBase _mudPlantFabric;

		public WorldObjectFactory(
			[FromKeyedServices("Grassland")] PlantFactoryBase grasslandPlantFabric,
			[FromKeyedServices("Water")] PlantFactoryBase waterPlantFabric,
			[FromKeyedServices("Mud")] PlantFactoryBase mudPlantFabric
			)
        {
			_grasslandPlantFabric = grasslandPlantFabric;
			_waterPlantFabric = waterPlantFabric;
			_mudPlantFabric = mudPlantFabric;
		}
        public PlantFactoryBase GetPlantFabric(LandTypes type)
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
