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
        public List<Part> Parts { get; set; } = new List<Part>();
        public async Task<ServiceResponse<AnswerDto>> CheckResult(AnswerDto answerDto)
        {
            return await _httpClient.GetFromJsonAsync<ServiceResponse<AnswerDto>>($"api/Part/check/{ answerDto}");
        }
        //public async Task GetParts()
        //{
        //    // var x = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Part>>>("api/Part");
        //    var res = await _httpClient.GetAsync("api/Part");
        //    var cars = res.Content.ReadFromJsonAsync<List<Part>>();
        //    Parts = x.Data;
        //}
        public async Task<ServiceResponse<List<Part>>> GetParts()
        {
            // var x = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Part>>>("api/Part");
            var res = await _httpClient.GetAsync("api/Part");
            var cars =await res.Content.ReadFromJsonAsync<ServiceResponse<List<Part>>>();
            return cars;
        }
        public async Task<ServiceResponse<Part>> CreatePart(PartDto partDto)
        {
            var x = await _httpClient.PostAsJsonAsync($"api/Part", partDto);
            var c = await x.Content.ReadFromJsonAsync<ServiceResponse<Part>>();
            return c;
        }

        //public async Task<Part> CreatePart(PartDto partDto)
        //{
        //    var x = await _httpClient.PostAsJsonAsync($"api/Part", partDto);
        //    return x.d;
        //}
    }
}
