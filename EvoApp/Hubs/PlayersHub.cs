using EvoApp.Services;
using Microsoft.AspNetCore.SignalR;

namespace EvoApp.Hubs
{
	public class PlayersHub : Hub
	{
		private readonly PlayersService _players;

		public PlayersHub(PlayersService players)
		{
			_players = players;
		}

		public void GetPlayer(int id)
		{
			if (_players.Players.TryGetValue(id, out var player))
			{
				Clients.Caller.SendAsync("Player", player);
			}
		}
	}
}
