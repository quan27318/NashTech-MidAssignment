using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BackEnd.Models;
using BackEnd.Services;
using System.Net;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServices _categoryServices;
        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        [HttpGet("getListCategory")]
        public List<Category> GetListCategory(){
            return _categoryServices.GetListCategory();
        }    
        [HttpPost("createCategory")] 
        public HttpStatusCode AddCategory(Category category)  {
            _categoryServices.AddCategory(category);
            return HttpStatusCode.OK;
        }
        [HttpPut("updateCategory")]
        public HttpStatusCode UpdateCategory(Category category){
            _categoryServices.UpdateCategory(category);
            return HttpStatusCode.OK;
        }
        [HttpDelete("deleteCategory")]
        public HttpStatusCode DeleteCategory(int id){
            _categoryServices.DeleteCategory(id);
            return HttpStatusCode.OK;
        }
    }
}