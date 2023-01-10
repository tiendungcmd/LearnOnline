using LearnOnline.API.Data;
using LearnOnline.Models;
using LearnOnline.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnOnline.API.Services.PartService
{
    public class PartService : IPartService
    {
        private readonly LearnOnlineDbContext _onlineDbContext;

        public PartService(LearnOnlineDbContext onlineDbContext)
        {
            _onlineDbContext = onlineDbContext;
        }

        public async Task<ServiceResponse<Part>> CreatePart(Part part)
        {
           _onlineDbContext.Parts.Add(part);
            await _onlineDbContext.SaveChangesAsync();
            //find Id
            var partAfter = _onlineDbContext.Parts.Find(part);
            part.Id = partAfter.Id;
            return new ServiceResponse<Part> { Data = part };
        }

        public Task<ServiceResponse<Part>> DeletePart(Part part)
        {
            throw new System.NotImplementedException();
        }
        //get by id category
        public ServiceResponse<List<Part>> GetPartById(int categoryId)
        {
            return new ServiceResponse<List<Part>>()
            {
                Data = _onlineDbContext.Parts.Where(x => x.CategoryId == categoryId).ToList()
            };
        }

        public ServiceResponse<List<Part>> GetParts()
        {
            return new ServiceResponse<List<Part>>()
            {
                Data = _onlineDbContext.Parts.ToList()
            };
        }

        public Task<ServiceResponse<Part>> UpdatePart(Part part)
        {
            throw new System.NotImplementedException();
        }
    }
}
