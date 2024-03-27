using EvoApp.Models;
using System.Collections.Immutable;

namespace EvoApp.Repositories
{
    public class WorldItems
    {
        public ImmutableDictionary<int, string> Trees { get; } = ImmutableDictionary<int, string>.Empty;
		public WorldItems()
        {
            Dictionary<int, string> trees = new()
            {
                { 1, "Oak"},
                { 2, "Birch"},
                { 3, "Maple"},
            };

            Trees = Trees.AddRange(trees);
        }
    }
}
