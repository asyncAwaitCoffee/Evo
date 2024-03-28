using EvoApp.Models;

namespace EvoApp.Interfaces
{
	public interface ILive
	{
		public LiveState LiveState { get; init; }
		public EvolveState EvolveState { get; init; }
		public void AddEvolveSchema(Func<WorldObject, object?> evolveSchema);
    }
}
