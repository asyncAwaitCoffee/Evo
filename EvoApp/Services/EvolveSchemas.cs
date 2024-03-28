using EvoApp.DTOs;
using EvoApp.Models;

namespace EvoApp.Services
{
	public class EvolveSchemas
	{
		public Func<WorldObject, object?> Aged(int age)
		{
			return (WorldObject worldObject) => {
				if (worldObject.LiveState.Age >= age)
				{
					worldObject.EvolveState.Prefix = "Aged";
					worldObject.EvolveState.Evolved = true;
					return new { worldObject.FullName };
				}
				return null;
			};
		}
		public Func<WorldObject, object?> Eternity(int age)
		{
			return (WorldObject worldObject) => {
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
