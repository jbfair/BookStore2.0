using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project2_Group4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project2_Group4.Controllers
{
    public class HomeController : Controller
    {
        private blahContext DbContext { get; set; }

        //private TaskDatabaseContext _TaskContext { get; set; }
        //public HomeController(TaskDatabaseContext x)
        //{
        //    _TaskContext = x;
        //}

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = daContext.Categories.ToList();
            var form = daContext.Responses.Single(x => x.MovieID == movieid);
            return View("MovieForm", form);
        }
        [HttpPost]
        public IActionResult Edit(ApplicationResponse response)
        {
            daContext.Update(response);
            daContext.SaveChanges();
            return RedirectToAction("Display");
        }
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var form = daContext.Responses.Single(x => x.MovieID == movieid);
            //ViewBag.Categories = daContext.Categories.ToList();
            return View(form);
        }
        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            daContext.Responses.Remove(ar);
            daContext.SaveChanges();
            return RedirectToAction("Display");
        }
    }
}
