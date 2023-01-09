using LearnOnline.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnOnline.Web.Services.NewService
{
    public interface INewService
    {
        List<New> News { get; set; }
        public Task GetNews();
        public Task<ServiceResponse<New>> GetNewById(int id);
    }
}
