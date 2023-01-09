using BlazorInputFile;
using System.Threading.Tasks;

namespace LearnOnline.Web.Services.Upload
{
    public interface IFileUpload
    {
        Task Upload(IFileListEntry file);
    }
}
