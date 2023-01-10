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
