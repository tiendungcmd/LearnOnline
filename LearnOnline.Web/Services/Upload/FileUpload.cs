using BlazorInputFile;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Threading.Tasks;

namespace LearnOnline.Web.Services.Upload
{
    public class FileUpload : IFileUpload
    {
        private readonly IHostEnvironment _webHostEnvironment;

        public FileUpload(IHostEnvironment webHostEnvironment)
        {
           _webHostEnvironment = webHostEnvironment;
        }
        public async Task Upload(IFileListEntry file)
        {
            var path = Path.Combine(_webHostEnvironment.ContentRootPath, "../UploadFile", file.Name);
            var memoryStream = new MemoryStream();
            await file.Data.CopyToAsync(memoryStream);
            using (FileStream fileStream = new FileStream(path,FileMode.Create,FileAccess.Write))
            {
                memoryStream.WriteTo(fileStream);   
            }
        }
    }
}
