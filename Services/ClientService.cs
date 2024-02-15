using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Data;
using System.Configuration;
using Exportar_XML.Repository;
using System.Xml;

namespace Exportar_XML.Services
{
    public class ClientService : IClientService
    {
        private readonly IDatabaseService _databaseService;
        private IRepository _repository;
        public ClientService(IDatabaseService databaseService,
                             IRepository repository)
        {
            _databaseService = databaseService;
            _repository = repository;
        }

        public void Delete(DataGridView grid, int filaSeleccionada)
        {
            try
            {
                if (filaSeleccionada >= 0 && filaSeleccionada < grid.Rows.Count)
                {
                    int id = (int)grid.Rows[filaSeleccionada].Cells["Id"].Value;
                    _repository.Delete(id);
                    grid.Rows.RemoveAt(filaSeleccionada);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ExportXML(string filepath, DataTable grid)
        {

            XmlTextWriter xmlWriter = new XmlTextWriter(filepath, null);

            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("ListaClientes");

            foreach (DataRow row in grid.Rows)
            {
                xmlWriter.WriteStartElement("Cliente");

                foreach (DataColumn column in grid.Columns)
                {
                    xmlWriter.WriteElementString(column.ColumnName, row[column].ToString().Trim());
                    //  string nombre = row[column].ToString();
                    //Console.WriteLine(nombre);
                }
                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement(); // Cierre del elemento raíz
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();

        }

        public void BorrarGrid(DataGridView grid)
        {
            int rows = grid.Rows.Count - 1;
            for (int row = rows; row >= 0; row--)
            {
                grid.Rows.RemoveAt(row);
                // Console.WriteLine(row);
            }
            int columnCount = grid.ColumnCount;
            for (int colum = columnCount - 1; colum >= 0; colum--)
            {
                grid.Columns.RemoveAt(colum);

            }

        }
    }
}
