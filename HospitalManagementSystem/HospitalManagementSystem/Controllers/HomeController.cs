using HospitalManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using System.Diagnostics;

namespace HospitalManagementSystem.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly UserManager<IdentityApplicationUser> userManager;

        public HomeController(ILogger<HomeController> logger)
        {
            //UserManager<IdentityApplicationUser> userManager
            _logger = logger;
            //this.userManager = userManager;
        }

        public IActionResult Index()
        {
            //ViewData["UserID"]=userManager.GetUserId(this.User);
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Hospitals()
        {
            return View();
        }

        public ActionResult Appointment()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public IActionResult Privacy()
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
