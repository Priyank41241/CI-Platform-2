using MainProjectEntity.Data;
using MainProjectEntity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;


namespace CI_Platform.Controllers
{
    public class LoginController : Controller
    {

        private readonly CIPlatformContext _db;

        public LoginController(CIPlatformContext db)
        {
            _db = db;
        }


        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoginPage(User obj)
        {
            if (ModelState.IsValid)
            {

                var Ucount = _db.Users.Where(x => x.Email == obj.Email && x.Password == obj.Password).ToList().Count();

                TempData["NoUser"] = null;
                TempData["UserError"] = null;

                if (Ucount == 1)
                {
                    return RedirectToAction("Index", "Home");
                }

                else if (Ucount == 0)
                {
                    TempData["NoUser"] = "User not found!!!";
                }
                else
                {
                    TempData["UserError"] = "There is some error in Loggin in..";
                }
            }
            return View();

        }

        [HttpGet]
        public IActionResult ForgotPass()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ForgotPassPost()
        {

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            string mail = HttpContext.Request.Form["email_forgot"];

            try
            {
                MailMessage newMail = new MailMessage();
                // use the Gmail SMTP Host
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                // Follow the RFS 5321 Email Standard
                newMail.From = new MailAddress("hashisenjurama85@gmail.com", "Hashirama");

                newMail.To.Add(mail);// declare the email subject

                newMail.Subject = "My First Email"; // use HTML for the email body

                newMail.IsBodyHtml = true; newMail.Body = "<h1> This is my first Templated Email in C# </h1>";

                // enable SSL for encryption across channels
                client.EnableSsl = true;
                // Port 465 for SSL communication
                client.Port = 465;
                // Provide authentication information with Gmail SMTP server to authenticate your sender account
                client.Credentials = new System.Net.NetworkCredential("hashisenjurama85@gmail.com", "Hashirama@85");

                client.Send(newMail); // Send the constructed mail
                Console.WriteLine("Email Sent");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error -" + ex);
                TempData["Exception"] = ex.ToString();
            }
            return RedirectToAction("ForgotPass");
        }


        public IActionResult ResetPass()
        { return View(); }


        public IActionResult Registration()
        { return View(); }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(User obj)
        {
            _db.Users.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
