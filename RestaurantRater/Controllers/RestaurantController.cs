using RestaurantRater.Models;
using System.Linq;
using System.Web.Mvc;

namespace RestaurantRater.Controllers
{
    public class RestaurantController : Controller
    {

        // GET: Restaurants
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Spaghetti()
        {
            return View();
        }
    }
}