using LearnOnline.Models;
using System.Collections.Generic;

namespace LearnOnline.API.Services.NewsService
{
    public interface INewService
    {
        ServiceResponse<List<New>> GetNews();
        ServiceResponse<New> GetNew(int id);
    }
}
