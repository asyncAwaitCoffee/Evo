﻿using EvoApp.Environment.Plants.Models;
using EvoApp.Repositories;
using EvoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace EvoApp.Environment.Plants
{
	public abstract class PlantFactoryBase
	{
		protected readonly EvolveShemas _evolveShemas;
		protected readonly IWorldItemsRepo _worldItems;
		public PlantFactoryBase(EvolveShemas evolveShemas, IWorldItemsRepo worldItems)
		{
			_evolveShemas = evolveShemas;
			_worldItems = worldItems;
		}
		public Plant Tier(int tierId, int subtypeId)
		{
			return tierId switch
			{
				1 => TierOne(subtypeId),
				2 => TierTwo(subtypeId),
				3 => TierThree(subtypeId),
				_ => throw new NotImplementedException()
			};
		}
		public abstract Plant TierOne(int subtypeId);
		public abstract Plant TierTwo(int subtypeId);
		public abstract Plant TierThree(int subtypeId);
	}
}