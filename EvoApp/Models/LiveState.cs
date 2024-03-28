using EvoApp.Interfaces;
using System.Text.Json.Serialization;

namespace EvoApp.Models
{
	public class LiveState
	{
        private int _age;
        [JsonIgnore]
        public Func<LiveState, string?, bool>? EvolveSchema { get; set; }
        public int Age {
            get { return _age; }
            set {
                _age = value;
            }
        }
        public bool Evolved { get; private set; } = false;
        public string Prefix { get; set; } = "";
        public bool TryEvolve()
        {
            if (EvolveSchema is null)
            {
                return false;
            }

            if (EvolveSchema(this, null))
            {
                Evolved = true;
            }

            return Evolved;
        }
    }
}
