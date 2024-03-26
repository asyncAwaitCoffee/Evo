using EvoApp.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EvoApp.Models
{
	public class Tree(string name, int landX, int landY, int tyleX, int tyleY)
		: WorldObject(name, landX, landY, tyleX, tyleY), ILive
	{
		public int Age { get; set; }

		public void Grow()
		{
			Age++;
        }
	}
}
