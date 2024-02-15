using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exportar_XML.Repository
{
    public interface IRepository
    {
        public Task Get(DataGridView grid);
        public Task Add(TextBox name, TextBox lastname, TextBox age);
        public Task Delete(int id);


    }
}

