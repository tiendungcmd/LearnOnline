using LearnOnline.Models;
using LearnOnline.Models.Entities;
using System.Collections.Generic;

namespace LearnOnline.API.Services.AnswerService
{
    public interface IAnswerService
    {
        ServiceResponse<List<Answer>> GetAnswers();
        ServiceResponse<List<Answer>> GetAnswerById(int Partid);
       // ServiceResponse<Answer> CheckResult(AnswerDto answerDto);
    }
}
