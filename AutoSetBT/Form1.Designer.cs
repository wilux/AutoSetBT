
namespace AutoSetBT
{
    partial class Form1
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
            this.inputCuil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFirmarLD = new System.Windows.Forms.Button();
            this.dataLD = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.btnConsultarLD = new System.Windows.Forms.Button();
            this.richResultado = new System.Windows.Forms.RichTextBox();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataFirma = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.dataInstancia = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.textInstanciaSelected = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richResultado_candidatos = new System.Windows.Forms.RichTextBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.inputEntrevista = new System.Windows.Forms.TextBox();
            this.inputUsuario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaBT = new System.Windows.Forms.Label();
            this.btnUsuarioAnterior = new System.Windows.Forms.Button();
            this.comboBoxEntorno = new System.Windows.Forms.ComboBox();
            this.richResultado_usuarios = new System.Windows.Forms.RichTextBox();
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
            this.btnFirmarLD.Location = new System.Drawing.Point(23, 68);
            this.btnFirmarLD.Name = "btnFirmarLD";
            this.btnFirmarLD.Size = new System.Drawing.Size(75, 23);
            this.btnFirmarLD.TabIndex = 3;
            this.btnFirmarLD.Text = "Firmar";
            this.btnFirmarLD.UseVisualStyleBackColor = true;
            this.btnFirmarLD.Click += new System.EventHandler(this.btnFirmar_Click);
            // 
            // dataLD
            // 
            this.dataLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLD.Location = new System.Drawing.Point(4, 141);
            this.dataLD.Name = "dataLD";
            this.dataLD.RowTemplate.Height = 25;
            this.dataLD.Size = new System.Drawing.Size(776, 150);
            this.dataLD.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Legajo Digital";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 306);
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
            this.btnConsultarLD.Location = new System.Drawing.Point(23, 39);
            this.btnConsultarLD.Name = "btnConsultarLD";
            this.btnConsultarLD.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarLD.TabIndex = 12;
            this.btnConsultarLD.Text = "Consultar";
            this.btnConsultarLD.UseVisualStyleBackColor = true;
            this.btnConsultarLD.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // richResultado
            // 
            this.richResultado.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.richResultado.Location = new System.Drawing.Point(115, 24);
            this.richResultado.Name = "richResultado";
            this.richResultado.ReadOnly = true;
            this.richResultado.Size = new System.Drawing.Size(667, 96);
            this.richResultado.TabIndex = 13;
            this.richResultado.Text = "";
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.Location = new System.Drawing.Point(115, 6);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(53, 15);
            this.label_Resultado.TabIndex = 14;
            this.label_Resultado.Text = "Consola:";
            // 
            // tabControl1
            // 
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
            this.tabPage1.Controls.Add(this.label_Resultado);
            this.tabPage1.Controls.Add(this.dataFirma);
            this.tabPage1.Controls.Add(this.richResultado);
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
            this.dataFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFirma.Location = new System.Drawing.Point(6, 324);
            this.dataFirma.Name = "dataFirma";
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
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.richResultado_candidatos);
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
            this.label14.Location = new System.Drawing.Point(438, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Instancia";
            // 
            // dataInstancia
            // 
            this.dataInstancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInstancia.Location = new System.Drawing.Point(438, 182);
            this.dataInstancia.Name = "dataInstancia";
            this.dataInstancia.RowTemplate.Height = 25;
            this.dataInstancia.Size = new System.Drawing.Size(165, 333);
            this.dataInstancia.TabIndex = 22;
            this.dataInstancia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataInstancia_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(241, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Instancia Seleccionada:";
            // 
            // textInstanciaSelected
            // 
            this.textInstanciaSelected.Location = new System.Drawing.Point(384, 130);
            this.textInstanciaSelected.Name = "textInstanciaSelected";
            this.textInstanciaSelected.ReadOnly = true;
            this.textInstanciaSelected.Size = new System.Drawing.Size(100, 23);
            this.textInstanciaSelected.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(537, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Usuario Seleccionado: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Consola:";
            // 
            // richResultado_candidatos
            // 
            this.richResultado_candidatos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.richResultado_candidatos.Location = new System.Drawing.Point(203, 35);
            this.richResultado_candidatos.Name = "richResultado_candidatos";
            this.richResultado_candidatos.ReadOnly = true;
            this.richResultado_candidatos.Size = new System.Drawing.Size(582, 84);
            this.richResultado_candidatos.TabIndex = 15;
            this.richResultado_candidatos.Text = "";
            // 
            // textUsuarioSelected
            // 
            this.textUsuarioSelected.Location = new System.Drawing.Point(680, 125);
            this.textUsuarioSelected.Name = "textUsuarioSelected";
            this.textUsuarioSelected.ReadOnly = true;
            this.textUsuarioSelected.Size = new System.Drawing.Size(100, 23);
            this.textUsuarioSelected.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Usuarios Candidatos";
            // 
            // dataUsuarios
            // 
            this.dataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsuarios.Location = new System.Drawing.Point(609, 182);
            this.dataUsuarios.Name = "dataUsuarios";
            this.dataUsuarios.RowTemplate.Height = 25;
            this.dataUsuarios.Size = new System.Drawing.Size(171, 330);
            this.dataUsuarios.TabIndex = 7;
            this.dataUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUsuarios_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado Entrevista";
            // 
            // dataEntrevista
            // 
            this.dataEntrevista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEntrevista.Location = new System.Drawing.Point(6, 182);
            this.dataEntrevista.Name = "dataEntrevista";
            this.dataEntrevista.RowTemplate.Height = 25;
            this.dataEntrevista.Size = new System.Drawing.Size(399, 333);
            this.dataEntrevista.TabIndex = 5;
            this.dataEntrevista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEntrevista_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cambiar a Usuario Candidato";
            // 
            // btnCambiarUsuario
            // 
            this.btnCambiarUsuario.Location = new System.Drawing.Point(34, 82);
            this.btnCambiarUsuario.Name = "btnCambiarUsuario";
            this.btnCambiarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarUsuario.TabIndex = 2;
            this.btnCambiarUsuario.Text = "Cambiar";
            this.btnCambiarUsuario.UseVisualStyleBackColor = true;
            this.btnCambiarUsuario.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConsultarCandidatos
            // 
            this.btnConsultarCandidatos.Location = new System.Drawing.Point(34, 35);
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
            this.dataBridger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBridger.Location = new System.Drawing.Point(25, 148);
            this.dataBridger.Name = "dataBridger";
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
            this.tabPage4.Controls.Add(this.richResultado_usuarios);
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(545, 378);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 15);
            this.label18.TabIndex = 25;
            this.label18.Text = "Sector Seleccionado: ";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // textBoxSector
            // 
            this.textBoxSector.Enabled = false;
            this.textBoxSector.Location = new System.Drawing.Point(684, 378);
            this.textBoxSector.Name = "textBoxSector";
            this.textBoxSector.ReadOnly = true;
            this.textBoxSector.Size = new System.Drawing.Size(100, 23);
            this.textBoxSector.TabIndex = 24;
            this.textBoxSector.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Consultar";
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
            this.textBoxUsuario.Enabled = false;
            this.textBoxUsuario.Location = new System.Drawing.Point(684, 420);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.ReadOnly = true;
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
            this.dataGridUsuario.Name = "dataGridUsuario";
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
            this.dataGridSector.Name = "dataGridSector";
            this.dataGridSector.RowHeadersVisible = false;
            this.dataGridSector.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridSector.RowTemplate.Height = 25;
            this.dataGridSector.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSector.Size = new System.Drawing.Size(240, 476);
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
            // btnUsuarioAnterior
            // 
            this.btnUsuarioAnterior.Location = new System.Drawing.Point(560, 11);
            this.btnUsuarioAnterior.Name = "btnUsuarioAnterior";
            this.btnUsuarioAnterior.Size = new System.Drawing.Size(104, 23);
            this.btnUsuarioAnterior.TabIndex = 26;
            this.btnUsuarioAnterior.Text = "Usuario Anterior";
            this.btnUsuarioAnterior.UseVisualStyleBackColor = true;
            this.btnUsuarioAnterior.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBoxEntorno
            // 
            this.comboBoxEntorno.AutoCompleteCustomSource.AddRange(new string[] {
            "QA"});
            this.comboBoxEntorno.FormattingEnabled = true;
            this.comboBoxEntorno.Items.AddRange(new object[] {
            "QA"});
            this.comboBoxEntorno.Location = new System.Drawing.Point(680, 31);
            this.comboBoxEntorno.Name = "comboBoxEntorno";
            this.comboBoxEntorno.Size = new System.Drawing.Size(121, 23);
            this.comboBoxEntorno.TabIndex = 27;
            // 
            // richResultado_usuarios
            // 
            this.richResultado_usuarios.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.richResultado_usuarios.Location = new System.Drawing.Point(522, 92);
            this.richResultado_usuarios.Name = "richResultado_usuarios";
            this.richResultado_usuarios.ReadOnly = true;
            this.richResultado_usuarios.Size = new System.Drawing.Size(267, 252);
            this.richResultado_usuarios.TabIndex = 26;
            this.richResultado_usuarios.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 619);
            this.Controls.Add(this.comboBoxEntorno);
            this.Controls.Add(this.btnUsuarioAnterior);
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
            this.MaximumSize = new System.Drawing.Size(828, 658);
            this.MinimumSize = new System.Drawing.Size(828, 658);
            this.Name = "Form1";
            this.Text = "QA BT Tools";
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
        private System.Windows.Forms.RichTextBox richResultado;
        private System.Windows.Forms.Label label_Resultado;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richResultado_candidatos;
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
        private System.Windows.Forms.Button btnUsuarioAnterior;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.DataGridView dataGridSector;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxEntorno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxSector;
        private System.Windows.Forms.RichTextBox richResultado_usuarios;
    }

}