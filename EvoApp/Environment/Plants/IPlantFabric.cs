using EvoApp.Environment.Plants.Models;

namespace EvoApp.Environment.Plants
{
    public interface IPlantFabric
	{
		Plant TierOne(int category);
		Plant TierTwo(int category);
		Plant TierThree(int category);
	}
}