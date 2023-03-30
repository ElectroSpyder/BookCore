using Core.BookSolution.Model;

namespace Core.BookSolution.Repository
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetBooks();
        IEnumerable<Book> GetBooksByCurrentYear();
    }
}
