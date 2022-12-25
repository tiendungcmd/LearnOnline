using LearnOnline.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace LearnOnline.API.Services.NewsService
{
    public interface INewService
    {
        Task<IEnumerable<New>> GetNews();
        Task<New> GetNew(int id);
    }
}
