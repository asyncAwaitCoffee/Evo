using EvoApp.DTOs;
using EvoApp.Models;

namespace EvoApp.Services
{
	public class EvolveSchemas
	{
		public Func<LivingSpecie, object?> Aged(int age)
		{
			return (LivingSpecie worldObject) => {
				if (worldObject.LiveState.Age >= age)
				{
					worldObject.EvolveState.Prefix = "Aged";
					worldObject.EvolveState.Evolved = true;
					return new { worldObject.FullName };
				}
				return null;
			};
		}
		public Func<LivingSpecie, object?> Eternity(int age)
		{
			return (LivingSpecie worldObject) => {
				if (worldObject.LiveState.Age >= age)
				{
					worldObject.EvolveState.Postfix = "of Eternity";
					worldObject.EvolveState.Evolved = true;
					return new { worldObject.FullName };
				}
				return null;
			};
		}
	}
}
