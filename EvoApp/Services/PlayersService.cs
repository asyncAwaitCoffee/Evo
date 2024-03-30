using EvoApp.Player;

namespace EvoApp.Services
{
	public class PlayersService
	{
		public Dictionary<int, PlayerEntity> Players { get; set; } = new() {
			{ 1, new() },
		};
	}
}
