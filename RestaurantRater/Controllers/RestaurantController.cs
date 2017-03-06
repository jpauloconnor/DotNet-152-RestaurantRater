using RestaurantRater.Models;
using System.Linq;
using System.Web.Mvc;

namespace RestaurantRater.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDBContext db = new RestaurantDBContext();

        // GET: Restaurants
        public ActionResult Index()
        {
            return View(db.Restaurants.ToList());
        }
    }
}