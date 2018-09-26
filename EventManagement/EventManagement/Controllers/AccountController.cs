using System.Web.Mvc;

namespace EventManagement.Controllers
{
    using EventManagement.Models.DTO;

    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult LogIn()
        {
            return View(new UserView());
        }

        [HttpPost]
        public ActionResult LogIn(UserView userView)
        {
            string username = userView.username;
            string password = userView.password;
            return View();
        }
    }
}