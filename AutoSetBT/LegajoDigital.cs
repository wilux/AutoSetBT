using System;
using System.Collections;
using System.Collections.Generic;

namespace AutoSetBT
{
    public class LegajoDigital
    {
        public static string Completar(string cuil)
        {

            string db_LegajoDigital = "LegajoDigital_QA";
            string db_Firma = "FirmaGrafometrica_QA";

            //Obtengo idPersona
            string sql_idPersona = $"select idPersona from PERSONA where CuitCuil = '{cuil}'";
            string idPersona = DB.ObtenerValorCampo(sql_idPersona, "idPersona", db_LegajoDigital);

            //Obtengo lista con idTramite
            string sql_idTramite = $"select idTramite from TRAMITE where idPersona = '{idPersona}' and estado = 1";
            IList idTramites = DB.ObtenerValoresColumna(sql_idTramite, "idTramite", db_LegajoDigital);
            List<string> ListaTramites = new List<string>();

            foreach (int tramite in idTramites)
            {
                ListaTramites.Add(tramite.ToString());
            }

            //Obtengo Tramites para una lista de idTramites
            string tramites = string.Join(",", ListaTramites);

            //Aprobar Tramites
            string sql_UpdateTramite = $"UPDATE Tramite SET estado = 2 where  idTramite in ('{tramites}')";
            string resTramites = DB.ejecutarQuery(sql_UpdateTramite, db_LegajoDigital);

            //Aprobar Documentos
            string sql_updateVersionDocumento = $"UPDATE VERSIONDOCUMENTO SET estado=2 where idVersionDocumento in (select idVersionDocumento from TRAMITEVERSIONDOCUMENTO where idTramite in ('{tramites}'))";
            string resDocumentos = DB.ejecutarQuery(sql_updateVersionDocumento, db_LegajoDigital);

            //FirmaDigital
            string sql_updateFirma = $"UPDATE Tramite SET activo = 0 where CuitCuil = '{cuil}'";
            string resFirma = DB.ejecutarQuery(sql_updateFirma, db_Firma);

            return sql_UpdateTramite + ": "+resTramites + Environment.NewLine +
                   sql_updateVersionDocumento + ": " + resDocumentos + Environment.NewLine +
                   sql_updateFirma + ": " + resFirma;


        }
    }
}
