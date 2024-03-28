namespace EvoApp.Models
{
	public abstract class WorldObject(string name)
	{
		private Coordinates _coordinates;
		protected string _name = name;
		public abstract string FullName { get; }
		public abstract LiveState State { get; init; }
		public Coordinates Coordinates {
			get { return _coordinates; }
			set {
				// TODO - coordinates checks
				_coordinates = value;
			} }
		public abstract void AdvanceInTime();
    }
}
