namespace EvoApp.Models
{
	public class Coordinates(int landX, int landY, int tileX, int tileY)
	{
		public int LandX { get; set; } = landX;
        public int LandY { get; set; } = landY;
		public int TileX { get; set; } = tileX;
		public int TileY { get; set; } = tileY;
	}
}
