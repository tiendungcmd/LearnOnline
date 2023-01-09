using LearnOnline.API.Data;
using LearnOnline.Models;
using LearnOnline.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LearnOnline.API.Services.PartService
{
    public class PartService : IPartService
    {
        private readonly LearnOnlineDbContext _onlineDbContext;

        public PartService(LearnOnlineDbContext onlineDbContext)
        {
            _onlineDbContext = onlineDbContext;
        }
        public ServiceResponse<Part> GetPartById(int partId)
        {
            return new ServiceResponse<Part>()
            {
                Data = _onlineDbContext.Parts.FirstOrDefault(x => x.Id == partId)
            };
        }

        public ServiceResponse<List<Part>> GetParts()
        {
            return new ServiceResponse<List<Part>>()
            {
                Data = _onlineDbContext.Parts.ToList()
            };
        }
    }
}
