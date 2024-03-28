using EvoApp.Interfaces;

namespace EvoApp.Models
{
	public abstract class WorldObject(string name)
	{
		private Coordinates _coordinates;
		protected string _name = name;
		public abstract string FullName { get; }
        public Coordinates Coordinates {
			get { return _coordinates; }
			set {
				// TODO - checks
				_coordinates = value;
			} }
    }
}
