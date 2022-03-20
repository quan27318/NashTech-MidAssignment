using BackEnd.Models;
using BackEnd.Responsitory;

namespace BackEnd.Services{
    public class BookServices : IBookServices
    {
        private readonly IBookResponsitory _bookResponsitory;
        public BookServices(IBookResponsitory bookResponsitory)
        {
            _bookResponsitory = bookResponsitory;
        }

        public void AddBook(Book book)
        {
            _bookResponsitory.CreateBook(book);
        }

        public void DeleteBook(int id)
        {
            _bookResponsitory.DeleteBook(id);
        }

        public List<Book> GetBooks()
        {
            return _bookResponsitory.GetBooks();
        }

        public void UpdateBook(Book book)
        {
            _bookResponsitory.UpdateBook(book);
        }
    }
}