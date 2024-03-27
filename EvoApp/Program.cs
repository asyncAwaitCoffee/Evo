using EvoApp.Environment;
using EvoApp.Environment.Plants;
using EvoApp.Environment.Plants.Models;
using EvoApp.Hubs;
using EvoApp.Models;
using EvoApp.Repositories;
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
			builder.Services.AddSingleton<LifeTime>();
			builder.Services.AddSingleton<EvolveShemas>();
			builder.Services.AddSingleton<IWorldItemsRepo, WorldItemsRepo>();
			builder.Services.AddKeyedSingleton<PlantFactoryBase, GrasslandPlantFactory>("Grassland");
			builder.Services.AddKeyedSingleton<PlantFactoryBase, WaterPlantFactory>("Water");
			builder.Services.AddKeyedSingleton<PlantFactoryBase, MudPlantFactory>("Mud");
			builder.Services.AddSingleton<WorldObjectFactory>();

			var app = builder.Build();

            app.UseStaticFiles();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}"
				);

#if DEBUG
			app.MapGet("api/test", () =>
			{
				return Results.Json(new { data = "some info" });
			});

			app.MapGet("cat/{n}", (int n) =>
			{
				int x = n * 100 + 5;
				return Results.Json(new { catName = "Kosha", foodLimit = "Unlimited", result = x });
			});
#endif
			app.MapHub<LandHub>("/land");

			app.Run();
		}
	}
}
