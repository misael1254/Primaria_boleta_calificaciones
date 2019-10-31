using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
namespace Primaria

{
   public  class calif
    {
       public static int cont = 0;
        public static string viejo;
        public static string nuevo;

        public struct dat
        {
            public float calificacion;
            float Calificacion
            {
                get { return calificacion; }
                set { calificacion = value; }
            }
        }

        public static void pdf1ro()
        {
            if (RegistrarCalificaciones.grado == "1" || RegistrarCalificaciones.grado == "2")
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
                //Arriba se guardó en la lista
                //Para imprimir Abajo
                if (RegistrarCalificaciones.grado == "1")
                {
                    boletas.viejo =Path.Combine(Application.StartupPath, "primaria\\1viejo.pdf");
                  
                    boletas.nuevo = Path.Combine(Application.StartupPath, "primaria\\1nuevo.pdf");
                }
                else if (RegistrarCalificaciones.grado == "2")
                {
                    boletas.viejo = Path.Combine(Application.StartupPath, "primaria\\2viejo.pdf");
                    boletas.nuevo = Path.Combine(Application.StartupPath, "primaria\\2nuevo.pdf");
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

                PdfReader lector = new PdfReader(boletas.viejo);
                var tam = lector.GetPageSizeWithRotation(1);
                Document documento = new Document(tam);  //se creo un documento con el tamaño del otro pdf
                                                         //se abre la escritura
                FileStream fs = new FileStream(boletas.nuevo, FileMode.Create, FileAccess.Write);
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
                int conta = 570;
                int var = 0;
                double aux;
                for (int i = 0; i < diag.Count; i++)
                {
                    aux = Convert.ToDouble(diag[i].calificacion);

                    if (aux < 6.0) { rojo.SetColorFill(BaseColor.RED); }
                    else { rojo.SetColorFill(BaseColor.BLACK); }
                    rojo.BeginText();
                    rojo.ShowTextAligned(1, Convert.ToString(diag[i].calificacion + ".00").Substring(0, 3), 192, (570 - (i * 17)), 0);
                    rojo.EndText();

                }

                for (int j = 0; j < sept.Count; j++)
                {

                    if (sept[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                    else { cal.SetColorFill(BaseColor.BLACK); }
                    if (j == 6)
                    {
                        conta = 446;
                        var = 0;

                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(sept[j].calificacion), 210, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                    }
                    else
                    {
                        if (j == 7) { var = 1; }
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(sept[j].calificacion), 210, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                        //conta++;
                    }
                }
                conta = 570;
                var = 0;
                for (int j = 0; j < octu.Count; j++)
                {
                    if (octu[j].calificacion < 6.0) { cal2.SetColorFill(BaseColor.RED); }
                    else { cal2.SetColorFill(BaseColor.BLACK); }
                    if (j == 6)
                    {
                        conta = 446;
                        var = 0;
                        cal2.BeginText();
                        cal2.ShowTextAligned(1, Convert.ToString(octu[j].calificacion), 230, (conta - (var * 17)), 0);
                        cal2.EndText();
                        var++;
                    }
                    else
                    {
                        if (j == 7) { var = 1; }
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(octu[j].calificacion), 230, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                        //conta++;
                    }
                }
                conta = 570;
                var = 0;
                for (int j = 0; j < novi.Count; j++)
                {
                    if (novi[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                    else { cal.SetColorFill(BaseColor.BLACK); }

                    if (j == 6)
                    {
                        conta = 446;
                        var = 0;
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(novi[j].calificacion), 250, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                    }
                    else
                    {
                        if (j == 7) { var = 1; }
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(novi[j].calificacion), 250, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                        //conta++;
                    }
                }
                conta = 570;
                var = 0;
                for (int j = 0; j < dici.Count; j++)
                {
                    if (dici[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                    else { cal.SetColorFill(BaseColor.BLACK); }
                    if (j == 6)
                    {
                        conta = 446;
                        var = 0;
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(dici[j].calificacion), 270, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                    }
                    else
                    {
                        if (j == 7) { var = 1; }
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(dici[j].calificacion), 270, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                        //conta++;
                    }
                }
                conta = 570;
                var = 0;
                for (int j = 0; j < ener.Count; j++)
                {
                    if (ener[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                    else { cal.SetColorFill(BaseColor.BLACK); }
                    if (j == 6)
                    {
                        conta = 446;
                        var = 0;
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(ener[j].calificacion), 290, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                    }
                    else
                    {
                        if (j == 7) { var = 1; }
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(ener[j].calificacion), 290, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                        //conta++;
                    }
                }
                conta = 570;
                var = 0;
                for (int j = 0; j < febr.Count; j++)
                {
                    if (febr[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                    else { cal.SetColorFill(BaseColor.BLACK); }
                    if (j == 6)
                    {
                        conta = 446;
                        var = 0;
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(febr[j].calificacion), 310, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                    }
                    else
                    {
                        if (j == 7) { var = 1; }
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(febr[j].calificacion), 310, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                        //conta++;
                    }
                }
                conta = 570;
                var = 0;
                for (int j = 0; j < marz.Count; j++)
                {
                    if (marz[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                    else { cal.SetColorFill(BaseColor.BLACK); }
                    if (j == 6)
                    {
                        conta = 446;
                        var = 0;
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(marz[j].calificacion), 330, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                    }
                    else
                    {
                        if (j == 7) { var = 1; }
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(marz[j].calificacion), 330, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                        //conta++;
                    }
                }
                conta = 570;
                var = 0;
                for (int j = 0; j < abri.Count; j++)
                {
                    if (abri[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                    else { cal.SetColorFill(BaseColor.BLACK); }
                    if (j == 6)
                    {
                        conta = 446;
                        var = 0;
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(abri[j].calificacion), 350, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                    }

                    else
                    {
                        if (j == 7) { var = 1; }
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(abri[j].calificacion), 350, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                        //conta++;
                    }
                }
                conta = 570;
                var = 0;
                for (int j = 0; j < mayo.Count; j++)
                {
                    if (mayo[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                    else { cal.SetColorFill(BaseColor.BLACK); }
                    if (j == 6)
                    {
                        conta = 446;
                        var = 0;
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(mayo[j].calificacion), 370, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                    }
                    else
                    {
                        if (j == 7) { var = 1; }
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(mayo[j].calificacion), 370, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                        //conta++;
                    }
                }
                conta = 570;
                var = 0;
                for (int j = 0; j < juni.Count; j++)
                {
                    if (juni[j].calificacion < 6.0) { cal.SetColorFill(BaseColor.RED); }
                    else { cal.SetColorFill(BaseColor.BLACK); }
                    if (j == 6)
                    {
                        conta = 446;
                        var = 0;

                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(juni[j].calificacion), 390, (conta - (var * 17)), 0);
                        cal.EndText();
                        var++;
                    }
                    else
                    {
                        if (j == 7) { var = 1; }
                        cal.BeginText();
                        cal.ShowTextAligned(1, Convert.ToString(juni[j].calificacion), 390, (conta - (var * 17)), 0);
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
                int consep = 6, conext = 5;
                for (int i = 0; i < 11; i++)
                {
                    if (i < 6)
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
                    if (i >= 6)
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
                double[,] bimestresep = new double[6, 5];
                double[,] bimestresext = new double[5, 5];
                int x = 0;
                for (int j = 0; j < 5; j++)
                {
                    x = 0;
                    for (int i = 0; i < 11; i++)
                    {
                        if (i < 6)
                        {
                            if (j == 0 && RegistrarCalificaciones.pr >= 2) { bimestresep[i, j] = (sept[i].calificacion + octu[i].calificacion) / 2; }
                            if (j == 1 && RegistrarCalificaciones.pr >= 4) { bimestresep[i, j] = (novi[i].calificacion + dici[i].calificacion) / 2; }
                            if (j == 2 && RegistrarCalificaciones.pr >= 6) { bimestresep[i, j] = (ener[i].calificacion + febr[i].calificacion) / 2; }
                            if (j == 3 && RegistrarCalificaciones.pr >= 8) { bimestresep[i, j] = (marz[i].calificacion + abri[i].calificacion) / 2; }
                            if (j == 4 && RegistrarCalificaciones.pr >= 10) { bimestresep[i, j] = (mayo[i].calificacion + juni[i].calificacion) / 2; }
                        }
                        if (i >= 6)
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
                    for (int i = 0; i < 6; i++)
                    {
                        bimsumasep[j] = bimsumasep[j] + bimestresep[i, j];
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    bimsep[i] = bimsumasep[i] / 6;
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
                    for (int i = 0; i < 5; i++)
                    {
                        sumagenerales = sumagenerales + (bimsumasep[i] + bimsumaext[i]);
                    }
                    puntgenerales = sumagenerales / 5;
                    PdfContentByte cali = escritor.DirectContent;

                    cali.SetColorFill(BaseColor.BLACK);
                    cali.SetFontAndSize(bf, 8);
                    double[] promfinal = new double[14];
                    double[] sumafinal = new double[14];
                    double[] sumase = new double[1];
                    double[] sumaex = new double[1];
                    double[] sumax = new double[1];
                    int contar = 0;
                    for (int i = 0; i < 11; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i < 6) { sumafinal[i] = sumafinal[i] + bimestresep[i, j]; }

                            if (i == 0) { sumase[i] = sumase[i] + bimsep[j]; sumaex[i] = sumaex[i] + bimext[j]; sumax[i] = sumax[i] + promgenbi[j]; }
                            if (i >= 6 && contar < 5) { sumafinal[i] = sumafinal[i] + bimestresext[contar, j]; }


                        }
                        if (i >= 6) { contar++; }
                    }
                    for (int i = 0; i < 11; i++) { if (i < 6) { promfinal[i] = sumafinal[i] / 5; } if (i >= 6) { promfinal[i] = sumafinal[i] / 5; } }
                    double promfsep = sumase[0] / 6;
                    double promfext = sumaext[0] / 5;
                    double gen = (promfsep + promfext) / 2;
                    contar = 0;
                    for (int i = 0; i < 11; i++)
                    {
                        if (promfsep < 6.0) { cali.SetColorFill(BaseColor.RED); }
                        else { cali.SetColorFill(BaseColor.BLACK); }
                        cali.BeginText();
                        cali.ShowTextAligned(1, Convert.ToString(promfsep + ".00").Substring(0, 3), 550, 463, 0);
                        cali.EndText();
                        if (promfext < 6.0) { cali.SetColorFill(BaseColor.RED); }
                        else { cali.SetColorFill(BaseColor.BLACK); }
                        cali.BeginText();
                        cali.ShowTextAligned(1, Convert.ToString(promfext + ".00").Substring(0, 3), 550, 363, 0);
                        cali.EndText();
                        if (gen < 6.0) { cali.SetColorFill(BaseColor.RED); }
                        else { cali.SetColorFill(BaseColor.BLACK); }


                        cali.BeginText();
                        cali.ShowTextAligned(1, Convert.ToString(gen + ".00").Substring(0, 3), 550, 340, 0);
                        cali.EndText();
                        if (i < 6)
                        {
                            if (promfinal[i] < 6.0) { cali.SetColorFill(BaseColor.RED); }
                            else { cali.SetColorFill(BaseColor.BLACK); }
                            cali.BeginText();
                            cali.ShowTextAligned(1, Convert.ToString(promfinal[i] + ".00").Substring(0, 3), 550, 570 - (i * 17), 0);
                            cali.EndText();
                        }
                        if (i >= 6)
                        {
                            if (promfinal[i] < 6.0) { cali.SetColorFill(BaseColor.RED); }
                            else { cali.SetColorFill(BaseColor.BLACK); }
                            cali.BeginText();
                            cali.ShowTextAligned(1, Convert.ToString(promfinal[i] + ".00").Substring(0, 3), 550, 446 - (contar * 17), 0);
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
                    for (int i = 0; i < 6; i++)
                    {
                        if (j == 0 && RegistrarCalificaciones.pr >= 2)
                        {
                            if (bimestresep[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimestresep[i, j]+".00").Substring(0, 3), 450, 570 - (i * 17), 0);
                            prom.EndText();
                            if (bimsep[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimsep[j] + ".00").Substring(0, 3), 450, 463, 0);
                            prom.EndText();
                            if (bimext[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimext[j] + ".00").Substring(0, 3), 450, 364, 0);
                            prom.EndText();
                            if (promgenbi[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(promgenbi[j] + ".00").Substring(0, 3), 450, 338, 0);
                            prom.EndText();
                            if (i < 5)
                            {
                                if (bimestresext[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                                else { prom.SetColorFill(BaseColor.BLACK); }
                                prom.BeginText();
                                prom.ShowTextAligned(1, Convert.ToString(bimestresext[i, j]+".00").Substring(0, 3), 450, 446 - (posY * 17), 0);
                                prom.EndText();
                                posY++;
                            }
                            prom.SetColorFill(BaseColor.BLACK);
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString((bimsumasep[0] + bimsumaext[0]) + ".00").Substring(0, 4), 450 , 320, 0);
                            prom.EndText();

                        }
                        if (j == 1 && RegistrarCalificaciones.pr >= 4)
                        {
                            if (bimestresep[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimestresep[i, j] + ".00").Substring(0, 3), 470, 570 - (i * 17), 0);
                            prom.EndText();
                            if (bimsep[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimsep[j] + ".00").Substring(0, 3), 470, 463, 0);
                            prom.EndText();
                            if (bimext[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimext[j] + ".00").Substring(0, 3), 470, 364, 0);
                            prom.EndText();
                            if (promgenbi[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(promgenbi[j] + ".00").Substring(0, 3), 470, 338, 0);
                            prom.EndText();
                            if (i < 5)
                            {
                                if (bimestresext[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                                else { prom.SetColorFill(BaseColor.BLACK); }
                                prom.BeginText();
                                prom.ShowTextAligned(1, Convert.ToString(bimestresext[i, j]+".00").Substring(0, 3), 470, 446 - (posY * 17), 0);
                                prom.EndText();
                                posY++;
                            }
                            prom.SetColorFill(BaseColor.BLACK);
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString((bimsumasep[0] + bimsumaext[0]) + ".00").Substring(0, 4), 470, 320, 0);
                            prom.EndText();
                        }
                        if (j == 2 && RegistrarCalificaciones.pr >= 6)
                        {
                            if (bimestresep[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimestresep[i, j]+".00").Substring(0, 3), 490, 570 - (i * 17), 0);
                            prom.EndText();
                            if (bimsep[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimsep[j] + ".00").Substring(0, 3), 490, 463, 0);
                            prom.EndText();
                            if (bimext[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimext[j] + ".00").Substring(0, 3), 490, 364, 0);
                            prom.EndText();
                            if (promgenbi[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(promgenbi[j] + ".00").Substring(0, 3), 490, 338, 0);
                            prom.EndText();
                            if (i < 5)
                            {
                                if (bimestresext[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                                else { prom.SetColorFill(BaseColor.BLACK); }
                                prom.BeginText();
                                prom.ShowTextAligned(1, Convert.ToString(bimestresext[i, j] + ".00").Substring(0, 3), 490, 446 - (posY * 17), 0);
                                prom.EndText();
                                posY++;
                            }
                            prom.SetColorFill(BaseColor.BLACK);
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString((bimsumasep[0] + bimsumaext[0]) + ".00").Substring(0, 4), 490, 320, 0);
                            prom.EndText();
                        }
                        if (j == 3 && RegistrarCalificaciones.pr >= 8)
                        {
                            if (bimestresep[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimestresep[i, j] + ".00").Substring(0, 3), 510, 570 - (i * 17), 0);
                            prom.EndText();
                            if (bimsep[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimsep[j] + ".00").Substring(0, 3), 510, 463, 0);
                            prom.EndText();
                            if (bimext[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimext[j] + ".00").Substring(0, 3), 510, 364, 0);
                            prom.EndText();
                            if (promgenbi[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(promgenbi[j] + ".00").Substring(0, 3), 510, 338, 0);
                            prom.EndText();
                            if (i < 5)
                            {
                                if (bimestresext[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                                else { prom.SetColorFill(BaseColor.BLACK); }
                                prom.BeginText();
                                prom.ShowTextAligned(1, Convert.ToString(bimestresext[i, j]).Substring(0, 3), 510, 446 - (posY * 17), 0);
                                prom.EndText();
                                posY++;
                            }
                            prom.SetColorFill(BaseColor.BLACK);
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString((bimsumasep[0] + bimsumaext[0]) + ".00").Substring(0, 4), 510, 320, 0);
                            prom.EndText();
                        }
                        if (j == 4 && RegistrarCalificaciones.pr >= 10)
                        {
                            if (bimestresep[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimestresep[i, j] + ".00").Substring(0, 3), 530, 570 - (i * 17), 0);
                            prom.EndText();
                            if (bimsep[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimsep[j] + ".00").Substring(0, 3), 530, 463, 0);
                            prom.EndText();
                            if (bimext[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(bimext[j] + ".00").Substring(0, 3), 530, 364, 0);
                            prom.EndText();
                            if (promgenbi[j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                            else { prom.SetColorFill(BaseColor.BLACK); }
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(promgenbi[j] + ".00").Substring(0, 3), 530, 338, 0);
                            prom.EndText();
                            if (i < 5)
                            {
                                if (bimestresext[i, j] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                                else { prom.SetColorFill(BaseColor.BLACK); }
                                prom.BeginText();
                                prom.ShowTextAligned(1, Convert.ToString(bimestresext[i, j] + ".00").Substring(0, 3), 530, 446 - (posY * 17), 0);
                                prom.EndText();
                                posY++;
                            }
                            prom.SetColorFill(BaseColor.BLACK);
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString((bimsumasep[4] + bimsumaext[4]) + ".00").Substring(0, 4), 530, 320, 0);
                            prom.EndText();
                            prom.BeginText();
                            prom.ShowTextAligned(1, Convert.ToString(puntgenerales + ".00").Substring(0, 4), 550, 320, 0);
                            prom.EndText();
                        }
                    }

                }
               
                for (int i = 0; i < RegistrarCalificaciones.pr; i++)
                {
                    if (promediosep[i] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                    else { prom.SetColorFill(BaseColor.BLACK); }
                    prom.BeginText();
                    prom.ShowTextAligned(1, Convert.ToString(promediosep[i] + ".00").Substring(0, 3), 210 + (i * 20), 463, 0);
                    prom.EndText();
                    if (promedioext[i] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                    else { prom.SetColorFill(BaseColor.BLACK); }
                    prom.BeginText();
                    prom.ShowTextAligned(1, Convert.ToString(promedioext[i] + ".00").Substring(0, 3), 210 + (i * 20), 364, 0);
                    prom.EndText();
                    if (promgen[i] < 6.0) { prom.SetColorFill(BaseColor.RED); }
                    else { prom.SetColorFill(BaseColor.BLACK); }
                    prom.BeginText();
                    prom.ShowTextAligned(1, Convert.ToString(promgen[i] + ".00").Substring(0, 3), 210 + (i * 20), 338, 0);
                    prom.EndText();
                    prom.SetColorFill(BaseColor.BLACK);
                    prom.BeginText();
                    prom.ShowTextAligned(1, Convert.ToString((sumasep[i] + sumaext[i]) + ".00").Substring(0, 4), 210 + (i * 20), 320, 0);
                    prom.EndText();
                 
                }
                if (promd < 6.0) { prom.SetColorFill(BaseColor.RED); }
                else { prom.SetColorFill(BaseColor.BLACK); }
                prom.BeginText();
                prom.ShowTextAligned(1, Convert.ToString(promd + ".00").Substring(0, 3), 192, 463, 0);
                prom.EndText();
                prom.BeginText();
                prom.ShowTextAligned(1, Convert.ToString(suma + ".00").Substring(0, 4), 192, 320, 0);
                prom.EndText();
                prom.BeginText();
                prom.ShowTextAligned(1, Convert.ToString(promd + ".00").Substring(0, 3), 192, 340, 0);
                prom.EndText();

                PdfImportedPage page = escritor.GetImportedPage(lector, 1);
                nom.SetColorFill(BaseColor.BLACK);
                nom.SetFontAndSize(bf, 8);
                nom.BeginText();
                nom.ShowTextAligned(1, RegistrarCalificaciones.dat, 395, 695, 0);
                nom.EndText();
                nom.AddTemplate(page, 0, 0);
                //Cerrar
                documento.Close();
                fs.Close();
                escritor.Close();
                lector.Close();

                boletas metodos = new boletas();
                metodos.enviarboletas(RegistrarCalificaciones.curp, true);

            }
            if (RegistrarCalificaciones.grado=="3")
            {
                boletas metodos = new boletas();
                metodos.boleta3();
            }
            if (RegistrarCalificaciones.grado == "4"|| RegistrarCalificaciones.grado == "5" || RegistrarCalificaciones.grado == "6")
            {
                boletas metodos = new boletas();
                metodos.boleta4();
            }
            
        }
       
        }
    }

