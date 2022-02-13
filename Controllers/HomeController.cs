using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotesApp.Models;
using System.Diagnostics;
using System.Linq;

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
            
        }
    }
}
