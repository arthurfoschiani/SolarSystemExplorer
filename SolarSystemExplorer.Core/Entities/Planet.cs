using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystemExplorer.Core.Entities
{
    /// <summary>
    /// Represents a planet in the solar system.
    /// </summary>
    public class Planet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public double DistanceFromSun { get; set; }
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Returns a string representation of the planet.
        /// </summary>
        /// <returns>A string representing the planet.</returns>
        public override string ToString()
        {
            return $"{Name} - {Type}, {DistanceFromSun} million kilometers from the Sun";
        }
    }
}
