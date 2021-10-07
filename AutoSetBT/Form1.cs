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
            if (inputCuil.Text != "")
            {
                richResultado.Text = "";
                richResultado.Text = LegajoDigital.Completar(inputCuil.Text);
            }
            else
            {
                richResultado.Text = "Debe ingresar un CUIL";
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           
            string db_LegajoDigital = "LegajoDigital_QA";
            string db_Firma = "FirmaGrafometrica_QA";
            if (inputCuil.Text != "")
            {
                string sql_lg = $"select *  from TRAMITE where idPersona in (select idPersona from PERSONA where CuitCuil = '{inputCuil.Text}')";
                string sql_firma = $"select *  from TRAMITE where CuitCuil = '{inputCuil.Text}' and activo = 1";

                DataSet legajo = DB.ObtenerDatos(sql_lg, db_LegajoDigital);
                DataSet firma = DB.ObtenerDatos(sql_firma, db_Firma);

                richResultado.Text = "";
                richResultado.Text = Environment.NewLine + sql_lg + Environment.NewLine + sql_firma;

                dataLD.DataSource = legajo.Tables[0];
                dataFirma.DataSource = firma.Tables[0];
            }
            else
            {
                richResultado.Text = "Debe ingresar un CUIL";
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Test_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputEntrevista.Text != "")
            {
                richResultado_candidatos.Text = "";
                string sql_Entrevista = $"select c.WFAttSVal Entrevista,b.WFTaskName,c.WFInsPrcId, WFItemUsrCod, a.WFTaskCod from wfwrkitems a (nolock) inner join wftask b (nolock) on a.WFTaskCod=b.WFTaskCod and b.WFPrcId in(9,10,13) inner join wfattsvalues c (nolock) on a.WFInsPrcId=c.WFInsPrcId and c.WFAttSId='ENTREVISTA' and c.WFAttSVal in('{inputEntrevista.Text}.0000') order by b.WFTasKCod desc";
                string sql_WFInsPrcId = $"select  top 1 c.WFInsPrcId from wfwrkitems a (nolock) inner join wftask b (nolock) on a.WFTaskCod=b.WFTaskCod and b.WFPrcId in(9,10,13) inner join wfattsvalues c (nolock) on a.WFInsPrcId=c.WFInsPrcId and c.WFAttSId='ENTREVISTA' and c.WFAttSVal in('{inputEntrevista.Text}.0000') order by b.WFTasKCod desc";
                
                DataSet entrevista = DB.ObtenerDatos(sql_Entrevista);
                string WFInsPrcId = DB.ObtenerValorCampo(sql_WFInsPrcId, "WFInsPrcId");

                dataEntrevista.DataSource = entrevista.Tables[0];

                string sql_Candidatos = $"select WFWrkLstUsrCod as Usuarios from WFWORKLIST  (nolock) where WFWrkLstItemId in(select wfitemid from WFWRKITEMS where   WFInsPrcId = {WFInsPrcId})";
                DataSet candidatos = DB.ObtenerDatos(sql_Candidatos);

                dataUsuarios.DataSource = candidatos.Tables[0];

                

                richResultado_candidatos.Text = Environment.NewLine + sql_Entrevista + Environment.NewLine + sql_Candidatos;

            }
            else
            {
                richResultado_candidatos.Text = "Debe ingresar nro Entrevista";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textUsuarioSelected.Text !="")
            {
                richResultado_candidatos.Text  = DB.CambiarUsuario(textUsuarioSelected.Text);
            }
            else
            {
                richResultado_candidatos.Text = "Debe seleccionar un usuario candidato";
            }
        }



        private void dataUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textUsuarioSelected.Text = (string)dataUsuarios.CurrentCell.Value;
        }
    }
}
