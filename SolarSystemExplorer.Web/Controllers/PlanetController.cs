using Microsoft.AspNetCore.Mvc;
using SolarSystemExplorer.Core.Repositories;
using SolarSystemExplorer.Web.Models;

namespace SolarSystemExplorer.Web.Controllers
{
    /// <summary>
    /// Controller for handling requests related to planets.
    /// </summary>
    public class PlanetController : Controller
    {
        // Repository for accessing planet data.
        private readonly PlanetRepository planetRepository = new PlanetRepository();

        /// <summary>
        /// Displays a list of all planets.
        /// </summary>
        /// <returns>A view displaying all planets.</returns>
        public IActionResult Index()
        {
            // Retrieve all planets and map them to view models.
            var planets = planetRepository.GetAllPlanets()
                .Select(planet => new PlanetViewModel
                {
                    Id = planet.Id,
                    Name = planet.Name
                });
            return View(planets);
        }

        /// <summary>
        /// Displays details of a specific planet.
        /// </summary>
        /// <param name="id">The ID of the planet to display.</param>
        /// <returns>A view displaying the planet details.</returns>
        public IActionResult Details(int id)
        {

            // Retrieve the planet by its ID.
            var planet = planetRepository.GetPlanetById(id);
            if (planet == null)
            {
                return NotFound();
            }

            // Map the planet to a view model.
            var viewModel = new PlanetViewModel
            {
                Id = planet.Id,
                Name = planet.Name,
                Type = planet.Type,
                DistanceFromSun = planet.DistanceFromSun,
                ImageUrl = planet.ImageUrl
            };
            return View(viewModel);
        }
    }
}
