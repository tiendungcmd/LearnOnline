using LearnOnline.API.Data;
using LearnOnline.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LearnOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : Controller
    {
        private readonly LearnOnlineDbContext _learnOnlineDbContext;

        public ImageController(LearnOnlineDbContext learnOnlineDbContext)
        {
            _learnOnlineDbContext = learnOnlineDbContext;
        }
        [HttpPost("image")]
        public ActionResult<ServiceResponse<int>> SaveImage(Image image)
        {
            _learnOnlineDbContext.Images.Add(image);
            var response = _learnOnlineDbContext.SaveChanges();
            return Ok(response);
        }
        [HttpGet("partId")]
        public ActionResult<List<Image>> GetImage(int partId)
        {
            var response = _learnOnlineDbContext.Images.Where(x => x.PartId == partId);
            return Ok(response);
        }
    }
}
