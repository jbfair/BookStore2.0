using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalBooks { get; set; }
        public int BooksPerPg { get; set; }

        public int CurrentPg { get; set; }

        public int TotalPages => (int) Math.Ceiling((double) TotalBooks / BooksPerPg);
    }
}
