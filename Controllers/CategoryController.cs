using ecommerce_web_api.Models;
using ecommerce_web_api.Services.Categories;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        //return all categories
        [HttpGet]
        public ActionResult<List<Category>> GetAllCategories()
        {
            var data = _categoryService.GetCategories();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public ActionResult<List<Category>> GetAllCategoriesbyid(int id)
        {
            var data = _categoryService.GetCategoryById(id);
            if (data == null)
                return NotFound("no category found with Id:" + id);
            return Ok(data);
        }

        //add category
        [HttpPost]
        public ActionResult<Category> PostCategory([FromBody] Category category)
        {
            var data = _categoryService.AddCategory(category);
            if (data == null)
                return BadRequest();
            return Created("", data);
        }

        //update category
        [HttpPut("{id}")]
        public ActionResult<Category> PutCategory(int id, [FromBody] Category category)
        {
            var data = _categoryService.GetCategoryById(id);
            if (data == null)
                return NotFound("no category found with Id:" + id);
            var response=_categoryService.UpdateCategory(id, category); 
            return Ok(response);    
        }

        //delete Category
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteCategory(int id)
        {
            var data=_categoryService.GetCategoryById(id);
            if (data==null)
                return NotFound("Not category found with id:"+id);
            _categoryService.DeleteCategory(id);    
            return Ok("category deleted");
        }

       
    }
}
