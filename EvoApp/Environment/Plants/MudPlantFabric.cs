using EvoApp.Environment.Plants.Models;

namespace EvoApp.Environment.Plants
{
	public class MudPlantFabric : IPlantFabric
	{
		public Plant TierOne(int subtypeId)
		{
			string nameBasedOnCategory = $"Mud T1 ST{subtypeId}";
			return new MudPlantain(nameBasedOnCategory, subtypeId);
		}

		public Plant TierTwo(int subtypeId)
		{
			string nameBasedOnCategory = $"Mud T2 ST{subtypeId}";
			return new MudPlantain(nameBasedOnCategory, subtypeId);
		}

		public Plant TierThree(int subtypeId)
		{
			string nameBasedOnCategory = $"Mud T3 ST{subtypeId}";
			return new MudPlantain(nameBasedOnCategory, subtypeId);
		}
	}
}
