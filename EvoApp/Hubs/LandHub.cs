﻿using EvoApp.Environment;
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
		public void PlacePlant(
			[FromServices] LandMap land,
			[FromServices] LifeTime life,
			[FromServices] WorldObjectFactory worldObjectFabric,
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
			plant.AddEvolveSchema(evolve.Eternity(11 * tierId));

			Coordinates coordinates = new(landX, landY, tileX, tileY);
			plant.Coordinates = coordinates;

            life.AddToLiving(plant);
			landTile.PlaceItem(plant, tileX, tileY);

            Clients.All.SendAsync("PlacedItem", new { name = plant.FullName, landX, landY, tileX, tileY });
        }
	}
}
