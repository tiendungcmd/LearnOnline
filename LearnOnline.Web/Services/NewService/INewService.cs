
using LearnOnline.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnOnline.Web.Services.NewService
{
    public interface INewService
    {
        public List<New> News { get; set; }
        public Task GetNews();
    }
}
