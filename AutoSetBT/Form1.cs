using System;
using System.Data;
using System.Windows.Forms;

namespace AutoSetBT
{
    public partial class Form1 : Form
    {
        string usuarioActual = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void UsuarioActual()
        {
            //usuarioActual

            string sql_CurrentUser = $"select J055XZUsr from J055XZ where J055XZUad='{Environment.UserName}'";
            usuarioActual = DB.ObtenerValorCampo(sql_CurrentUser, "J055XZUsr");
            inputUsuario.Text = usuarioActual.Replace(" ", String.Empty);
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
                string sql_Entrevista = $"select c.WFAttSVal Entrevista,b.WFTaskName,c.WFInsPrcId, WFItemUsrCod, a.WFTaskCod from wfwrkitems a (nolock) inner join wftask b (nolock) on a.WFTaskCod=b.WFTaskCod and b.WFPrcId in(9,10,13) inner join wfattsvalues c (nolock) on a.WFInsPrcId=c.WFInsPrcId and c.WFAttSId='ENTREVISTA' and c.WFAttSVal in('{inputEntrevista.Text}.0000')";
                string sql_WFInsPrcId = $"select  top 1 a.WFInsPrcId from wfwrkitems a (nolock) inner join wftask b (nolock) on a.WFTaskCod=b.WFTaskCod and b.WFPrcId in(9,10,13) inner join wfattsvalues c (nolock) on a.WFInsPrcId=c.WFInsPrcId and c.WFAttSId='ENTREVISTA' and c.WFAttSVal in('{inputEntrevista.Text}.0000') order by a.WFInsPrcId desc";
                string sql_Instancia = $"select         a.WFInsPrcId from wfwrkitems a (nolock) inner join wftask b (nolock) on a.WFTaskCod=b.WFTaskCod and b.WFPrcId in(9,10,13) inner join wfattsvalues c (nolock) on a.WFInsPrcId=c.WFInsPrcId and c.WFAttSId='ENTREVISTA' and c.WFAttSVal in('{inputEntrevista.Text}.0000') order by a.WFInsPrcId desc";
                
                DataSet entrevista = DB.ObtenerDatos(sql_Entrevista);
                DataSet instancia = DB.ObtenerDatos(sql_Instancia);

                string WFInsPrcId = DB.ObtenerValorCampo(sql_WFInsPrcId, "WFInsPrcId");

                dataEntrevista.DataSource = entrevista.Tables[0];
                dataInstancia.DataSource = instancia.Tables[0];

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

                //usuarioActual

                //string sql_CurrentUser = $"select J055XZUsr from J055XZ where J055XZUad='{Environment.UserName}'";
                //string usuarioActual = DB.ObtenerValorCampo(sql_CurrentUser, "J055XZUsr");
                //inputUsuario.Text = usuarioActual.Replace(" ", String.Empty);

                UsuarioActual();

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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inputCuil.Text != "")
            {
                richResultado_bridger.Text = "";
                string sql_Bridger = $"select * from    BPNC37 where    BPNC37NID = '{inputCuil.Text}'";


                DataSet bridger = DB.ObtenerDatos(sql_Bridger);

                dataBridger.DataSource = bridger.Tables[0];


                richResultado_bridger.Text = Environment.NewLine + sql_Bridger + Environment.NewLine;

            }
            else
            {
                richResultado_bridger.Text = "Debe ingresar nro Cuil/Cuit";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inputCuil.Text != "" && inputUsuario.Text !="")
            {
                richResultado_bridger.Text = BridgerInsight.Insertar(inputCuil.Text, inputUsuario.Text);
            }
            else
            {
                richResultado_bridger.Text = "Debe escribir un cuil/cuit y ademas el usuario de plataforma";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Fecha BT
            string sql_FechaBT = "select Pgfape from fst017";

            var parsedDate = DateTime.Parse(DB.ObtenerValorCampo(sql_FechaBT, "Pgfape"));

            var fecha = parsedDate.ToString("dd/MM/yyyy");

            txtFechaBT.Text = fecha;

            //usuarioActual

            //string sql_CurrentUser = $"select J055XZUsr from J055XZ where J055XZUad='{Environment.UserName}'";
            //usuarioActual = DB.ObtenerValorCampo(sql_CurrentUser, "J055XZUsr");
            //inputUsuario.Text = usuarioActual.Replace(" ", String.Empty);

            UsuarioActual();

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaBT_Click(object sender, EventArgs e)
        {

        }

        private void dataEntrevista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataInstancia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textInstanciaSelected.Text = (string)dataInstancia.CurrentCell.Value.ToString();

            string sql_Candidatos = $"select WFWrkLstUsrCod as Usuarios from WFWORKLIST  (nolock) where WFWrkLstItemId in(select wfitemid from WFWRKITEMS where   WFInsPrcId = {textInstanciaSelected.Text})";
            DataSet candidatos = DB.ObtenerDatos(sql_Candidatos);

            dataUsuarios.DataSource = candidatos.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
                  DB.CambiarUsuario(usuarioActual);

            //string sql_CurrentUser = $"select J055XZUsr from J055XZ where J055XZUad='{Environment.UserName}'";
            //string usuarioActual2 = DB.ObtenerValorCampo(sql_CurrentUser, "J055XZUsr");
            //inputUsuario.Text = usuarioActual2.Replace(" ", String.Empty);

            UsuarioActual();
        }

        private void EntornoSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //string sql_sectores = $"select distinct DescUnidadOrg Sector_PeopleNet  from WFUSERS1 wf inner join BNQGC23 c23 on wf.WFRstValue = c23.BNQGC23ISE inner join J055XZ xz on wf.WFUsrCod = xz.J055XZUsr inner join PeopleNet_Nomina pn on RIGHT(pn.Legajo, 9) = xz.J055XZLeg where WFRstCod = 'SECTOR' order by Sector_PeopleNet asc";
            string sql_sectores = "select distinct DescUnidadOrg from PeopleNet_Nomina order by DescUnidadOrg";
            richResultado_usuarios.Text = sql_sectores;
            DataSet sectores = DB.ObtenerDatos(sql_sectores);

            dataGridSector.DataSource = sectores.Tables[0];
        }

        private void dataGridSector_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxSector.Text = (string)dataGridSector.CurrentCell.Value.ToString();
            //string sql_usuarios = $"select j055xzusr Usuario_BT  from WFUSERS1 wf inner join BNQGC23 c23 on wf.WFRstValue = c23.BNQGC23ISE inner join J055XZ xz on wf.WFUsrCod = xz.J055XZUsr inner join PeopleNet_Nomina pn on RIGHT(pn.Legajo, 9) = xz.J055XZLeg where WFRstCod = 'SECTOR' and DescUnidadOrg = '{textBoxSector.Text}'";
            string sql_usuarios = $"select J055XZUsr from J055XZ wf inner join PeopleNet_Nomina pn on RIGHT(pn.Legajo, 9) = wf.J055XZLeg where DescUnidadOrg = '{textBoxSector.Text}' ";
            richResultado_usuarios.Text = sql_usuarios;
            DataSet usuarios = DB.ObtenerDatos(sql_usuarios);

            dataGridUsuario.DataSource = usuarios.Tables[0];
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxUsuario.Text = (string)dataGridUsuario.CurrentCell.Value.ToString();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text != "")
            {
                richResultado_usuarios.Text = DB.CambiarUsuario(textBoxUsuario.Text);

                UsuarioActual();

            }
            else
            {
                richResultado_usuarios.Text = "Debe seleccionar un usuario candidato";
            }
        }
    }
}
