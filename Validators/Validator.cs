using Exportar_XML.Repository;
using Exportar_XML.Services;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Exportar_XML.Validators
{
    public class Validator : IValidators
    {
        private IDatabaseService _databaseService;
        private IClientService _clientService;
        private IRepository _repository;
        private IEventos _eventos;
        private SqlConnection _connection;
        public Validator(IDatabaseService database,
                        IClientService clientService,
                        IRepository repository,
                        IEventos eventos
                           )
        {
            _databaseService = database;
            _clientService = clientService;
            _repository = repository;
            _eventos = eventos;
        }

        public void ValidatorDelete(DataGridView grid, int fila)
        {
            _connection = _databaseService.ConnectionDB();
            if (_connection.State == ConnectionState.Open)
            {
                _clientService.Delete(grid, fila);
            }
            else { MessageBox.Show("Se encuentra desconectado del servidor"); }
        }

        public void ValidatorGet(DataGridView grid)
        {
            _connection = _databaseService.ConnectionDB();
            if (_connection.State == ConnectionState.Open)
            {
                _repository.Get(grid);
            }
            else if (_connection.State != ConnectionState.Open)
            {

                MessageBox.Show("La conexión esta cerrada, no se puede acceder al servidor");
            }
        }

        public void ValidatorInsert(TextBox name, TextBox lastname, TextBox age)

        {
            _connection = _databaseService.ConnectionDB();
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                MessageBox.Show("La conexión esta cerrada, para poder ingresar datos debe conectarse a la DB");
            }
            else if (_connection.State == System.Data.ConnectionState.Open)
            {
                if (name.Text.Length != 0 || lastname.Text.Length != 0 || age.Text.Length != 0)
                {
                    _repository.Add(name, lastname, age);
                }
                else
                {
                    MessageBox.Show("No se pueden guardar campos vacios");
                }
            }
            else
            {
                MessageBox.Show("La conexión a la DB esta cerrada");
            }
        }

        public void ValidatorExportXML(SaveFileDialog save, DataGridView grid)
        {
            _connection = _databaseService.ConnectionDB();
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                MessageBox.Show("La conexión esta cerrada, para exportar los datos debe conectarse a la DB");
            }
            else if (_connection.State == System.Data.ConnectionState.Open)
            {
                if (grid.Rows.Count == 0)
                {
                    MessageBox.Show("No se pueden exportar, si los datos no han sido cargados");
                }
                else {
                    try
                    {
                        save.ShowDialog();
                        if (!string.IsNullOrWhiteSpace(save.FileName))
                        {
                            DataTable dt = (DataTable)grid.DataSource;
                            _clientService.ExportXML(save.FileName, dt);
                            MessageBox.Show("Archivo XML guardado exitosamente.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error... " + ex);
                        throw;
                    }
                }
            }

        }

        public void ValidatorCloseConnection(DataGridView grid, Label text)
        {
            try
            {
                _connection = _databaseService.ConnectionDB();
                if (_connection.State != ConnectionState.Closed)
                {
                    _databaseService.CloseConnection();
                    _eventos.CloseLabel(text);
                    _clientService.BorrarGrid(grid);
                    MessageBox.Show("Desconectando del Servidor");
                }
                else if (_connection.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Se encuentra desconectado del servidor");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw;
            }
        }
        public void ValidatorOpenConnection(Label text)
        {
            try
            {
                _connection = _databaseService.ConnectionDB();
                if (_connection.State != ConnectionState.Open)
                {
                    _databaseService.ConnectionOpen();
                    _eventos.ConnectedLabel(text);
                    MessageBox.Show("Conexión Exitosa");
                }
                else if (_connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Ya se encuentra conectado al servidor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +ex.Message);
                throw;
            }
               
        }
    }
}
