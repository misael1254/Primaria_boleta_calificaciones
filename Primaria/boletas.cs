using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

using System.Net;
using System.Net.Mail;
using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace Primaria
{
    public class boletas
    {
        public static int cont = 0;
        public static string viejo;
        public static string nuevo;

        //------------------------------------------------------

        public static double[,] prommes = new double[3, 10];//promedio por mes de materia

        public static double[,] promediobimes = new double[3, 5];//
        public static double[] promediostotalfinal = new double[13];//promedio entre bimestres de materias
        public static double[] promediostotalfinalprom = new double[3];//promedio entre bimestres de promedios
        public static double[,] calificacionesmat = new double[13, 5];//promedio bimestral por materia
        public static double[] puntos_totales = new double[16];
        public static string[] dirs = { };


        public struct dat
        {
            public float calificacion;
            float Calificacion
            {
                get { return calificacion; }
                set { calificacion = value; }
            }
        }
        public void boleta3()
        {
            string[] meses = { "Diag", "Sept", "Octu", "Novi", "Dici", "Ener", "Febr", "Marz", "Abri", "Mayo", "Juni" };
            if (RegistrarCalificaciones.mm == "Diag") { cont = 1; }
            else if (RegistrarCalificaciones.mm == "Sept") { cont = 2; } else if (RegistrarCalificaciones.mm == "Octu") { cont = 3; } else if (RegistrarCalificaciones.mm == "Novi") { cont = 4; } else if (RegistrarCalificaciones.mm == "Dici") { cont = 5; } else if (RegistrarCalificaciones.mm == "Ener") { cont = 6; } else if (RegistrarCalificaciones.mm == "Febr") { cont = 7; } else if (RegistrarCalificaciones.mm == "Marz") { cont = 8; } else if (RegistrarCalificaciones.mm == "Abr") { cont = 9; } else if (RegistrarCalificaciones.mm == "Mayo") { cont = 10; } else if (RegistrarCalificaciones.mm == "Juni") { cont = 11; }
            List<dat> sept = new List<dat>(); List<dat> diag = new List<dat>(); List<dat> octu = new List<dat>(); List<dat> novi = new List<dat>(); List<dat> dici = new List<dat>(); List<dat> ener = new List<dat>(); List<dat> febr = new List<dat>(); List<dat> marz = new List<dat>(); List<dat> abri = new List<dat>(); List<dat> mayo = new List<dat>(); List<dat> juni = new List<dat>();
            dat obsept = new dat();
            dat obs = new dat();
            dat obo = new dat();

            //poner una variable para guardar el mes
            for (int i = 0; i < cont; i++)
            {
                MySqlCommand comando = new MySqlCommand(string.Format("select calificacion.clave_materia, calif_materia,mes_calificacion, alumno.curp_alumno,materia.nombre_materia,materia.especif_materia from alumno INNER JOIN calificacion on(alumno.curp_alumno = calificacion.curp_alumno and calificacion.curp_alumno = '{0}' and calificacion.mes_calificacion = '{1}') INNER JOIN materia on(materia.clave_materia = calificacion.clave_materia) ORDER BY materia.especif_materia = 'EXT'; ", RegistrarCalificaciones.curp, meses[i]), Conexion.conectar());
                MySqlDataReader lec = comando.ExecuteReader();

                while (lec.Read())
                {
                    if (meses[i] == "Diag")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        diag.Add(obsept);
                    }
                    else if (meses[i] == "Sept")
                    {
                        obs.calificacion = lec.GetFloat(1);
                        sept.Add(obs);
                    }
                    else if (meses[i] == "Octu")
                    {
                        obo.calificacion = lec.GetFloat(1);
                        octu.Add(obo);
                    }
                    else if (meses[i] == "Novi")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        novi.Add(obsept);
                    }
                    else if (meses[i] == "Dici")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        dici.Add(obsept);
                    }
                    else if (meses[i] == "Ener")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        ener.Add(obsept);
                    }
                    else if (meses[i] == "Febr")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        febr.Add(obsept);
                    }
                    else if (meses[i] == "Marz")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        marz.Add(obsept);
                    }
                    else if (meses[i] == "Abri")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        abri.Add(obsept);
                    }
                    else if (meses[i] == "Mayo")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        mayo.Add(obsept);
                    }
                    else if (meses[i] == "Juni")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        juni.Add(obsept);
                    }
                }
                lec.Close();

            }



            viejo = Path.Combine(Application.StartupPath, "primaria\\3viejo.pdf");
            nuevo = Path.Combine(Application.StartupPath, "primaria\\3nuevo.pdf");
            PdfReader lector = new PdfReader(viejo);
            var tam = lector.GetPageSizeWithRotation(1);
            Document documento = new Document(tam);  //se creo un documento con el tamaño del otro pdf
                                                     //se abre la escritura
            FileStream fs = new FileStream(nuevo, FileMode.Create, FileAccess.Write);
            PdfWriter escritor = PdfWriter.GetInstance(documento, fs);
            documento.Open();
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            PdfContentByte cal = escritor.DirectContent;

            // cal.SetColorFill(BaseColor.BLACK);
            cal.SetFontAndSize(bf, 8);
            PdfContentByte nom = escritor.DirectContent;

            PdfContentByte cal1 = escritor.DirectContent;

            cal1.SetColorFill(BaseColor.BLACK);
            cal1.SetFontAndSize(bf, 8);

            PdfContentByte rojo = escritor.DirectContent;
            //rojo.SetColorFill(BaseColor.RED);
            rojo.SetFontAndSize(bf, 8);

            PdfContentByte cal2 = escritor.DirectContent;

            cal2.SetColorFill(BaseColor.BLACK);
            cal2.SetFontAndSize(bf, 8);
            int conta = 566;
            int var = 0;
            double aux;
            for (int i = 0; i < diag.Count; i++)
            {
                aux = Convert.ToDouble(diag[i].calificacion);

                if (aux < 6.0) { rojo.SetColorFill(BaseColor.RED); }
                else { rojo.SetColorFill(BaseColor.BLACK); }
                rojo.BeginText();
                rojo.ShowTextAligned(1, Convert.ToString(diag[i].calificacion + ".00").Substring(0, 3), 172, (566 - (i * 17)), 0);
                rojo.EndText();

            }

            for (int j = 0; j < sept.Count; j++)
            {

                if (sept[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                else { cal.SetColorFill(BaseColor.BLACK); }
                if (j == 7)
                {
                    conta = 410;
                    var = 0;

                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(sept[j].calificacion), 193, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                }
                else
                {
                    if (j == 8) { var = 1; }
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(sept[j].calificacion), 193, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                    //conta++;
                }
            }
            conta = 566;
            var = 0;
            for (int j = 0; j < octu.Count; j++)
            {
                if (octu[j].calificacion < 6.0) { cal2.SetColorFill(BaseColor.RED); }
                else { cal2.SetColorFill(BaseColor.BLACK); }
                if (j == 7)
                {
                    conta = 410;
                    var = 0;
                    cal2.BeginText();
                    cal2.ShowTextAligned(1, Convert.ToString(octu[j].calificacion), 213, (conta - (var * 17)), 0);
                    cal2.EndText();
                    var++;
                }
                else
                {
                    if (j == 8) { var = 1; }
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(octu[j].calificacion), 213, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                    //conta++;
                }
            }
            conta = 566;
            var = 0;
            for (int j = 0; j < novi.Count; j++)
            {
                if (novi[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                else { cal.SetColorFill(BaseColor.BLACK); }

                if (j == 7)
                {
                    conta = 410;
                    var = 0;
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(novi[j].calificacion), 235, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                }
                else
                {
                    if (j == 8) { var = 1; }
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(novi[j].calificacion), 235, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                    //conta++;
                }
            }
            conta = 566;
            var = 0;
            for (int j = 0; j < dici.Count; j++)
            {
                if (dici[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                else { cal.SetColorFill(BaseColor.BLACK); }
                if (j == 7)
                {
                    conta = 410;
                    var = 0;
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(dici[j].calificacion), 256, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                }
                else
                {
                    if (j == 8) { var = 1; }
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(dici[j].calificacion), 256, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                    //conta++;
                }
            }
            conta = 566;
            var = 0;
            for (int j = 0; j < ener.Count; j++)
            {
                if (ener[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                else { cal.SetColorFill(BaseColor.BLACK); }
                if (j == 7)
                {
                    conta = 410;
                    var = 0;
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(ener[j].calificacion), 276, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                }
                else
                {
                    if (j == 8) { var = 1; }
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(ener[j].calificacion), 276, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                    //conta++;
                }
            }
            conta = 566;
            var = 0;
            for (int j = 0; j < febr.Count; j++)
            {
                if (febr[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                else { cal.SetColorFill(BaseColor.BLACK); }
                if (j == 7)
                {
                    conta = 410;
                    var = 0;
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(febr[j].calificacion), 297, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                }
                else
                {
                    if (j == 8) { var = 1; }
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(febr[j].calificacion), 297, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                    //conta++;
                }
            }
            conta = 566;
            var = 0;
            for (int j = 0; j < marz.Count; j++)
            {
                if (marz[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                else { cal.SetColorFill(BaseColor.BLACK); }
                if (j == 7)
                {
                    conta = 410;
                    var = 0;
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(marz[j].calificacion), 317, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                }
                else
                {
                    if (j == 8) { var = 1; }
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(marz[j].calificacion), 317, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                    //conta++;
                }
            }
            conta = 566;
            var = 0;
            for (int j = 0; j < abri.Count; j++)
            {
                if (abri[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                else { cal.SetColorFill(BaseColor.BLACK); }
                if (j == 7)
                {
                    conta = 410;
                    var = 0;
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(abri[j].calificacion), 337, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                }

                else
                {
                    if (j == 8) { var = 1; }
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(abri[j].calificacion), 337, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                    //conta++;
                }
            }
            conta = 566;
            var = 0;
            for (int j = 0; j < mayo.Count; j++)
            {
                if (mayo[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                else { cal.SetColorFill(BaseColor.BLACK); }
                if (j == 7)
                {
                    conta = 410;
                    var = 0;
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(mayo[j].calificacion), 360, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                }
                else
                {
                    if (j == 8) { var = 1; }
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(mayo[j].calificacion), 360, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                    //conta++;
                }
            }
            conta = 566;
            var = 0;
            for (int j = 0; j < juni.Count; j++)
            {
                if (juni[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                else { cal.SetColorFill(BaseColor.BLACK); }
                if (j == 7)
                {
                    conta = 410;
                    var = 0;

                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(juni[j].calificacion), 382, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                }
                else
                {
                    if (j == 8) { var = 1; }
                    cal.BeginText();
                    cal.ShowTextAligned(1, Convert.ToString(juni[j].calificacion), 382, (conta - (var * 17)), 0);
                    cal.EndText();
                    var++;
                    //conta++;
                }

            }
            double promd = 0, suma = 0;
            for (int i = 0; i < diag.Count; i++)
            {
                suma = suma + diag[i].calificacion;
            }
            promd = suma / diag.Count;

            //ARREGLO PARA LOS PROMEDIOS   ------------------------------
            double[] promediosep = new double[10];
            double[] sumasep = new double[10];
            double[] sumaext = new double[10];
            double[] promedioext = new double[10];
            int consep = 7, conext = 5;
            for (int i = 0; i < 12; i++)
            {
                if (i < 7)
                {
                    if (sept.Count != 0) { sumasep[0] = sumasep[0] + sept[i].calificacion; }
                    if (octu.Count != 0) { sumasep[1] = sumasep[1] + octu[i].calificacion; }
                    if (novi.Count != 0) { sumasep[2] = sumasep[2] + novi[i].calificacion; }
                    if (dici.Count != 0) { sumasep[3] = sumasep[3] + dici[i].calificacion; }
                    if (ener.Count != 0) { sumasep[4] = sumasep[4] + ener[i].calificacion; }
                    if (febr.Count != 0) { sumasep[5] = sumasep[5] + febr[i].calificacion; }
                    if (marz.Count != 0) { sumasep[6] = sumasep[6] + marz[i].calificacion; }
                    if (abri.Count != 0) { sumasep[7] = sumasep[7] + abri[i].calificacion; }
                    if (mayo.Count != 0) { sumasep[8] = sumasep[8] + mayo[i].calificacion; }
                    if (juni.Count != 0) { sumasep[9] = sumasep[9] + juni[i].calificacion; }
                }
                if (i >= 7)
                {
                    if (sept.Count != 0) { sumaext[0] = sumaext[0] + sept[i].calificacion; }
                    if (octu.Count != 0) { sumaext[1] = sumaext[1] + octu[i].calificacion; }
                    if (novi.Count != 0) { sumaext[2] = sumaext[2] + novi[i].calificacion; }
                    if (dici.Count != 0) { sumaext[3] = sumaext[3] + dici[i].calificacion; }
                    if (ener.Count != 0) { sumaext[4] = sumaext[4] + ener[i].calificacion; }
                    if (febr.Count != 0) { sumaext[5] = sumaext[5] + febr[i].calificacion; }
                    if (marz.Count != 0) { sumaext[6] = sumaext[6] + marz[i].calificacion; }
                    if (abri.Count != 0) { sumaext[7] = sumaext[7] + abri[i].calificacion; }
                    if (mayo.Count != 0) { sumaext[8] = sumaext[8] + mayo[i].calificacion; }
                    if (juni.Count != 0) { sumaext[9] = sumaext[9] + juni[i].calificacion; }

                }

            }
            promediosep[0] = sumasep[0] / consep;
            promediosep[1] = sumasep[1] / consep;
            promediosep[2] = sumasep[2] / consep;
            promediosep[3] = sumasep[3] / consep;
            promediosep[4] = sumasep[4] / consep;
            promediosep[5] = sumasep[5] / consep;
            promediosep[6] = sumasep[6] / consep;
            promediosep[7] = sumasep[7] / consep;
            promediosep[8] = sumasep[8] / consep;
            promediosep[9] = sumasep[9] / consep;

            promedioext[0] = sumaext[0] / conext;
            promedioext[1] = sumaext[1] / conext;
            promedioext[2] = sumaext[2] / conext;
            promedioext[3] = sumaext[3] / conext;
            promedioext[4] = sumaext[4] / conext;
            promedioext[5] = sumaext[5] / conext;
            promedioext[6] = sumaext[6] / conext;
            promedioext[7] = sumaext[7] / conext;
            promedioext[8] = sumaext[8] / conext;
            promedioext[9] = sumaext[9] / conext;

            double[] promgen = new double[10];
            for (int i = 0; i < 10; i++)
            {
                promgen[i] = (promediosep[i] + promedioext[i]) / 2;
            }
            double[,] bimestresep = new double[7, 5];
            double[,] bimestresext = new double[5, 5];
            int x = 0;
            for (int j = 0; j < 5; j++)
            {
                x = 0;
                for (int i = 0; i < 12; i++)
                {
                    if (i < 7)
                    {
                        if (j == 0 && RegistrarCalificaciones.pr >= 2) { bimestresep[i, j] = (sept[i].calificacion + octu[i].calificacion) / 2; }
                        if (j == 1 && RegistrarCalificaciones.pr >= 4) { bimestresep[i, j] = (novi[i].calificacion + dici[i].calificacion) / 2; }
                        if (j == 2 && RegistrarCalificaciones.pr >= 6) { bimestresep[i, j] = (ener[i].calificacion + febr[i].calificacion) / 2; }
                        if (j == 3 && RegistrarCalificaciones.pr >= 8) { bimestresep[i, j] = (marz[i].calificacion + abri[i].calificacion) / 2; }
                        if (j == 4 && RegistrarCalificaciones.pr >= 10) { bimestresep[i, j] = (mayo[i].calificacion + juni[i].calificacion) / 2; }
                    }
                    if (i >= 7)
                    {
                        if (j == 0 && RegistrarCalificaciones.pr >= 2) { bimestresext[x, j] = (sept[i].calificacion + octu[i].calificacion) / 2; x++; }
                        if (j == 1 && RegistrarCalificaciones.pr >= 4) { bimestresext[x, j] = (novi[i].calificacion + dici[i].calificacion) / 2; x++; }
                        if (j == 2 && RegistrarCalificaciones.pr >= 6) { bimestresext[x, j] = (ener[i].calificacion + febr[i].calificacion) / 2; x++; }
                        if (j == 3 && RegistrarCalificaciones.pr >= 8) { bimestresext[x, j] = (marz[i].calificacion + abri[i].calificacion) / 2; x++; }
                        if (j == 4 && RegistrarCalificaciones.pr >= 10) { bimestresext[x, j] = (mayo[i].calificacion + juni[i].calificacion) / 2; x++; }
                    }
                }
            }
            double[] bimsep = new double[5];
            double[] bimsumasep = new double[5];
            double[] bimext = new double[5];
            double[] bimsumaext = new double[5];
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 7; i++)
                {
                    bimsumasep[j] = bimsumasep[j] + bimestresep[i, j];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                bimsep[i] = bimsumasep[i] / 5;
            }
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    bimsumaext[j] = bimsumaext[j] + bimestresext[i, j];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                bimext[i] = bimsumaext[i] / 5;
            }
            double[] promgenbi = new double[5];
            for (int k = 0; k < 5; k++)
            {
                promgenbi[k] = (bimsep[k] + bimext[k]) / 2;
            }

            double puntgenerales = 0;
            double sumagenerales = 0;

            if (RegistrarCalificaciones.pr == 10)
            {
                PdfContentByte cali = escritor.DirectContent;

                for (int i = 0; i < 5; i++)
                {
                    sumagenerales = sumagenerales + (bimsumasep[i] + bimsumaext[i]);
                }
                puntgenerales = sumagenerales / 5;

                cali.SetColorFill(BaseColor.BLACK);
                cali.SetFontAndSize(bf, 8);
                double[] promfinal = new double[14];
                double[] sumafinal = new double[14];
                double[] sumase = new double[1];
                double[] sumaex = new double[1];
                double[] sumax = new double[1];
                int contar = 0;
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i < 7) { sumafinal[i] = sumafinal[i] + bimestresep[i, j]; }

                        if (i == 0) { sumase[i] = sumase[i] + bimsep[j]; sumaex[i] = sumaex[i] + bimext[j]; sumax[i] = sumax[i] + promgenbi[j]; }
                        if (i >= 7 && contar < 5) { sumafinal[i] = sumafinal[i] + bimestresext[contar, j]; }


                    }
                    if (i >= 7) { contar++; }
                }
                for (int i = 0; i < 12; i++) { if (i < 7) { promfinal[i] = sumafinal[i] / 5; } if (i >= 7) { promfinal[i] = sumafinal[i] / 5; } }
                double promfsep = sumase[0] / 7;
                double promfext = sumaext[0] / 5;
                double gen = (promfsep + promfext) / 2;
                contar = 0;
                for (int i = 0; i < 12; i++)
                {
                    if (promfsep < 6.0) { cali.SetColorFill(BaseColor.RED); }
                    else { cali.SetColorFill(BaseColor.BLACK); }
                    cali.BeginText();
                    cali.ShowTextAligned(1, Convert.ToString(promfsep + ".00").Substring(0, 3), 550, 446, 0);
                    cali.EndText();
                    if (promfext < 6.0) { cali.SetColorFill(BaseColor.RED); }
                    else { cali.SetColorFill(BaseColor.BLACK); }
                    cali.BeginText();
                    cali.ShowTextAligned(1, Convert.ToString(promfext + ".00").Substring(0, 3), 550, 326, 0);
                    cali.EndText();
                    if (gen < 6.0) { cali.SetColorFill(BaseColor.RED); }
                    else { cali.SetColorFill(BaseColor.BLACK); }


                    cali.BeginText();
                    cali.ShowTextAligned(1, Convert.ToString(gen + ".00").Substring(0, 3), 550, 292, 0);
                    cali.EndText();
                    if (i < 7)
                    {
                        if (promfinal[i] < 6.0) { cali.SetColorFill(BaseColor.RED); }
                        else { cali.SetColorFill(BaseColor.BLACK); }
                        cali.BeginText();
                        cali.ShowTextAligned(1, Convert.ToString(promfinal[i] + ".00").Substring(0, 3), 550, 566 - (i * 17), 0);
                        cali.EndText();
                    }
                    if (i >= 7)
                    {
                        if (promfinal[i] < 6.0) { cali.SetColorFill(BaseColor.RED); }
                        else { cali.SetColorFill(BaseColor.BLACK); }
                        cali.BeginText();
                        cali.ShowTextAligned(1, Convert.ToString(promfinal[i] + ".00").Substring(0, 3), 550, 416 - (contar * 17), 0);
                        cali.EndText(); contar++;
                    }


                }

            }

            PdfContentByte prom = escritor.DirectContent;

            prom.SetColorFill(BaseColor.BLACK);
            prom.SetFontAndSize(bf, 8);
            //-------------------------------------------------------------------------------
            PdfContentByte califb = escritor.DirectContent;

            califb.SetColorFill(BaseColor.BLACK);
            califb.SetFontAndSize(bf, 8);//--------------------------------------------------
            int posY = 0;
            for (int j = 0; j < 5; j++)
            {
                posY = 0;
                for (int i = 0; i < 7; i++)
                {
                    if (j == 0 && RegistrarCalificaciones.pr >= 2)
                    {
                        if (bimestresep[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimestresep[i, j] + ".00").Substring(0, 3), 448, 566 - (i * 17), 0);
                        prom.EndText();
                        if (bimsep[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimsep[j] + ".00").Substring(0, 3), 448, 443, 0);
                        prom.EndText();
                        if (bimext[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimext[j] + ".00").Substring(0, 3), 448, 326, 0);
                        prom.EndText();
                        if (promgenbi[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(promgenbi[j] + ".00").Substring(0, 3), 448, 293, 0);
                        prom.EndText();
                        if (i < 5)
                        {
                            if (bimestresext[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimestresext[i, j] + ".00").Substring(0, 3), 448, 416 - (posY * 17), 0);
                            prom.EndText();
                            posY++;



                        }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString((bimsumasep[0] + bimsumaext[0]) + ".00").Substring(0, 4), 448, 280, 0);
                        prom.EndText();

                    }
                    if (j == 1 && RegistrarCalificaciones.pr >= 4)
                    {
                        if (bimestresep[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimestresep[i, j] + ".00").Substring(0, 3), 468, 566 - (i * 17), 0);
                        prom.EndText();
                        if (bimsep[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimsep[j] + ".00").Substring(0, 3), 468, 443, 0);
                        prom.EndText();
                        if (bimext[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimext[j] + ".00").Substring(0, 3), 468, 326, 0);
                        prom.EndText();
                        if (promgenbi[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(promgenbi[j] + ".00").Substring(0, 3), 468, 293, 0);
                        prom.EndText();
                        if (i < 5)
                        {
                            if (bimestresext[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimestresext[i, j]).Substring(0, 3), 468, 416 - (posY * 17), 0);
                            prom.EndText();
                            posY++;
                        }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString((bimsumasep[1] + bimsumaext[1]) + ".00").Substring(0, 4), 468, 280, 0);
                        prom.EndText();
                    }
                    if (j == 2 && RegistrarCalificaciones.pr >= 6)
                    {
                        if (bimestresep[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimestresep[i, j]).Substring(0, 3), 488, 566 - (i * 17), 0);
                        prom.EndText();
                        if (bimsep[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimsep[j] + ".00").Substring(0, 3), 488, 443, 0);
                        prom.EndText();
                        if (bimext[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimext[j] + ".00").Substring(0, 3), 488, 326, 0);
                        prom.EndText();
                        if (promgenbi[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(promgenbi[j] + ".00").Substring(0, 3), 488, 293, 0);
                        prom.EndText();
                        if (i < 5)
                        {
                            if (bimestresext[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimestresext[i, j] + ".00").Substring(0, 3), 488, 416 - (posY * 17), 0);
                            prom.EndText();
                            posY++;
                        }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString((bimsumasep[2] + bimsumaext[2]) + ".00").Substring(0, 4), 488, 280, 0);
                        prom.EndText();
                    }
                    if (j == 3 && RegistrarCalificaciones.pr >= 8)
                    {
                        if (bimestresep[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimestresep[i, j]).Substring(0, 3), 508, 566 - (i * 17), 0);
                        prom.EndText();
                        if (bimsep[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimsep[j] + ".00").Substring(0, 3), 508, 443, 0);
                        prom.EndText();
                        if (bimext[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimext[j] + ".00").Substring(0, 3), 508, 326, 0);
                        prom.EndText();
                        if (promgenbi[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(promgenbi[j] + ".00").Substring(0, 3), 508, 293, 0);
                        prom.EndText();
                        if (i < 5)
                        {
                            if (bimestresext[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimestresext[i, j]).Substring(0, 3), 508, 416 - (posY * 17), 0);
                            prom.EndText();
                            posY++;
                        }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString((bimsumasep[3] + bimsumaext[3]) + ".00").Substring(0, 4), 509, 280, 0);
                        prom.EndText();
                    }

                    if (j == 4 && RegistrarCalificaciones.pr >= 10)
                    {
                        if (bimestresep[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimestresep[i, j] + ".00").Substring(0, 3), 528, 566 - (i * 17), 0);
                        prom.EndText();
                        if (bimsep[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimsep[j] + ".00").Substring(0, 3), 528, 443, 0);
                        prom.EndText();
                        if (bimext[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(bimext[j] + ".00").Substring(0, 3), 528, 326, 0);
                        prom.EndText();
                        if (promgenbi[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                        else { prom.SetColorFill(BaseColor.BLACK); }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(promgenbi[j] + ".00").Substring(0, 3), 528, 293, 0);
                        prom.EndText();
                        if (i < 5)
                        {
                            if (bimestresext[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimestresext[i, j] + ".00").Substring(0, 3), 528, 416 - (posY * 17), 0);
                            prom.EndText();
                            posY++;
                        }
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString((bimsumasep[4] + bimsumaext[4]) + ".00").Substring(0, 4), 530, 280, 0);
                        prom.EndText();
                        prom.BeginText();
                        prom.ShowTextAligned(1, Convert.ToString(puntgenerales + ".00").Substring(0, 4), 551, 280, 0);
                        prom.EndText();
                    }
                }

            }
            for (int i = 0; i < RegistrarCalificaciones.pr; i++)
            {
                if (promediosep[i] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                else { prom.SetColorFill(BaseColor.BLACK); }
                prom.BeginText();
                prom.ShowTextAligned(1, Convert.ToString(promediosep[i] + ".00").Substring(0, 3), 192 + (i * 21), 443, 0);
                prom.EndText();
                if (promedioext[i] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                else { prom.SetColorFill(BaseColor.BLACK); }
                prom.BeginText();
                prom.ShowTextAligned(1, Convert.ToString(promedioext[i] + ".00").Substring(0, 3), 192 + (i * 21), 326, 0);
                prom.EndText();
                if (promgen[i] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                else { prom.SetColorFill(BaseColor.BLACK); }
                prom.BeginText();
                prom.ShowTextAligned(1, Convert.ToString(promgen[i] + ".00").Substring(0, 3), 192 + (i * 22), 293, 0);
                prom.EndText();
                prom.BeginText();
                prom.ShowTextAligned(1, Convert.ToString((sumasep[i] + sumaext[i]) + ".00").Substring(0, 4), 193 + (i * 21), 277, 0);
                prom.EndText();

            }
            if (promd < 6.0) { prom.SetColorFill(BaseColor.RED); }
            else { prom.SetColorFill(BaseColor.BLACK); }
            prom.BeginText();
            prom.ShowTextAligned(1, Convert.ToString(promd + ".00").Substring(0, 3), 172, 443, 0);
            prom.EndText();
            prom.BeginText();
            prom.ShowTextAligned(1, Convert.ToString(suma + ".00").Substring(0, 4), 172, 278, 0);
            prom.EndText();
            prom.BeginText();
            prom.ShowTextAligned(1, Convert.ToString(promd + ".00").Substring(0, 3), 172, 295, 0);
            prom.EndText();
            PdfImportedPage page = escritor.GetImportedPage(lector, 1);
            nom.SetColorFill(BaseColor.BLACK);
            nom.SetFontAndSize(bf, 8);
            nom.BeginText();
            nom.ShowTextAligned(1, RegistrarCalificaciones.dat, 375, 683, 0);
            nom.EndText();
            nom.AddTemplate(page, 0, 0);
            //Cerrar
            documento.Close();
            fs.Close();
            escritor.Close();
            enviarboletas(RegistrarCalificaciones.curp, true);

        }
        public void boleta4()
        {
            string[] meses = { "Diag", "Sept", "Octu", "Novi", "Dici", "Ener", "Febr", "Marz", "Abri", "Mayo", "Juni" };
            float[] materias = { };
            string nombre = "";
            int n_lista = 0;
            if (RegistrarCalificaciones.mm == "Diag") { cont = 1; }
            else if (RegistrarCalificaciones.mm == "Sept") { cont = 2; } else if (RegistrarCalificaciones.mm == "Octu") { cont = 3; } else if (RegistrarCalificaciones.mm == "Novi") { cont = 4; } else if (RegistrarCalificaciones.mm == "Dici") { cont = 5; } else if (RegistrarCalificaciones.mm == "Ener") { cont = 6; } else if (RegistrarCalificaciones.mm == "Febr") { cont = 7; } else if (RegistrarCalificaciones.mm == "Marz") { cont = 8; } else if (RegistrarCalificaciones.mm == "Abr") { cont = 9; } else if (RegistrarCalificaciones.mm == "Mayo") { cont = 10; } else if (RegistrarCalificaciones.mm == "Juni") { cont = 11; }
            List<dat> sept = new List<dat>(); List<dat> diag = new List<dat>(); List<dat> octu = new List<dat>(); List<dat> novi = new List<dat>(); List<dat> dici = new List<dat>(); List<dat> ener = new List<dat>(); List<dat> febr = new List<dat>(); List<dat> marz = new List<dat>(); List<dat> abri = new List<dat>(); List<dat> mayo = new List<dat>(); List<dat> juni = new List<dat>();
            dat obsept = new dat();
            dat obs = new dat();
            dat obo = new dat();

            //poner una variable para guardar el mes
            for (int i = 0; i < cont; i++)
            {
                MySqlCommand comando = new MySqlCommand(string.Format("select calificacion.clave_materia, calif_materia,mes_calificacion, alumno.curp_alumno,materia.nombre_materia,materia.especif_materia from alumno INNER JOIN calificacion on(alumno.curp_alumno = calificacion.curp_alumno and calificacion.curp_alumno = '{0}' and calificacion.mes_calificacion = '{1}') INNER JOIN materia on(materia.clave_materia = calificacion.clave_materia) ORDER BY materia.especif_materia = 'EXT'; ", RegistrarCalificaciones.curp, meses[i]), Conexion.conectar());
                MySqlDataReader lec = comando.ExecuteReader();

                while (lec.Read())
                {
                    if (meses[i] == "Diag")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        diag.Add(obsept);
                    }
                    else if (meses[i] == "Sept")
                    {
                        obs.calificacion = lec.GetFloat(1);
                        sept.Add(obs);
                    }
                    else if (meses[i] == "Octu")
                    {
                        obo.calificacion = lec.GetFloat(1);
                        octu.Add(obo);
                    }
                    else if (meses[i] == "Novi")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        novi.Add(obsept);
                    }
                    else if (meses[i] == "Dici")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        dici.Add(obsept);
                    }
                    else if (meses[i] == "Ener")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        ener.Add(obsept);
                    }
                    else if (meses[i] == "Febr")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        febr.Add(obsept);
                    }
                    else if (meses[i] == "Marz")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        marz.Add(obsept);
                    }
                    else if (meses[i] == "Abri")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        abri.Add(obsept);
                    }
                    else if (meses[i] == "Mayo")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        mayo.Add(obsept);
                    }
                    else if (meses[i] == "Juni")
                    {
                        obsept.calificacion = lec.GetFloat(1);
                        juni.Add(obsept);
                    }
                }
                lec.Close();

            }
            //Arriba se guardó en la lista
            MySqlCommand consulta = new MySqlCommand(string.Format("SELECT alumno.ap_pat_alumno,alumno.ap_mat_alumno,alumno.nombre_alumno,alumno.curp_alumno from alumno where alumno.grado_grupo='" + RegistrarCalificaciones.grado + "' ORDER BY ap_pat_alumno ASC;"), Conexion.conectar());
            MySqlDataReader lectura = consulta.ExecuteReader();
            int aux = 1;
            while (lectura.Read())
            {
                if (lectura.GetString(3).ToString() == "" + RegistrarCalificaciones.curp + "")
                {
                    nombre = "" + lectura.GetString(0).ToString() + " " + lectura.GetString(1).ToString() + " " + lectura.GetString(2).ToString() + "";
                    n_lista = aux;
                }
                else
                {
                    aux++;
                }
            }
            //Para imprimir Abajo
            if (RegistrarCalificaciones.grado == "1")
            {
                viejo = Path.Combine(Application.StartupPath, "primaria\\1viejo.pdf"); ;
                nuevo = Path.Combine(Application.StartupPath, "primaria\\1nuevo.pdf");
            }
            else if (RegistrarCalificaciones.grado == "2")
            {
                viejo = Path.Combine(Application.StartupPath, "primaria\\2viejo.pdf");
                nuevo = Path.Combine(Application.StartupPath, "primaria\\2nuevo.pdf");
            }
            else if (RegistrarCalificaciones.grado == "3")
            {
                viejo = Path.Combine(Application.StartupPath, "primaria\\3viejo.pdf");
                nuevo = Path.Combine(Application.StartupPath, "primaria\\3nuevo.pdf");
            }
            else if (RegistrarCalificaciones.grado == "4")
            {
                viejo = Path.Combine(Application.StartupPath, "primaria\\4viejo.pdf");
                nuevo = Path.Combine(Application.StartupPath, "primaria\\4nuevo.pdf");
            }
            else if (RegistrarCalificaciones.grado == "5")
            {
                viejo = Path.Combine(Application.StartupPath, "primaria\\5viejo.pdf");
                nuevo = Path.Combine(Application.StartupPath, "primaria\\5nuevo.pdf");
            }
            else if (RegistrarCalificaciones.grado == "6")
            {
                viejo = Path.Combine(Application.StartupPath, "primaria\\6viejo.pdf");
                nuevo = Path.Combine(Application.StartupPath, "primaria\\6nuevo.pdf");
            }

            PdfReader lector = new PdfReader(viejo);
            var tam = lector.GetPageSizeWithRotation(1);
            Document documento = new Document(tam);  //se creo un documento con el tamaño del otro pdf
            //se abre la escritura
            FileStream fs = new FileStream(nuevo, FileMode.Create, FileAccess.Write);
            PdfWriter escritor = PdfWriter.GetInstance(documento, fs);
            documento.Open();
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            PdfContentByte cal = escritor.DirectContent;

            cal.SetColorFill(BaseColor.BLACK);
            cal.SetFontAndSize(bf, 8);
            PdfContentByte nom = escritor.DirectContent;

            PdfContentByte cal1 = escritor.DirectContent;

            cal1.SetColorFill(BaseColor.BLACK);
            cal1.SetFontAndSize(bf, 8);
            PdfContentByte cal2 = escritor.DirectContent;

            cal2.SetColorFill(BaseColor.BLACK);
            cal2.SetFontAndSize(bf, 8);
            // --------------------------------------------------------------- NOMBRE Y NUMERO DE LISTA
            //float nombre 385,684 float numero 370, 696; para pdf 5 y 6
            float x, x2;
            if (RegistrarCalificaciones.grado == "4")
            {
                x = 397;
                x2 = 370;
            }
            else
            {
                x = 385;
                x2 = 368;
            }
            cal1.BeginText();
            cal.ShowTextAligned(1, nombre.ToString(), x, 684, 0);
            cal.ShowTextAligned(1, n_lista.ToString(), x2, 696, 0);
            cal1.EndText();

            // --------------------------------------------------------------- NOMBRE Y NUMERO DE LISTA

            // --------------------------------------------------------------- BUCLE PARA IMPRIMIR DATOS SI ES QUE LOS HAY DE DIAGNOSTICO
            float y = 559; x = 446; //COORDENADAS INICIALES PARA PASAR COMO PARAMETROS PARA PODER IMPRIMIR POR COLUMNAS
            double promedio = 0, promediogeneralmes = 0; //VARIABLES AUXILIARES PARA GUARDAR PROMEDIO DE SEP Y COMPLEMENTARIAS POR MES 
            aux = 0; // AUXILIAR PARA CONTAR CUANTAS VECES SE HA REPETIDO UN BUCLE Y ACTUAR CON RESPECTO A ELLA
            double tempo; //VARIABLE TEMPORAL PARA HACER MAS ENTENDIBLE EL CÓDIGO, EN DONDE SE ALMACENARÁ UN VALOR Y SE LIMITARÁ A 1 DIGITO DESPUES DEL PUNTO DECIMAL


            for (int i = 0; i < diag.Count; i++)
            {
                if (diag[i].calificacion < 6)
                {
                    cal.SetColorFill(BaseColor.RED);
                }
                else { cal.SetColorFill(BaseColor.BLACK); }// CONDICIONES PARA VERIFICAR EL COLOR DE COMO SE IMPRIMIRÁ
                aux++;
                tempo = Math.Round(diag[i].calificacion, 1); //EXTRAER CONTENIDO CON MAXIMO UN DIGITO DESPUES DEL PUNTO
                cal.BeginText();
                cal.ShowTextAligned(1, tempo.ToString(), 173, y, 0); //SE IMPRIMIRÁ DATO (ALINEACION,DATO,COORDENADA EN X,COORDENADA EN Y,ROTACIÓN)
                cal.EndText();

                y -= 17; //CADA ITERACION SE RESTA COORDENADA Y DADO A QUE SE IMPRIMIRÁ COLUMNA POR COLUMNA
                promedio += diag[i].calificacion; //SE VA ALMACENANDO LOS DATOS PARA OBTENER PROMEDIO
                if (aux == diag.Count) //SI YA ES SU ÚLTIMA ITERACIÓN
                {

                    promedio /= diag.Count; //SE OPTIENE PROMEDIO
                    promedio = Math.Round(promedio, 1);
                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); } //CONDICIONES PARA ELEGIR COLOR DEPENDIENDO AL CONTENIDO
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 173, y, 0); //SE IMPRIMIRÁ PROMEDIO CON LA COORDENADA ELEGIDA
                    cal1.EndText();

                }
            }
            //---------------------------------------------------------------------BUCLE PARA IMPRIMIR DATOS SI ES QUE LOS HAY DE SEPTIEMBRE
            y = 559; promedio = 0; aux = 0; //SE INICIALIZA DE NUEVO LAS VARIABLES AUXILIARES "y" PARA INICIAR NUEVAMENTE ARRIBA, "promedio" PARA NO TENER VALORES ANTES ALMACENADOS

            for (int j = 0; j < sept.Count; j++)//BLUCLE SI HAY ALGÚN VALOR(CALIFICACIÓN) ALMACENADO EN LA LISTA
            {
                puntos_totales[0] += sept[j].calificacion; //SE VAN CONTABILIZANDO LOS PUNTOS TOTALES POR MES
                aux++;
                if (j == 8) //SI YA LLEGÓ A SU OCTABA ITERACIÓN
                {
                    promedio /= 8; //SE OPTIENE PROMEDIO DE LAS CALIFICACIONES ALMACENADAS Y SE DIVIDE ENTRE 8 EL NUMERO DE MATERIAS SEP
                    promedio = Math.Round(promedio, 1);
                    prommes[0, 0] = promedio;//GUARDA EN EL ARREGLO DE PROMEDIOS POR MES EL PROMEDIO EN LA FILA PARA PROMEDIOS DE SEP
                    promediogeneralmes += promedio; //SUMATORIA DE PROMEDIOS PARA OBTENER PROMEDIO POR MES

                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }//SE ESCOGE UN COLOR
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 194, y, 0); //SE IMPRIME EL PROMEDIO DE SEP POR MES
                    cal1.EndText();
                    y -= 32;
                    promedio = 0; //SE INICIALIZA NUEVAMENTE LA VARIABLE PARA GUARDAR LAS SIGUIENTES MATERIAS (COMPLEMENTARIAS)
                }
                if (sept[j].calificacion < 6)
                { cal.SetColorFill(BaseColor.RED); }
                else
                { cal.SetColorFill(BaseColor.BLACK); } //SE ELIGE COLOR DEPENDIENDO AL VALOR

                cal.BeginText();
                cal.ShowTextAligned(1, Convert.ToString(sept[j].calificacion), 194, y, 0); //SE IMPRIME LO QUE ESTÁ EN LA LISTA QUE GUARDA LAS CALIFICACIONES
                cal.EndText();
                y -= 17;
                promedio += sept[j].calificacion;//SUMATORIA DE LOS DATOS DE LA LISTA DE CALIFICACIONES
                if (aux == sept.Count) //SI ES SU ÚLTIMA ITERACIÓN
                {
                    promedio /= 5;// SE OPTIENE EL PROMEDIO DE LAS MATERIAS COMPLEMENTARIAS
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio; //SUMATORIA PARA PROMEDIO GENERAL POR MES
                    promediogeneralmes /= 2;//SE OPTIENE EL PROMEDIO GENERAL POR MES DIVIDIENDO ENTRE DOS (SEP Y COMPLEMENTARIAS)
                    promediogeneralmes = Math.Round(promediogeneralmes, 1);
                    prommes[1, 0] = promedio; //SE GUARDA EL PROMEDIO DE COMPLEMENTARIAS EN LA MATRIZ EN LA FILA PARA LOS PROMEDIOS COMPLEMENTARIOS
                    prommes[2, 0] = promediogeneralmes;// SE GUARDA EL PROMEDIO GENERAL POR MES EN LA MATRIZ PARA LA FILA PARA LOS PROMEDIOS POR MES
                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }

                    if (promediogeneralmes < 6)
                    {
                        cal2.SetColorFill(BaseColor.RED);
                    }
                    else { cal2.SetColorFill(BaseColor.BLACK); } //CONDICIONES PARA ESCOGER COLORES DEPENDIENDO A LOS VALORES 
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 194, y, 0); //SE IMPRIME PROMEDIO DE COMPLEMENTARIAS
                    y -= 32;
                    cal1.EndText();
                    cal2.BeginText();
                    cal2.ShowTextAligned(1, promediogeneralmes.ToString(), 194, y, 0); //SE IMPRIME PROMEDIO DEL MES
                    cal2.EndText();
                }
            }
            //------------------------------------------------------------------------------ BUCLE PARA IMPRIMIR DATOS SI ES QUE LOS HAY DE OCTUBRE
            y = 559; promedio = 0; aux = 0; promediogeneralmes = 0;
            for (int j = 0; j < octu.Count; j++)
            {
                puntos_totales[1] += octu[j].calificacion;
                aux++;
                if (j == 8)
                {
                    promedio /= 8;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    prommes[0, 1] = promedio;

                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 215, y, 0);
                    cal1.EndText();
                    y -= 32;
                    promedio = 0;
                }
                if (octu[j].calificacion < 6)
                {
                    cal.SetColorFill(BaseColor.RED);
                }
                else
                {
                    cal.SetColorFill(BaseColor.BLACK);
                }
                cal.BeginText();
                cal.ShowTextAligned(1, Convert.ToString(octu[j].calificacion), 215, y, 0);
                cal.EndText();
                y -= 17;
                promedio += octu[j].calificacion;

                if (aux == octu.Count)
                {
                    promedio /= 5;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    promediogeneralmes /= 2;
                    promediogeneralmes = Math.Round(promediogeneralmes, 1);
                    prommes[1, 1] = promedio;
                    prommes[2, 1] = promediogeneralmes;
                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    if (promediogeneralmes < 6)
                    {
                        cal2.SetColorFill(BaseColor.RED);
                    }
                    else { cal2.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 215, y, 0);
                    y -= 32;
                    cal1.EndText();
                    cal2.BeginText();
                    cal2.ShowTextAligned(1, promediogeneralmes.ToString(), 215, y, 0);
                    cal2.EndText();
                }
            }
            //------------------------------------------------------------------------------ BUCLE PARA IMPRIMIR DATOS SI ES QUE LOS HAY DE NOVIEMBRE
            y = 559; promedio = 0; aux = 0; promediogeneralmes = 0;
            for (int j = 0; j < novi.Count; j++)
            {
                puntos_totales[2] += novi[j].calificacion;
                aux++;
                if (j == 8)
                {
                    promedio /= 8;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    prommes[0, 2] = promedio;

                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 236, y, 0);
                    cal1.EndText();
                    y -= 32;
                    promedio = 0;
                }
                if (novi[j].calificacion < 6)
                {
                    cal.SetColorFill(BaseColor.RED);
                }
                else
                {
                    cal.SetColorFill(BaseColor.BLACK);
                }
                cal.BeginText();
                cal.ShowTextAligned(1, Convert.ToString(novi[j].calificacion), 236, y, 0);
                cal.EndText();
                y -= 17;
                promedio += novi[j].calificacion;

                if (aux == novi.Count)
                {
                    promedio /= 5;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    promediogeneralmes /= 2;
                    promediogeneralmes = Math.Round(promediogeneralmes, 1);
                    prommes[1, 2] = promedio;
                    prommes[2, 2] = promediogeneralmes;

                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    if (promediogeneralmes < 6)
                    {
                        cal2.SetColorFill(BaseColor.RED);
                    }
                    else { cal2.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 236, y, 0);
                    y -= 32;
                    cal1.EndText();
                    cal2.BeginText();
                    cal2.ShowTextAligned(1, promediogeneralmes.ToString(), 236, y, 0);
                    cal2.EndText();
                }
            }
            //------------------------------------------------------------------------------BUCLE PARA IMPRIMIR DATOS SI ES QUE LOS HAY DE DICIEMBRE
            y = 559; promedio = 0; aux = 0; promediogeneralmes = 0;
            for (int j = 0; j < dici.Count; j++)
            {
                puntos_totales[3] += dici[j].calificacion;
                aux++;
                if (j == 8)
                {
                    promedio /= 8;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    prommes[0, 3] = promedio;

                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 257, y, 0);
                    cal1.EndText();
                    y -= 32;
                    promedio = 0;
                }
                if (dici[j].calificacion < 6)
                {
                    cal.SetColorFill(BaseColor.RED);
                }
                else
                {
                    cal.SetColorFill(BaseColor.BLACK);
                }
                cal.BeginText();
                cal.ShowTextAligned(1, Convert.ToString(dici[j].calificacion), 257, y, 0);
                cal.EndText();
                y -= 17;
                promedio += dici[j].calificacion;

                if (aux == dici.Count)
                {
                    promedio /= 5;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    promediogeneralmes /= 2;
                    promediogeneralmes = Math.Round(promediogeneralmes, 1);
                    prommes[1, 3] = promedio;
                    prommes[2, 3] = promediogeneralmes;

                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    if (promediogeneralmes < 6)
                    {
                        cal2.SetColorFill(BaseColor.RED);
                    }
                    else { cal2.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 257, y, 0);
                    y -= 32;
                    cal1.EndText();
                    cal2.BeginText();
                    cal2.ShowTextAligned(1, promediogeneralmes.ToString(), 257, y, 0);
                    cal2.EndText();
                }

            }
            //------------------------------------------------------------------------------BUCLE PARA IMPRIMIR DATOS SI ES QUE LOS HAY DE ENERO
            y = 559; promedio = 0; aux = 0; promediogeneralmes = 0;
            for (int j = 0; j < ener.Count; j++)
            {
                puntos_totales[4] += ener[j].calificacion;
                aux++;
                if (j == 8)
                {
                    promedio /= 8;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    prommes[0, 4] = promedio;

                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 278, y, 0);
                    cal1.EndText();
                    y -= 32;
                    promedio = 0;
                }
                if (ener[j].calificacion < 6)
                {
                    cal.SetColorFill(BaseColor.RED);
                }
                else
                {
                    cal.SetColorFill(BaseColor.BLACK);
                }
                cal.BeginText();
                cal.ShowTextAligned(1, Convert.ToString(ener[j].calificacion), 278, y, 0);
                cal.EndText();
                y -= 17;
                promedio += ener[j].calificacion;

                if (aux == ener.Count)
                {
                    promedio /= 5;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    promediogeneralmes /= 2;
                    promediogeneralmes = Math.Round(promediogeneralmes, 1);
                    prommes[1, 4] = promedio;
                    prommes[2, 4] = promediogeneralmes;
                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    if (promediogeneralmes < 6)
                    {
                        cal2.SetColorFill(BaseColor.RED);
                    }
                    else { cal2.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 278, y, 0);
                    y -= 32;
                    cal1.EndText();
                    cal2.BeginText();
                    cal2.ShowTextAligned(1, promediogeneralmes.ToString(), 278, y, 0);
                    cal2.EndText();
                }
            }
            //------------------------------------------------------------------------------BUCLE PARA IMPRIMIR DATOS SI ES QUE LOS HAY DE FEBRERO
            y = 559; promedio = 0; aux = 0; promediogeneralmes = 0;
            for (int j = 0; j < febr.Count; j++)
            {
                puntos_totales[5] += febr[j].calificacion;
                aux++;
                if (j == 8)
                {
                    promedio /= 8;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    prommes[0, 5] = promedio;

                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 299, y, 0);
                    cal1.EndText();
                    y -= 32;
                    promedio = 0;
                }
                if (febr[j].calificacion < 6)
                {
                    cal.SetColorFill(BaseColor.RED);
                }
                else
                {
                    cal.SetColorFill(BaseColor.BLACK);
                }
                cal.BeginText();
                cal.ShowTextAligned(1, Convert.ToString(febr[j].calificacion), 299, y, 0);
                cal.EndText();
                y -= 17;
                promedio += febr[j].calificacion;

                if (aux == febr.Count)
                {
                    promedio /= 5;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    promediogeneralmes /= 2;
                    promediogeneralmes = Math.Round(promediogeneralmes, 1);
                    prommes[1, 5] = promedio;
                    prommes[2, 5] = promediogeneralmes;
                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    if (promediogeneralmes < 6)
                    {
                        cal2.SetColorFill(BaseColor.RED);
                    }
                    else { cal2.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 299, y, 0);
                    y -= 32;
                    cal1.EndText();
                    cal2.BeginText();
                    cal2.ShowTextAligned(1, promediogeneralmes.ToString(), 299, y, 0);
                    cal2.EndText();
                }
            }
            //------------------------------------------------------------------------------BUCLE PARA IMPRIMIR DATOS SI ES QUE LOS HAY DE MARZO
            y = 559; promedio = 0; aux = 0; promediogeneralmes = 0;
            for (int j = 0; j < marz.Count; j++)
            {
                puntos_totales[6] += marz[j].calificacion;
                aux++;
                if (j == 8)
                {
                    promedio /= 8;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    prommes[0, 6] = promedio;
                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 320, y, 0);
                    cal1.EndText();
                    y -= 32;
                    promedio = 0;
                }
                if (marz[j].calificacion < 6)
                {
                    cal.SetColorFill(BaseColor.RED);
                }
                else
                {
                    cal.SetColorFill(BaseColor.BLACK);
                }
                cal.BeginText();
                cal.ShowTextAligned(1, Convert.ToString(marz[j].calificacion), 320, y, 0);
                cal.EndText();
                y -= 17;
                promedio += marz[j].calificacion;

                if (aux == marz.Count)
                {
                    promedio /= 5;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    promediogeneralmes /= 2;
                    promediogeneralmes = Math.Round(promediogeneralmes, 1);
                    prommes[1, 6] = promedio;
                    prommes[2, 6] = promediogeneralmes;
                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    if (promediogeneralmes < 6)
                    {
                        cal2.SetColorFill(BaseColor.RED);
                    }
                    else { cal2.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 320, y, 0);
                    y -= 32;
                    cal1.EndText();
                    cal2.BeginText();
                    cal2.ShowTextAligned(1, promediogeneralmes.ToString(), 320, y, 0);
                    cal2.EndText();
                }
            }
            //------------------------------------------------------------------------------BUCLE PARA IMPRIMIR DATOS SI ES QUE LOS HAY DE ABRIL
            y = 559; promedio = 0; aux = 0; promediogeneralmes = 0;
            for (int j = 0; j < abri.Count; j++)
            {
                puntos_totales[7] += abri[j].calificacion;
                aux++;
                if (j == 8)
                {
                    promedio /= 8;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    prommes[0, 7] = promedio;
                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 341, y, 0);
                    cal1.EndText();
                    y -= 32;
                    promedio = 0;
                }
                if (abri[j].calificacion < 6)
                {
                    cal.SetColorFill(BaseColor.RED);
                }
                else
                {
                    cal.SetColorFill(BaseColor.BLACK);
                }
                cal.BeginText();
                cal.ShowTextAligned(1, Convert.ToString(abri[j].calificacion), 341, y, 0);
                cal.EndText();
                y -= 17;
                promedio += abri[j].calificacion;

                if (aux == abri.Count)
                {
                    promedio /= 5;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    promediogeneralmes /= 2;
                    promediogeneralmes = Math.Round(promediogeneralmes, 1);
                    prommes[1, 7] = promedio;
                    prommes[2, 7] = promediogeneralmes;

                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    if (promediogeneralmes < 6)
                    {
                        cal2.SetColorFill(BaseColor.RED);
                    }
                    else { cal2.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 341, y, 0);
                    y -= 32;
                    cal1.EndText();
                    cal2.BeginText();
                    cal2.ShowTextAligned(1, promediogeneralmes.ToString(), 341, y, 0);
                    cal2.EndText();
                }
            }
            //------------------------------------------------------------------------------BUCLE PARA IMPRIMIR DATOS SI ES QUE LOS HAY DE MAYO
            y = 559; promedio = 0; aux = 0; promediogeneralmes = 0;
            for (int j = 0; j < mayo.Count; j++)
            {
                puntos_totales[8] += mayo[j].calificacion;
                aux++;
                if (j == 8)
                {
                    promedio /= 8;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    prommes[0, 8] = promedio;
                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 362, y, 0);
                    cal1.EndText();
                    y -= 32;
                    promedio = 0;
                }
                if (mayo[j].calificacion < 6)
                {
                    cal.SetColorFill(BaseColor.RED);
                }
                else
                {
                    cal.SetColorFill(BaseColor.BLACK);
                }
                cal.BeginText();
                cal.ShowTextAligned(1, Convert.ToString(mayo[j].calificacion), 362, y, 0);
                cal.EndText();
                y -= 17;
                promedio += mayo[j].calificacion;
                if (aux == mayo.Count)
                {
                    promedio /= 5;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    promediogeneralmes /= 2;
                    promediogeneralmes = Math.Round(promediogeneralmes, 1);
                    prommes[1, 8] = promedio;
                    prommes[2, 8] = promediogeneralmes;

                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    if (promediogeneralmes < 6)
                    {
                        cal2.SetColorFill(BaseColor.RED);
                    }
                    else { cal2.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 362, y, 0);
                    y -= 32;
                    cal1.EndText();
                    cal2.BeginText();
                    cal2.ShowTextAligned(1, promediogeneralmes.ToString(), 362, y, 0);
                    cal2.EndText();
                }

            }
            //------------------------------------------------------------------------------
            //------------------------------------------------------------------------------BUCLE PARA IMPRIMIR DATOS SI ES QUE LOS HAY DE JUNIO
            y = 559; promedio = 0; aux = 0; promediogeneralmes = 0;
            for (int j = 0; j < juni.Count; j++)
            {
                puntos_totales[9] += juni[j].calificacion;
                aux++;
                if (j == 8)
                {
                    promedio /= 8;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    prommes[0, 9] = promedio;
                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 383, y, 0);
                    cal1.EndText();
                    y -= 32;
                    promedio = 0;
                }
                if (juni[j].calificacion < 6)
                {
                    cal.SetColorFill(BaseColor.RED);
                }
                else
                {
                    cal.SetColorFill(BaseColor.BLACK);
                }
                cal.BeginText();
                cal.ShowTextAligned(1, Convert.ToString(juni[j].calificacion), 383, y, 0);
                cal.EndText();
                y -= 17;
                promedio += juni[j].calificacion;

                if (aux == juni.Count)
                {
                    promedio /= 5;
                    promedio = Math.Round(promedio, 1);
                    promediogeneralmes += promedio;
                    promediogeneralmes /= 2;
                    promediogeneralmes = Math.Round(promediogeneralmes, 1);
                    prommes[1, 9] = promedio;
                    prommes[2, 9] = promediogeneralmes;
                    if (promedio < 6)
                    {
                        cal1.SetColorFill(BaseColor.RED);
                    }
                    else { cal1.SetColorFill(BaseColor.BLACK); }
                    if (promediogeneralmes < 6)
                    {
                        cal2.SetColorFill(BaseColor.RED);
                    }
                    else { cal2.SetColorFill(BaseColor.BLACK); }
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, promedio.ToString(), 383, y, 0);
                    y -= 32;
                    cal1.EndText();
                    cal2.BeginText();
                    cal2.ShowTextAligned(1, promediogeneralmes.ToString(), 383, y, 0);
                    cal2.EndText();
                }
            }
            //---------------------------------------------------------------------------------------- BUCLE PARA CALCULAR PROMEDIOS POR BIMESTRE DE LAS MATERIAS, PROMEDIOS POR BIMESTRE DE LOS PROMEDIOS POR MES SI ES QUE HAY DATOS EN AMBOS MESES 

            int columnas = 0;
            for (int i = 0; i < 13; i++)
            {
                if (sept.Count != 0 && octu.Count != 0) { calificacionesmat[i, columnas] = (sept[i].calificacion + octu[i].calificacion) / 2; promediobimes[0, columnas] = (prommes[0, 0] + prommes[0, 1]) / 2; promediobimes[1, columnas] = (prommes[1, 0] + prommes[1, 1]) / 2; promediobimes[2, columnas] = (prommes[2, 0] + prommes[2, 1]) / 2; }
                if (novi.Count != 0 && dici.Count != 0) { calificacionesmat[i, columnas + 1] = (novi[i].calificacion + dici[i].calificacion) / 2; promediobimes[0, columnas + 1] = (prommes[0, 2] + prommes[0, 3]) / 2; promediobimes[1, columnas + 1] = (prommes[1, 2] + prommes[1, 3]) / 2; promediobimes[2, columnas + 1] = (prommes[2, 2] + prommes[2, 3]) / 2; }
                if (ener.Count != 0 && febr.Count != 0) { calificacionesmat[i, columnas + 2] = (ener[i].calificacion + febr[i].calificacion) / 2; promediobimes[0, columnas + 2] = (prommes[0, 4] + prommes[0, 5]) / 2; promediobimes[1, columnas + 2] = (prommes[1, 4] + prommes[1, 5]) / 2; promediobimes[2, columnas + 2] = (prommes[2, 4] + prommes[2, 5]) / 2; }
                if (marz.Count != 0 && abri.Count != 0) { calificacionesmat[i, columnas + 3] = (marz[i].calificacion + abri[i].calificacion) / 2; promediobimes[0, columnas + 3] = (prommes[0, 6] + prommes[0, 7]) / 2; promediobimes[1, columnas + 3] = (prommes[1, 6] + prommes[1, 7]) / 2; promediobimes[2, columnas + 3] = (prommes[2, 6] + prommes[2, 7]) / 2; }
                if (mayo.Count != 0 && juni.Count != 0) { calificacionesmat[i, columnas + 4] = (mayo[i].calificacion + juni[i].calificacion) / 2; promediobimes[0, columnas + 4] = (prommes[0, 8] + prommes[0, 9]) / 2; promediobimes[1, columnas + 4] = (prommes[1, 8] + prommes[1, 9]) / 2; promediobimes[2, columnas + 4] = (prommes[2, 8] + prommes[2, 9]) / 2; }
            }
            //----------------------------------------------------------------------------------
            float xnu = 446; //SE ESTABLECE NUEVA VARIABLE PARA COORDENADA EN X

            columnas = 0;
            y = 559; float yaux = 423; //NUEVAS VARIABLES PARA COORDENADAS Y
            for (int i = 0; i < 5; i++)
            { //BUCLE PARA RECORRER LAS COLUMNAS
                if (calificacionesmat[0, i] != 0)
                { //SI HAY DATOS DENTRO DE LA MATRIZ DE LOS PROMEDIOS DE ALGUN BIMESTRE
                    for (int j = 0; j < 13; j++)
                    {
                        puntos_totales[columnas + 10] += calificacionesmat[j, columnas]; //GUARDA LOS PUNTOS
                        if (calificacionesmat[j, columnas] < 6) { cal1.SetColorFill(BaseColor.RED); } else { cal1.SetColorFill(BaseColor.BLACK); } //ESCOGE COLORES
                        calificacionesmat[j, columnas] = Math.Round(calificacionesmat[j, columnas], 1);
                        cal1.BeginText();
                        cal1.ShowTextAligned(1, calificacionesmat[j, columnas].ToString(), xnu, y, 0); //IMPRIME PROMEDIO POR BIMESTRE DE UNA MATERIA
                        cal1.EndText();
                        y -= 17;
                        if (j == 7)
                        {
                            for (int k = 0; k < 3; k++) //BUCLE PARA IMPRIMIR LOS PROMEDIOS DE LOS PROMEDIOS DE BIMESTRE RECORRIENDO LA MATRIZ QUE LOS ALMACENA
                            {
                                if (promediobimes[k, columnas] < 6) { cal1.SetColorFill(BaseColor.RED); } else { cal1.SetColorFill(BaseColor.BLACK); }
                                promediobimes[k, columnas] = Math.Round(promediobimes[k, columnas], 1);
                                cal1.BeginText();
                                cal1.ShowTextAligned(1, promediobimes[k, columnas].ToString(), xnu, yaux, 0);//IMPRIME EL PROMEDIO EN LAS COORDENADAS DADAS
                                cal1.EndText();
                                if (k == 0) yaux = 306;
                                if (k == 1) yaux = 274;
                            }
                            y -= 32;
                        }
                    }
                    columnas += 1; //RECORRE OTRA COLUMNA (BIMESTRE)
                    xnu += 21;
                    y = 559;
                    yaux = 423;
                }

            }



            //----------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------
            int cuantoshaymat = 0, cuantoshayprom = 0; xnu = 190;

            cal1.SetColorFill(BaseColor.BLACK);
            cal1.SetFontAndSize(bf, 8);
            for (int i = 0; i < 10; i++)  //BUCLE PARA SABER CUANTOS MESES SE HAN REGISTRADO
            {
                if (puntos_totales[i] != 0) cuantoshaymat += 1; //SUMATORIA PARA GUARDAR CUANTOS MESES SE HAN REGISTRADO

            }
            for (int i = 10; i < 15; i++)
            {
                if (puntos_totales[i] != 0) cuantoshayprom += 1; //SUMATORIA PARA GUARDAR CUANTOS MESES SE HAN REGISTRADO EN BIMESTRE

            }
            if (cuantoshaymat != 0)
            {
                for (int i = 0; i < cuantoshaymat; i++) //BUCLE PARA IMPRIMIR LOS PUNTOS TOTALES HASTA LOS MESES QUE SE HALLAN REGISTRADO
                {
                    tempo = Math.Round(puntos_totales[i], 0);
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, tempo.ToString(), xnu, 257, 0);
                    cal1.EndText();
                    xnu += 21;

                }
            }
            xnu = 443;
            if (cuantoshayprom != 0)
            {
                for (int i = 0; i < cuantoshayprom; i++)//BUCLE PARA IMPRIMIR LOS PUNTOS TOTALES POR BIMESTRE HASTA LOS MESES QUE SE HALLAN REGISTRADO
                {
                    tempo = Math.Round(puntos_totales[10 + i], 0);
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, tempo.ToString(), xnu, 257, 0);
                    cal1.EndText();
                    xnu += 21;
                }
            }
            //----------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------
            int existencia = 0; columnas = 0;
            for (int i = 5; i > 0; i--)
            {
                if (calificacionesmat[0, i - 1] != 0) { existencia = i - 1; i = 0; } else { existencia = -1; }//BUCLE PARA OBTENER CUANTOS BIMESTRES SE HA OBTEIDO PROMEDIO

            }
            if (existencia >= 0)
            {
                for (int i = 0; i < existencia + 1; i++) //EXISTENCIA CONTROLA LAS COLUMNAS
                {
                    for (int j = 0; j < 13; j++) //BUCLE PARA SUMARATORIA DE PROMEDIOS POR BIMESTRES
                    {
                        promediostotalfinal[j] += calificacionesmat[j, i];

                    }

                }
                for (int i = 0; i < 13; i++) //BUCLE PARA CALCULAR LOS PROMEDIOS TOTALES
                {
                    promediostotalfinal[i] /= existencia + 1;
                }
            }


            //----------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------- //BUCLE PARA IMPRIMIR LOS PROMEDIOS TOTALES POR MATERIA Y BIMESTRE
            tempo = 0; xnu = 550; y = 559;
            if (promediostotalfinal[0] != 0) //SI HAY DATOS GUARDADOS EN LOS PROMEDIOS FINALES
            {
                for (int i = 0; i < 13; i++) //BUCLE PARA IMPRIMIR LOS PROMEDIOS TOTALES FINAL
                {
                    tempo = Math.Round(promediostotalfinal[i], 1);
                    puntos_totales[15] += tempo;
                    if (tempo < 6) { cal1.SetColorFill(BaseColor.RED); } else { cal1.SetColorFill(BaseColor.BLACK); } //ESCOGE UN COLOR
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, tempo.ToString(), xnu, y, 0); //IMPRIME LOS DATOS EN LAS COORDENADAS DADAS
                    cal1.EndText();
                    y -= 17;
                    if (i == 7)
                    {
                        y -= 32;
                    }
                }
            }


            //----------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------//BUCLE PARA IMPRIMIR LOS PROMEDIOS TOTALES DEL PROMEDIO 
            if (existencia >= 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < existencia + 1; j++)
                    {
                        promediostotalfinalprom[i] += promediobimes[i, j];
                    }
                    promediostotalfinalprom[i] /= existencia + 1;
                }
                xnu = 548; y = 424;

                for (int i = 0; i < 3; i++)
                {
                    tempo = Math.Round(promediostotalfinalprom[i], 1);
                    if (tempo < 6) { cal1.SetColorFill(BaseColor.RED); } else cal1.SetColorFill(BaseColor.BLACK);
                    cal1.BeginText();
                    cal1.ShowTextAligned(1, tempo.ToString(), xnu, y, 0);
                    cal1.EndText();
                    if (i == 0) y = 306;
                    if (i == 1) y = 273;
                }
                tempo = Math.Round(puntos_totales[15], 1);
                cal1.BeginText();
                cal1.ShowTextAligned(1, tempo.ToString(), 551, 256, 0);
                cal1.EndText();
            }


            //----------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------

            //---------------------------------------------------------------------------------- //SE CREA UN NUEVO CUMENTO CON TODO LO QUE SE HA IMPRESO
            PdfImportedPage page = escritor.GetImportedPage(lector, 1);
            nom.SetColorFill(BaseColor.BLACK);
            nom.SetFontAndSize(bf, 8);
            nom.BeginText();
            nom.ShowTextAligned(1, "HOLA", 150, 700, 0);
            nom.EndText();
            nom.AddTemplate(page, 0, 0);
            //Cerrar
            documento.Close();
            fs.Close();
            escritor.Close();
            lector.Close();

            enviarboletas(RegistrarCalificaciones.curp, true);
        }

        public bool enviarboletas(string curp_enviar, bool guardar)
        {
            if (AccesoInternet())
            {
                MailMessage correo = new MailMessage();
                SmtpClient envios = new SmtpClient();
                string co1 = "", co2 = "";
                bool vacio = false; ;
                MySqlCommand comando = new MySqlCommand(string.Format("SELECT tutor.email_tutor, tutor.email_extra_tutor from tutor inner join alumno on (alumno.curp_tutor = tutor.curp_tutor and alumno.curp_alumno = '{0}')", curp_enviar), Conexion.conectar());
                MySqlDataReader read = comando.ExecuteReader();
                while (read.Read())
                {
                    co1 = read[0].ToString().Trim();
                    co2 = read[1].ToString().Trim();
                }
                if (co2 == "")
                {
                    vacio = true;
                }
                try
                {
                    correo.To.Clear();
                    correo.Body = "BOLETA";
                    correo.Subject = "BOLETA DE CALIFICACION";
                    correo.IsBodyHtml = true;
                    correo.To.Add(co1);
                    //correo.To.Add("escom_97@hotmail.com");
                    if (!vacio)
                        correo.To.Add(co2.Trim());
                    //System.Net.Mail.Attachment achivo = new System.Net.Mail.Attachment(nuevo); //aqui paso el archivo
                    correo.Attachments.Add(new Attachment(GetStreamFile(nuevo), nuevo, "aplication/pdf"));
                    correo.From = new MailAddress("pruebasescuelas1297@gmail.com");
                    envios.Credentials = new NetworkCredential("pruebasescuelas1297@gmail.com", "pruebaescuela1");

                    envios.Host = "smtp.gmail.com";
                    envios.Port = 587;
                    envios.EnableSsl = true;

                    envios.Send(correo);
                    MessageBox.Show("ARCHIVO ENVIADO", "EXITO");
                    correo.Attachments.Clear();
                    return true;

                }
                catch (Exception e)
                {
                    MessageBox.Show("" + e + "", "error");
                    MessageBox.Show("se guardará la boleta", "error");
                    guardarboleta(guardar);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("NO HAY CONEXIÓN A INTERNET, EL ARCHIVO SE GUARDARÁ", "ADVERTENCIA");
                guardarboleta(guardar);
                return false;
            }
        }


        public static bool AccesoInternet()
        {
            try
            {
                IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }

        }
        public void guardarboleta(bool copiar)
        {
            try
            {
                Computer computadora = new Computer();
                if (copiar == true)
                    computadora.FileSystem.CopyFile(nuevo,Path.Combine(Application.StartupPath, "boletasguard\\" + RegistrarCalificaciones.curp + ".pdf") , true);
                MessageBox.Show("ARCHIVO GUARDADO", "EXITO");
                //System.Diagnostics.Process.Start("explorer", "C:\\Users\\chedraui\\Desktop\\bd\\Primaria\\Primaria\\boletas_pendientes");
                dirs = Directory.GetFiles(@""+Path.Combine(Application.StartupPath,"boletasguard"), "*.pdf");
                MessageBox.Show("" + dirs.Length + "", "EXITO");
                //enviarboletaspendientes();

            }
            catch (Exception e)
            {
                MessageBox.Show("" + e + "", "error");
            }

        }
        public void enviarboletaspendientes()
        {
            int a = 0;
            string[] ficherosexistentes = Directory.GetFiles(Path.Combine(Application.StartupPath, "boletasguard\\"));
            string t = "";
            if (ficherosexistentes.Length == 0)
            {
                MessageBox.Show("NO HAY BOLETAS PENDIENTES POR ENVIAR");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("¿ENVIAR TODAS LAS BOLETAS PENDIENTES?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    for (int i = 0; i < ficherosexistentes.Length; i++)
                    {
                        a = ficherosexistentes[i].Length;
                        //  System.Windows.Forms.MessageBox.Show("" + a + "  "+ficherosexistentes[i]+"");
                        t = ficherosexistentes[i];
                        nuevo = t;
                        t = t.Substring(a - 22, 18);
                        MessageBox.Show("" + t + "");
                        nuevo = ficherosexistentes[i];
                        if (enviarboletas(t, false))
                        {
                            Computer computadora = new Computer();
                            computadora.FileSystem.DeleteFile(Path.Combine(Application.StartupPath, "boletasguard\\" + t + ".pdf"));
                        }
                    }
                }
                else
                {
                    try
                    {
                        OpenFileDialog explorador = new OpenFileDialog();
                        explorador.Filter = "Archivo pdf(*,pdf)|*.pdf";
                        explorador.Title = "Archivos pdf";
                        explorador.InitialDirectory = Path.Combine(Application.StartupPath,"boletasguard\\");
                        if (explorador.ShowDialog() == DialogResult.OK)
                        {
                            t = explorador.FileName;
                            nuevo = t;
                            a = t.Length;
                            t = t.Substring(a - 22, 18);
                            MessageBox.Show("" + t + "");
                            if (enviarboletas(t, false))
                            {
                                Computer computadora = new Computer();
                                computadora.FileSystem.DeleteFile(Path.Combine(Application.StartupPath,"boletasguard\\" + t + ".pdf"));
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("OCURRIO UN ERROR INESPERADO, VUELVA A INTENTARLO");
                        MessageBox.Show("" + e + "");
                    }
                }
            }
        }

        public Stream GetStreamFile(string ruta)
        {
            using (FileStream fileStream = File.OpenRead(ruta))
            {
                MemoryStream memStream = new MemoryStream();
                memStream.SetLength(fileStream.Length);
                fileStream.Read(memStream.GetBuffer(), 0, (int)fileStream.Length);

                return memStream;
            }
        }

    }

}