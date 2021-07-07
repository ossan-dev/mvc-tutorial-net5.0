using Rocky.DB;
using Rocky.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IDataProvider _dataProvider;

        public CategoryService(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public IEnumerable<Category> GetCategories()
        {
            var output = new List<Category>();
            string cmdText = @"SELECT id, name, display_order FROM category";
            var dt = _dataProvider.GetData(cmdText);
            foreach (DataRow row in dt.Rows)
            {
                var values = row.ItemArray;
                var category = new Category { Id = Convert.ToInt32(values[0]), Name = Convert.ToString(values[1]), DisplayOrder = Convert.ToInt32(values[2]) };
                output.Add(category);
            }

            return output;
        }
    }
}
