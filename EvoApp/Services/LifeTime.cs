using EvoApp.Interfaces;

namespace EvoApp.Services
{
	public class LifeTime
	{
		private PeriodicTimer _timer;
		private List<ILive> _lives = [];
		public LifeTime() {
			_timer = new PeriodicTimer(TimeSpan.FromSeconds(5));
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
                }
            }
        }
	}
}
