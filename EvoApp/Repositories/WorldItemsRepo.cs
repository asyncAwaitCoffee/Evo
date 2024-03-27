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
								{ 1, new("Dandelion", "", LandTypes.Grass, 1, 1) },
								{ 2, new("Ryegrass", "", LandTypes.Grass, 1, 2) },
								{ 3, new("Marigold", "", LandTypes.Grass, 1, 3) },
							}
						},
						{ 2,
							new() {
								{ 1, new("Rhododendron", "", LandTypes.Grass, 2, 1) },
								{ 2, new("Boxwood", "", LandTypes.Grass, 2, 2) },
								{ 3, new("Forsythia", "", LandTypes.Grass, 2, 3) },
							}
						},
						{ 3,
							new() {
								{ 1, new("Birch", "", LandTypes.Grass, 3, 1) },
								{ 2, new("Maple", "", LandTypes.Grass, 3, 2) },
								{ 3, new("Oak", "", LandTypes.Grass, 3, 3) },
							}
						},
					}
				},
				{ LandTypes.Mud,
					new() {
						{ 1,
							new() {
								{ 1, new("", "", LandTypes.Mud, 1, 1) },
								{ 2, new("", "", LandTypes.Mud, 1, 2) },
								{ 3, new("", "", LandTypes.Mud, 1, 3) },
							}
						},
						{ 2,
							new() {
								{ 1, new("", "", LandTypes.Mud, 2, 1) },
								{ 2, new("", "", LandTypes.Mud, 2, 2) },
								{ 3, new("", "", LandTypes.Mud, 2, 3) },
							}
						},
						{ 3,
							new() {
								{ 1, new("", "", LandTypes.Mud, 3, 1) },
								{ 2, new("", "", LandTypes.Mud, 3, 2) },
								{ 3, new("", "", LandTypes.Mud, 3, 3) },
							}
						},
					}
				},
				{ LandTypes.Water,
					new() {
						{ 1,
							new() {
								{ 1, new("", "", LandTypes.Water, 1, 1) },
								{ 2, new("", "", LandTypes.Water, 1, 2) },
								{ 3, new("", "", LandTypes.Water, 1, 3) },
							}
						},
						{ 2,
							new() {
								{ 1, new("", "", LandTypes.Water, 2, 1) },
								{ 2, new("", "", LandTypes.Water, 2, 2) },
								{ 3, new("", "", LandTypes.Water, 2, 3) },
							}
						},
						{ 3,
							new() {
								{ 1, new("", "", LandTypes.Water, 3, 1) },
								{ 2, new("", "", LandTypes.Water, 3, 2) },
								{ 3, new("", "", LandTypes.Water, 3, 3) },
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
			return new("Unknown", "No info available", LandTypes.None, 0, 0);
		}

		public IEnumerable<PlantDataDTO> GetPlants()
		{
            foreach (var landType in _plants)
            {
                foreach (var tier in landType.Value)
                {
                    foreach (var plant in tier.Value)
                    {
						yield return plant.Value;
                    }


                }
            }
        }
	}
}
