using LearnOnline.Models;
using LearnOnline.Models.Entities;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace LearnOnline.Web.Services.PartService
{
    public class PartService : IPartService
    {
        private readonly HttpClient _httpClient;

        public PartService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ServiceResponse<AnswerDto>> CheckResult(AnswerDto answerDto)
        {
           return await _httpClient.GetFromJsonAsync<ServiceResponse<AnswerDto>> ($"api/Part/check/{ answerDto}");
        }

        //public async Task<ServiceResponse<List<Part>>CheckResult(AnswerDto answerDto)
        //{
        //     await _httpClient.PostAsJsonAsync("api/Part/check", answerDto);
        //}

        public async Task<ServiceResponse<List<Part>>> GetParts()
        {
            return await _httpClient.GetFromJsonAsync<ServiceResponse<List<Part>>>("api/Part");
        }
    }
}
