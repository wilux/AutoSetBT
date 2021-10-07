
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFirmar = new System.Windows.Forms.Button();
            this.dataLD = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.richResultado = new System.Windows.Forms.RichTextBox();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataFirma = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.textUsuarioSelected = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richResultado_candidatos = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataUsuarios = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dataEntrevista = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.inputEntrevista = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataLD)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFirma)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntrevista)).BeginInit();
            this.SuspendLayout();
            // 
            // inputCuil
            // 
            this.inputCuil.Location = new System.Drawing.Point(40, 30);
            this.inputCuil.Name = "inputCuil";
            this.inputCuil.Size = new System.Drawing.Size(100, 23);
            this.inputCuil.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Completar Legajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuil";
            // 
            // btnFirmar
            // 
            this.btnFirmar.Location = new System.Drawing.Point(87, 74);
            this.btnFirmar.Name = "btnFirmar";
            this.btnFirmar.Size = new System.Drawing.Size(75, 23);
            this.btnFirmar.TabIndex = 3;
            this.btnFirmar.Text = "Firmar";
            this.btnFirmar.UseVisualStyleBackColor = true;
            this.btnFirmar.Click += new System.EventHandler(this.btnFirmar_Click);
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
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(6, 74);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // richResultado
            // 
            this.richResultado.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.richResultado.Location = new System.Drawing.Point(200, 24);
            this.richResultado.Name = "richResultado";
            this.richResultado.ReadOnly = true;
            this.richResultado.Size = new System.Drawing.Size(582, 96);
            this.richResultado.TabIndex = 13;
            this.richResultado.Text = "";
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.Location = new System.Drawing.Point(200, 6);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(53, 15);
            this.label_Resultado.TabIndex = 14;
            this.label_Resultado.Text = "Consola:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 595);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label_Resultado);
            this.tabPage1.Controls.Add(this.dataFirma);
            this.tabPage1.Controls.Add(this.richResultado);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnConsultar);
            this.tabPage1.Controls.Add(this.inputCuil);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnFirmar);
            this.tabPage1.Controls.Add(this.dataLD);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 567);
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
            this.dataFirma.Size = new System.Drawing.Size(776, 212);
            this.dataFirma.TabIndex = 0;
            this.dataFirma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Test_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textUsuarioSelected);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.richResultado_candidatos);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dataUsuarios);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dataEntrevista);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.inputEntrevista);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Usuarios Candidatos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(548, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Usuario Seleccionado: ";
            // 
            // textUsuarioSelected
            // 
            this.textUsuarioSelected.Location = new System.Drawing.Point(680, 126);
            this.textUsuarioSelected.Name = "textUsuarioSelected";
            this.textUsuarioSelected.ReadOnly = true;
            this.textUsuarioSelected.Size = new System.Drawing.Size(100, 23);
            this.textUsuarioSelected.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Consola:";
            // 
            // richResultado_candidatos
            // 
            this.richResultado_candidatos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.richResultado_candidatos.Location = new System.Drawing.Point(203, 23);
            this.richResultado_candidatos.Name = "richResultado_candidatos";
            this.richResultado_candidatos.ReadOnly = true;
            this.richResultado_candidatos.Size = new System.Drawing.Size(582, 96);
            this.richResultado_candidatos.TabIndex = 15;
            this.richResultado_candidatos.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Usuarios Candidatos";
            // 
            // dataUsuarios
            // 
            this.dataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsuarios.Location = new System.Drawing.Point(518, 182);
            this.dataUsuarios.Name = "dataUsuarios";
            this.dataUsuarios.RowTemplate.Height = 25;
            this.dataUsuarios.Size = new System.Drawing.Size(262, 362);
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
            this.dataEntrevista.Size = new System.Drawing.Size(478, 362);
            this.dataEntrevista.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Entrevista Nro";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cambiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputEntrevista
            // 
            this.inputEntrevista.Location = new System.Drawing.Point(94, 37);
            this.inputEntrevista.Name = "inputEntrevista";
            this.inputEntrevista.Size = new System.Drawing.Size(100, 23);
            this.inputEntrevista.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 619);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelEstado);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(828, 658);
            this.MinimumSize = new System.Drawing.Size(828, 658);
            this.Name = "Form1";
            this.Text = "QA BT Tools";
            ((System.ComponentModel.ISupportInitialize)(this.dataLD)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFirma)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntrevista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputCuil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFirmar;
        private System.Windows.Forms.DataGridView dataLD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button btnConsultar;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputEntrevista;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richResultado_candidatos;
        private System.Windows.Forms.TextBox textUsuarioSelected;
        private System.Windows.Forms.Label label11;
    }

}