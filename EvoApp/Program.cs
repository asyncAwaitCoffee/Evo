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
			builder.Services.AddSingleton<WorldObjectFabric>();
			builder.Services.AddKeyedSingleton<IPlantFactory, GrasslandPlantFactory>("Grassland");
			builder.Services.AddKeyedSingleton<IPlantFactory, WaterPlantFactory>("Water");
			builder.Services.AddKeyedSingleton<IPlantFactory, MudPlantFactory>("Mud");

			var app = builder.Build();

            app.UseStaticFiles();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}"
				);

#if DEBUG
			app.MapGet("api/test", (LandMap landMap) =>
			{
                Plant p = new Herb("", 1);
			});
#endif
			app.MapHub<LandHub>("/land");

			app.Run();
		}
	}
}
