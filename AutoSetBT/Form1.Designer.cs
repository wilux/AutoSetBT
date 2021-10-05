
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
            this.dataFirma = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.richResultado = new System.Windows.Forms.RichTextBox();
            this.label_Resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // inputCuil
            // 
            this.inputCuil.Location = new System.Drawing.Point(46, 36);
            this.inputCuil.Name = "inputCuil";
            this.inputCuil.Size = new System.Drawing.Size(100, 23);
            this.inputCuil.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Completar Legajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuil";
            // 
            // btnFirmar
            // 
            this.btnFirmar.Location = new System.Drawing.Point(93, 80);
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
            this.dataLD.Location = new System.Drawing.Point(12, 147);
            this.dataLD.Name = "dataLD";
            this.dataLD.RowTemplate.Height = 25;
            this.dataLD.Size = new System.Drawing.Size(776, 150);
            this.dataLD.TabIndex = 5;
            // 
            // dataFirma
            // 
            this.dataFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFirma.Location = new System.Drawing.Point(10, 342);
            this.dataFirma.Name = "dataFirma";
            this.dataFirma.RowTemplate.Height = 25;
            this.dataFirma.Size = new System.Drawing.Size(776, 150);
            this.dataFirma.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Legajo Digital";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 324);
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
            this.btnConsultar.Location = new System.Drawing.Point(12, 80);
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
            this.richResultado.Location = new System.Drawing.Point(204, 45);
            this.richResultado.Name = "richResultado";
            this.richResultado.ReadOnly = true;
            this.richResultado.Size = new System.Drawing.Size(582, 96);
            this.richResultado.TabIndex = 13;
            this.richResultado.Text = "";
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.Location = new System.Drawing.Point(204, 27);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(111, 15);
            this.label_Resultado.TabIndex = 14;
            this.label_Resultado.Text = "Consulta Ejecutada:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 505);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.richResultado);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataFirma);
            this.Controls.Add(this.dataLD);
            this.Controls.Add(this.btnFirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputCuil);
            this.Name = "Form1";
            this.Text = "QA CompletarLegajo";
            ((System.ComponentModel.ISupportInitialize)(this.dataLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFirma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputCuil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFirmar;
        private System.Windows.Forms.DataGridView dataLD;
        private System.Windows.Forms.DataGridView dataFirma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RichTextBox richResultado;
        private System.Windows.Forms.Label label_Resultado;
    }
}

