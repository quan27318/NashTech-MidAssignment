using BackEnd.Models;

namespace BackEnd.Services
{
    public interface ICategoryServices
    {
     public List<Category> GetListCategory();   
     public void AddCategory(Category category);
     public void UpdateCategory(Category category);
     public void DeleteCategory(int id);
    }
}