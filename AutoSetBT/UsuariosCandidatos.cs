using System;
using System.Collections;
using System.Collections.Generic;

namespace AutoSetBT
{
    public class UsuariosCandidatos
    {
        //public static string Cambiar(string entrevista)
        //{

        //    string db_Bt = "BPN_WEB_QA";

        //    //Obtengo ultimo WFInsPrcId 
        //    string sql_Entrevista = $"select  top 1 c.WFInsPrcId from wfwrkitems a (nolock) inner join wftask b (nolock) on a.WFTaskCod=b.WFTaskCod and b.WFPrcId in(9,10,13) inner join wfattsvalues c (nolock) on a.WFInsPrcId=c.WFInsPrcId and c.WFAttSId='ENTREVISTA' and c.WFAttSVal in('{entrevista}.0000') order by b.WFTasKCod desc";
        //    string WFInsPrcId = DB.ObtenerValorCampo(sql_Entrevista, "WFInsPrcId");

        //    //Consulta Candidatos


        //    //Cambiar Usuario
        //    //sql_updateVersionDocumento = $"UPDATE VERSIONDOCUMENTO SET estado=2 where idVersionDocumento in (select idVersionDocumento from TRAMITEVERSIONDOCUMENTO where idTramite in ({tramites}))";
        //    //resDocumentos = DB.ejecutarQuery(sql_updateVersionDocumento, db_LegajoDigital);
        //    //}
        //    //else {  resTramites = "No hay registro para actualizar"; }

        //    ////FirmaDigital
        //    //string sql_updateFirma = $"UPDATE Tramite SET activo = 0 where CuitCuil = '{cuil}'";
        //    //string resFirma = DB.ejecutarQuery(sql_updateFirma, db_Firma);

        //    //return sql_UpdateTramite + Environment.NewLine +resTramites + Environment.NewLine +
        //    //       sql_updateVersionDocumento + Environment.NewLine + resDocumentos + Environment.NewLine +
        //    //       sql_updateFirma + Environment.NewLine + resFirma;



        //}
    }
}
