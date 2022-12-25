using LearnOnline.API.Data;
using LearnOnline.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnOnline.API.Services.NewsService
{
   
    public class NewService : INewService
    {
        private readonly LearnOnlineDbContext _learnOnlineDbContext;
        public NewService(LearnOnlineDbContext learnOnlineDbContext)
        {
            _learnOnlineDbContext = learnOnlineDbContext;
        }
        public async Task<New> GetNew(int id)
        {
            return await _learnOnlineDbContext.News.FirstAsync(x => x.Id == id);  
        }


        public async Task<IEnumerable<New>> GetNews()
        {
            return await _learnOnlineDbContext.News.ToListAsync();
        }
    }
}
