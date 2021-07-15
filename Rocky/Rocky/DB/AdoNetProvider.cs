using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.DB
{
    public class AdoNetProvider : IDataProvider
    {
        private readonly string _connectionString;
        public AdoNetProvider(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public DataTable GetData(string queryText)
        {
            DataTable dt = new();
            try
            {
                SqlDataReader reader;
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(queryText, connection))
                    {
                        reader = cmd.ExecuteReader();
                        dt.Load(reader);

                        reader.Close();
                        connection.Close();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }

        public int ExecuteCommand(string commandText)
        {
            int affectedRows = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        affectedRows = command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return affectedRows;
        }

        public int ExecuteCommand2(string commandText)
        {
            int affectedRows = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        affectedRows = command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return affectedRows;
        }
    }
}
