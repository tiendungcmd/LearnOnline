using LearnOnline.API.Data;
using LearnOnline.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LearnOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly LearnOnlineDbContext _learnOnlineDb;

        public CategoryController(LearnOnlineDbContext learnOnlineDb)
        {
            _learnOnlineDb = learnOnlineDb;
        }
        [HttpGet]
        public ActionResult<List<Category>> GetCategory()
        {
            var result = _learnOnlineDb.Categories.ToList();
            return result;
        }
        [HttpPost]
        public ActionResult<Category> CreateCategory(Category category)
        {
           
            if (category.CategoryName == null) return Ok();
            if(category.Id != 0)
            {
               var update = _learnOnlineDb.Categories.Update(category);
                _learnOnlineDb.SaveChanges();
                return Ok(update);
            }
            var result = _learnOnlineDb.Categories.Add(category);
            _learnOnlineDb.SaveChanges();
            return Ok(result);
        }
        [HttpDelete("{categoryId}")]
        public ActionResult DeleteCategory(int categoryId)
        {
            var category = _learnOnlineDb.Categories.FirstOrDefault(x => x.Id == categoryId);
            _learnOnlineDb.Categories.Remove(category);
            _learnOnlineDb.SaveChanges();
            return Ok();
        }
        [HttpGet("categoryId")]
        public ActionResult<Category> GetbyId(int categoryId)
        {
            var result = _learnOnlineDb.Categories.FirstOrDefault(x => x.Id == categoryId);
            var response = new ServiceResponse<Category>()
            {
                Data = result
            };
            return Ok(result);
        }
        [HttpGet("categoryName")]
        public ActionResult<ServiceResponse<Category>> Index(string categoryName)
        {
            var result = _learnOnlineDb.Categories.FirstOrDefault(x => x.CategoryName.ToLower().Contains(categoryName.ToLower()));
            var response = new ServiceResponse<Category>()
            {
                Data = result
            };
            return Ok(response);
        }
    }
}
