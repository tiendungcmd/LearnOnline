using LearnOnline.API.Data;
using LearnOnline.Models;
using LearnOnline.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LearnOnline.API.Services.AnswerService
{
    public class AnswerService : IAnswerService
    {
        private readonly LearnOnlineDbContext _learnOnlineDb;

        public AnswerService(LearnOnlineDbContext learnOnlineDb)
        {
            _learnOnlineDb = learnOnlineDb;
        }

        //public ServiceResponse<Answer> CheckResult(AnswerDto answerDto)
        //{
        //    var response = new ServiceResponse<Answer>();
        //    var result = _learnOnlineDb.Answer.Where(x=>x.PartId== answerDto.PartId && x.CorrectAnswer == true );
        //    result = result.Where(x => x.Content.ToLower().Contains(answerDto.Result1.ToLower()) || x.Content.ToLower().Contains(answerDto.Result4.ToLower())
        //    || x.Content.ToLower().Contains(answerDto.Result2.ToLower())|| x.Content.ToLower().Contains(answerDto.Result5.ToLower()) 
        //    || x.Content.ToLower().Contains(answerDto.Result3.ToLower()));
        //    if (result.Any())
        //    {
        //        response.Message = "Correct";
        //    }
        //    else
        //    {
        //        response.Message = "Incorrect";
        //    }
        //    return response;
        //}

        public ServiceResponse<List<Answer>> GetAnswerById(int id)
        {
            return new ServiceResponse<List<Answer>>()
            {
                Data = _learnOnlineDb.Answer.Where(x=>x.QuestionId == id).ToList()
            };
        }

        public ServiceResponse<List<Answer>> GetAnswers()
        {
            return new ServiceResponse<List<Answer>>()
            {
                Data = _learnOnlineDb.Answer.ToList()
            };
        }
    }
}
