using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exportar_XML.Services
{
    public interface IClientService
    {
        public void ExportXML(string save, DataTable grid);
        public void BorrarGrid(DataGridView grid);
        public void Delete(DataGridView grid, int fila);
    }
}
