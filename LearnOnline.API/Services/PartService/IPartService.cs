using LearnOnline.Models;
using LearnOnline.Models.Entities;
using System.Collections.Generic;

namespace LearnOnline.API.Services.PartService
{
    public interface IPartService
    {
        ServiceResponse<List<Part>> GetParts();
        ServiceResponse<Part> GetPartById(int partId);
    }
}
