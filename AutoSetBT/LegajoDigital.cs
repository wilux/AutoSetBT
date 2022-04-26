using System;
using System.Collections;
using System.Collections.Generic;

namespace AutoSetBT
{
    public class LegajoDigital
    {
        public static string Completar(string cuil, string server = "arcncd07")
        {
            string db_LegajoDigital;
            string db_Firma;

            if (server == "arcncd07")
            {
                db_LegajoDigital = "LegajoDigital_QA";
                db_Firma = "FirmaGrafometrica_QA";
            }
            else
            {
                db_LegajoDigital = "LegajoDigital_Desa";
                db_Firma = "FirmaGrafometrica_Desa";
            }

            //Obtengo idPersona
            string sql_idPersona = $"select idPersona from PERSONA where CuitCuil = '{cuil}'";
            string idPersona = DB.ObtenerValorCampo(sql_idPersona, "idPersona", db_LegajoDigital, server);

            //Obtengo lista con idTramite
            string sql_idTramite = $"select idTramite from TRAMITE where idPersona = '{idPersona}' and estado = 1";
            IList idTramites = DB.ObtenerValoresColumna(sql_idTramite, "idTramite", db_LegajoDigital, server);
            List<string> ListaTramites = new List<string>();

            foreach (int tramite in idTramites)
            {
                ListaTramites.Add(tramite.ToString());
            }

            //Obtengo Tramites para una lista de idTramites
            string tramites = string.Join(",", ListaTramites);
            string resTramites = "";
            string resDocumentos = "";
            string sql_updateVersionDocumento = "";
            string sql_UpdateTramite = "";

            //Aprobar Tramites
            if (server == "arcncd07")
            {
                 sql_UpdateTramite = $"UPDATE Tramite SET estado = 2 where  idTramite in ({tramites})";
            }
            else
            {
                 sql_UpdateTramite = $"UPDATE Tramite SET activo = 2 where  IdInstanciaLegajoDigital in ({tramites})";
            }



            if (tramites != "")
            {
                 resTramites = DB.ejecutarQuery(sql_UpdateTramite, db_LegajoDigital, server);


            //Aprobar Documentos
            sql_updateVersionDocumento = $"UPDATE VERSIONDOCUMENTO SET estado=2 where idVersionDocumento in (select idVersionDocumento from TRAMITEVERSIONDOCUMENTO where idTramite in ({tramites}))";
            resDocumentos = DB.ejecutarQuery(sql_updateVersionDocumento, db_LegajoDigital, server);
            }
            else {  resTramites = "No hay registro para actualizar"; }

            //FirmaDigital

            string sql_updateFirma = $"UPDATE Tramite SET activo = 0 where CuitCuil = '{cuil}'";
            string resFirma = DB.ejecutarQuery(sql_updateFirma, db_Firma, server);

            return sql_UpdateTramite + Environment.NewLine +resTramites + Environment.NewLine +
                   sql_updateVersionDocumento + Environment.NewLine + resDocumentos + Environment.NewLine +
                   sql_updateFirma + Environment.NewLine + resFirma;


        }
    }
}
