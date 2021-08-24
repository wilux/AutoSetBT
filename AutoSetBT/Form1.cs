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
            //LegajoDigital.Completar(inputCuil.Text);

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string db_LegajoDigital = "LegajoDigital_QA";
            string db_Firma = "FirmaGrafometrica_QA";

            string sql = $"select *  from TRAMITE where idPersona in (select idPersona from PERSONA where CuitCuil = '{inputCuil.Text}')";

            DataSet a = DB.ObtenerDatos(sql, db_LegajoDigital);

            dataLD.DataSource = a.Tables[0];
        }
    }
}
