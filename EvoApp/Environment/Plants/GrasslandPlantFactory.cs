using EvoApp.Environment.Plants.Models;
using EvoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace EvoApp.Environment.Plants
{
    public class GrasslandPlantFactory([FromServices] EvolveShemas evolveShemas)
		: PlantFactoryBase(evolveShemas)
	{
		public override Plant TierOne(int subtypeId)
		{
			string nameBasedOnCategory = $"Grass T1 ST{subtypeId}";
			return new Herb(nameBasedOnCategory, subtypeId, _evolveShemas.Age(10));
		}
		public override Plant TierTwo(int subtypeId)
		{
			string nameBasedOnCategory = $"Grass T2 ST{subtypeId}";
			return new Bush(nameBasedOnCategory, subtypeId, _evolveShemas.Age(20));
		}
		public override Plant TierThree(int subtypeId)
		{
			string nameBasedOnCategory = $"Grass T3 ST{subtypeId}";
			return new Tree(nameBasedOnCategory, subtypeId, _evolveShemas.Age(30));
		}
	}
}
