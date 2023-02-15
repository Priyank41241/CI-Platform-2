using Microsoft.AspNetCore.Mvc;

namespace CI_Platform.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult LoginPage()
        {
            return View();
        }

        public IActionResult ForgotPass()
        {
            return View();
        }

        public IActionResult ResetPass()
        { return View(); }

        public IActionResult Registration()
        { return View(); }
    }
}
