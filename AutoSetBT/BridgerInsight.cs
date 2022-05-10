using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace AutoSetBT
{
    public class BridgerInsight
    {

        public static string  Insertar(string cuil, string usuario, string db = "BPN_WEB_QA", string server = "arcncd07")
        {

            string sql_sucursal = $"select bnqfx06suc from bnqfx06 where BNQFX06Usu = '{usuario}'";
            string sucursal =   DB.ObtenerValorCampo(sql_sucursal, "bnqfx06suc", db, server);

            //Fecha BT
            string sql_FechaBT = "select Pgfape from fst017";
            string fechaBT = DB.ObtenerValorCampo(sql_FechaBT, "Pgfape", db, server);

            string horaLocal = DateTime.Now.ToString("HH:mm:ss");
            var parsedDate = DateTime.Parse(fechaBT);

            var fecha = parsedDate.ToString("yyyy-MM-dd");

            string date = fecha + " " + horaLocal;

            //Inserto consulta falsa // Sumar tiempo (sacar hora real)
            string sql_InsertBridgerInsight = $"insert into BPNC37 select '{usuario}',{sucursal},'10.10.6.53','{date}',penom,pendoc,'R','N' from fsd001 where pendoc = '{cuil}'";
             //$" select '{usuario}',{sucursal},'0.10.6.116',dateadd(second,convert(int,substring(pendoc,8,4)),dateadd(day,-16, getdate())),penom,pendoc,'R','N' from fsd001 where pendoc = '{cuil}'";


            string resBridger = DB.ejecutarQuery(sql_InsertBridgerInsight);


            return sql_InsertBridgerInsight + Environment.NewLine + resBridger;


        }
    }

}