using LearnOnline.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace LearnOnline.Web.Services
{
    public class UploadFile
    {
        private readonly HttpClient _client;

        public UploadFile(HttpClient client)
        {
            _client = client;
        }
        public async Task<ServiceResponse<Image>> SaveFile(Image image)
        {
            var result = await _client.PostAsJsonAsync("api/Image/image", image);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<Image>>();
        }
        public async Task<List<Image>> GetFile(int partId)
        {
            var result = await _client.GetFromJsonAsync<List<Image>>($"api/Image/partId?partId={partId}");
            return result;
        }
    }
}
