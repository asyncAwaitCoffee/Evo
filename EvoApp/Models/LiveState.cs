using EvoApp.Interfaces;

namespace EvoApp.Models
{
	public class LiveState
	{
        private int _age;
        private readonly int _ageThreshold;
        public LiveState(int ageThreshold)
        {
			_ageThreshold = ageThreshold;
		}
        public int Age {
            get { return _age; }
            set {
                _age = value;
                if (Age >= _ageThreshold)
                {
                    Evolved = true;
					Console.WriteLine("Evolve!");
                }
            }
        }
        public bool Evolved { get; private set; }
    }
}
