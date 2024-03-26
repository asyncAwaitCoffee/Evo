namespace EvoApp.Models
{
	public abstract class WorldObject(string name, int tileX, int tileY)
	{
		public string Name { get; init; } = name;
		public (int tileX, int tileY) Coordinates { get; set; } = (tileX, tileY);
    }
}
