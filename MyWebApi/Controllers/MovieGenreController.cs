using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    [Route("MovieGenre")]
    public class MovieGenreController : Controller
    {
        // GET: MovieGenreController
        public ActionResult Index()
        {
            return View();
        }

    }
}
