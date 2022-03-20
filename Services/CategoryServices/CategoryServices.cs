using BackEnd.Models;
using BackEnd.Responsitory;

namespace BackEnd.Services{
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategoryResponsitory _iCategoryResponsitory;
        public CategoryServices(ICategoryResponsitory icategoryResponsitory)
        {
            _iCategoryResponsitory = icategoryResponsitory;
        }
        public void AddCategory(Category category)
        {
            _iCategoryResponsitory.CreateCategory(category);
        }

        public void DeleteCategory(int id)
        {
            _iCategoryResponsitory.DeleteCategory(id);
        }

        public List<Category> GetListCategory()
        {
            return _iCategoryResponsitory.GetListCategory();
        }

        public void UpdateCategory(Category category)
        {
            _iCategoryResponsitory.UpdateCategory(category);
        }
    }
}