using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exportar_XML.Services
{
    public interface IDatabaseService
    {
        public Task ConnectionOpen();
        public SqlConnection ConnectionDB();
        public Task CloseConnection();

    }
}
