using EvoApp.Environment.Plants.Models;
using EvoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace EvoApp.Environment.Plants
{
	public class WaterPlantFactory([FromServices] EvolveShemas evolveShemas)
		: PlantFactoryBase(evolveShemas)
	{
		public override Plant TierOne(int subtypeId)
		{
			string nameBasedOnCategory = $"Water T1 ST{subtypeId}";
			return new Algae(nameBasedOnCategory, subtypeId, _evolveShemas.Age(10));
		}

		public override Plant TierTwo(int subtypeId)
		{
			string nameBasedOnCategory = $"Water T2 ST{subtypeId}";
			return new Algae(nameBasedOnCategory, subtypeId, _evolveShemas.Age(20));
		}

		public override Plant TierThree(int subtypeId)
		{
			string nameBasedOnCategory = $"Water T3 ST{subtypeId}";
			return new Algae(nameBasedOnCategory, subtypeId, _evolveShemas.Age(30));
		}
	}
}
