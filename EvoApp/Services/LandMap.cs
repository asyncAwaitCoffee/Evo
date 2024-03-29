using EvoApp.Enums;
using EvoApp.Models;

namespace EvoApp.Services
{
    public class LandMap
    {
		// TODO - switch to array of arrays
		public LandTile[,] LandTiles { get; init; } = {
                {new(LandTypes.Mud, 0, 0), new(LandTypes.Water, 1, 0), new(LandTypes.Grass, 2, 0),},
                {new(LandTypes.Water, 0, 1), new(LandTypes.Water, 1, 1), new(LandTypes.Mud, 2, 1), },
                {new(LandTypes.Water, 0, 2), new(LandTypes.Grass, 1, 2), new(LandTypes.Grass, 2, 2),},
        };

        public LandTile GetLandTile(int landX, int landY)
        {
            return LandTiles[landY,landX];
        }
    }
}
