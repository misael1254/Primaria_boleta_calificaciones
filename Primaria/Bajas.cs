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
    public partial class Bajas : Form
    {
        MySqlDataAdapter query;
        public string valor;
        int y;

        public Bajas()
        {
            InitializeComponent();
        }

        private void Bajas_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }


        private void bus_btn_Click(object sender, EventArgs e)
        {
            if (grupo_txt.Text.Equals(""))
            {
                // MessageBox.Show("Parece que no hay algo que buscar", "¡Inserte la CURP!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (listBox1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione una opción por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlDataAdapter com = new MySqlDataAdapter("select *from alumno where grado_grupo='" + listBox1.SelectedItem.ToString() + "';", Conexion.conectar());
                    DataTable tab = new DataTable();
                    com.Fill(tab);
                    bajas_grid.DataSource = tab;
                }
            }
            else
            {
                query = new MySqlDataAdapter("select * from alumno where curp_alumno = '" + grupo_txt.Text + "'", Conexion.conectar());
                DataTable tabla = new DataTable();
                query.Fill(tabla);
                bajas_grid.DataSource = tabla;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            grupo_txt.Text = "";
            listBox1.SelectedItem = false;
            //bajas_grid.DataSource = opera.bajaespecifica(grupo_txt.Text);
        }

        public  void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {

                datos.op = "baja";
                var ob = new Bajas();
                if (Validar.seguir == false)
                {
                    Validar frm = new Validar();
                    frm.Show();
                    y = bajas_grid.CurrentCellAddress.Y;
                    datos.val1 = valor = bajas_grid.Rows[y].Cells[0].Value.ToString();
                }
                if (Validar.seguir == true && Validar.permiso == "s")
                {

                    /* MySqlCommand quitarllave = new MySqlCommand("SET foreign_key_checks = 0;", Conexion.conectar());
                     quitarllave.ExecuteNonQuery();*/

                    MySqlCommand com = new MySqlCommand("delete from alumno where curp_alumno='" + datos.val1 + "';", Conexion.conectar());
                    com.ExecuteNonQuery();
                    datos.op = "nada carnal";

                    MessageBox.Show("Exito!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Validar.seguir = false; Validar.permiso = "n";
                }
                else if (Validar.seguir == true && Validar.permiso == "n") { MessageBox.Show("La clave no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Validar.seguir = false; }
                //MySqlCommand ponerllave = new MySqlCommand("SET foreign_key_checks = 1;", Conexion.conectar());
                //ponerllave.ExecuteNonQuery();
            }
            catch (Exception)
            { MessageBox.Show("Ocurrio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
            }
        }
    
