using Exportar_XML.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Exportar_XML.Repository
{
    public class ClientRepository : IRepository
    {
        private readonly string _connectionString;
        private IDatabaseService _databaseService;

        public ClientRepository(string connectionString,
                                IDatabaseService databaseService)
        {
            _connectionString = connectionString;
            _databaseService = databaseService;
        }

        public async Task Get(DataGridView grid)
        {
            var connection =_databaseService.ConnectionDB();
            try
            {
                    string sql = "Select *from Clientes";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataTable data = new DataTable();
                    await Task.Run(() =>
                    {
                        adapter.Fill(data);

                    });
                    grid.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error interno en la DB" + ex);
                throw;
            }
        }

        public async Task Add(TextBox name, TextBox lastname, TextBox age)
        {
            var connection = _databaseService.ConnectionDB();
            try
            {
                        string nombre = name.Text.ToString();
                        string apellido = lastname.Text.ToString();
                        int edad = int.Parse(age.Text.ToString());

                        string sql = "INSERT INTO Clientes (nombre, apellido, edad) VALUES (@nombre, @apellido, @edad)";
                        SqlCommand query = new SqlCommand(sql, connection);
                        query.Parameters.AddWithValue("@nombre", nombre);
                        query.Parameters.AddWithValue("@apellido", apellido);
                        query.Parameters.AddWithValue("@edad", edad);
                        await query.ExecuteNonQueryAsync();

                        MessageBox.Show("Datos agregados correctamente a la base de datos.");

                        //Limpiar celdas TexBox

                        name.Text = string.Empty;
                        lastname.Text = string.Empty;
                        age.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error interno en la DB"+ex);
                throw;
            }
        }

        public async Task Delete(int id)
        {
            var connection = _databaseService.ConnectionDB();

            try
            {          
                    string sql = "DELETE FROM Clientes WHERE id = @id";
                    SqlCommand query = new SqlCommand(sql, connection);
                    query.Parameters.AddWithValue("id", id);
                    await query.ExecuteNonQueryAsync();
        
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
