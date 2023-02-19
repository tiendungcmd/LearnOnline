using LearnOnline.API.Data;
using LearnOnline.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LearnOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly LearnOnlineDbContext _learnOnlineDb;

        public UserController(LearnOnlineDbContext learnOnlineDb)
        {
            _learnOnlineDb = learnOnlineDb;
        }
        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            var result = _learnOnlineDb.Users.ToList();
            return result;
        }
        [HttpDelete("{userId}")]
        public ActionResult DeleteUser(int userId)
        {
            var user = _learnOnlineDb.Users.FirstOrDefault(x => x.Id == userId);
            _learnOnlineDb.Users.Remove(user);
            _learnOnlineDb.SaveChanges();
            return Ok();
        }
    }
}
