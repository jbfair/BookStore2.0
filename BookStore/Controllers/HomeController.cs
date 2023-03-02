using BookStore.Models;
using BookStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private IBookStoreRepo repo;

        public HomeController(IBookStoreRepo temp) => repo = temp;
        public IActionResult Index(int pgNum)
        {
            int pgSize = 10;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .OrderBy(p => p.Title)
                .Skip((pgNum - 1) * pgSize)
                .Take(pgSize),

                PageInfo = new PageInfo
                {
                    TotalBooks = repo.Books.Count(),
                    BooksPerPg = pgSize,
                    CurrentPg = pgNum
                }

            };

            
            return View(x);
        }
    }
}
