using EvoApp.DTOs;

namespace EvoApp.Models
{
	public abstract class WorldObject(string name)
	{
		private Coordinates _coordinates = Coordinates.Default;
		protected string _name = name;
		public abstract string FullName { get; }
		public abstract LiveState LiveState { get; init; }
		public abstract EvolveState EvolveState { get; init; }
		public abstract GatherContent GatherContent { get; init; }
		public Coordinates Coordinates {
			get { return _coordinates; }
			set {
				// TODO - coordinates checks
				_coordinates = value;
			} }
		public abstract AdvancedDataDTO AdvanceInTime();
    }
}
