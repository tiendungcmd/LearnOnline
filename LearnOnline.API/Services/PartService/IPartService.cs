using LearnOnline.Models;
using LearnOnline.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnOnline.API.Services.PartService
{
    public interface IPartService
    {
        ServiceResponse<List<Part>> GetParts();
        ServiceResponse<List<Part>> GetPartById(int categoryId);
        Task<ServiceResponse<Part>> CreatePart(Part part);
        Task<ServiceResponse<Part>> UpdatePart(Part part);
        Task<ServiceResponse<Part>> DeletePart(Part part);
    }
}
