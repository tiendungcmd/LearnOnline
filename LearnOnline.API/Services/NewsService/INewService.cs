using LearnOnline.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnOnline.API.Services.NewsService
{
    public interface INewService
    {
        ServiceResponse<List<New>> GetNews();
        Task<ServiceResponse<New>> GetNew(int id);
    }
}
