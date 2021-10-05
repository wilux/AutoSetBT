using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AutoSetBT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnFirmar_Click(object sender, EventArgs e)
        {
            richResultado.Text = "";
            richResultado.Text = LegajoDigital.Completar(inputCuil.Text);

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string db_LegajoDigital = "LegajoDigital_QA";
            string db_Firma = "FirmaGrafometrica_QA";

            string sql_lg = $"select *  from TRAMITE where idPersona in (select idPersona from PERSONA where CuitCuil = '{inputCuil.Text}')";
            string sql_firma = $"select *  from TRAMITE where CuitCuil = '{inputCuil.Text}' and activo = 1";
            DataSet legajo = DB.ObtenerDatos(sql_lg, db_LegajoDigital);
            DataSet firma = DB.ObtenerDatos(sql_firma, db_Firma);

            richResultado.Text = "";
            richResultado.Text = Environment.NewLine + sql_lg + Environment.NewLine + sql_firma;

            dataLD.DataSource = legajo.Tables[0];
            dataFirma.DataSource = firma.Tables[0];
        }

    }
}
