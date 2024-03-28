using EvoApp.Models;

namespace EvoApp.Services
{
	public class EvolveSchemas
	{
		public Func<LiveState, string?, bool> Age(int age)
		{
			return (LiveState liveState, string? prefix) => {
				liveState.Prefix = prefix is null ? "Aged" : prefix;
				return liveState.Age > age;
			};
		}
	}
}
