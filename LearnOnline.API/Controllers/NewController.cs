using LearnOnline.API.Data;
using LearnOnline.API.Services.NewsService;
using LearnOnline.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewController : ControllerBase
    {
        private readonly INewService _newService;
        private readonly LearnOnlineDbContext _dbContext;

        public NewController(INewService newService, LearnOnlineDbContext dbContext)
        {
            _newService = newService;
            _dbContext = dbContext;
        }
        [HttpGet("topic")]
        public ActionResult<List<New>> GetNew(int topic)
        {
            var result = _dbContext.News.Where(x => x.Topic == topic.ToString()).ToList();
            return result;
        }
        [HttpGet("id")]
        public ActionResult<Category> GetbyId(int id)
        {
            var result = _dbContext.News.FirstOrDefault(x => x.Id == id);
            var response = new ServiceResponse<New>()
            {
                Data = result
            };
            return Ok(result);
        }
        [HttpPost]
        public ActionResult New(New request)
        {
            // request.UserId = 8342;
            var user = _dbContext.Users.FirstOrDefault(x => x.Email == request.UserName);
            request.UserId = user.Id;
            if (request.Title == null) return Ok();
            if (request.Id != 0)
            {
                _dbContext.News.Update(request);
                _dbContext.SaveChanges();
                return Ok();
            }
            _dbContext.News.Add(request);
            _dbContext.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(int id)
        {
            var news = _dbContext.News.FirstOrDefault(x => x.Id == id);
            _dbContext.News.Remove(news);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
