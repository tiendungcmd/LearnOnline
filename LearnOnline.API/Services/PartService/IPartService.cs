using LearnOnline.Models;
using LearnOnline.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnOnline.API.Services.PartService
{
    public interface IPartService
    {
        ServiceResponse<List<Part>> GetParts();
        ServiceResponse<Part> GetPartById(int partId);
        Task<ServiceResponse<Part>> CreatePart(Part part);
        Task<ServiceResponse<Part>> UpdatePart(Part part);
        Task<ServiceResponse<Part>> DeletePart(Part part);
    }
}
