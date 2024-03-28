using EvoApp.DTOs;
using EvoApp.Models;

namespace EvoApp.Services
{
	public class EvolveSchemas
	{
		public Func<WorldObject, string?, object?> Age(int age)
		{
			return (WorldObject worldObject, string? prefix) => {
				worldObject.EvolveState.Prefix = prefix is null ? "Aged" : prefix;
				if (worldObject.LiveState.Age >= age)
				{
					worldObject.EvolveState.Evolved = true;
					worldObject.EvolveState.EvolveSchema = null;
					return new { worldObject.FullName };
				}
				return null;
			};
		}
	}
}
