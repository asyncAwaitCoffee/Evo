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
    public class LandsHub : Hub
	{
		public void PlacePlant(
			[FromServices] LandService land,
			[FromServices] LifeTime life,
			[FromServices] LivingSpeciesFactory worldObjectFabric,
			[FromServices] EvolveSchemas evolve,
			int tierId,
			int subtypeId,
			int landX, int landY,
			int tileX, int tileY)
		{

			LandTile landTile = land.GetLandTile(landX, landY);
			if (!landTile.CanPlaceItem(tileX, tileY))
			{
				// TODO - send message
				return;
			}
			PlantFactoryBase plantFabric = worldObjectFabric.GetPlantFabric(landTile.LandType);

            Plant plant = plantFabric.Tier(tierId, subtypeId);
			plant.AddEvolveSchema(evolve.Aged(10 * tierId));
			plant.AddEvolveSchema(evolve.Eternity(10 * tierId + 5));

			Coordinates coordinates = new(landX, landY, tileX, tileY);
			plant.Coordinates = coordinates;

            life.AddToLiving(plant);
			landTile.PlaceItem(plant, tileX, tileY);

            Clients.All.SendAsync("PlacedItem", new { name = plant.FullName, landX, landY, tileX, tileY });
        }

		public void GatherPlant(
			[FromServices] LandService land,
			[FromServices] LifeTime life,
			[FromServices] PlayerService players,
			int landX, int landY,
			int tileX, int tileY)
		{
            LandTile landTile = land.GetLandTile(landX, landY);
			var item = landTile.GetItem(tileX, tileY);
			if (item is Plant plant)
			{
				life.RemoveFromLiving(plant);
				landTile.RemoveItem(tileX, tileY);

				var gathered = plant.GatherContent.Gather();
				// TODO - real player id | real gathering
				players.TryScore(1, gathered.Sum());

				Clients.All.SendAsync("GatheredItem", new { gathered, landX, landY, tileX, tileY });
			}
		}
	}
}
