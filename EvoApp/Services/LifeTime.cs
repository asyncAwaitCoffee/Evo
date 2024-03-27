﻿using EvoApp.Hubs;
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
		private ConcurrentDictionary<ILive, LiveState?> _lives = [];
		public LifeTime(IHubContext<LandHub> landHubContext) {
			_timer = new PeriodicTimer(TimeSpan.FromSeconds(1));
			_landHubContext = landHubContext;
			Start();
		}

		public void AddToLiving(ILive live)
		{
			_lives.TryAdd(live, null);
		}

		public LiveState? RemoveFromLiving(ILive live)
		{
			if (_lives.TryRemove(live, out LiveState? liveState))
			{
				return liveState;
			}
			// TODO - return empty LiveState default
			return null;
		}

		private async void Start()
		{
            while (await _timer.WaitForNextTickAsync())
            {
                foreach (var live in _lives)
                {
					live.Key.Grow();
					_landHubContext.Clients.All.SendAsync("Grow", live.Key);
				}
            }
        }
	}
}
