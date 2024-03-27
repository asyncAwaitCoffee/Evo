using EvoApp.Environment.Plants.Models;

namespace EvoApp.Environment.Plants
{
    public class GrasslandPlantFabric : IPlantFabric
	{
		public Plant TierOne(int category)
		{
			string nameBasedOnCategory = "Test Grass Name 1";
			return new Herb(nameBasedOnCategory, category);
		}
		public Plant TierTwo(int category)
		{
			string nameBasedOnCategory = "Test Grass Name 2";
			return new Bush(nameBasedOnCategory, category);
		}
		public Plant TierThree(int category)
		{
			string nameBasedOnCategory = "Test Grass Name 3";
			return new Tree(nameBasedOnCategory, category);
		}
	}
}
