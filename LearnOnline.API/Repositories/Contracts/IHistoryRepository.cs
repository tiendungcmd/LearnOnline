using LearnOnline.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnOnline.API.Repositories.Contracts
{
    public interface IHistoryRepository
    {
        Task<IEnumerable<History>> GetHistories();
        Task<History> GetHistorie(int id);
    }
}
