using LearnOnline.Models;
using LearnOnline.Web.Service;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace LearnOnline.Web.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _http;
        // private readonly AuthenticationStateProvider _authStateProvider;

        public AuthService(HttpClient http)
        {
            _http = http;
        }


        public async Task<ServiceResponse<string>> Login(UserLogin request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/login", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<int>> Register(UserRegister request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/register", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}
