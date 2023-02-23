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
        //private blahContext DbContext { get; set; }

        private TaskDatabaseContext _TaskContext { get; set; }
        public HomeController(TaskDatabaseContext x)
        {
            _TaskContext = x;
        }

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
            ViewBag.Categories = x.Categories.ToList();
            var form = x.Responses.Single(x => x.MovieID == movieid);
            return View("MovieForm", form);
        }
        [HttpPost]
        public IActionResult Edit(TaskModel response)
        {
            x.Update(response);
            x.SaveChanges();
            return RedirectToAction("Display");
        }
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var form = x.Responses.Single(x => x.MovieID == movieid);
            //ViewBag.Categories = daContext.Categories.ToList();
            return View(form);
        }
        [HttpPost]
        public IActionResult Delete(TaskModel ar)
        {
            x.Responses.Remove(ar);
            x.SaveChanges();
            return RedirectToAction("Display");
        }
    }
}
