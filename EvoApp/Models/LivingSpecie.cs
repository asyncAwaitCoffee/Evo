using EvoApp.DTOs;

namespace EvoApp.Models
{
	public abstract class LivingSpecie(string name)
	{
		private Coordinates _coordinates = Coordinates.Default();
		protected string _name = name;
		public abstract string FullName { get; }
		public abstract required LiveState LiveState { get; init; }
		public abstract required EvolveState EvolveState { get; init; }
		public abstract required GatherContent GatherContent { get; init; }
		public Coordinates Coordinates {
			get { return _coordinates; }
			set {
				// TODO - coordinates checks
				_coordinates = value;
			} }
		public abstract AdvancedDataDTO AdvanceInTime();
		public abstract void AddEvolveSchema(Func<LivingSpecie, object?> evolveSchema);
	}
}
