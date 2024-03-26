using EvoApp.Enums;

namespace EvoApp.Models
{
	public class LandTile(LandTypes landType, int landX, int landY)
	{
        public WorldObject?[,] TileGrid { get; init; } = new WorldObject?[3,3];
		public LandTypes LandType { get; init; } = landType;
		public (int landX, int landY) Coordinates { get; set; } = (landX, landY);
        public void PlaceItem(WorldObject worldObject, int tileX, int tileY)
		{
			TileGrid[tileY,tileX] = worldObject;
        }
		public void RemoveItem(int tileX, int tileY)
		{
			TileGrid[tileY,tileX] = null;
		}
	}
}
