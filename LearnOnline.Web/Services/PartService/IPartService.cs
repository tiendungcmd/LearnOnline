using LearnOnline.Models;
using LearnOnline.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnOnline.Web.Services.PartService
{
    public interface IPartService
    {
        List<Part> Parts { get; set; }
        Task<ServiceResponse<List<Part>>> GetParts();
        public Task<ServiceResponse<AnswerDto>> CheckResult(AnswerDto answerDto);
        public Task<ServiceResponse<Part>> CreatePart(PartDto partDto);
    }
}
