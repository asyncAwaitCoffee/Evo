using EvoApp.Hubs;
using EvoApp.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;

namespace EvoApp.Services
{
	public class LifeTime
	{
		private PeriodicTimer _timer;
		private IHubContext<LandHub> _landHubContext;
		private ConcurrentBag<ILive> _lives = [];
		public LifeTime(IHubContext<LandHub> landHubContext) {
			_timer = new PeriodicTimer(TimeSpan.FromSeconds(1));
			_landHubContext = landHubContext;
			Start();
		}

		public void AddToLiving(ILive live)
		{
			_lives.Add(live);
		}

		private async void Start()
		{
            while (await _timer.WaitForNextTickAsync())
            {
                foreach (var live in _lives)
                {
					live.Grow();
					_landHubContext.Clients.All.SendAsync("Grow", live);
				}
            }
        }
	}
}
