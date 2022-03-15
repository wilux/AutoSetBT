using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace AutoSetBT
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();
        }

        private void UsuarioActual()
        {
            //usuarioActual

            string sql_CurrentUser = $"select J055XZUsr from J055XZ where J055XZUad='{Environment.UserName}'";
            usuarioActual = DB.ObtenerValorCampo(sql_CurrentUser, "J055XZUsr", ambiente, server);
            inputUsuario.Text = usuarioActual.Replace(" ", String.Empty).Trim(); ;
        }

        private void FechaBT()
        {
            string sql_FechaBT = "select Pgfape from fst017";

            var parsedDate = DateTime.Parse(DB.ObtenerValorCampo(sql_FechaBT, "Pgfape",ambiente,server));

            var fecha = parsedDate.ToString("dd/MM/yyyy");

            txtFechaBT.Text = fecha.Trim();
        }


        private void btnFirmar_Click(object sender, EventArgs e)
        {
            if (ambiente == "BPN_WEB_QA")
            {

                if (inputCuil.Text != "")
                {
                    richConsola.Text = "";
                    richConsola.Text = LegajoDigital.Completar(inputCuil.Text, server).Trim();
                }
                else
                {
                    richConsola.Text = "Debe ingresar un CUIL";
                }
            }
            else 
            {

                if (inputCuil.Text != "")
                {
                    richConsola.Text = "";
                    richConsola.Text = LegajoDigital.Completar(inputCuil.Text, server).Trim();
                }
                else
                {
                    richConsola.Text = "Debe ingresar un CUIL";
                }


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

                    richConsola.Text = "";
                    richConsola.Text = Environment.NewLine + sql_lg + Environment.NewLine + sql_firma;

                    dataLD.DataSource = legajo.Tables[0];
                    dataFirma.DataSource = firma.Tables[0];
                }
                else
                {
                    richConsola.Text = "Debe ingresar un CUIL";
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
                richConsola.Text = "";
                string sql_Entrevista = 
                    @$"select c.WFAttSVal Entrevista,b.WFTaskName,c.WFInsPrcId, WFItemUsrCod, a.WFTaskCod from 
                    wfwrkitems a (nolock) inner join wftask b (nolock) on a.WFTaskCod=b.WFTaskCod and b.WFPrcId in(9,10,13)
                    inner join wfattsvalues c (nolock) on a.WFInsPrcId=c.WFInsPrcId and c.WFAttSId='ENTREVISTA' and 
                    c.WFAttSVal in('{inputEntrevista.Text}.0000')";

                string sql_WFInsPrcId = 
                        @$"select  top 1 a.WFInsPrcId from wfwrkitems a (nolock) inner join wftask b (nolock) on
                        a.WFTaskCod=b.WFTaskCod and b.WFPrcId in(9,10,13) inner join wfattsvalues c (nolock) on 
                        a.WFInsPrcId=c.WFInsPrcId and c.WFAttSId='ENTREVISTA' and c.WFAttSVal in('{inputEntrevista.Text}.0000') 
                        order by a.WFInsPrcId desc";

                string sql_Instancia = 
                    @$"select a.WFInsPrcId from wfwrkitems a (nolock) inner join wftask b (nolock) on 
                    a.WFTaskCod=b.WFTaskCod and b.WFPrcId in(9,10,13) inner join wfattsvalues c (nolock) on 
                    a.WFInsPrcId=c.WFInsPrcId and c.WFAttSId='ENTREVISTA' and c.WFAttSVal in('{inputEntrevista.Text}.0000') order by a.WFInsPrcId desc";
                
                DataSet entrevista = DB.ObtenerDatos(sql_Entrevista, ambiente, server);
                DataSet instancia = DB.ObtenerDatos(sql_Instancia, ambiente, server);

                string WFInsPrcId = DB.ObtenerValorCampo(sql_WFInsPrcId, "WFInsPrcId");

                dataEntrevista.DataSource = entrevista.Tables[0];
                dataInstancia.DataSource = instancia.Tables[0];

                string sql_Candidatos = 
                    @$"select WFWrkLstUsrCod as Usuarios from WFWORKLIST  (nolock) where WFWrkLstItemId 
                    in(select wfitemid from WFWRKITEMS where   WFInsPrcId = {WFInsPrcId})";
                DataSet candidatos = DB.ObtenerDatos(sql_Candidatos, ambiente, server);

                dataUsuarios.DataSource = candidatos.Tables[0];
                richConsola.Text = Environment.NewLine + sql_Entrevista + Environment.NewLine + sql_Candidatos;

            }
            else
            {
                richConsola.Text = "Debe ingresar nro Entrevista";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textUsuarioSelected.Text != "")
            {
                richConsola.Text  = DB.CambiarUsuario(textUsuarioSelected.Text, ambiente, server);

                UsuarioActual();

            }
            else
            {
                richConsola.Text = "Debe seleccionar un usuario candidato";
            }
        }



        private void dataUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textUsuarioSelected.Text = (string)dataUsuarios.CurrentCell.Value;
            textUsuarioSelected.Text = textUsuarioSelected.Text.Trim();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inputCuil.Text != "")
            {
                richConsola.Text = "";
                string sql_Bridger = $"select * from    BPNC37 where    BPNC37NID = '{inputCuil.Text}'";


                DataSet bridger = DB.ObtenerDatos(sql_Bridger, ambiente, server);

                dataBridger.DataSource = bridger.Tables[0];


                richConsola.Text = Environment.NewLine + sql_Bridger + Environment.NewLine;

            }
            else
            {
                richConsola.Text = "Debe ingresar nro Cuil/Cuit";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inputCuil.Text != "" && inputUsuario.Text !="")
            {
                richConsola.Text = BridgerInsight.Insertar(inputCuil.Text, inputUsuario.Text, ambiente, server);
            }
            else
            {
                richConsola.Text = "Debe escribir un cuil/cuit y ademas el usuario de plataforma";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            FechaBT();

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
                DB.CambiarUsuario(usuarioActual, ambiente, server);
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
            string sql_sectores = "select distinct DescUnidadOrg from PeopleNet_Nomina order by DescUnidadOrg";
            richConsola.Text = sql_sectores;
            DataSet sectores = DB.ObtenerDatos(sql_sectores, ambiente, server);

            dataGridSector.DataSource = sectores.Tables[0];
        }

        private void dataGridSector_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxSector.Text = (string)dataGridSector.CurrentCell.Value.ToString();
            string sql_usuarios = $"select J055XZUsr from J055XZ wf inner join PeopleNet_Nomina pn on RIGHT(pn.Legajo, 9) = wf.J055XZLeg where DescUnidadOrg = '{textBoxSector.Text}' ";
            richConsola.Text = sql_usuarios;
            DataSet usuarios = DB.ObtenerDatos(sql_usuarios, ambiente, server);

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
                richConsola.Text = DB.CambiarUsuario(textBoxUsuario.Text, ambiente, server);

                UsuarioActual();

            }
            else
            {
                richConsola.Text = "Debe seleccionar un usuario candidato";
            }
        }



        private void radioButtonQA_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonQA.Checked)
            {
                ambiente = "bpn_web_Desa";
                server = "arcncd09";
                UsuarioActual();
                FechaBT();
                richConsola.Text = "Se cambio de ambiente --> "+"Ambiente: "+ambiente+" "+"Servidor: "+server;
            }
        }

        private void radioButtonDF_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonDF.Checked)
            {
                ambiente = "BPN_WEB_QA";
                server = "arcncd07";
                UsuarioActual();
                FechaBT();
                richConsola.Text = "Se cambio de ambiente --> " + "Ambiente: " + ambiente + " " + "Servidor: " + server;

            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string sql_usuarios_busqueda = $"select J055XZUsr from J055XZ wf inner join PeopleNet_Nomina pn on RIGHT(pn.Legajo, 9) = wf.J055XZLeg where Nombre like '%{textBoxBusquedaUsuario.Text}%' or Apellido like '%{textBoxBusquedaUsuario.Text}%' order by J055XZUsr asc";
            richConsola.Text = sql_usuarios_busqueda;
            DataSet usuarios = DB.ObtenerDatos(sql_usuarios_busqueda, ambiente, server);

            dataGridUsuario.DataSource = usuarios.Tables[0];
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            string sql_usuarios_busqueda = $"SELECT J055XZUsr FROM J055XZ where J055XZUsr like '%{textBoxBusquedaUsr.Text}%' UNION SELECT WFUsrCod from wfusers1 where WFUsrCod like '%{textBoxBusquedaUsr.Text}%'";
           
            richConsola.Text = sql_usuarios_busqueda;
            DataSet usuarios = DB.ObtenerDatos(sql_usuarios_busqueda, ambiente, server);

            dataGridUsuario.DataSource = usuarios.Tables[0];
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string sql_sectores = $"select distinct DescUnidadOrg from PeopleNet_Nomina where DescUnidadOrg like '%{textBoxBusquedaSector.Text}%'  order by DescUnidadOrg";
            richConsola.Text = sql_sectores;
            DataSet sectores = DB.ObtenerDatos(sql_sectores, ambiente, server);

            dataGridSector.DataSource = sectores.Tables[0];
        }





        private void button7_Click(object sender, EventArgs e)
        {
            if (inputEntrevista.Text != "")
            {
                richConsola.Text = "";
                string sql_Entrevista = 
                @$"select c.WFAttSVal Entrevista,b.WFTaskName,a.*,b.* from wfwrkitems a (nolock)
                inner join wftask b(nolock) on a.WFTaskCod = b.WFTaskCod and b.WFPrcId in(9, 10, 13)--and b.WFTaskCod = 70
                inner join wfattsvalues c(nolock) on a.WFInsPrcId = c.WFInsPrcId and c.WFAttSId = 'ENTREVISTA' and c.WFAttSVal in('{inputEntrevista.Text}.0000')
                order by WFItemInit";
                DataSet entrevista = DB.ObtenerDatos(sql_Entrevista, ambiente, server);
                dataHistoriaEntrevista.DataSource = entrevista.Tables[0];
                richConsola.Text = Environment.NewLine + sql_Entrevista + Environment.NewLine;

            }
            else
            {
                richConsola.Text = "Debe ingresar nro Entrevista";
            }
        }

        //Setear todas las Entrevistas para un CUIL y Despaquetizaciones Pendientes
        private void button5_Click_1(object sender, EventArgs e)
        {

            if (inputCuil.Text != "")
            {

                //Entrevistas para el CUIL en CUR y U se pasan a C
                string sql_BNQFPA2Nro = @$"select BNQFPA2Nro from BNQFPA2 where BNQFPA2NDo='{inputCuil.Text}' and BNQFPA2Est = 'CUR'";
            DataSet entrevista = DB.ObtenerDatos(sql_BNQFPA2Nro, ambiente, server);
            dataHistoriaEntrevista.DataSource = entrevista.Tables[0];

            
            foreach (DataRow dr in entrevista.Tables[0].Rows)
            {
                string nroEntrevista = dr[0].ToString();
                string sql_WFInsPrcId = @$"select WFInsPrcId from WFINSTPRC where WFInsPrcSta = 'U' and WFInsPrcSubject like '%Nro {nroEntrevista}%'";

                DataSet WFInsPrcId = DB.ObtenerDatos(sql_WFInsPrcId, ambiente, server);

                foreach (DataRow dr1 in WFInsPrcId.Tables[0].Rows)
                {
                    string nroWFInsPrcId = dr1[0].ToString();


                    string sql_Entrevista_update = @$"update  WFINSTPRC set WFInsPrcSta = 'C' from WFINSTPRC where WFInsPrcid={nroWFInsPrcId}";
                    DB.ejecutarQuery(sql_Entrevista_update, ambiente, server);

                    richConsola.Text = Environment.NewLine + sql_Entrevista_update + Environment.NewLine;
                    }


            }

            //Cuentas que tienen paquetes pendientes de confirmar para el CUIL
            string sql_Cuil_Paquete_update = @$"update JBNYC7 set JBNYC7Esta = 'A'  where  JBNYC7Esta = 'D' and JBNYC7NCta in (select BNQFPA2Cta from BNQFPA2 where BNQFPA2NDo='{inputCuil.Text}')";
            DB.ejecutarQuery(sql_Cuil_Paquete_update, ambiente, server);

                richConsola.Text = Environment.NewLine + sql_Cuil_Paquete_update + Environment.NewLine;





            }
            else
            {
                richConsola.Text = "Debe ingresar nro de Cuil";
            }

        }

            private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inputEntrevista.Text != "")
            {
                richConsola.Text = "";
                string sql_Entrevista_update =
                @$"update  WFINSTPRC set WFInsPrcSta = 'C' from WFINSTPRC where WFInsPrcid in (select  c.WFInsPrcId from wfwrkitems a (nolock) inner join wftask b (nolock) 
                on a.WFTaskCod=b.WFTaskCod and b.WFPrcId in(9,10,13) inner join wfattsvalues c (nolock) on a.WFInsPrcId=c.WFInsPrcId 
                and c.WFAttSId='ENTREVISTA' and c.WFAttSVal in('{inputEntrevista.Text}.0000'))";

                string sql_Entrevista_consulta = $@"select WFInsPrcSta,* from WFINSTPRC where WFInsPrcid in (select  c.WFInsPrcId from wfwrkitems a (nolock) inner join wftask b (nolock) 
                on a.WFTaskCod=b.WFTaskCod and b.WFPrcId in(9,10,13) inner join wfattsvalues c (nolock) on a.WFInsPrcId=c.WFInsPrcId 
                and c.WFAttSId='ENTREVISTA' and c.WFAttSVal in('{inputEntrevista.Text}.0000'))";

                DataSet entrevista = DB.ObtenerDatos(sql_Entrevista_consulta, ambiente, server);
                dataHistoriaEntrevista.DataSource = entrevista.Tables[0];

                richConsola.Text = Environment.NewLine + sql_Entrevista_update + Environment.NewLine + DB.ejecutarQuery(sql_Entrevista_update, ambiente, server);

            }
            else
            {
                richConsola.Text = "Debe ingresar nro Entrevista";
            }
        }

        // BIE Precalificados
        private void button8_Click(object sender, EventArgs e)
        {
            string sql_FechaBT = "select Pgfape from fst017";

            string fecha = DB.ObtenerValorCampo(sql_FechaBT, "Pgfape", ambiente, server);

            string sql_casos_consulta = $@"select distinct sccta from FSD011 where sccta in (select  J055C17Cta from J055C19 b where J055C17NDo in 
            (select pendoc from FSR008 where ctnro in (select JBNYC7ncta from JBNYC7 where  JBNYC7Pqte in(1,2,3,4,9)  )and petdoc=1)
            and not exists (select * from bnqfpa2 c where c.BNQFPA2NDo = b.J055C17NDo and c.BNQFPA2est = 'CUR') ) and sctope in (304,302,303) and 
            Scfvto>'{fecha}'";

            
            DataSet casos = DB.ObtenerDatos(sql_casos_consulta, ambiente, server);
            dataGridCasos.DataSource = casos.Tables[0];

            richConsola.Text = Environment.NewLine + sql_casos_consulta + Environment.NewLine;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sql_FechaBT = "select Pgfape from fst017";

            string fecha = DB.ObtenerValorCampo(sql_FechaBT, "Pgfape", ambiente, server);

            string sql_casos_consulta = $@"select distinct sccta from FSD011 where sccta in (select  J055C17Cta from J055C19 b where J055C17NDo in 
            (select pendoc from FSR008 where ctnro in (select JBNYC7ncta from JBNYC7 where  JBNYC7Pqte not in(1,2,3,4,9)  )and petdoc=1)
            and not exists (select * from bnqfpa2 c where c.BNQFPA2NDo = b.J055C17NDo and c.BNQFPA2est = 'CUR') ) and sctope in (304,302,303) and 
            Scfvto>'{fecha}'";


            DataSet casos = DB.ObtenerDatos(sql_casos_consulta, ambiente, server);
            dataGridCasos.DataSource = casos.Tables[0];

            richConsola.Text = Environment.NewLine + sql_casos_consulta + Environment.NewLine;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sql_casos_consulta = $@"select distinct J055C17NDo from J055C19 b where J055C17NDo in 
            (select pendoc from FSR008 where ctnro  not in (select JBNYC7ncta from JBNYC7 where  JBNYC7Pqte in(1,2,3,4,9) )and petdoc=2 and J055C19Cna=8)
            and not exists (select * from bnqfpa2 c where c.BNQFPA2NDo = b.J055C17NDo and c.BNQFPA2est = 'CUR') ";


            DataSet casos = DB.ObtenerDatos(sql_casos_consulta, ambiente, server);
            dataGridCasos.DataSource = casos.Tables[0];

            richConsola.Text = Environment.NewLine + sql_casos_consulta + Environment.NewLine;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string sql_casos_consulta = $@"select distinct J055C17NDo from J055C19 b where J055C17NDo in 
            (select pendoc from FSR008 where ctnro  in (select JBNYC7ncta from JBNYC7 where  JBNYC7Pqte in(1,2,3,4,9) )and petdoc=2 and J055C19Cna=8)
            and not exists (select * from bnqfpa2 c where c.BNQFPA2NDo = b.J055C17NDo and c.BNQFPA2est = 'CUR') ";


            DataSet casos = DB.ObtenerDatos(sql_casos_consulta, ambiente, server);
            dataGridCasos.DataSource = casos.Tables[0];

            richConsola.Text = Environment.NewLine + sql_casos_consulta + Environment.NewLine;
        }

        private void dataGridCasos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string caso = (string)dataGridCasos.CurrentCell.Value.ToString();
            try
            {
                Clipboard.SetText(caso);
                MessageBox.Show("El caso "+caso+" fué copiado!");
            }
            catch
            {
                MessageBox.Show("Error al copiar el Caso al porta papeles");
            }
        }
    }
}
