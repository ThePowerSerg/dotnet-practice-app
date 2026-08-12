using MessagingAPI.Models;
using MessagingAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MessagingAPI.Contollers
{
    [ApiController]
    [Route("api/[controller]")]  // http://localhost:5232/api/books
    public class BooksController(IBookService bookService) : ControllerBase
    {
        // GET api/books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            var items = bookService.GetBooks();
            return Ok(items);
        }

        // GET api/books/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(Guid id)
        {
            var item = bookService.GetBookById(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // POST api/books
        [HttpPost]
        public ActionResult Post([FromBody] Book value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = bookService.AddBook(value);
            return CreatedAtAction("Get", new { id = item.Id }, item);
        }

        // DELETE api/books/5
        [HttpDelete("{id}")]
        public ActionResult Remove(Guid id)
        {
            var existingItem = bookService.GetBookById(id);

            if (existingItem == null)
            {
                return NotFound();
            }

            bookService.RemoveBook(id);
            return Ok();
        }
    }
}