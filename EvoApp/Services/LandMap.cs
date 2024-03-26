using EvoApp.Enums;
using EvoApp.Models;

namespace EvoApp.Services
{
    public class LandMap
    {
        public LandTile[][] LandTiles { get; init; } = [
                [new(LandTypes.Mud), new(LandTypes.Water), new(LandTypes.Grass),],
                [new(LandTypes.Water), new(LandTypes.Water), new(LandTypes.Mud),],
                [new(LandTypes.Water), new(LandTypes.Grass), new(LandTypes.Grass),],
            ];

        public LandTile GetLandTile(int landX, int landY)
        {
            return LandTiles[landX][landY];
        }
    }
}
