using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2_Group4.Models
{
    public class blah : Controller
    {
        public blahContext(DbContextOptions<blahContext> options) : base(options)
        {

        }
        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public IActionResult Index()
        {
            return View();
        }
    }
}
