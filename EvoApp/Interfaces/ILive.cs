using EvoApp.Models;

namespace EvoApp.Interfaces
{
	public interface ILive
	{
		public LiveState State { get; init; }
		public void Grow()
		{
			State.Age++;
		}
    }
}
