namespace Exportar_XML
{
    partial class FrUsers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Data_Grid_Clients = new DataGridView();
            Label_Connection = new Label();
            Group_Box_Clients = new GroupBox();
            Text_Box_Age = new TextBox();
            Text_Box_Lastname = new TextBox();
            Tex_Box_Name = new TextBox();
            Label4 = new Label();
            Label3 = new Label();
            Label_Name = new Label();
            Btn_Salir = new Button();
            Btn_Off_DB = new Button();
            Btn_Eliminar = new Button();
            Btn_Export_Xml = new Button();
            Btn_Agregar = new Button();
            Btn_Connect = new Button();
            Btn_Actualizar = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)Data_Grid_Clients).BeginInit();
            Group_Box_Clients.SuspendLayout();
            SuspendLayout();
            // 
            // Data_Grid_Clients
            // 
            Data_Grid_Clients.AllowUserToAddRows = false;
            Data_Grid_Clients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Data_Grid_Clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Data_Grid_Clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Data_Grid_Clients.DefaultCellStyle = dataGridViewCellStyle2;
            Data_Grid_Clients.Location = new Point(253, 245);
            Data_Grid_Clients.Name = "Data_Grid_Clients";
            Data_Grid_Clients.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Data_Grid_Clients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            Data_Grid_Clients.RowHeadersWidth = 51;
            Data_Grid_Clients.Size = new Size(555, 254);
            Data_Grid_Clients.TabIndex = 17;
            Data_Grid_Clients.CellClick += Data_Grid_Clients_CellClick;
            // 
            // Label_Connection
            // 
            Label_Connection.AutoSize = true;
            Label_Connection.ForeColor = SystemColors.ActiveCaptionText;
            Label_Connection.Location = new Point(704, 41);
            Label_Connection.Name = "Label_Connection";
            Label_Connection.Size = new Size(0, 20);
            Label_Connection.TabIndex = 16;
            // 
            // Group_Box_Clients
            // 
            Group_Box_Clients.Controls.Add(Text_Box_Age);
            Group_Box_Clients.Controls.Add(Text_Box_Lastname);
            Group_Box_Clients.Controls.Add(Tex_Box_Name);
            Group_Box_Clients.Controls.Add(Label4);
            Group_Box_Clients.Controls.Add(Label3);
            Group_Box_Clients.Controls.Add(Label_Name);
            Group_Box_Clients.Location = new Point(253, 34);
            Group_Box_Clients.Name = "Group_Box_Clients";
            Group_Box_Clients.Size = new Size(423, 173);
            Group_Box_Clients.TabIndex = 15;
            Group_Box_Clients.TabStop = false;
            Group_Box_Clients.Text = "Registros";
            // 
            // Text_Box_Age
            // 
            Text_Box_Age.Location = new Point(117, 130);
            Text_Box_Age.Name = "Text_Box_Age";
            Text_Box_Age.Size = new Size(216, 27);
            Text_Box_Age.TabIndex = 5;
            // 
            // Text_Box_Lastname
            // 
            Text_Box_Lastname.Location = new Point(117, 89);
            Text_Box_Lastname.Name = "Text_Box_Lastname";
            Text_Box_Lastname.Size = new Size(216, 27);
            Text_Box_Lastname.TabIndex = 4;
            // 
            // Tex_Box_Name
            // 
            Tex_Box_Name.Location = new Point(117, 42);
            Tex_Box_Name.Name = "Tex_Box_Name";
            Tex_Box_Name.Size = new Size(216, 27);
            Tex_Box_Name.TabIndex = 3;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(26, 133);
            Label4.Name = "Label4";
            Label4.Size = new Size(43, 20);
            Label4.TabIndex = 2;
            Label4.Text = "Edad";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(26, 89);
            Label3.Name = "Label3";
            Label3.Size = new Size(66, 20);
            Label3.TabIndex = 1;
            Label3.Text = "Apellido";
            // 
            // Label_Name
            // 
            Label_Name.AutoSize = true;
            Label_Name.Location = new Point(26, 45);
            Label_Name.Name = "Label_Name";
            Label_Name.Size = new Size(64, 20);
            Label_Name.TabIndex = 0;
            Label_Name.Text = "Nombre";
            // 
            // Btn_Salir
            // 
            Btn_Salir.Location = new Point(21, 449);
            Btn_Salir.Name = "Btn_Salir";
            Btn_Salir.Size = new Size(167, 60);
            Btn_Salir.TabIndex = 14;
            Btn_Salir.Text = "Salir";
            Btn_Salir.UseVisualStyleBackColor = true;
            Btn_Salir.Click += Btn_Salir_Click;
            // 
            // Btn_Off_DB
            // 
            Btn_Off_DB.Location = new Point(21, 373);
            Btn_Off_DB.Name = "Btn_Off_DB";
            Btn_Off_DB.Size = new Size(167, 60);
            Btn_Off_DB.TabIndex = 13;
            Btn_Off_DB.Text = "Desconectar";
            Btn_Off_DB.UseVisualStyleBackColor = true;
            Btn_Off_DB.Click += Btn_Off_DB_Click;
            // 
            // Btn_Eliminar
            // 
            Btn_Eliminar.Location = new Point(21, 293);
            Btn_Eliminar.Name = "Btn_Eliminar";
            Btn_Eliminar.Size = new Size(167, 60);
            Btn_Eliminar.TabIndex = 12;
            Btn_Eliminar.Text = "Eliminar";
            Btn_Eliminar.UseVisualStyleBackColor = true;
            Btn_Eliminar.Click += Btn_Eliminar_Click;
            // 
            // Btn_Export_Xml
            // 
            Btn_Export_Xml.Location = new Point(21, 186);
            Btn_Export_Xml.Name = "Btn_Export_Xml";
            Btn_Export_Xml.Size = new Size(167, 60);
            Btn_Export_Xml.TabIndex = 11;
            Btn_Export_Xml.Text = "Exportar XML";
            Btn_Export_Xml.UseVisualStyleBackColor = true;
            Btn_Export_Xml.Click += Btn_Export_Xml_Click;
            // 
            // Btn_Agregar
            // 
            Btn_Agregar.Location = new Point(21, 104);
            Btn_Agregar.Name = "Btn_Agregar";
            Btn_Agregar.Size = new Size(167, 60);
            Btn_Agregar.TabIndex = 10;
            Btn_Agregar.Text = "Agregar";
            Btn_Agregar.UseVisualStyleBackColor = true;
            Btn_Agregar.Click += Btn_Agregar_Click;
            // 
            // Btn_Connect
            // 
            Btn_Connect.Location = new Point(21, 21);
            Btn_Connect.Name = "Btn_Connect";
            Btn_Connect.Size = new Size(167, 60);
            Btn_Connect.TabIndex = 9;
            Btn_Connect.Text = "Conectar";
            Btn_Connect.UseVisualStyleBackColor = true;
            Btn_Connect.Click += Btn_Connect_Click;
            // 
            // Btn_Actualizar
            // 
            Btn_Actualizar.Location = new Point(704, 178);
            Btn_Actualizar.Name = "Btn_Actualizar";
            Btn_Actualizar.Size = new Size(94, 29);
            Btn_Actualizar.TabIndex = 18;
            Btn_Actualizar.Text = "Actualizar";
            Btn_Actualizar.UseVisualStyleBackColor = true;
            Btn_Actualizar.Click += Btn_Actualizar_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "ArchivosXml(.xml)|.xml";
            saveFileDialog1.Title = "Registro_Clientes.xml";
            // 
            // FrUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 541);
            Controls.Add(Btn_Actualizar);
            Controls.Add(Data_Grid_Clients);
            Controls.Add(Label_Connection);
            Controls.Add(Group_Box_Clients);
            Controls.Add(Btn_Salir);
            Controls.Add(Btn_Off_DB);
            Controls.Add(Btn_Eliminar);
            Controls.Add(Btn_Export_Xml);
            Controls.Add(Btn_Agregar);
            Controls.Add(Btn_Connect);
            Name = "FrUsers";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)Data_Grid_Clients).EndInit();
            Group_Box_Clients.ResumeLayout(false);
            Group_Box_Clients.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal DataGridView Data_Grid_Clients;
        internal Label Label_Connection;
        internal GroupBox Group_Box_Clients;
        internal TextBox Text_Box_Age;
        internal TextBox Text_Box_Lastname;
        internal TextBox Tex_Box_Name;
        internal Label Label4;
        internal Label Label3;
        internal Label Label_Name;
        internal Button Btn_Salir;
        internal Button Btn_Off_DB;
        internal Button Btn_Eliminar;
        internal Button Btn_Export_Xml;
        internal Button Btn_Agregar;
        internal Button Btn_Connect;
        private Button Btn_Actualizar;
        private SaveFileDialog saveFileDialog1;
    }
}
