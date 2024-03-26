using EvoApp.Hubs;
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

			var app = builder.Build();

            app.UseStaticFiles();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}"
				);

#if DEBUG
			app.MapGet("api/test", (LandMap landMap) =>
			{
                
			});
#endif
			app.MapHub<LandHub>("/land");

			app.Run();
		}
	}
}
