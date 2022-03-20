using BackEnd.Models;

namespace BackEnd.Responsitory{
    public class BookResponsitory : IBookResponsitory
    { 
        private readonly LibraryDbContext _dbContext;
        public BookResponsitory(LibraryDbContext dbContext)
        {
         _dbContext = dbContext;   
        }
        
        public void CreateBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _dbContext.Books.Where(x => x.BookId == id).FirstOrDefault();
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }

        public List<Book> GetBooks()
        {
            return _dbContext.Books.ToList();
        }

        public void UpdateBook(Book book)
        {
            var bookUpdate = _dbContext.Books.Where(x => x.BookId == book.BookId).FirstOrDefault();
            bookUpdate.BookId = book.BookId;
            bookUpdate.BookName = book.BookName;
           bookUpdate.BookType= book.BookType;
           bookUpdate.Author = book.Author;
           bookUpdate.CategoryId = book.CategoryId;
           _dbContext.SaveChanges();
        }
    }
}