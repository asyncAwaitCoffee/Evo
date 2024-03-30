namespace EvoApp.Models
{
	public class EvolveState
	{
		public bool Evolved { get; set; } = false;
		public string Prefix { get; set; } = "";
		public string Postfix { get; set; } = "";
		public List<Func<LivingSpecie, object?>> EvolveSchemas { get; set; } = [];
		public object? TryEvolve(LivingSpecie worldObject)
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
