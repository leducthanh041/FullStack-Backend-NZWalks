namespace NZWalksAPI.Models.DTO
{
    public class RegionDto
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        // With the "?" the value can be null
        public string? RegionImageUrl { get; set; }
    }
}
