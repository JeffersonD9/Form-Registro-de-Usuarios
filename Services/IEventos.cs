using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exportar_XML.Services
{
    public interface IEventos
    {
        public int CapturarCeldaDataGrid(DataGridViewCellEventArgs e);
        public void ConnectedLabel(Label text);
        public void CloseLabel(Label text);
    }
}
