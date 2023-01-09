using LearnOnline.Models;
using System.Collections.Generic;

namespace LearnOnline.API.Services.HistoryService
{
    public interface IHistoryService
    {
        ServiceResponse<List<History>> GetHistories();
        ServiceResponse<History> GetHistoryById(int id);    
    }
}
