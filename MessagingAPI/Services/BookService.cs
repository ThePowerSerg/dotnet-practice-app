using MessagingAPI.Data;
using MessagingAPI.Models;

namespace MessagingAPI.Services
{
    public class BookService(MessagingApiContext context) : IBookService
    {
        public IEnumerable<Book> GetBooks()
        {
            return context.Books.ToList();
        }

        public Book AddBook(Book newBook)
        {
            context.Books.Add(newBook);
            return newBook;
        }

        public Book? GetBookById(Guid id)
        {
            var book = context.Books.FirstOrDefault(a => a.Id == id);
            return book;
        }

        public void RemoveBook(Guid id)
        {
            var existing = context.Books.First(a => a.Id == id);
            context.Books.Remove(existing);
        }
    }
}