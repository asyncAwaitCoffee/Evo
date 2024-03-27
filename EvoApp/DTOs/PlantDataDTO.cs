using EvoApp.Enums;

namespace EvoApp.DTOs
{
	public record class PlantDataDTO(string Name, string Info, LandTypes landType, int tier, int subcategory);
}
