using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Primaria
{
    class ObtenerDatos
    {
        public static string segunda;
        public static string segunda1;
        public static char aux;
        public static string GetSexo(string sex)
        {

            if (sex == "Hombre")
            {
                return "H";
            }
            else
            {
                return "M";
            }
        }
        public static string Getgrado(string grado)
        {
            if (grado == "1")
            {
                return "1";
            }
            if (grado == "2")
            {
                return "2";
            }
            if (grado == "3")
            {
                return "3";
            }
            if (grado == "4")
            {
                return "4";
            }
            if (grado == "5")
            {
                return "5";
            }
            else
            {
                return "6";
            }
        }
        public static string GetProfesor(string profe)
        {
            if (profe == "1")
            {
                return "Anuar Vargas Clemente";
            }
            if (profe == "2")
            {
                return "Azucena Basilio Encarnación";
            }
            if (profe == "3")
            {
                return "Maria Luisa Soto Olea";
            }
            if (profe == "4")
            {
                return "Blanca Martinez Ochoa";
            }
            if (profe == "5")
            {
                return "Francisco Salgado Delabra";
            }
            else
            {
                return "Jesús Ramirez Carmona";
            }
        }
        public static int ExistenciaTutor(string c)
        {
            int contador = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("select curp_tutor from tutor where curp_tutor='" + c + "';"), Conexion.conectar());
            MySqlDataReader lec = comando.ExecuteReader();
            while (lec.Read())
            {
                contador++;
            }
            return contador;
        }
        public static int ExistenciaAlumno(string c)
        {
            int contador = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("select curp_alumno from alumno where curp_alumno='" + c + "';"), Conexion.conectar());
            MySqlDataReader lec = comando.ExecuteReader();
            while (lec.Read())
            {
                contador++;
            }
            return contador;
        }

        public static string GetPermiso(string Nac, string grad)
        {
            DateTime f = DateTime.Now;
            string fechaac = f.ToString("yyyy-MM-dd");
            string anno = fechaac.Substring(0, 4);
            int an = int.Parse(anno);
            string annonac = Nac.Substring(0, 4);
            int ann = int.Parse(annonac);
            string mes = Nac.Substring(6, 2);
            int edad = an - ann;
            if ((edad == 6 && grad == "1")/*||(edad==5 && grad=="1" && (mes=="09"|| mes == "10" || mes == "11" || mes == "12" )) || (edad == 6 && grad == "1" && (mes == "09" || mes == "10" || mes == "11" || mes == "12"))*/)
            {
                return "s";
            }
            else if ((edad == 7 && grad == "2") /*|| (edad == 6 && grad == "2" && (mes == "09" || mes == "10" || mes == "11" || mes == "12")) || (edad == 7 && grad == "2" && (mes == "09" || mes == "10" || mes == "11" || mes == "12"))*/)
            {
                return "s";
            }
            else if ((edad == 8 && grad == "3") /*|| (edad == 7 && grad == "3" && (mes == "09" || mes == "10" || mes == "11" || mes == "12")) || (edad == 8 && grad =="3" && (mes == "09" || mes == "10" || mes == "11" || mes == "12"))*/)
            {
                return "s";
            }
            else if ((edad == 9 && grad == "4") /*|| (edad == 8 && grad == "4" && (mes == "09" || mes == "10" || mes == "11" || mes == "12")) || (edad == 9 && grad == "4" && (mes == "09" || mes == "10" || mes == "11" || mes == "12"))*/)
            {
                return "s";
            }
            else if ((edad == 10 && grad == "5") /*||/* (edad == 9 && grad == "5" && (mes == "09" || mes == "10" || mes == "11" || mes == "12")) || (edad == 10 && grad == "5" && (mes == "09" || mes == "10" || mes == "11" || mes == "12"))*/)
            {
                return "s";
            }
            else if ((edad == 11 && grad == "6") /*|| (edad == 10 && grad == "6" && (mes == "09" || mes == "10" || mes == "11" || mes == "12")) || (edad == 11 && grad == "6" && (mes == "09" || mes == "10" || mes == "11" || mes == "12"))*/)
            {
                return "s";
            }
            else
            {
                return "n";
            }
        }
        public static datos.EdadFechaNac DatosNac(string curp)
        {
            datos.EdadFechaNac calculo = new datos.EdadFechaNac();
            string an = "20" + curp.Substring(4, 2);
            string mes = curp.Substring(6, 2);
            string dia = curp.Substring(8, 2);
            DateTime f = DateTime.Now;
            string fechaActual = f.ToString("yyyy-MM-dd");
            string annActual = fechaActual.Substring(0, 4);
            int fechaNac = Convert.ToInt32(an);
            int fechaAhora = Convert.ToInt32(annActual);
            int edad = fechaAhora - fechaNac;
            string rEdad = Convert.ToString(edad);
            calculo.AnnoNac = an;
            calculo.DiaNac = dia;
            calculo.MesNac = mes;
            calculo.Edad = rEdad;
            return calculo;

        }
        public static int ComprobarCURP(string curp, string nombre, string paterno, string materno, string sexo)
        {

            string primera = paterno.Substring(0, 1);
            char aux;
            if (paterno.Substring(1, 1).ToUpper() == "A" || paterno.Substring(1, 1).ToUpper() == "O" || paterno.Substring(1, 1).ToUpper() == "E" || paterno.Substring(1, 1).ToUpper() == "U" || paterno.Substring(1, 1).ToUpper() == "I")
            {
                segunda = paterno.Substring(1, 1);
            }
            else
            {
                for (int i = 0; i < paterno.Length; i++)
                {
                    aux = Convert.ToChar(paterno.Substring((i + 1), 1).ToUpper());
                    if (aux == 'A' || aux == 'E' || aux == 'I' || aux == 'O' || aux == 'U')
                    {
                        segunda = Convert.ToString(aux);
                        i = paterno.Length;
                    }
                }
            }
            string LApellido = primera.ToUpper() + segunda.ToUpper();
            string LAppellidoM = materno.Substring(0, 1).ToUpper();
            string LNombre = nombre.Substring(0, 1).ToUpper();
            string LSexo = sexo.Substring(0, 1).ToUpper();
            if (LApellido == curp.Substring(0, 2) && LAppellidoM == curp.Substring(2, 1) && LNombre == curp.Substring(3, 1) && LSexo == curp.Substring(10, 1))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public static int ComprobarCurpTutor(string curp, string nombre, string paterno, string materno)
        {


            string primera = paterno.Substring(0, 1);
            char aux;
            if (paterno.Substring(1, 1).ToUpper() == "A" || paterno.Substring(1, 1).ToUpper() == "O" || paterno.Substring(1, 1).ToUpper() == "E" || paterno.Substring(1, 1).ToUpper() == "U" || paterno.Substring(1, 1).ToUpper() == "I")
            {
                segunda1 = paterno.Substring(1, 1);
            }
            else
            {
                for (int i = 0; i < paterno.Length; i++)
                {
                    aux = Convert.ToChar(paterno.Substring((i + 1), 1).ToUpper());
                    if (aux == 'A' || aux == 'E' || aux == 'I' || aux == 'O' || aux == 'U')
                    {
                        segunda1 = Convert.ToString(aux);
                        i = paterno.Length;
                    }
                }
            }
            string LApellido = primera.ToUpper() + segunda1.ToUpper();
            string LAppellidoM = materno.Substring(0, 1).ToUpper();
            string LNombre = nombre.Substring(0, 1).ToUpper();
            if (LApellido == curp.Substring(0, 2) && LAppellidoM == curp.Substring(2, 1) && LNombre == curp.Substring(3, 1))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        /*  public static string generarCurpM(string curp, string apPaterno, string apMaterno, string Nombre)
          {
              string segundaparte = curp.Substring(4, 14).ToUpper();
              string pl = curp.Substring(0, 1).ToUpper();
              string seg;

              if (apPaterno.Substring(1, 1).ToUpper() == "A" || apPaterno.Substring(1, 1).ToUpper() == "O" || apPaterno.Substring(1, 1).ToUpper() == "E" || apPaterno.Substring(1, 1).ToUpper() == "U" || apPaterno.Substring(1, 1).ToUpper() == "I")
              {
                  seg = apPaterno.Substring(1, 1);
              }
              else
              {
                  for (int i = 0; i < apPaterno.Length; i++)
                  {
                      aux = Convert.ToChar(apPaterno.Substring((i + 1), 1).ToUpper());
                      if (aux == 'A' || aux == 'E' || aux == 'I' || aux == 'O' || aux == 'U')
                      {
                          seg = Convert.ToString(aux);
                          i = apPaterno.Length;
                      }
                  }
              }

                  string Am = apMaterno.Substring(1, 1).ToUpper();
                  string nom = Nombre.Substring(1, 1).ToUpper();
                  string completa = pl + seg + Am + nom + segundaparte;
                  return completa;

          }*/

        public static string generarCurpM(string curp, string nombre, string paterno, string materno)
        {

            string seg = curp.Substring(4, 14);
            string primera = paterno.Substring(0, 1);
            char aux;
            if (paterno.Substring(1, 1).ToUpper() == "A" || paterno.Substring(1, 1).ToUpper() == "O" || paterno.Substring(1, 1).ToUpper() == "E" || paterno.Substring(1, 1).ToUpper() == "U" || paterno.Substring(1, 1).ToUpper() == "I")
            {
                segunda = paterno.Substring(1, 1);
            }
            else
            {
                for (int i = 0; i < paterno.Length; i++)
                {
                    aux = Convert.ToChar(paterno.Substring((i + 1), 1).ToUpper());
                    if (aux == 'A' || aux == 'E' || aux == 'I' || aux == 'O' || aux == 'U')
                    {
                        segunda = Convert.ToString(aux);
                        i = paterno.Length;
                    }
                }
            }
            string LApellido = primera.ToUpper() + segunda.ToUpper();
            string LAppellidoM = materno.Substring(0, 1).ToUpper();
            string LNombre = nombre.Substring(0, 1).ToUpper();
            return (LApellido + LAppellidoM + LNombre + seg);

        }
    }
}
