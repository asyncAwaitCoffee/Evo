using EvoApp.Enums;

namespace EvoApp.Models
{
	public class LandTile(LandTypes landType, int landX, int landY)
	{
		// TODO - switch to array of arrays
        public LivingSpecie?[,] TileGrid { get; init; } = new LivingSpecie?[3,3];
		public LandTypes LandType { get; init; } = landType;
		public (int landX, int landY) Coordinates { get; set; } = (landX, landY);
        public void PlaceItem(LivingSpecie worldObject, int tileX, int tileY)
		{
			TileGrid[tileY,tileX] = worldObject;
		}
		public LivingSpecie? GetItem(int tileX, int tileY)
		{
			return TileGrid[tileY, tileX];
		}
		public void RemoveItem(int tileX, int tileY)
		{
			TileGrid[tileY,tileX] = null;
		}
		public bool CanPlaceItem(int tileX, int tileY)
		{
			return TileGrid[tileY, tileX] is null;
		}
	}
}
