using EvoApp.Environment.Plants.Models;

namespace EvoApp.Environment.Plants
{
    public interface IPlantFabric
	{
		Plant Tier(int tierId, int subtypeId)
		{
			return tierId switch
			{
				1 => TierOne(subtypeId),
				2 => TierTwo(subtypeId),
				3 => TierThree(subtypeId),
				_ => throw new NotImplementedException()
			};
		}
		Plant TierOne(int subtypeId);
		Plant TierTwo(int subtypeId);
		Plant TierThree(int subtypeId);
	}
}