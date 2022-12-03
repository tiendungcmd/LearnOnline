using LearnOnline.Models;
using System.Threading.Tasks;

namespace LearnOnline.Web.Service
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(UserRegister request);
        Task<ServiceResponse<string>> Login(UserLogin request);
    }
}
