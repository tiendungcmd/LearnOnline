
using LearnOnline.API.Services.NewsService;
using LearnOnline.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewController : Controller
    {
        private readonly INewService _newService;

        public NewController(INewService newService)
        {
            _newService = newService;
        }
        [HttpGet]
        public async Task<ActionResult<List<New>>> GetNews()
        {
            var result = await _newService.GetNews();
            return Ok(result);
        }
    }
}
