﻿
namespace AutoSetBT
{
    partial class Form1
    {
        public string usuarioActual = "";
        public string ambiente = "BPN_WEB_QA";
        public string server = "arcncd07";

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
            this.inputCuil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFirmarLD = new System.Windows.Forms.Button();
            this.dataLD = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.btnConsultarLD = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataFirma = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.dataInstancia = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.textInstanciaSelected = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textUsuarioSelected = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataUsuarios = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dataEntrevista = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCambiarUsuario = new System.Windows.Forms.Button();
            this.btnConsultarCandidatos = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataBridger = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.richResultado_bridger = new System.Windows.Forms.RichTextBox();
            this.btnConsultarBridger = new System.Windows.Forms.Button();
            this.btnInsertarBridger = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxBusquedaSector = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxBusquedaUsr = new System.Windows.Forms.TextBox();
            this.buttonBuscarUsuario = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBusquedaUsuario = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxSector = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.dataGridSector = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.dataHistoriaEntrevista = new System.Windows.Forms.DataGridView();
            this.label28 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.inputEntrevista = new System.Windows.Forms.TextBox();
            this.inputUsuario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaBT = new System.Windows.Forms.Label();
            this.radioButtonQA = new System.Windows.Forms.RadioButton();
            this.radioButtonDF = new System.Windows.Forms.RadioButton();
            this.richConsola = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLD)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFirma)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInstancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntrevista)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBridger)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSector)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoriaEntrevista)).BeginInit();
            this.SuspendLayout();
            // 
            // inputCuil
            // 
            this.inputCuil.Location = new System.Drawing.Point(50, 12);
            this.inputCuil.Name = "inputCuil";
            this.inputCuil.Size = new System.Drawing.Size(100, 23);
            this.inputCuil.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuil";
            // 
            // btnFirmarLD
            // 
            this.btnFirmarLD.Location = new System.Drawing.Point(709, 475);
            this.btnFirmarLD.Name = "btnFirmarLD";
            this.btnFirmarLD.Size = new System.Drawing.Size(75, 23);
            this.btnFirmarLD.TabIndex = 3;
            this.btnFirmarLD.Text = "Firmar";
            this.btnFirmarLD.UseVisualStyleBackColor = true;
            this.btnFirmarLD.Click += new System.EventHandler(this.btnFirmar_Click);
            // 
            // dataLD
            // 
            this.dataLD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLD.Location = new System.Drawing.Point(9, 31);
            this.dataLD.Name = "dataLD";
            this.dataLD.ReadOnly = true;
            this.dataLD.RowTemplate.Height = 25;
            this.dataLD.Size = new System.Drawing.Size(776, 193);
            this.dataLD.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Legajo Digital";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Firma Digital";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(694, 702);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(0, 15);
            this.labelEstado.TabIndex = 11;
            // 
            // btnConsultarLD
            // 
            this.btnConsultarLD.Location = new System.Drawing.Point(628, 475);
            this.btnConsultarLD.Name = "btnConsultarLD";
            this.btnConsultarLD.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarLD.TabIndex = 12;
            this.btnConsultarLD.Text = "Consultar";
            this.btnConsultarLD.UseVisualStyleBackColor = true;
            this.btnConsultarLD.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 543);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dataFirma);
            this.tabPage1.Controls.Add(this.btnConsultarLD);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnFirmarLD);
            this.tabPage1.Controls.Add(this.dataLD);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Legajo Digital";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataFirma
            // 
            this.dataFirma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFirma.Location = new System.Drawing.Point(11, 259);
            this.dataFirma.Name = "dataFirma";
            this.dataFirma.ReadOnly = true;
            this.dataFirma.RowTemplate.Height = 25;
            this.dataFirma.Size = new System.Drawing.Size(776, 188);
            this.dataFirma.TabIndex = 0;
            this.dataFirma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Test_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.dataInstancia);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textInstanciaSelected);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textUsuarioSelected);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dataUsuarios);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dataEntrevista);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnCambiarUsuario);
            this.tabPage2.Controls.Add(this.btnConsultarCandidatos);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Usuarios Candidatos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(438, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Instancia";
            // 
            // dataInstancia
            // 
            this.dataInstancia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataInstancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInstancia.Location = new System.Drawing.Point(438, 30);
            this.dataInstancia.Name = "dataInstancia";
            this.dataInstancia.ReadOnly = true;
            this.dataInstancia.RowTemplate.Height = 25;
            this.dataInstancia.Size = new System.Drawing.Size(165, 415);
            this.dataInstancia.TabIndex = 22;
            this.dataInstancia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataInstancia_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Instancia Seleccionada:";
            // 
            // textInstanciaSelected
            // 
            this.textInstanciaSelected.Enabled = false;
            this.textInstanciaSelected.Location = new System.Drawing.Point(148, 451);
            this.textInstanciaSelected.Name = "textInstanciaSelected";
            this.textInstanciaSelected.ReadOnly = true;
            this.textInstanciaSelected.Size = new System.Drawing.Size(100, 23);
            this.textInstanciaSelected.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 488);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Usuario Seleccionado: ";
            // 
            // textUsuarioSelected
            // 
            this.textUsuarioSelected.Enabled = false;
            this.textUsuarioSelected.Location = new System.Drawing.Point(148, 480);
            this.textUsuarioSelected.Name = "textUsuarioSelected";
            this.textUsuarioSelected.ReadOnly = true;
            this.textUsuarioSelected.Size = new System.Drawing.Size(100, 23);
            this.textUsuarioSelected.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Usuarios Candidatos";
            // 
            // dataUsuarios
            // 
            this.dataUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsuarios.Location = new System.Drawing.Point(609, 30);
            this.dataUsuarios.Name = "dataUsuarios";
            this.dataUsuarios.ReadOnly = true;
            this.dataUsuarios.RowTemplate.Height = 25;
            this.dataUsuarios.Size = new System.Drawing.Size(171, 415);
            this.dataUsuarios.TabIndex = 7;
            this.dataUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUsuarios_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado Entrevista";
            // 
            // dataEntrevista
            // 
            this.dataEntrevista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEntrevista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEntrevista.Location = new System.Drawing.Point(6, 30);
            this.dataEntrevista.Name = "dataEntrevista";
            this.dataEntrevista.ReadOnly = true;
            this.dataEntrevista.RowTemplate.Height = 25;
            this.dataEntrevista.Size = new System.Drawing.Size(399, 415);
            this.dataEntrevista.TabIndex = 5;
            this.dataEntrevista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEntrevista_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cambiar a Usuario Candidato";
            // 
            // btnCambiarUsuario
            // 
            this.btnCambiarUsuario.Location = new System.Drawing.Point(705, 474);
            this.btnCambiarUsuario.Name = "btnCambiarUsuario";
            this.btnCambiarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarUsuario.TabIndex = 2;
            this.btnCambiarUsuario.Text = "Cambiar";
            this.btnCambiarUsuario.UseVisualStyleBackColor = true;
            this.btnCambiarUsuario.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConsultarCandidatos
            // 
            this.btnConsultarCandidatos.Location = new System.Drawing.Point(624, 475);
            this.btnConsultarCandidatos.Name = "btnConsultarCandidatos";
            this.btnConsultarCandidatos.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCandidatos.TabIndex = 1;
            this.btnConsultarCandidatos.Text = "Consultar";
            this.btnConsultarCandidatos.UseVisualStyleBackColor = true;
            this.btnConsultarCandidatos.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataBridger);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.richResultado_bridger);
            this.tabPage3.Controls.Add(this.btnConsultarBridger);
            this.tabPage3.Controls.Add(this.btnInsertarBridger);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 515);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "BridgerInsight";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dataBridger
            // 
            this.dataBridger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBridger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBridger.Location = new System.Drawing.Point(25, 148);
            this.dataBridger.Name = "dataBridger";
            this.dataBridger.ReadOnly = true;
            this.dataBridger.RowTemplate.Height = 25;
            this.dataBridger.Size = new System.Drawing.Size(759, 364);
            this.dataBridger.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Consola:";
            // 
            // richResultado_bridger
            // 
            this.richResultado_bridger.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.richResultado_bridger.Location = new System.Drawing.Point(148, 32);
            this.richResultado_bridger.Name = "richResultado_bridger";
            this.richResultado_bridger.ReadOnly = true;
            this.richResultado_bridger.Size = new System.Drawing.Size(636, 96);
            this.richResultado_bridger.TabIndex = 19;
            this.richResultado_bridger.Text = "";
            // 
            // btnConsultarBridger
            // 
            this.btnConsultarBridger.Location = new System.Drawing.Point(49, 32);
            this.btnConsultarBridger.Name = "btnConsultarBridger";
            this.btnConsultarBridger.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarBridger.TabIndex = 18;
            this.btnConsultarBridger.Text = "Consultar";
            this.btnConsultarBridger.UseVisualStyleBackColor = true;
            this.btnConsultarBridger.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInsertarBridger
            // 
            this.btnInsertarBridger.Location = new System.Drawing.Point(49, 76);
            this.btnInsertarBridger.Name = "btnInsertarBridger";
            this.btnInsertarBridger.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarBridger.TabIndex = 17;
            this.btnInsertarBridger.Text = "Insertar";
            this.btnInsertarBridger.UseVisualStyleBackColor = true;
            this.btnInsertarBridger.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.textBoxBusquedaSector);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.textBoxBusquedaUsr);
            this.tabPage4.Controls.Add(this.buttonBuscarUsuario);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.textBoxBusquedaUsuario);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.textBoxSector);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.textBoxUsuario);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.dataGridUsuario);
            this.tabPage4.Controls.Add(this.dataGridSector);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(791, 515);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Usuarios";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(707, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(527, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 15);
            this.label21.TabIndex = 33;
            this.label21.Text = "Buscar Sector:";
            // 
            // textBoxBusquedaSector
            // 
            this.textBoxBusquedaSector.Location = new System.Drawing.Point(527, 64);
            this.textBoxBusquedaSector.Name = "textBoxBusquedaSector";
            this.textBoxBusquedaSector.Size = new System.Drawing.Size(255, 23);
            this.textBoxBusquedaSector.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(527, 204);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 15);
            this.label20.TabIndex = 31;
            this.label20.Text = "Buscar por Usuario:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(707, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // textBoxBusquedaUsr
            // 
            this.textBoxBusquedaUsr.Location = new System.Drawing.Point(527, 225);
            this.textBoxBusquedaUsr.Name = "textBoxBusquedaUsr";
            this.textBoxBusquedaUsr.Size = new System.Drawing.Size(255, 23);
            this.textBoxBusquedaUsr.TabIndex = 29;
            // 
            // buttonBuscarUsuario
            // 
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(707, 165);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarUsuario.TabIndex = 28;
            this.buttonBuscarUsuario.Text = "Buscar";
            this.buttonBuscarUsuario.UseVisualStyleBackColor = true;
            this.buttonBuscarUsuario.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(527, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Buscar por Nombre/Apellido:";
            // 
            // textBoxBusquedaUsuario
            // 
            this.textBoxBusquedaUsuario.Location = new System.Drawing.Point(527, 136);
            this.textBoxBusquedaUsuario.Name = "textBoxBusquedaUsuario";
            this.textBoxBusquedaUsuario.Size = new System.Drawing.Size(255, 23);
            this.textBoxBusquedaUsuario.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(544, 362);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 15);
            this.label18.TabIndex = 25;
            this.label18.Text = "Sector Seleccionado: ";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // textBoxSector
            // 
            this.textBoxSector.Enabled = false;
            this.textBoxSector.Location = new System.Drawing.Point(545, 380);
            this.textBoxSector.Name = "textBoxSector";
            this.textBoxSector.ReadOnly = true;
            this.textBoxSector.Size = new System.Drawing.Size(239, 23);
            this.textBoxSector.TabIndex = 24;
            this.textBoxSector.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Listar Todos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(261, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 22;
            this.label17.Text = "Usuarios";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(545, 420);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 15);
            this.label16.TabIndex = 21;
            this.label16.Text = "Usuario Seleccionado: ";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(684, 420);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 23);
            this.textBoxUsuario.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cambiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridUsuario
            // 
            this.dataGridUsuario.AllowUserToAddRows = false;
            this.dataGridUsuario.AllowUserToDeleteRows = false;
            this.dataGridUsuario.AllowUserToResizeColumns = false;
            this.dataGridUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuario.ColumnHeadersVisible = false;
            this.dataGridUsuario.Location = new System.Drawing.Point(261, 33);
            this.dataGridUsuario.MultiSelect = false;
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.ReadOnly = true;
            this.dataGridUsuario.RowHeadersVisible = false;
            this.dataGridUsuario.RowTemplate.Height = 25;
            this.dataGridUsuario.Size = new System.Drawing.Size(240, 476);
            this.dataGridUsuario.TabIndex = 3;
            this.dataGridUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuario_CellContentClick);
            // 
            // dataGridSector
            // 
            this.dataGridSector.AllowUserToAddRows = false;
            this.dataGridSector.AllowUserToDeleteRows = false;
            this.dataGridSector.AllowUserToResizeColumns = false;
            this.dataGridSector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSector.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSector.ColumnHeadersVisible = false;
            this.dataGridSector.Location = new System.Drawing.Point(6, 33);
            this.dataGridSector.MultiSelect = false;
            this.dataGridSector.Name = "dataGridSector";
            this.dataGridSector.ReadOnly = true;
            this.dataGridSector.RowHeadersVisible = false;
            this.dataGridSector.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridSector.RowTemplate.Height = 25;
            this.dataGridSector.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSector.Size = new System.Drawing.Size(240, 447);
            this.dataGridSector.TabIndex = 2;
            this.dataGridSector.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSector_CellContentClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Sectores";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button5);
            this.tabPage6.Controls.Add(this.dataHistoriaEntrevista);
            this.tabPage6.Controls.Add(this.label28);
            this.tabPage6.Controls.Add(this.button7);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(791, 515);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Entrevista";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(709, 486);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Setear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // dataHistoriaEntrevista
            // 
            this.dataHistoriaEntrevista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistoriaEntrevista.Location = new System.Drawing.Point(6, 32);
            this.dataHistoriaEntrevista.Name = "dataHistoriaEntrevista";
            this.dataHistoriaEntrevista.RowTemplate.Height = 25;
            this.dataHistoriaEntrevista.Size = new System.Drawing.Size(778, 448);
            this.dataHistoriaEntrevista.TabIndex = 9;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(7, 14);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(127, 15);
            this.label28.TabIndex = 8;
            this.label28.Text = "Estado de la Entrevista:";
            this.label28.Click += new System.EventHandler(this.label28_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(628, 486);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Consultar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Entrevista Nro";
            // 
            // inputEntrevista
            // 
            this.inputEntrevista.Location = new System.Drawing.Point(251, 12);
            this.inputEntrevista.Name = "inputEntrevista";
            this.inputEntrevista.Size = new System.Drawing.Size(100, 23);
            this.inputEntrevista.TabIndex = 0;
            // 
            // inputUsuario
            // 
            this.inputUsuario.Enabled = false;
            this.inputUsuario.Location = new System.Drawing.Point(454, 12);
            this.inputUsuario.Name = "inputUsuario";
            this.inputUsuario.Size = new System.Drawing.Size(100, 23);
            this.inputUsuario.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(364, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Usuario Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fecha BT";
            // 
            // txtFechaBT
            // 
            this.txtFechaBT.AutoSize = true;
            this.txtFechaBT.Location = new System.Drawing.Point(739, 12);
            this.txtFechaBT.Name = "txtFechaBT";
            this.txtFechaBT.Size = new System.Drawing.Size(38, 15);
            this.txtFechaBT.TabIndex = 25;
            this.txtFechaBT.Text = "Fecha";
            this.txtFechaBT.Click += new System.EventHandler(this.txtFechaBT_Click);
            // 
            // radioButtonQA
            // 
            this.radioButtonQA.AutoSize = true;
            this.radioButtonQA.Checked = true;
            this.radioButtonQA.Location = new System.Drawing.Point(578, 13);
            this.radioButtonQA.Name = "radioButtonQA";
            this.radioButtonQA.Size = new System.Drawing.Size(42, 19);
            this.radioButtonQA.TabIndex = 27;
            this.radioButtonQA.TabStop = true;
            this.radioButtonQA.Text = "QA";
            this.radioButtonQA.UseVisualStyleBackColor = true;
            this.radioButtonQA.CheckedChanged += new System.EventHandler(this.radioButtonQA_CheckedChanged);
            // 
            // radioButtonDF
            // 
            this.radioButtonDF.AutoSize = true;
            this.radioButtonDF.Location = new System.Drawing.Point(626, 13);
            this.radioButtonDF.Name = "radioButtonDF";
            this.radioButtonDF.Size = new System.Drawing.Size(39, 19);
            this.radioButtonDF.TabIndex = 28;
            this.radioButtonDF.Text = "DF";
            this.radioButtonDF.UseVisualStyleBackColor = true;
            this.radioButtonDF.CheckedChanged += new System.EventHandler(this.radioButtonDF_CheckedChanged);
            // 
            // richConsola
            // 
            this.richConsola.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richConsola.Location = new System.Drawing.Point(12, 635);
            this.richConsola.Name = "richConsola";
            this.richConsola.ReadOnly = true;
            this.richConsola.Size = new System.Drawing.Size(795, 74);
            this.richConsola.TabIndex = 29;
            this.richConsola.Text = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 614);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 15);
            this.label19.TabIndex = 30;
            this.label19.Text = "Consola";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 719);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.richConsola);
            this.Controls.Add(this.radioButtonDF);
            this.Controls.Add(this.radioButtonQA);
            this.Controls.Add(this.txtFechaBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.inputUsuario);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.inputCuil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputEntrevista);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(828, 758);
            this.MinimumSize = new System.Drawing.Size(828, 658);
            this.Name = "Form1";
            this.Text = "QA/DF BT Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLD)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFirma)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInstancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntrevista)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBridger)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSector)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoriaEntrevista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputCuil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFirmarLD;
        private System.Windows.Forms.DataGridView dataLD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button btnConsultarLD;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataFirma;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataUsuarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataEntrevista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCambiarUsuario;
        private System.Windows.Forms.Button btnConsultarCandidatos;
        private System.Windows.Forms.TextBox inputEntrevista;
        private System.Windows.Forms.TextBox textUsuarioSelected;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richResultado_bridger;
        private System.Windows.Forms.Button btnConsultarBridger;
        private System.Windows.Forms.Button btnInsertarBridger;
        private System.Windows.Forms.DataGridView dataBridger;
        private System.Windows.Forms.TextBox inputUsuario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtFechaBT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textInstanciaSelected;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataInstancia;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.DataGridView dataGridSector;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxSector;
        private System.Windows.Forms.RadioButton radioButtonQA;
        private System.Windows.Forms.RadioButton radioButtonDF;
        private System.Windows.Forms.RichTextBox richConsola;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonBuscarUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBusquedaUsuario;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxBusquedaUsr;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxBusquedaSector;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataHistoriaEntrevista;
        private System.Windows.Forms.Button button5;
    }

}