using EvoApp.Environment.Plants.Models;

namespace EvoApp.Environment.Plants
{
	public class WaterPlantFabric : IPlantFabric
	{
		public Plant TierOne(int subtypeId)
		{
			string nameBasedOnCategory = "Water T1 ST{subtypeId}";
			return new Algae(nameBasedOnCategory, subtypeId);
		}

		public Plant TierTwo(int subtypeId)
		{
			string nameBasedOnCategory = $"Water T2 ST{subtypeId}";
			return new Algae(nameBasedOnCategory, subtypeId);
		}

		public Plant TierThree(int subtypeId)
		{
			string nameBasedOnCategory = "Water T3 ST{subtypeId}";
			return new Algae(nameBasedOnCategory, subtypeId);
		}
	}
}
