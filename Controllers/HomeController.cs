using Microsoft.AspNetCore.Mvc;
using Searching_OMDB_Lab.Models;
using System.Diagnostics;

namespace Searching_OMDB_Lab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MovieSearch()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieSearch(string title)
        {
            return View(OMDB_DAL.SearchMovie(title));
        }
        //[HttpGet]
        //public IActionResult MovieSearchForm() 
        //{
        //    return View(MovieSearch());
        //}
        //[HttpPost]
        //public IActionResult MovieSearchResults(string title)
        //{
        //    OMDB_Model result = OMDB_DAL.SearchMovie(title);
        //    return View(result);
        //}
        public IActionResult MovieNight()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieNight(string title1, string title2, string title3)
        {
            List<OMDB_Model> result = new List<OMDB_Model>();
            result.Add(OMDB_DAL.SearchMovie(title1));
            result.Add(OMDB_DAL.SearchMovie(title2));
            result.Add(OMDB_DAL.SearchMovie(title3));
            return View(result);
        }

        //[HttpGet]
        //public IActionResult MovieNightForm()
        //{
        //    return View();
        //}

        //public IActionResult MovieNightResults()
        //{
        //    return View();
        //}



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}