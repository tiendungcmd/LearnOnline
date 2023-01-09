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

        public List<New> News { get; set; } = new List<New>();

        public async Task<ServiceResponse<New>> GetNewById(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<New>>($"api/New/id?id={id}");
            return response;
        }

        public async Task GetNews()
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<New>>>("api/New");
            News = response.Data;
        }
    }
}
