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

            //var listImg = _learnOnlineDbContext.Images.Where(x => x.PartId == image.PartId).ToList();
            //if (listImg.Count > 0)
            //{
            //    foreach (var img in listImg)
            //    {
            //        _learnOnlineDbContext.Images.Remove(img);
            //        _learnOnlineDbContext.SaveChanges();
            //    }
            //}
            image.Id = 0;
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
        [HttpDelete("{Id}")]
        public ActionResult<ServiceResponse<int>> DeleteImage(int Id)
        {

            var listImg = _learnOnlineDbContext.Images.Where(x => x.PartId == Id).ToList();
            if (listImg.Count > 0)
            {
                foreach (var img in listImg)
                {
                    _learnOnlineDbContext.Images.Remove(img);
                    _learnOnlineDbContext.SaveChanges();
                }
            }
           // var response = _learnOnlineDbContext.SaveChanges();
            return Ok(1);
        }
    }
}
