namespace EvoApp.Models
{
	public abstract class WorldObject
		(string name, int landX, int landY, int tileX, int tileY)
	{
		public string Name { get; init; } = name;
		public Coordinates Coordinates { get; set; } 
			= new(landX, landY, tileX, tileY);
    }
}
