using Microsoft.AspNetCore.Mvc;

namespace INFASS_BAS.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password, bool rememberMe)
        {
            // Add your authentication logic here
            if (username == "admin" && password == "password")
            {
                return RedirectToAction("Index", "Home");
            }

            // Return view with error if authentication fails
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View();
        }
    }
}
