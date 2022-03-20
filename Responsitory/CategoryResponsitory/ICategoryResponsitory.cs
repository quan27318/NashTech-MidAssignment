using BackEnd.Models;

namespace BackEnd.Responsitory{
    public interface ICategoryResponsitory{
        public List<Category> GetListCategory();
        public void CreateCategory(Category category);
        public void UpdateCategory(Category category);
        public void DeleteCategory(int id);
    }
}