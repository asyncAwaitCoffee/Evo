using System.Text.Json.Serialization;

namespace EvoApp.Models
{
	public class LiveState
	{
        private int _age;
        public int Age {
            get { return _age; }
            set {
                _age = value;
            }
        }
    }
}
