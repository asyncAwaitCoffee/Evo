using EvoApp.Enums;

namespace EvoApp.DTOs
{
	public record class PlantDataDTO(string Name, string Info, LandTypes LandType, int Tier, int Subcategory, decimal BasePrice);
}
