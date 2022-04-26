using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace AutoSetBT
{
    public class Bcp
    {

        public static string  runQADF(string dbA, string dbB, string serverA, string serverB, string consulta, string tabla)
        {
            string outTabla = "";
            string outConsulta = "";
            string inTabla = "";

            //OUT

            //bcp "select * from bpn_web_Desa..JBNYC5 where JBNYC5Pqte=19" queryout JBNYC5.txt - o JBNYC5.out -S arcncd09 - T - c
            //pause

            //bcp "select * from bpn_web..BNQFPB2" queryout BNQFPB2.txt -n -o BNQFPB2.out -S Arcncd19 -U UE_CTRL_FUNC2 -P nP461oD5 -c

            if (consulta == "")
            {
                 outTabla = $@"'select * from {dbA}..{tabla}' queryout {tabla}.txt -o {tabla}.out -S {serverA} -T -c";
            }
            else
            {
                 outConsulta = $@"'select * from {dbA}..{tabla} where {consulta}' queryout {tabla}.txt -o {tabla}.out -S {serverA} -T -c";
            }


            //IN

            //bcp bpn_web_QA..JBNYC5 IN JBNYC5.txt - S arcncd07 - T - c
            //pause

            inTabla = $@"{dbB}..{tabla} IN {tabla}.txt -S {serverB} -T -c";


            return "OUT TABLA: "+outTabla + Environment.NewLine + "OUTCONSULTA: "+outConsulta + Environment.NewLine + "IN: "+inTabla;

        }

        public static string runHistorico(string dbB, string serverA, string serverB, string consulta, string tabla, string password)
        {

            string outTabla = "";
            string outConsulta = "";
            string inTabla = "";

            //OUT

            //bcp "select * from bpn_web..BNQFPB2" queryout BNQFPB2.txt -n -o BNQFPB2.out -S Arcncd19 -U UE_CTRL_FUNC2 -P nP461oD5 -c
            if (consulta == "")
            {
                 outTabla = $@"'select * from bpn_web..{tabla}' queryout {tabla}.txt - n - o {tabla}.out -S Arcncd19 - U UE_CTRL_FUNC2 - P {password} - c";
            }
            else
            {
                 outConsulta = $@"'select * from bpn_web..{tabla} where {consulta}' queryout {tabla}.txt - n - o {tabla}.out -S Arcncd19 - U UE_CTRL_FUNC2 - P {password} - c";
            }


            //IN

            //bcp bpn_web_QA..JBNYC5 IN JBNYC5.txt - S arcncd07 - T - c
            //pause

             inTabla = $@"{dbB}..{tabla} IN {tabla}.txt - S {serverB} - T - c";


            return "OUT TABLA: " + outTabla + Environment.NewLine + "OUTCONSULTA: " + outConsulta + Environment.NewLine + "IN: " + inTabla;

        }
    }

}