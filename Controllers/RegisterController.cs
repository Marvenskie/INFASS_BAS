using Microsoft.AspNetCore.Mvc;

namespace INFASS_BAS.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string firstName, string lastName, string email, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                ModelState.AddModelError(string.Empty, "Passwords do not match.");
                return View();
            }

            // Add your database saving / registration logic here (e.g., ASP.NET Core Identity)

            // Redirect to login page upon successful signup
            return RedirectToAction("Login", "Account");
        }
    }
}
