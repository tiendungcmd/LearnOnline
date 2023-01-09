using LearnOnline.API.Data;
using LearnOnline.Models;
using System.Collections.Generic;
using System.Linq;

namespace LearnOnline.API.Services.HistoryService
{
    public class HistoryService : IHistoryService
    {
        private readonly LearnOnlineDbContext _learnOnlineDbContext;

        public HistoryService(LearnOnlineDbContext learnOnlineDbContext)
        {
            _learnOnlineDbContext = learnOnlineDbContext;
        }
        public ServiceResponse<List<History>> GetHistories()
        {
            return new ServiceResponse<List<History>>()
            {
                Data = _learnOnlineDbContext.Histories.ToList()
            };
        }

        public ServiceResponse<History> GetHistoryById(int id)
        {
            return new ServiceResponse<History>()
            {
                Data = _learnOnlineDbContext.Histories.FirstOrDefault(x => x.Id == id)
            };
        }
    }
}
