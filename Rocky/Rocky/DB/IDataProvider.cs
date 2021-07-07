using System.Data;

namespace Rocky.DB
{
    public interface IDataProvider
    {
        DataTable GetData(string queryText);
    }
}