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

            var parsedDate = DateTime.Parse(DB.ObtenerValorCampo(sql_FechaBT, "Pgfape", ambiente, server));

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



            if (ambiente == "BPN_WEB_QA")
            {
                string db_LegajoDigital = "LegajoDigital_QA";
                string db_Firma = "FirmaGrafometrica_QA";

                if (inputCuil.Text != "")
                {
                    string sql_lg = $"select *  from TRAMITE where idPersona in (select idPersona from PERSONA where CuitCuil = '{inputCuil.Text}')";
                    string sql_firma = $"select *  from TRAMITE where CuitCuil = '{inputCuil.Text}' and activo = 1";

                    DataSet legajo = DB.ObtenerDatos(sql_lg, db_LegajoDigital, server);
                    DataSet firma = DB.ObtenerDatos(sql_firma, db_Firma, server);

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
            else
            {
                string db_LegajoDigital = "LegajoDigital_Desa";
                string db_Firma = "FirmaGrafometrica_Desa";

                if (inputCuil.Text != "")
                {
                    string sql_lg = $"select *  from TRAMITE where idPersona in (select idPersona from PERSONA where CuitCuil = '{inputCuil.Text}')";
                    string sql_firma = $"select *  from TRAMITE where CuitCuil = '{inputCuil.Text}' and activo = 1";

                    DataSet legajo = DB.ObtenerDatos(sql_lg, db_LegajoDigital, server);
                    DataSet firma = DB.ObtenerDatos(sql_firma, db_Firma, server);

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
                richConsola.Text = DB.CambiarUsuario(textUsuarioSelected.Text, ambiente, server);

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
            if (inputCuil.Text != "" && inputUsuario.Text != "")
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

                if (!listUserHistory.Items.Contains(textBoxUsuario.Text))
                {
                    listUserHistory.Items.Add(textBoxUsuario.Text);
                }

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
                richConsola.Text = "Se cambio de ambiente --> " + "Ambiente: " + ambiente + " " + "Servidor: " + server;
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

        // BIE Precalificados C/PAQ
        private void button8_Click(object sender, EventArgs e)
        {
            // string sql_FechaBT = "select Pgfape from fst017";

            // string fecha = DB.ObtenerValorCampo(sql_FechaBT, "Pgfape", ambiente, server);

            string sql_casos_consulta = $@"select  distinct J055C17Cta from J055C19 (nolock) where J055C17Cta in (
            SELECT BNQFPA2Cta FROM bnqfpa2 a (nolock) INNER JOIN JBNYC7 b ON a.BNQFPA2Cta = b.JBNYC7NCta  where  JBNYC7Pqte  in(1,2,3,4,9)  and BNQFPA2est <> 'CUR' and BNQFPA2Cnd = 'BIE' and BNQFPA2Fch > '2021-09-01')";


            DataSet casos = DB.ObtenerDatos(sql_casos_consulta, ambiente, server);
            dataGridCasos.DataSource = casos.Tables[0];

            richConsola.Text = Environment.NewLine + sql_casos_consulta + Environment.NewLine;

        }

        // BIE Preca S/PAQ
        private void button9_Click(object sender, EventArgs e)
        {
            string sql_FechaBT = "select Pgfape from fst017";

            string fecha = DB.ObtenerValorCampo(sql_FechaBT, "Pgfape", ambiente, server);

            string sql_casos_consulta = $@"select  distinct J055C17Cta from J055C19 (nolock) where J055C17Cta  in (
            SELECT BNQFPA2Cta FROM bnqfpa2 a (nolock) INNER JOIN JBNYC7 b ON a.BNQFPA2Cta = b.JBNYC7NCta  where  JBNYC7Pqte  not in(1,2,3,4,9)  and BNQFPA2est <> 'CUR' and BNQFPA2Cnd = 'BIE' and BNQFPA2Fch > '2021-09-01')";


            DataSet casos = DB.ObtenerDatos(sql_casos_consulta, ambiente, server);
            dataGridCasos.DataSource = casos.Tables[0];

            richConsola.Text = Environment.NewLine + sql_casos_consulta + Environment.NewLine;
        }

        //Bi S/ PAQ
        private void button10_Click(object sender, EventArgs e)
        {
            string sql_casos_consulta = $@"select  distinct J055C17Cta from J055C19 (nolock) where J055C17Cta  in (
            SELECT BNQFPA2Cta FROM bnqfpa2 a (nolock) INNER JOIN JBNYC7 b ON a.BNQFPA2Cta = b.JBNYC7NCta  where  JBNYC7Pqte  not in(1,2,3,4,9)  and BNQFPA2est <> 'CUR' and BNQFPA2Cnd = 'BI' and BNQFPA2Fch > '2021-09-01')";


            DataSet casos = DB.ObtenerDatos(sql_casos_consulta, ambiente, server);
            dataGridCasos.DataSource = casos.Tables[0];

            richConsola.Text = Environment.NewLine + sql_casos_consulta + Environment.NewLine;
        }

        //BI C/PAQ
        private void button11_Click(object sender, EventArgs e)
        {
            string sql_casos_consulta = $@"select  distinct J055C17Cta from J055C19 (nolock) where J055C17Cta in (
            SELECT BNQFPA2Cta FROM bnqfpa2 a (nolock) INNER JOIN JBNYC7 b ON a.BNQFPA2Cta = b.JBNYC7NCta  where  JBNYC7Pqte  in(1,2,3,4,9)  and BNQFPA2est <> 'CUR' and BNQFPA2Cnd = 'BI' and BNQFPA2Fch > '2021-09-01')";


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
                MessageBox.Show("El caso " + caso + " fué copiado!");
            }
            catch
            {
                MessageBox.Show("Error al copiar el Caso al porta papeles");
            }
        }

        private void listUserHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "";
            // try { textBoxUsuario.Text = listUserHistory.SelectedItem.ToString(); } catch (Exception ee){ richConsola.Text = ee.ToString(); }
            if (listUserHistory.SelectedItem != null)
            {
                textBoxUsuario.Text = listUserHistory.SelectedItem.ToString();
            }
        }

        //BE
        private void button12_Click(object sender, EventArgs e)
        {
            string sql_casos_consulta = $@"SELECT distinct BNQFPA2Cta FROM bnqfpa2  (nolock) where  BNQFPA2est <> 'CUR' and BNQFPA2Cnd = 'BE'";


            DataSet casos = DB.ObtenerDatos(sql_casos_consulta, ambiente, server);
            dataGridCasos.DataSource = casos.Tables[0];

            richConsola.Text = Environment.NewLine + sql_casos_consulta + Environment.NewLine;
        }

        //BE C/ CALIF
        private void button13_Click(object sender, EventArgs e)
        {
            string sql_casos_consulta = $@"select distinct top 100 Pendoc from FSR008 a (nolock) where ctnro in 
            (select distinct sccta from fsd011 (nolock) where Scmod=303 and Scstat=0 and scfvto > '{txtFechaBT.Text}') 
            and petdoc=1 and convert(NUMERIC,Pendoc) >30000000000
            and not exists  (select * from bnqfpa2 c where c.BNQFPA2NDo = a.Pendoc and c.BNQFPA2est = 'CUR')";


            DataSet casos = DB.ObtenerDatos(sql_casos_consulta, ambiente, server);
            dataGridCasos.DataSource = casos.Tables[0];

            richConsola.Text = Environment.NewLine + sql_casos_consulta + Environment.NewLine;
        }



        // COPIAR desde ..  a ...
        private void button17_Click(object sender, EventArgs e)
        {
            string[][] bcp = { };

            if (bcp_serverA != "PROD") {
                if (bcp_tipo)
                {
                    bcp = Bcp.runQADF(bcp_ambienteA, bcp_ambienteB, bcp_serverA, bcp_serverB, "", textTabla.Text);

                    richTextVistaOUT.Text = $"\"{bcp[0][0]}\"" + bcp[0][1];
                    richTextVistaIN.Text = bcp[0][0];
                }
                else
                {
                    bcp = Bcp.runQADF(bcp_ambienteA, bcp_ambienteB, bcp_serverA, bcp_serverB, textConsulta.Text, textTabla.Text);
                    richTextVistaOUT.Text = $"\"{bcp[0][0]}\"" + bcp[0][1];
                    richTextVistaIN.Text = bcp[0][0];
                }
            }
            else
            {
                if (bcp_tipo)
                {

                    // bcp = Bcp.runHistorico(bcp_ambienteA, bcp_serverA, bcp_serverB, "", textTabla.Text, textProdPass.Text);
                    richTextVistaOUT.Text = $"\"{bcp[0][0]}\"" + bcp[0][1];
                    richTextVistaIN.Text = bcp[0][0];
                }
                else
                {
                    //  bcp = Bcp.runHistorico(bcp_ambienteA, bcp_serverA, bcp_serverB, textConsulta.Text, textTabla.Text, textProdPass.Text);
                    richTextVistaOUT.Text = $"\"{bcp[0][0]}\"" + bcp[0][1];
                    richTextVistaIN.Text = bcp[0][0];
                }
            }
  
            try { 
            var startInfo = new ProcessStartInfo
            {
                FileName = "bcp.exe",
                Verb = "runas",
                Arguments = richTextVistaOUT.Text,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            var cmd = Process.Start(startInfo);
            string output = cmd.StandardOutput.ReadToEnd();
                if (output != "")
                {
                    richConsola.Text = output;
                }
                else
                {
                    richConsola.Text = $"La copia de la tabla {textTabla.Text} se creo exitosamente en {Application.StartupPath} con los nombres {textTabla.Text}.txt y {textTabla.Text}.out";
                }
            cmd.WaitForExit();

            }catch (Exception er)
            {
                richConsola.Text = "";
                richConsola.Text = er.Message;
            }
}

        private void comboServerA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboServerA.Text == "QA")
            {
                bcp_serverA = "arcncd07";
                bcp_ambienteA = "bpn_web_qa";
                textProdPass.Visible = false;
            }
           
            if (comboServerA.Text == "DF")
            {
                bcp_serverA = "arcncd09";
                bcp_ambienteA = "bpn_web_Desa";
                textProdPass.Visible = false;
            }
            if (comboServerA.Text == "PROD")
            {
                bcp_serverA = "Arcncd19";
                bcp_ambienteA = "bpn_web";
                textProdPass.Visible = true;
            }
        }

        private void comboServerB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboServerB.Text == "QA")
            {
                bcp_serverB = "arcncd07";
                bcp_ambienteB = "bpn_web_qa";
            }
            if (comboServerB.Text == "DF")
            {
                bcp_serverB = "arcncd09";
                bcp_ambienteB = "bpn_web_Desa";
            }

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            
            radioButton1.Checked = false;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bcp_tipo = radioButton1.Checked;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bcp_tipo = radioButton1.Checked;
            textSql.Text = $@"select * from {bcp_ambienteA}...{textTabla.Text} where";
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {



            string message = $"Seguro que queres borrar la tabla {textTabla.Text} de  {bcp_ambienteB} en {bcp_serverB}???";
            string title = "Alerta - Perdida de datos...";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                richConsola.Text = "";
                richConsola.Text = "No se realizó el borrado de datos.";
                this.Close();
            }
            else
            {
                string sql = $"delete {textTabla.Text}";

                richConsola.Text = "";
                richConsola.Text = sql + Environment.NewLine + DB.ejecutarQuery(sql, bcp_ambienteB, bcp_serverB);
            }

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = "bcp.exe",
                    Verb = "runas",
                    Arguments = richTextVistaIN.Text,
                    RedirectStandardOutput = true,
                    UseShellExecute = false
                };

                var cmd = Process.Start(startInfo);
                string output = cmd.StandardOutput.ReadToEnd();
                richConsola.Text = output;
                cmd.WaitForExit();
            }catch (Exception er)
            {
                richConsola.Text = "";
                richConsola.Text = er.Message;
            }
        }
    }
}
