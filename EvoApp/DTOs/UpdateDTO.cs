using EvoApp.Models;

namespace EvoApp.DTOs
{
	/// <summary>
	/// Contains update packet data
	/// </summary>
	/// <param name="Coordinates">Coordinates of the updated object</param>
	/// <param name="Data">Data that represents updated props</param>
	public record class UpdateDTO(Coordinates Coordinates, object Data);
}
