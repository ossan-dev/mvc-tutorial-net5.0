using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.DB
{
    public class MySqlProvider : IDataProvider
    {
        public DataTable GetData(string queryText)
        {
            throw new NotImplementedException();
        }
    }
}
