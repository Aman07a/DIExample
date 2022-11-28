using Microsoft.AspNetCore.Mvc;
using Services;
using ServiceContracts;

namespace DIExample.Controllers
{
	public class HomeController : Controller
	{
		private readonly ICitiesService _citiesService;

		// Constructor
		public HomeController()
		{
			// Create  object of CitiesService class
			// new CitiesService();
			_citiesService = null;
		}

		[Route("/")]
		public IActionResult Index()
		{
			List<string> cities = _citiesService.GetCities();
			return View(cities);
		}
	}
}
