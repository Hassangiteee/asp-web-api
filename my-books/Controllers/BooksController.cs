using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Models;
using my_books.Data.Models.Services;
using my_books.Data.ViewModels;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BookService _booksService;
        public BooksController(BookService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet("get-all-books")]

        public IActionResult GetAllBooks()
        {
            var allBooks = _booksService.GetAllBooks();
            return Ok(allBooks);
        }

        [HttpGet("get-book/{id}")]

        public IActionResult GetBookById(int id)
        {
            var book = _booksService.GetBookById(id);
            return Ok(book);
        }




        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVm book)
        {
            _booksService.AddBook(book);
            return Ok();
        }
    }
}
