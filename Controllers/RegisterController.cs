using INFASS_BAS.Models;
using Microsoft.AspNetCore.Mvc;


namespace INFASS_BAS.Controllers
{
    public class RegisterController : Controller
    {
		User user = new User();

		[HttpGet]
        public IActionResult Register()
        {
            return View();
        }

		[HttpPost]
		public IActionResult SubmitRegistration([FromBody] User userData)
		{
			if (userData == null)
			{
				return BadRequest("No data received.");
			}

			System.Diagnostics.Debug.WriteLine("================ USER SIGN UP DATA ================");
			System.Diagnostics.Debug.WriteLine($"Fullname:  {userData.FirstName} {userData.LastName}");
			System.Diagnostics.Debug.WriteLine($"Username:  {userData.Username}");
			System.Diagnostics.Debug.WriteLine($"Password:  {userData.Password}");
			System.Diagnostics.Debug.WriteLine("===================================================");

			string message = $"Successfully received registration for: \n" +
				$"\n" +
				$"Fullname: {userData.FirstName} {userData.LastName} \n" +
				$"Username: {userData.Username} \n" +
				$"Password: {userData.Password} \n" +
				$"Confirm Password: {userData.ConfirmPassword}";

			return Json(message);
		}
	}
}
