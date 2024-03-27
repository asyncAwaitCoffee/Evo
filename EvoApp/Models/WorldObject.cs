namespace EvoApp.Models
{
	public abstract class WorldObject(string name)
	{
		private Coordinates _coordinates;
		public string Name { get; init; } = name;
		public Coordinates Coordinates {
			get { return _coordinates; }
			set {
				// TODO - checks
				_coordinates = value;
			} }
    }
}
