using Microsoft.AspNetCore.Mvc;
using Mission09_meldrumn.Models;
using Mission09_meldrumn.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_meldrumn.Controllers
{
    public class HomeController : Controller
    {
        //private BookstoreContext context { get; set; }

        // Lambda function shortcut to do what is above, works if you dont need to pass stuff (both no longer needed since done in ef repository)
        //public HomeController(BookstoreContext temp) => context = temp;

        private IBookstoreRepository repo;

        public HomeController (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;

            var randomname = new BooksViewModel
            {
                Books = repo.Books
                .OrderBy(p => p.BookId)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(randomname);
        }
    }
}
