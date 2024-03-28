using System.Text.Json.Serialization;

namespace EvoApp.Models
{
	public class EvolveState
	{
		public bool Evolved { get; set; } = false;
		public string Prefix { get; set; } = "";
		[JsonIgnore]
		public Func<WorldObject, string?, object?>? EvolveSchema { get; set; }
		public object? TryEvolve(WorldObject worldObject)
		{
			if (EvolveSchema is not null)
			{
				return EvolveSchema(worldObject, null);
			}
			return null;
		}
	}
}
