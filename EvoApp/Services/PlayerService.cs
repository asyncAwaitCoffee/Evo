using EvoApp.Hubs;
using EvoApp.Player;
using Microsoft.AspNetCore.SignalR;

namespace EvoApp.Services
{
	public class PlayerService
	{
		IHubContext<PlayersHub> _playersHub;
		public PlayerService(IHubContext<PlayersHub> playersHub)
        {
            _playersHub = playersHub;
        }
        public Dictionary<int, PlayerEntity> Players { get; set; } = new() {
			{ 1, new() },
		};

		public void TryScore(int playerId, decimal score)
		{
			if (Players.TryGetValue(playerId, out PlayerEntity player))
			{
				player.Score += score;
				_playersHub.Clients.All.SendAsync("Score", new { player.Score });
			}
		}
	}
}
