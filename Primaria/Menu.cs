using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Primaria
{
    public partial class Menu : Form
    {
        public static string datos = "";
        public Menu()
        {
            InitializeComponent();
        }

        

        private void cerrSes_btn_Click(object sender, EventArgs e)
        {
            DateTime f = DateTime.Now;
            string fechasalida = f.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlCommand inser = new MySqlCommand("update bitacora set salida='" + fechasalida + "' where salida='nada';", Conexion.conectar());
            inser.ExecuteNonQuery();
            Form1 frm = new Form1();
            frm.Show();
            Close();
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            DateTime f = DateTime.Now;
            string fechasalida = f.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlCommand inser = new MySqlCommand("update bitacora set salida='" + fechasalida + "' where salida='nada';", Conexion.conectar());
            inser.ExecuteNonQuery();
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificar frm = new Modificar();
            frm.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Directorio frm = new Directorio();
            frm.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultaCalificaciones frm = new ConsultaCalificaciones();
            frm.Show();
            Close();
        }

        private void Inscripcion_Click(object sender, EventArgs e)
        {
            Insercion frm = new Insercion();
            frm.Show();
            Close();
        }

        private void Bajas_Click(object sender, EventArgs e)
        {
            Bajas frm = new Primaria.Bajas();
            frm.Show();
            Close();
        }

        private void Calif_Click(object sender, EventArgs e)
        {
           // Form2 frm = new Form2();
            RegistrarCalificaciones frm = new RegistrarCalificaciones();
            frm.Show();
            Close();
        }

        private void Modif_Click(object sender, EventArgs e)
        {
            Modificar frm = new Modificar();
            frm.Show();
            Close();
        }

        private void ConsCalif_Click(object sender, EventArgs e)
        {
            ConsultaCalificaciones frm = new ConsultaCalificaciones();
            frm.Show();
            Close();
        }

        private void direct_Click(object sender, EventArgs e)
        {
            Directorio frm = new Directorio();
            frm.Show();
            Close();
        }

        private void List_Click(object sender, EventArgs e)
        {
            Listado frm = new Listado();
            frm.Show();
            Close();
        }
    }
}
