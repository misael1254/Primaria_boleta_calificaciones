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
    public partial class Modificar : Form
    {
        public static string cp;
        public static string nuevaC;
        public static string Curp;
        public static string Paterno;
        public static string Materno;
        public static string Nombre;
        public static string sangre;
        public static string alergia;
        public Modificar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            desactivar();
            if (Curp_txt.Text.Equals(""))
            {
                if(listBox1.SelectedItems.Count>0&&listBox1.SelectedIndex!=-1)
                {
                    MySqlDataAdapter consulta = new MySqlDataAdapter("select curp_alumno,ap_pat_alumno,ap_mat_alumno,nombre_alumno,tipo_sangre,enfer_alergi from alumno where grado_grupo='" + listBox1.SelectedItem.ToString() + "';", Conexion.conectar());
                    DataTable tabla = new DataTable();
                    consulta.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                    listBox1.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Asegurese tomar una opción!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MySqlDataAdapter consulta = new MySqlDataAdapter("select curp_alumno,ap_pat_alumno,ap_mat_alumno,nombre_alumno,tipo_sangre,enfer_alergi from alumno where curp_alumno='" + Curp_txt.Text + "';", Conexion.conectar());
                DataTable tabla = new DataTable();
                consulta.Fill(tabla);
                dataGridView1.DataSource = tabla;
                listBox1.SelectedIndex = -1;
            }
        }

        private void Curp_txt_Leave(object sender, EventArgs e)
        {
            if(Curp_txt.Text.Equals(""))
            {
                listBox1.Enabled = true;
            }
            else
            {
                listBox1.Enabled = false;
            }
        }

        private void Curp_txt_TextChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            listBox1.Enabled = false;
            if(Curp_txt.Text.Equals(""))
            {
                listBox1.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex==-1)
            {
                Curp_txt.Enabled = true;
            }
            else
            {
                Curp_txt.Enabled = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Ncurp_txt.Text = row.Cells["curp_alumno"].Value.ToString();
                NApp_txt.Text = row.Cells["ap_pat_alumno"].Value.ToString();
                Apm_txt.Text = row.Cells["ap_mat_alumno"].Value.ToString();
                NVnombre_txt.Text = row.Cells["nombre_alumno"].Value.ToString();
                NTipoS_txt.Text = row.Cells["tipo_sangre"].Value.ToString();
                Nenfer_txt.Text = row.Cells["enfer_alergi"].Value.ToString();
                cp = Ncurp_txt.Text;
            activar();
        }

        public void Modificar_pic_Click(object sender, EventArgs e)
        {
            try
            {
                datos.op = "mod";

                if (Validar.seguir == false && Validar.permiso.Equals("n"))
                {
                    Validar frm = new Validar();
                    frm.Show();
                    datos.Curp = Ncurp_txt.Text;
                    datos.Paterno = NApp_txt.Text;
                    datos.Materno = Apm_txt.Text;
                    datos.Nombre = NVnombre_txt.Text;
                    datos.Sangre = NTipoS_txt.Text;
                    datos.Alergia = Nenfer_txt.Text;
                    datos.NuevaC = ObtenerDatos.generarCurpM(datos.Curp, datos.Nombre, datos.Paterno, datos.Materno);

                }
                else
                {
                    if (Validar.seguir == true && Validar.permiso.Equals("s"))
                    {

                        Ncurp_txt.Text = datos.NuevaC;
                        MySqlCommand update = new MySqlCommand(string.Format("update alumno set curp_alumno='{0}',ap_pat_alumno='{1}',ap_mat_alumno='{2}',nombre_alumno='{3}',tipo_sangre='{4}',enfer_alergi='{5}' where curp_alumno='" + cp + "';", datos.NuevaC, datos.Paterno, datos.Materno, datos.Nombre, datos.Sangre, datos.Alergia), Conexion.conectar());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Modificación exitosa!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desactivar();
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Las claves no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            { MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }


        public void activar()
        {
            Ncurp_txt.Enabled = false; NApp_txt.Enabled = true; Apm_txt.Enabled = true; NVnombre_txt.Enabled = true; NTipoS_txt.Enabled = true; Nenfer_txt.Enabled = true;
        }
        public void desactivar()
        {
            Ncurp_txt.Enabled = false; NApp_txt.Enabled = false; Apm_txt.Enabled = false; NVnombre_txt.Enabled = false; NTipoS_txt.Enabled = false; Nenfer_txt.Enabled = false;
        }
        public void limpiar()
        {
            Ncurp_txt.Text = ""; NApp_txt.Text=""; Apm_txt.Text=""; NVnombre_txt.Text = ""; NTipoS_txt.Text=""; Nenfer_txt.Text="";
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            desactivar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Primaria.Menu frm = new Primaria.Menu();
            frm.Show();
            Close();
        }
    }
}
