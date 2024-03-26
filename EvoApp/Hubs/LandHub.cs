using EvoApp.Models;
using EvoApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace EvoApp.Hubs
{
	public class LandHub : Hub
	{
		public void PlaceItem([FromServices] LandMap land, int itemId, int landX, int landY, int tileX, int tileY)
		{
            Console.WriteLine((itemId, landX, landY, tileX, tileY));
			LandTile landTile = land.GetLandTile(landX, landY);
			landTile.PlaceItem(new Tree("Oak", tileX, tileY), tileX, tileY);
			Clients.All.SendAsync("PlacedItem", new { itemId, landX, landY, tileX, tileY });
        }
	}
}
