using EvoApp.Hubs;
using EvoApp.Interfaces;
using EvoApp.Models;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;

namespace EvoApp.Services
{
	public class LifeTime
	{
		private PeriodicTimer _timer;
		private IHubContext<LandHub> _landHubContext;
		private ConcurrentDictionary<ILive, bool> _lives = [];

		public LifeTime(IHubContext<LandHub> landHubContext) {
			_timer = new PeriodicTimer(TimeSpan.FromSeconds(1));
			_landHubContext = landHubContext;
			Start();
		}

		public void AddToLiving(ILive live, bool evolved = false)
		{
			_lives.TryAdd(live, evolved);
		}

		public void RemoveFromLiving(ILive live)
		{
			_lives.TryRemove(live, out _);
		}

		private async void Start()
		{
			// TODO - strange things here
            while (await _timer.WaitForNextTickAsync())
            {
                foreach (var live in _lives)
                {
					live.Key.Grow();
					if (!live.Value)
					{
						live.Key.State.TryEvolve();
					}
					_landHubContext.Clients.All.SendAsync("Grow", live.Key);
				}
            }
        }
	}
}
