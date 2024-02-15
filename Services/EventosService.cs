using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exportar_XML.Services
{
    internal class EventosService : IEventos
    {
        private IDatabaseService _databaseService;
        private IClientService _clientService;

        public EventosService(IDatabaseService databaseService,
                              IClientService clientService)
        {
            _databaseService = databaseService;
            _clientService = clientService;
        }

        public void ConnectedLabel(Label text)
        {
            try
            {
                text.ForeColor = Color.Green;
                text.Text = "Conectado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw;
            }


        }
        public void CloseLabel(Label text)
        {
            try
            {
                text.ForeColor = Color.Red;
                text.Text = "Desconectado";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw;
            }
        }

        public int CapturarCeldaDataGrid(DataGridViewCellEventArgs e)
        {
            int FilaSeleccionada = 0;
            try
            {
                FilaSeleccionada = e.RowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }
            return FilaSeleccionada;
        }
    }
}
