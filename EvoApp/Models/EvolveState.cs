namespace EvoApp.Models
{
	public class EvolveState
	{
		public bool Evolved { get; set; } = false;
		public string Prefix { get; set; } = "";
		public string Postfix { get; set; } = "";
		public List<Func<WorldObject, object?>> EvolveSchemas { get; set; } = [];
		public object? TryEvolve(WorldObject worldObject)
		{
			foreach (var evolve in EvolveSchemas)
			{
				var result = evolve(worldObject);

				if (result is not null)
				{
					worldObject.EvolveState.EvolveSchemas.Remove(evolve);
				}

				return result;
			}
			return null;
		}
	}
}
