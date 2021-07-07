using Rocky.Models;
using System.Collections.Generic;

namespace Rocky.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();
    }
}