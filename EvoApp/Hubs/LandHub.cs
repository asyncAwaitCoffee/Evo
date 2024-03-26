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
			int itemId,
			int landX,
			int landY,
			int tileX,
			int tileY)
		{
			if (WorldItems.Trees.TryGetValue(itemId, out string? treeName))
			{
				LandTile landTile = land.GetLandTile(landX, landY);
                Tree tree = new(treeName, landX, landY, tileX, tileY);
                life.AddToLiving(tree);
                landTile.PlaceItem(tree, tileX, tileY);
                Clients.All.SendAsync("PlacedItem", new { itemId, landX, landY, tileX, tileY });
            }
			
			
        }
	}
}
