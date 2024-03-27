using EvoApp.Environment;
using EvoApp.Environment.Plants;
using EvoApp.Environment.Plants.Models;
using EvoApp.Models;
using EvoApp.Repositories;
using EvoApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace EvoApp.Hubs
{
    public class LandHub : Hub
	{
		public void PlaceItem(
			[FromServices] LandMap land,
			[FromServices] LifeTime life,
			[FromServices] WorldObjectFabric worldObjectFabric,
			int itemId,
			int landX,
			int landY,
			int tileX,
			int tileY)
		{
			LandTile landTile = land.GetLandTile(landX, landY);
			IPlantFabric plantFabric = worldObjectFabric.GetPlantFabric(landTile.LandType);

			Plant plant = plantFabric.TierOne(1);

			Coordinates coordinates = new(landX, landY, tileX, tileY);
			plant.Coordinates = coordinates;
            life.AddToLiving(plant);
			landTile.PlaceItem(plant, tileX, tileY);
            Clients.All.SendAsync("PlacedItem", new { itemId, landX, landY, tileX, tileY });
            
			
			
        }
	}
}
