using BlazorInputFile;
using System.Threading.Tasks;

namespace LearnOnline.Web.Services.Upload
{
    public interface IUploadAudio
    {
        Task Upload(IFileListEntry file);
    }
}
