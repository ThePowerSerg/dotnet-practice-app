using MessagingAPI.Services;
using MessagingAPI.Contollers;
using Microsoft.AspNetCore.Mvc;
using MessagingAPI.Models;

namespace MessagingTests
{
    public class BookTests
    {
        readonly IBookService bookService;
        readonly BooksController booksController;

        public BookTests()
        {
            bookService = new BookService();
            booksController = new BooksController(bookService);
        }

        [Fact]
        public void GetBooksTest()
        {
            // Arrange - Arrange has been skipped since method does not contain parameters 
            // Act - make the request to the Get endpoint
            var response = booksController.Get();
            // Assert
            // check the response type and make sure its OkObjectResult which is a serialized object
            Assert.IsType<OkObjectResult>(response.Result);
            // check that the result type is a list of books
            var bookList = response.Result as OkObjectResult;
            Assert.IsType<List<Book>>(bookList?.Value);
            // check the list of books contains 5 books
            var bookListCount = bookList.Value as List<Book>;
            Assert.Equal(5, bookListCount?.Count);
        }

        [Theory]
        [InlineData("Evolutionary Psychology", "117366b8-3541-4ac5-8732-860d698e26a2")]
        public void GetBookByIdTest(string expectedValue, Guid id)
        {
            // Arrange
            // Act - make the request to the Get endpoint
            var response = booksController.Get(id);
            // Assert - get the response result and the title 
            var result = response.Result as OkObjectResult;
            var book = result?.Value as Book;
            var title = book?.Title;
            // Assert - check that the book title mathes the expected value (passed title)
            Assert.Equal(expectedValue, title);
        }

        [Fact]
        public void AddBookTest()
        {
            // Arrange
            var newBook = new Book()
            {
                Id = new Guid(),
                Title = "Hacking APIs",
                Author= "Corey Ball",
                Description ="API security overview",
            };

            // Act 
            var response = booksController.Post(newBook);
            var item = response as CreatedAtActionResult;
            var book = item?.Value as Book;

            // Assert
            Assert.IsType<Book>(item?.Value);
            Assert.Equal(newBook.Author, book?.Author);
        
            Assert.IsType<CreatedAtActionResult>(response);
        }
    }
}