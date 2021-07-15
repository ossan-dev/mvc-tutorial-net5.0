using System.Data;

namespace Rocky.DB
{
    public interface IDataProvider
    {
        int ExecuteCommand(string commandText);
        int ExecuteCommand2(string commandText);
        DataTable GetData(string queryText);
    }
}