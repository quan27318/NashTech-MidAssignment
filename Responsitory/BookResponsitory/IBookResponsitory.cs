using BackEnd.Models;

namespace BackEnd.Responsitory{
    public interface IBookResponsitory{
        public List<Book> GetBooks();
        public void CreateBook(Book book);
        public void DeleteBook(int id);
        public void UpdateBook(Book book);
    }
}