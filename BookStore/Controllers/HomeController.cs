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
        public IActionResult Index(string bookCategory, int pgNum)
        {
            int pgSize = 10;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .Where(b => b.Category == bookCategory || bookCategory == null)
                .OrderBy(b => b.Title)
                .Skip((pgNum - 1) * pgSize)
                .Take(pgSize),

                PageInfo = new PageInfo
                {
                    TotalBooks = (bookCategory == null 
                    ? repo.Books.Count() 
                    : repo.Books.Where(x => x.Category == bookCategory).Count()),
                    BooksPerPg = pgSize,
                    CurrentPg = pgNum
                }

            };

            
            return View(x);
        }
    }
}
