using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exportar_XML.Validators
{
    public interface IValidators
    {
        public void ValidatorDelete(DataGridView grid, int fila);
        public void ValidatorInsert(TextBox name, TextBox lastname, TextBox age);
        public void ValidatorGet(DataGridView grid);
        public void ValidatorExportXML(SaveFileDialog save, DataGridView grid);
        public void ValidatorOpenConnection(Label text);
        public void ValidatorCloseConnection(DataGridView grid, Label text);
    }
}
