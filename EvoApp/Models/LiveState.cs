using EvoApp.Interfaces;
using System.Text.Json.Serialization;

namespace EvoApp.Models
{
	public class LiveState
	{
        private int _age;
        [JsonIgnore]
        public Predicate<LiveState> TryEvolve { get; set; }
        public int Age {
            get { return _age; }
            set {
                _age = value;
                if (TryEvolve(this))
                {
                    Evolved = true;
					Console.WriteLine("Evolve!");
                }
            }
        }
        public bool Evolved { get; private set; }
    }
}
