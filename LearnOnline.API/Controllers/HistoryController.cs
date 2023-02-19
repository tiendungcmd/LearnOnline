using LearnOnline.API.Data;
using LearnOnline.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LearnOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : Controller
    {
        private readonly LearnOnlineDbContext _learnOnline;

        public HistoryController(LearnOnlineDbContext learnOnline)
        {
            _learnOnline = learnOnline;
        }
        [HttpGet]
        public ActionResult<List<History>> GetCategory()
        {
            var result = _learnOnline.Histories.ToList();
            return result;
        }
        [HttpPost]
        public ActionResult<History> CreateHistory(HistoryDto historyDto)
        {
            History history = new History();
            history.Date = historyDto.Date;
            history.PartId = historyDto.PartId;
            history.TotalScore = historyDto.TotalScore;

            var id = _learnOnline.Users.FirstOrDefault(x => x.Email == historyDto.UserName);
            history.IdUser = id.Id;
            history.Email = historyDto.UserName;
            var result = _learnOnline.Histories.Add(history);
            _learnOnline.SaveChanges();
            return Ok(result);
        }
        [HttpGet("email")]
        public ActionResult<List<HistoryDto>> GetbyId(string email)
        {
            List<HistoryDto> historyDtos = new List<HistoryDto>();

            email += "@gmail.com";
            var result = _learnOnline.Histories.Where(x => x.Email == email).ToList();
            foreach (var item in result)
            {
                var historyDto = new HistoryDto();
                historyDto.Date = item.Date;
                historyDto.UserName = email;
                historyDto.TotalScore = item.TotalScore;
                historyDto.Id = item.Id;
                var part = _learnOnline.Parts.FirstOrDefault(x => x.Id == item.PartId);

                if (part.SkillId == 1) historyDto.Skill = "Reading";
                if (part.SkillId == 2) historyDto.Skill = "Listening";
                historyDto.PartTitle = part.Title;

                historyDtos.Add(historyDto);

            }
            return Ok(historyDtos);
        }
    }
}
