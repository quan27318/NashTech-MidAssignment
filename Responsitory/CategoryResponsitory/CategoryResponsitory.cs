using BackEnd.Models;

namespace BackEnd.Responsitory{
    public class CategoryResponsitory : ICategoryResponsitory
    {
        private readonly LibraryDbContext _dbContext;
        public CategoryResponsitory(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            var category = _dbContext.Categories.Where(c => c.CategoryId == id).FirstOrDefault();
            _dbContext.Categories.Remove(category);
            _dbContext.SaveChanges();

        }

        public List<Category> GetListCategory()
        {
            return _dbContext.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            var categoryUpdate = _dbContext.Categories.Where(c => c.CategoryId == category.CategoryId).FirstOrDefault();
            categoryUpdate.CategoryId = category.CategoryId;
            categoryUpdate.CategoryName = category.CategoryName;
            _dbContext.SaveChanges();
        }
    }
}