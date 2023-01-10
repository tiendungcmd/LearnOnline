using LearnOnline.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnOnline.Web.Services.CategoryService
{
    public interface ICategoryService
    {
        public Task<List<Category>> GetCategory();
    }
}
