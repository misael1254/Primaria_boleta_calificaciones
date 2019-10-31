using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Primaria
{
    class Conexion
    {
        
            public static MySqlConnection conectar()
        {
            MySqlConnection con= new MySqlConnection ("server=localhost; database=primaria; Uid=root; pwd=;");
            con.Open();
            return con;
        }
        public static MySqlConnection cerrar()
        {
            MySqlConnection con = new MySqlConnection("server=localhost; database=primaria; Uid=root; pwd=;");
            con.Close();
            return con;
        }
        
    }
}
