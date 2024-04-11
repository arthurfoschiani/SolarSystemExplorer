namespace SolarSystemExplorer.Web.Models
{
    /// <summary>
    /// View model representing a planet for display purposes.
    /// </summary>
    public class PlanetViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public double DistanceFromSun { get; set; }
        public string? ImageUrl { get; set; }
    }
}
