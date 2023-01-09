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
        [HttpGet]
        public ActionResult<ServiceResponse<List<New>>> GetNews()
        {
            var result = _newService.GetNews();
            return Ok(result);
        }
        [HttpGet("id")]
        public async Task<ActionResult<ServiceResponse<New>>> GetNewsById(int id)
        {
            var result = await _newService.GetNew(id);
            return Ok(result);
        }
    }
}
