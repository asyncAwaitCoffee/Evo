using EvoApp.Hubs;
using EvoApp.Models;
using EvoApp.Services;

namespace EvoApp
{
    public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllersWithViews();
			builder.Services.AddSignalR();
			builder.Services.AddSingleton<LandMap>();

			var app = builder.Build();

            app.UseStaticFiles();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}"
				);

			app.MapGet("api/land", (LandMap landMap) =>
			{
                foreach (var tile in landMap.LandTiles)
                {
					foreach (WorldObject? grid in tile.TileGrid)
                    {
						Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Colored name: {grid?.Name}");
					}
					Console.ResetColor();
					Console.WriteLine(tile.TileGrid[0,0]?.Name ?? "None");
					Console.WriteLine(tile.TileGrid[0,1]?.Name ?? "None");
					Console.WriteLine(tile.TileGrid[0,2]?.Name ?? "None");
					
                }
			});

			app.MapHub<LandHub>("/land");

			app.Run();
		}
	}
}
