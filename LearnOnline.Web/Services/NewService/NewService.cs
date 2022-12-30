using LearnOnline.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace LearnOnline.Web.Services.NewService
{

    public class NewService : INewService
    {
        private readonly HttpClient _httpClient;

        public NewService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<ServiceResponse<List<New>>> GetNews()
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<New>>>("api/New");
            return response;
        }
    }
}
