using Exportar_XML.Repository;
using Exportar_XML.Services;
using Exportar_XML.Validators;
using System;
using System.Data;
using System.Text.Unicode;
using System.Windows.Forms;
using System.Xml;

namespace Exportar_XML
{
    public partial class FrUsers : Form
    {
        private IClientService _clientService;
        private IDatabaseService _databaseService;
        private IRepository _repository;
        private IEventos _eventos;
        private IValidators _validators;
        private int selectedRowIndex = -1;
        public FrUsers(IClientService services,
                       IDatabaseService databaseService,
                       IRepository repository,
                       IEventos eventos,
                       IValidators validators)
        {
            InitializeComponent();
            _clientService = services;
            _databaseService = databaseService;
            _repository = repository;
            _eventos = eventos;
            _validators = validators;
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            _validators.ValidatorOpenConnection(Label_Connection);
            // _repository.Get(Data_Grid_Clients);
        }

        private void Btn_Off_DB_Click(object sender, EventArgs e)
        {
            _validators.ValidatorCloseConnection(Data_Grid_Clients, Label_Connection);
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            _validators.ValidatorInsert(Tex_Box_Name, Text_Box_Lastname, Text_Box_Age);
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            _validators.ValidatorGet(Data_Grid_Clients);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Data_Grid_Clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = _eventos.CapturarCeldaDataGrid(e);

        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            _validators.ValidatorDelete(Data_Grid_Clients, selectedRowIndex);
        }

        private void Btn_Export_Xml_Click(object sender, EventArgs e)
        {
            _validators.ValidatorExportXML(saveFileDialog1,Data_Grid_Clients);
        }

    }
}
