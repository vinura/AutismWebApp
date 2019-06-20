using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult TestAutism(AutismProfile tempUser)
        {
            var data = new ProfileData(tempUser);

            var model = new Services.PredictService().PredAutism(data).Result;

            ViewBag.Autism = model.Label;

            return View();
        
        }

        public ActionResult PatialTestAutism(AutismProfile tempUser)
        {
            var data = new ProfileData(tempUser);

            var model = new Services.PredictService().PredAutism(data).Result;
            return View(model);

        }
        public IActionResult Index()
        {

            return View();

        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
