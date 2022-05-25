using System.Web.Mvc;
using WAD2_Website.Models;

namespace WAD2_Website.Controllers
{
    public class Week2Controller : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.UserId = model.UserId;
                ViewBag.FirstName = model.UserFirstName;
                ViewBag.LastName = model.UserLastName;
                ViewBag.Password = model.Password;

            }
            
            return View(model);

        }
    }
}