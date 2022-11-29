using Microsoft.AspNetCore.Mvc;
using Services;
using ServiceContracts;

namespace DIExample.Controllers
{
	public class HomeController : Controller
	{
		// private readonly ICitiesService _citiesService;

		// // Constructor
		// public HomeController(ICitiesService citiesService)
		// {
		// 	// Create  object of CitiesService class
		// 	// new CitiesService();
		// 	// _citiesService = null;
		// 	_citiesService = citiesService;
		// }

		[Route("/")]
		public IActionResult Index([FromServices]ICitiesService _citiesService)
		{
			List<string> cities = _citiesService.GetCities();
			return View(cities);
		}
	}
}
