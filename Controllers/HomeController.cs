using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotesApp.Models;
using System.Diagnostics;
using System.Linq;
using System;

namespace NotesApp.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            NotesAppContext context = HttpContext.RequestServices.GetService(typeof(NotesApp.Models.NotesAppContext)) as NotesAppContext;

            return View(context.GetAllUsers());
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CreateAccount()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult ValidateLogin()
        {
            NotesAppContext context = HttpContext.RequestServices.GetService(typeof(NotesApp.Models.NotesAppContext)) as NotesAppContext;

            var users = context.GetAllUsers();
            var email = HttpContext.Request.Form.ElementAt(0).Value.ToString();
            var password = HttpContext.Request.Form.ElementAt(1).Value.ToString();

            foreach (var user in users)
            {
                if (user.email == email)
                {
                    if (user.password == password)
                    {
                        return Json(new { status = true, message = "Login Successfull!" });
                    }
                    else
                    {
                        return Json(new { status = false, message = "Invalid Password!" });
                    }
                }
            }
            return Json(new { status = false, message = "Invalid User!" });
        }

        public ActionResult ValidateNewUser()
        {
            NotesAppContext context = HttpContext.RequestServices.GetService(typeof(NotesApp.Models.NotesAppContext)) as NotesAppContext;
            
            var users = context.GetAllUsers();
            var name = HttpContext.Request.Form.ElementAt(0).Value.ToString();
            DateTime dob = DateTime.ParseExact(HttpContext.Request.Form.ElementAt(1).Value.ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            Console.Write(dob);
            var email = HttpContext.Request.Form.ElementAt(2).Value.ToString();
            var username = HttpContext.Request.Form.ElementAt(3).Value.ToString();
            var password = HttpContext.Request.Form.ElementAt(4).Value.ToString();
            var confirmpw = HttpContext.Request.Form.ElementAt(5).Value.ToString();

            foreach (var user in users)
            {
                if (password != confirmpw)
                {
                    return Json(new { status = false, message = "The passwords entered do not match!" });
                }
                if (user.username == username)
                {
                    if (user.password == password)
                    {
                        return Json(new { status = false, message = "Account already exists!" });
                    }
                }
                else
                {
                    return Json(new { status = false, message = "Username is not unique!" });
                }
            }
            context.saveNewUser(name, dob, email, username, password);
            Console.WriteLine("success!");
            return Json(new { status = true, message = "Account creation successful!" });
        }
    }
}
