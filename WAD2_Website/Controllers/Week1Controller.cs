using System.Web.Mvc;
using WAD2_Website.Models;


namespace WAD2_Website.Controllers
{
    public class Week1Controller : Controller
    {
        // GET
        public ActionResult Index()
        {
            var m = new UserModel
            {
                UserId = 1,
                UserFirstName = "Corey",
                UserLastName = "Adams",
                Password = "password123"
            };
            return View(m);
        }
    }
}