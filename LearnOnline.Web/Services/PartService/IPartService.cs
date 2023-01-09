using LearnOnline.Models;
using LearnOnline.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnOnline.Web.Services.PartService
{
    public interface IPartService
    {
        public Task<ServiceResponse<List<Part>>> GetParts();
        public Task<ServiceResponse<AnswerDto>> CheckResult(AnswerDto answerDto);
    }
}
