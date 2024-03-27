using EvoApp.Interfaces;
using System.Text.Json.Serialization;

namespace EvoApp.Models
{
	public class LiveState
	{
        private int _age;
        [JsonIgnore]
        public Predicate<LiveState> EvolveSchema { get; set; }
        public int Age {
            get { return _age; }
            set {
                _age = value;
            }
        }
        public bool Evolved { get; private set; }
        public bool TryEvolve()
        {
            return EvolveSchema is not null && EvolveSchema(this);
        }
    }
}
