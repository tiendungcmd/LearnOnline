using LearnOnline.Models;
using System.Threading.Tasks;

namespace LearnOnline.Web.Services.Upload
{
    public interface IUploadFile
    {
        Task<ServiceResponse<Image>> SaveFile(Image image);
    }
}
