using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ms=Microsoft.Office.Interop.Excel;
using SautinSoft.Document;
using System.Windows.Forms;
using System.IO;


namespace Primaria
{
    public class listadoPDF
    {

       public static string[,] informacion;
        public static double[,] calificaciones1;
        public static double[,] calificaciones2;
        public static int dimension,mat;
        public static int g;
        public static double[,] promedio;
        public static string ruta;
        public static string bim;
        public static string fecha;
        public static int pos;


        public static string rutacomb;
        public static void llenadoExterno()
        {
            if (Listado.meses[1] != "nada")
            {
                if (Listado.meses[0] == "Sept") { bim = "Primero"; }
                if (Listado.meses[0] == "Novi") { bim = "Segundo"; }
                if (Listado.meses[0] == "Ener") { bim = "Tercero"; }
                if (Listado.meses[0] == "Marz") { bim = "Cuarto"; }
                if (Listado.meses[0] == "Abri") { bim = "Quinto"; }
            }
            DateTime f = DateTime.Now;
            fecha = f.ToString("dd-MM-yyyy");
            if (Listado.meses[1] != "nada")
            {
                if (Listado.grado == "Primero")
                {
                    mat = 6;
                    g = 1;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listaexterna1.xlsx");
                    pos = 11;
                }
                if (Listado.grado == "Segundo")
                {
                    pos = 11;
                    mat = 6;
                    g = 2;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listaexterna2.xlsx");
                }
                if (Listado.grado == "Tercero")
                {
                    pos = 12;
                    mat = 7;
                    g = 3;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listaexterna3.xlsx");
                }
                if (Listado.grado == "Cuarto")
                {
                    pos = 13;
                    mat = 8;
                    g = 4;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listaexterna4.xlsx");
                }
                if (Listado.grado == "Quinto")
                {
                    pos = 13;
                    mat = 8;
                    g = 5;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listaexterna5.xlsx");
                }
                if (Listado.grado == "Sexto")
                {
                    pos = 13;
                    mat = 8;
                    g = 6;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listaexterna6.xlsx");
                }
            }
            else
            {
                if(Listado.grado == "Primero")
                {
                    mat = 6;
                    g = 1;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listaexternamen1.xlsx");
                    pos = 11;
                }
                if (Listado.grado == "Segundo")
                {
                    pos = 11;
                    mat = 6;
                    g = 2;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listaexternamen2.xlsx");
                }
                if (Listado.grado == "Tercero")
                {
                    pos = 12;
                    mat = 7;
                    g = 3;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listaexternamen3.xlsx");
                }
                if (Listado.grado == "Cuarto")
                {
                    pos = 13;
                    mat = 8;
                    g = 4;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listaexternamen4.xlsx");
                }
                if (Listado.grado == "Quinto")
                {
                    pos = 13;
                    mat = 8;
                    g = 5;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listaexternamen5.xlsx");
                }
                if (Listado.grado == "Sexto")
                {
                    pos = 13;
                    mat = 8;
                    g = 6;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listaexternamen6.xlsx");
                }
            }
            MySqlCommand cuenta = new MySqlCommand(string.Format("SELECT COUNT(*) from alumno where grado_grupo='{0}';",g), Conexion.conectar());
             dimension = Convert.ToInt16(cuenta.ExecuteScalar());
            informacion = new string[dimension, 4];
            MySqlCommand info = new MySqlCommand(string.Format("SELECT A.ap_pat_alumno,A.ap_mat_alumno,A.nombre_alumno,A.curp_alumno from alumno A where A.grado_grupo='{0}';",g), Conexion.conectar());
            MySqlDataReader lec = info.ExecuteReader();
            int cont = 0;
            while(lec.Read())
            {
                informacion[cont, 0] = lec.GetString(3);
                informacion[cont, 1] = lec.GetString(0);
                informacion[cont, 2] = lec.GetString(1);
                informacion[cont, 3] = lec.GetString(2);
                cont++;
            }
            lec.Close();
            //---------------HASTA AQUÍ YO YA TENGO CURP, NOMBRE Y SEXO----------------------------------
            //---------------VAMOS CON LAS CALIFICACIONES------------------------------------------------
            calificaciones1 = new double[cont, mat];
           
            int x = 0;
            for(int i=0;i<cont;i++)
            { 
                MySqlCommand calif = new MySqlCommand(string.Format("SELECT calif_materia from calificacion,alumno,materia where calificacion.curp_alumno='{0}' and alumno.grado_grupo='{1}' and mes_calificacion='{2}' and alumno.curp_alumno=calificacion.curp_alumno and materia.especif_materia='SEP' and materia.clave_materia=calificacion.clave_materia;", informacion[i, 0],g,Listado.meses[0]), Conexion.conectar());
               MySqlDataReader lec1 = calif.ExecuteReader();
                x = 0;
                while (lec1.Read())
                {
                    calificaciones1[i, x] = lec1.GetDouble(0);
                    x++;
                }
                lec1.Close();
            }
            if (Listado.meses[1] != "nada")
            {
                calificaciones2 = new double[cont, mat];
                for (int i = 0; i < cont; i++)
                {
                    MySqlCommand calif2 = new MySqlCommand(string.Format("SELECT calif_materia from calificacion,alumno,materia where calificacion.curp_alumno='{0}' and alumno.grado_grupo='{1}' and mes_calificacion='{2}' and alumno.curp_alumno=calificacion.curp_alumno and materia.especif_materia='SEP' and materia.clave_materia=calificacion.clave_materia;", informacion[i, 0], g, Listado.meses[1]), Conexion.conectar());
                    MySqlDataReader lec2 = calif2.ExecuteReader();
                    x = 0;
                    while (lec2.Read())
                    {
                        calificaciones2[i, x] = lec2.GetDouble(0);
                        x++;
                    }
                    lec2.Close();
                }
                promedio = new double[cont, mat];
                for (int k = 0; k < cont; k++)
                {
                    for (int h = 0; h < mat; h++)
                    {
                        promedio[k, h] = (calificaciones1[k, h] + calificaciones2[k, h]) / 2;
                    }
                }
            }
          
        }

        public static void llenadoExcelExterno()
        {
            llenadoExterno();
            Microsoft.Office.Interop.Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook libro;
            Microsoft.Office.Interop.Excel._Worksheet hoja;
            libro = ex.Workbooks.Open(rutacomb, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            hoja = (Microsoft.Office.Interop.Excel._Worksheet)libro.ActiveSheet;
            int x = 0;
            for (int i = 10; i <dimension+10; i++)
            {
                hoja.Cells[i, 2] = informacion[x, 0];
                hoja.Cells[i, 3] = informacion[x, 1];
                hoja.Cells[i, 4] = informacion[x, 2];
                hoja.Cells[i, 5] = informacion[x, 3];
                x++;
                
            }
            int c = 0, r = 0;
            if (Listado.meses[1] != "nada")
            {
                for (int i = 10; i < dimension + 10; i++)
                {
                    c = 0;
                    for (int j = 6; j < 6 + mat; j++)
                    {
                        hoja.Cells[i, j] = Convert.ToString(promedio[r, c] + ".00").Substring(0, 3);
                        c++;
                    }
                    r++;
                }
                hoja.Cells[7, 8] = bim;
            }
            else
            {
                for (int i = 10; i < dimension + 10; i++)
                {
                    c = 0;
                    for (int j = 6; j < 6 + mat; j++)
                    {
                        hoja.Cells[i, j] = Convert.ToString(calificaciones1[r, c] + ".00").Substring(0, 3);
                        c++;
                    }
                    r++;
                }
                hoja.Cells[7, 8] = Listado.meses[0];
            }
           
            hoja.Cells[6, 8] = Listado.grado;
            hoja.Cells[7, pos] = fecha;
            ex.Visible = false;
            ex.UserControl = true;
            //libro.Save();
            ex.Application.DisplayExcel4Menus = false;
            string nombre;
            if (Listado.meses[1] != "nada") { nombre = Listado.grado + "_" + bim; }
            else { nombre = Listado.grado + "_" + Listado.meses[0]; }
            try
            {
                hoja.ExportAsFixedFormat(ms.XlFixedFormatType.xlTypePDF, Path.Combine(Application.StartupPath, "primaria\\"+nombre));
            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.ToString());
            }
            ex.ActiveWorkbook.Close(true, Type.Missing);
            ex.Quit();
            ex = null;
          
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = Path.Combine(Application.StartupPath, "primaria\\"+nombre+".pdf");
            proc.Start();
            proc.Close();

        }
        public static void listainternallenar()
        {
            if (Listado.meses[1] != "nada")
            {
                if (Listado.meses[0] == "Sept") { bim = "Primero"; }
                if (Listado.meses[0] == "Novi") { bim = "Segundo"; }
                if (Listado.meses[0] == "Ener") { bim = "Tercero"; }
                if (Listado.meses[0] == "Marz") { bim = "Cuarto"; }
                if (Listado.meses[0] == "Abri") { bim = "Quinto"; }
                if (Listado.grado == "Primero")
                {
                    mat = 6;
                    g = 1;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listainterna1.xlsx");
                    pos = 12;
                }
                if (Listado.grado == "Segundo")
                {
                    pos = 11;
                    mat = 6;
                    g = 2;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listainterna2.xlsx");
                }
                if (Listado.grado == "Tercero")
                {
                    pos = 12;
                    mat = 7;
                    g = 3;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listainterna3.xlsx");
                }
                if (Listado.grado == "Cuarto")
                {
                    pos = 13;
                    mat = 8;
                    g = 4;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listainterna4.xlsx");
                }
                if (Listado.grado == "Quinto")
                {
                    pos = 13;
                    mat = 8;
                    g = 5;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listainterna5.xlsx");
                }
                if (Listado.grado == "Sexto")
                {
                    pos = 13;
                    mat = 8;
                    g = 6;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listainterna6.xlsx");
                }
            }
            else
            {
                if (Listado.grado == "Primero")
                {
                    mat = 6;
                    g = 1;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listainternamen1.xlsx");
                    pos = 12;
                }
                if (Listado.grado == "Segundo")
                {
                    pos = 11;
                    mat = 6;
                    g = 2;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listainternamen2.xlsx");
                }
                if (Listado.grado == "Tercero")
                {
                    pos = 12;
                    mat = 7;
                    g = 3;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listainternamen3.xlsx");
                }
                if (Listado.grado == "Cuarto")
                {
                    pos = 13;
                    mat = 8;
                    g = 4;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listainternamen4.xlsx");
                }
                if (Listado.grado == "Quinto")
                {
                    pos = 13;
                    mat = 8;
                    g = 5;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listainternamen5.xlsx");
                }
                if (Listado.grado == "Sexto")
                {
                    pos = 13;
                    mat = 8;
                    g = 6;
                    rutacomb = Path.Combine(Application.StartupPath, "primaria\\listainternamen6.xlsx");
                }
            }
            MySqlCommand cuenta = new MySqlCommand(string.Format("SELECT COUNT(*) from alumno where grado_grupo='{0}';", g), Conexion.conectar());
            dimension = Convert.ToInt16(cuenta.ExecuteScalar());
            informacion = new string[dimension, 3];
            MySqlCommand info = new MySqlCommand(string.Format("SELECT A.ap_pat_alumno,A.ap_mat_alumno,A.nombre_alumno,A.curp_alumno,A.sexo_alumno from alumno A where A.grado_grupo='{0}';", g), Conexion.conectar());
            MySqlDataReader lec = info.ExecuteReader();
            int cont = 0;
            while (lec.Read())
            {
                informacion[cont, 0] = lec.GetString(3);
                informacion[cont, 1] = lec.GetString(4);
                informacion[cont, 2] = lec.GetString(0) + " " + lec.GetString(1) + " " + lec.GetString(2);
                
                cont++;
            }
        }
        public static void listainterna()
        {
            listainternallenar();
            Microsoft.Office.Interop.Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook libro;
            Microsoft.Office.Interop.Excel._Worksheet hoja;
            libro = ex.Workbooks.Open(rutacomb, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            hoja = (Microsoft.Office.Interop.Excel._Worksheet)libro.ActiveSheet;
            int x = 0;
            for (int i = 15; i < dimension + 14; i++)
            {
                hoja.Cells[i, 2] = informacion[x, 1];
                hoja.Cells[i, 3] = informacion[x, 0];
                hoja.Cells[i, 4] = informacion[x, 2];
                
                x++;

            }
            if (Listado.meses[1] != "nada")
            {
                hoja.Cells[11, pos] = Listado.meses[0];
                hoja.Cells[11, pos + 8] = Listado.meses[1];
                hoja.Cells[11, 28] = bim;
            }
            else { hoja.Cells[11, pos] = Listado.meses[0]; }
            hoja.Cells[9, 13] = Listado.grado;
            ex.Visible = false;
            ex.UserControl = true;
            string nombre;
            nombre = Listado.grado + "_" + bim+"_Interno";
            try
            {
                hoja.ExportAsFixedFormat(ms.XlFixedFormatType.xlTypePDF, Path.Combine(Application.StartupPath, "primaria\\" + nombre));
            }
            catch(Exception ee )
            {
                System.Windows.Forms.MessageBox.Show(ee.ToString());
            }
            //      libro.Save();
            ex.Application.DisplayExcel4Menus = false;
            ex.ActiveWorkbook.Close(true, Type.Missing);
            ex.Quit();
            ex = null;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = Path.Combine(Application.StartupPath, "primaria\\" + nombre + ".pdf");
            proc.Start();
            proc.Close();
        }

    }
}
