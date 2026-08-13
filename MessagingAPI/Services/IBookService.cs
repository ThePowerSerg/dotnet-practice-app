using MessagingAPI.Models;

namespace MessagingAPI.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book AddBook(Book book);
        Book? GetBookById(Guid Id);
        void RemoveBook(Guid id);
    }
}