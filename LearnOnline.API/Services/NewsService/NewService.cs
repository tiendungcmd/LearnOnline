using LearnOnline.API.Data;
using LearnOnline.Models;
using System.Collections.Generic;
using System.Linq;

namespace LearnOnline.API.Services.NewsService
{

    public class NewService : INewService
    {
        private readonly LearnOnlineDbContext _learnOnlineDbContext;
        public NewService(LearnOnlineDbContext learnOnlineDbContext)
        {
            _learnOnlineDbContext = learnOnlineDbContext;
        }

        public ServiceResponse<New> GetNew(int id)
        {
            var response = new ServiceResponse<New>
            {
                Data = _learnOnlineDbContext.News.FirstOrDefault(x => x.Id == id)
            };
            return response;
        }

        public ServiceResponse<List<New>> GetNews()
        {
            var response = new ServiceResponse<List<New>>
            {
                Data = _learnOnlineDbContext.News.ToList()
            };
            return response;
        }
    }
}
