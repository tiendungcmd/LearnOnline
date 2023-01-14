using BlazorInputFile;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Threading.Tasks;

namespace LearnOnline.Web.Services.Upload
{
    public class UploadAudio : IUploadAudio
    {
        private readonly IHostEnvironment _webHostEnviroment;

        public UploadAudio(IHostEnvironment webHostEnviroment)
        {
            _webHostEnviroment = webHostEnviroment;
        }
        public async Task Upload(IFileListEntry file)
        {
            var path = Path.Combine(_webHostEnviroment.ContentRootPath,"Upload",file.Name);
            var memoryStream = new MemoryStream();
            await file.Data.CopyToAsync(memoryStream);
            using(FileStream fileStream  = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                memoryStream.WriteTo(fileStream);
            }
        }
    }
}
