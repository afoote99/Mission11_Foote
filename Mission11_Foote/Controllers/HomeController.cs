using Microsoft.AspNetCore.Mvc;
using Mission11_Foote.Models;
using Mission11_Foote.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Foote.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;

        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        //Setting 10 books per page
        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var blah = new BookListModel
            {
                Books = _repo.Books
                    .OrderBy(x => x.Title)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };
            return View(blah);
        }
    }
}
