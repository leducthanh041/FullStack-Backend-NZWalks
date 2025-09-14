namespace NZWalksAPI.Models.DTO
{
    public class UpdateRegionRequestDto
    {
        public string Code { get; set; }

        public string Name { get; set; }

        // With the "?" the value can be null
        public string? RegionImageUrl { get; set; }
    }
}
