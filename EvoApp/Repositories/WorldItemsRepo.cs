using EvoApp.DTOs;
using EvoApp.Enums;
using EvoApp.Environment.Plants.Models;
using System.Collections.Immutable;

namespace EvoApp.Repositories
{
	public class WorldItemsRepo : IWorldItemsRepo
	{
		private Dictionary<LandTypes, Dictionary<int, Dictionary<int, PlantDataDTO>>> _plants;
		public WorldItemsRepo()
		{
			// LandTypes -> Tier -> subcategory -> plant data

			_plants = new()
			{
				{ LandTypes.Grass,
					new() {
						{ 1,
							new() {
								{ 1, new("Dandelion") },
								{ 2, new("Ryegrass") },
								{ 3, new("Marigold") },
							}
						},
						{ 2,
							new() {
								{ 1, new("Rhododendron") },
								{ 2, new("Boxwood") },
								{ 3, new("Forsythia") },
							}
						},
						{ 3,
							new() {
								{ 1, new("Birch") },
								{ 2, new("Maple") },
								{ 3, new("Oak") },
							}
						},
					}
				},
				{ LandTypes.Mud,
					new() {
						{ 1,
							new() {
								{ 1, new("") },
								{ 2, new("") },
								{ 3, new("") },
							}
						},
						{ 2,
							new() {
								{ 1, new("") },
								{ 2, new("") },
								{ 3, new("") },
							}
						},
						{ 3,
							new() {
								{ 1, new("") },
								{ 2, new("") },
								{ 3, new("") },
							}
						},
					}
				},
				{ LandTypes.Water,
					new() {
						{ 1,
							new() {
								{ 1, new("") },
								{ 2, new("") },
								{ 3, new("") },
							}
						},
						{ 2,
							new() {
								{ 1, new("") },
								{ 2, new("") },
								{ 3, new("") },
							}
						},
						{ 3,
							new() {
								{ 1, new("") },
								{ 2, new("") },
								{ 3, new("") },
							}
						},
					}
				},
			};
		}

		public PlantDataDTO GetPlantData(LandTypes landType, int tier, int subcategory)
		{
			if (_plants.TryGetValue(landType, out var landPlants))
			{
				if (landPlants.TryGetValue(tier, out var tierPlants))
				{
					if (tierPlants.TryGetValue(subcategory, out var plantData))
					{
						return plantData;
					}
				}
			}
			return new("Unknown");
		}
	}
}
