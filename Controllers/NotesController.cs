using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotesApp.Models;
using System.Diagnostics;

namespace NotesWebApp.Controllers
{
    public class NotesController : Controller
    {
        private readonly ILogger<NotesController> _logger;
        public NotesController(ILogger<NotesController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
