using SolarSystemExplorer.Core.Entities;

namespace SolarSystemExplorer.Core.Repositories
{
    /// <summary>
    /// Repository for accessing planet data.
    /// </summary>
    public class PlanetRepository
    {
        // In-memory list of planets.
        private static readonly List<Planet> planets = new List<Planet>
        {
            new Planet { Id = 1, Name = "Mercury", Type = "Terrestrial", DistanceFromSun = 57.9, ImageUrl = "https://images-assets.nasa.gov/image/PIA11245/PIA11245~small.jpg" },
            new Planet { Id = 2, Name = "Venus", Type = "Terrestrial", DistanceFromSun = 108.2, ImageUrl = "https://images-assets.nasa.gov/image/PIA00252/PIA00252~medium.jpg" },
            new Planet { Id = 3, Name = "Earth", Type = "Terrestrial", DistanceFromSun = 149.6, ImageUrl = "https://images-assets.nasa.gov/image/0202795/0202795~medium.jpg" },
            new Planet { Id = 4, Name = "Mars", Type = "Terrestrial", DistanceFromSun = 227.9, ImageUrl = "https://images-assets.nasa.gov/image/PIA03016/PIA03016~small.jpg" },
            new Planet { Id = 5, Name = "Jupiter", Type = "Gas Giant", DistanceFromSun = 778.5, ImageUrl = "https://images-assets.nasa.gov/image/PIA00343/PIA00343~small.jpg" },
            new Planet { Id = 6, Name = "Saturn", Type = "Gas Giant", DistanceFromSun = 1433.5, ImageUrl = "https://images-assets.nasa.gov/image/PIA02225/PIA02225~small.jpg" },
            new Planet { Id = 7, Name = "Uranus", Type = "Ice Giant", DistanceFromSun = 2872.5, ImageUrl = "https://images-assets.nasa.gov/image/PIA18185/PIA18185~orig.jpg" },
            new Planet { Id = 8, Name = "Neptune", Type = "Ice Giant", DistanceFromSun = 4495.1, ImageUrl = "https://images-assets.nasa.gov/image/PIA01492/PIA01492~medium.jpg" }
        };

        /// <summary>
        /// Retrieves all planets.
        /// </summary>
        /// <returns>A list of all planets.</returns>
        public IEnumerable<Planet> GetAllPlanets()
        {
            return planets;
        }

        /// <summary>
        /// Retrieves a planet by its ID.
        /// </summary>
        /// <param name="id">The ID of the planet to retrieve.</param>
        /// <returns>The planet with the specified ID, or null if not found.</returns>
        public Planet GetPlanetById(int id)
        {
            return planets.Find(planet => planet.Id == id) ?? throw new KeyNotFoundException($"Planet with ID {id} not found.");
        }
    }
}
