using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Primaria
{
    public static class opera
    {
        /*public static List<datos> bajaespecifica(string curp)
        {
            List<datos> lista = new List<datos>();
            MySqlCommand cons = new MySqlCommand(string.Format("select curp_alumno,ap_pat_alumno,ap_mat_alumno,nombre_alumno,edad_alumno,fecha_nacimiento_alumno,sexo_alumno,tipo_sangre,enfer_alergi,curp_tutor from alumno where curp_alumno='" + curp + "';"), Conexion.conectar());
            MySqlDataReader lector = cons.ExecuteReader();
             
            while(lector.Read())
            {
                datos ob = new datos();
                ob.curp_alumno = lector.GetString(0);
                ob.ap_pat_alumno = lector.GetString(1);
                ob.ap_mat_alumno = lector.GetString(2);
                ob.nombre_alumno = lector.GetString(3);
                ob.edad_alumno = lector.GetInt32(4);
                ob.fecha_nacimiento_alumno = lector.GetString(5);
                ob.sexo_alumno = lector.GetString(6);
                ob.tipo_sangre = lector.GetString(7);
                ob.enfer_alergi = lector.GetString(8);
                ob.curp_tutor = lector.GetString(9);
                lista.Add(ob);
            }
            return lista;
            
        }*/
    
    }
}
