﻿using LearnOnline.API.Data;
using LearnOnline.Models;
using LearnOnline.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LearnOnline.API.Services.QuestionService
{
    public class QuestionService : IQuestionService
    {
        private readonly LearnOnlineDbContext _learnOnlineDbContext;

        public QuestionService(LearnOnlineDbContext learnOnlineDbContext)
        {
            _learnOnlineDbContext = learnOnlineDbContext;
        }
        public ServiceResponse<List<Question>> GetQuestionByPartId(int partId)
        {
            return new ServiceResponse<List<Question>>()
            {
                Data = _learnOnlineDbContext.Question.Where(x=>x.PartId == partId).ToList()
            };
        }
    }
}
