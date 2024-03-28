namespace EvoApp.Models
{
	public class EvolveState
	{
		public bool Evolved { get; set; } = false;
		public string Prefix { get; set; } = "";
		public Func<WorldObject, object?>? EvolveSchema { get; set; }
		public object? TryEvolve(WorldObject worldObject)
		{
			if (EvolveSchema is not null)
			{
				var result = EvolveSchema(worldObject);

				if (Evolved)
				{
					worldObject.EvolveState.EvolveSchema = null;
				}

				return result;
			}
			return null;
		}
	}
}
