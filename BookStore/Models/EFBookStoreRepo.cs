using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class EFBookStoreRepo : IBookStoreRepo
    {
        private BookstoreContext _book { get; set; }

        public EFBookStoreRepo(BookstoreContext temp) => _book = temp;
        public IQueryable<Book> Books => _book.Books;
    }
}
