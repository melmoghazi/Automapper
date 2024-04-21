using Automapper.lib.DTOs;
using Automapper.lib.Models;

namespace Automapper.API
{
    public class BookData
    {
        public List<Book> books = new List<Book>() {
        new Book() { BookId = 1, Title = "book 1", Description = "this is book 1", AuthorName = "author 1", Price = 13 },
        new Book() { BookId = 2, Title = "book 2", Description = "this is book 2", AuthorName = "author 2", Price = 5 },
        new Book() { BookId = 3, Title = "book 3", Description = "this is book 3", AuthorName = "author 3", Price = 0 }};

        public List<BookDTO> GetList()
        {
            var booksDTOs = books.Select(b => new BookDTO { Id = b.BookId, Title = b.Title, Summary = b.Description, AuthorName = b.AuthorName, Price = b.Price });
            return booksDTOs.ToList();
        }
    }
}
