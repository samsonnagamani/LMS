using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.Data;
using LMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS.Controllers
{
    public class LibraryController : Controller
    {
        
        private readonly IBookRepository _bookRepository;
        private readonly LibraryContext _context;

        public LibraryController(IBookRepository bookRepository, LibraryContext context)
        {
            _bookRepository = bookRepository;
            _context = context;
        }
        
        public IActionResult Index()
        {
            
            var books = _bookRepository.GetAllBooks();

            return View(books);
        }

        public IActionResult Info(int id)
        {
            var book = _bookRepository.GetBookById(id);
            return View(book);
        }

        public IActionResult SwitchStatus(int? id) 
        { 
            
            _bookRepository.SwitchStatus(id);

            return Redirect("/Library/Info/" + id);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BookModel book)
        {
            _bookRepository.Add(book);
            return Redirect("/Library");
        }

        public IActionResult ListView()
        {
            IEnumerable<BookModel> books = _bookRepository.GetAllBooks();
            return View(books);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {

            _bookRepository.DeleteById(id);
            return Redirect("/Library/ListView");
        }

        public IActionResult Edit(int id)
        {
            BookModel book = _bookRepository.GetBookById(id);
            
            return View(book);
        }
        
        [HttpPost]
        public IActionResult Edit(BookModel bookChanges)
        {
            _bookRepository.Update(bookChanges);
            return Redirect("/Library/ListView");
        }
    }
}