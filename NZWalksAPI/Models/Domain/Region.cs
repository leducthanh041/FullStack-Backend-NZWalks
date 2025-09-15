namespace NZWalksAPI.Models.Domain;

public class Region
{
    public Guid Id { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    // With the "?" the value can be null
    public string? RegionImageUrl { get; set; }
}
