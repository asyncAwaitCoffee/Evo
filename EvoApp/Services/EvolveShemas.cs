using EvoApp.Models;

namespace EvoApp.Services
{
	public class EvolveShemas
	{
		public Predicate<LiveState> Age(int age)
		{
			return (LiveState liveState) => { return liveState.Age > age; };
		}
	}
}
