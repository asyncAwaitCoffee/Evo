using EvoApp.Environment.Plants.Models;

namespace EvoApp.Environment.Plants
{
    public class GrasslandPlantFabric : IPlantFabric
	{
		public Plant TierOne(int subtypeId)
		{
			string nameBasedOnCategory = $"Grass T1 ST{subtypeId}";
			return new Herb(nameBasedOnCategory, subtypeId);
		}
		public Plant TierTwo(int subtypeId)
		{
			string nameBasedOnCategory = $"Grass T2 ST{subtypeId}";
			return new Bush(nameBasedOnCategory, subtypeId);
		}
		public Plant TierThree(int subtypeId)
		{
			string nameBasedOnCategory = $"Grass T3 ST{subtypeId}";
			return new Tree(nameBasedOnCategory, subtypeId);
		}
	}
}
