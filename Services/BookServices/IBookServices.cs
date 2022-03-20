using BackEnd.Models;

namespace BackEnd.Services{
    public interface IBookServices{
        public List<Book> GetBooks();
        public void AddBook(Book book);
        public void DeleteBook(int id);
        public void UpdateBook(Book book);
    }
}