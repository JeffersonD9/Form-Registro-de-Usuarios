using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Exportar_XML.Services
{
    public class DataBaseService : IDatabaseService
    {
        private readonly string _connectionString;
        private SqlConnection _connection;
        public DataBaseService(string ConnectionString) {
        
            _connectionString = ConnectionString;
            _connection = new SqlConnection(_connectionString);
        }

        public async Task ConnectionOpen()
        {
            try
            {
                _connection.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task CloseConnection()
        {
            try
            {
                await _connection.CloseAsync();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public SqlConnection ConnectionDB()
        {
            return _connection;
        }
    }
}
