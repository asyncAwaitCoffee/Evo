using EvoApp.Environment.Plants.Models;

namespace EvoApp.Environment.Plants
{
	public class WaterPlantFabric : IPlantFabric
	{
		public Plant TierOne(int category)
		{
			string nameBasedOnCategory = "Test Water Name 1";
			return new Algae(nameBasedOnCategory, category);
		}

		public Plant TierTwo(int category)
		{
			string nameBasedOnCategory = "Test Water Name 3";
			return new Algae(nameBasedOnCategory, category);
		}

		public Plant TierThree(int category)
		{
			string nameBasedOnCategory = "Test Water Name 2";
			return new Algae(nameBasedOnCategory, category);
		}
	}
}
