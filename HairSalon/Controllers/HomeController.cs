using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Models
{
    public class HomeController: Controller
    {
        [HttpGet("/")]

        public ActionResult Index()
        {
            return View();
        }
    }
}