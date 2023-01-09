using LearnOnline.Models;
using LearnOnline.Models.Entities;
using System.Collections.Generic;

namespace LearnOnline.API.Services.QuestionService
{
    public interface IQuestionService
    {
        ServiceResponse<List<Question>> GetQuestionByPartId(int partId);
        ServiceResponse<Question> CreateQuestion(Question question);
    }
}
