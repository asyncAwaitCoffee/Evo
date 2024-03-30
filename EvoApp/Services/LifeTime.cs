using EvoApp.DTOs;
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
		private ConcurrentDictionary<LivingSpecie, bool> _lives = [];

		public LifeTime(IHubContext<LandHub> landHubContext) {
			_timer = new PeriodicTimer(TimeSpan.FromMilliseconds(500));
			_landHubContext = landHubContext;
			Start();
		}

		public void AddToLiving(LivingSpecie live, bool evolved = false)
		{
			_lives.TryAdd(live, evolved);
		}

		public void RemoveFromLiving(LivingSpecie live)
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
					var advanceData = live.Key.AdvanceInTime();
					await _landHubContext.Clients.All.SendAsync("Evolve", advanceData);

					//await _landHubContext.Clients.All.SendAsync("Grow", live.Key);
				}
            }
        }
	}
}
