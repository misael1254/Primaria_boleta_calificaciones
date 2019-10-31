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
    public partial class Listado : Form
    {

        public static string grado;
        public static string tipo;
        public static string[] meses = new string[2];

        public Listado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            bimestre_CB.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (listgrupo.SelectedItems.Count != 1)
            { MessageBox.Show("Tiene que seleccionar un grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else {
                if (listgrupo.SelectedItem.ToString() == "Primero")
                {
                    grado = "1";
                }
                else if (listgrupo.SelectedItem.ToString() == "Segundo")
                {
                    grado = "2";
                }
                else if (listgrupo.SelectedItem.ToString() == "Tercero")
                {
                    grado = "3";
                }
                else if (listgrupo.SelectedItem.ToString() == "Cuarto")
                {
                    grado = "4";
                }
                else if (listgrupo.SelectedItem.ToString() == "Quinto")
                {
                    grado = "5";
                }
                else if (listgrupo.SelectedItem.ToString() == "Sexto")
                {
                    grado = "6";
                }
                else { grado = "0"; }
                if (grado == "1" || grado == "2" || grado == "3" || grado == "4" || grado == "5" || grado == "6")
                {
                    MySqlDataAdapter consulta = new MySqlDataAdapter("select ap_pat_alumno,ap_mat_alumno,nombre_alumno from alumno where grado_grupo='" + grado + "';", Conexion.conectar());
                    DataTable tabla = new DataTable();
                    consulta.Fill(tabla);
                    listado_grid.DataSource = tabla;
                    

                }
            }
           
        }



        private void listado_grid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listgrupo.SelectedIndex = -1;
            listado_grid.DataSource = "";
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Primaria.Menu frm = new Primaria.Menu();
            frm.Show();
            Close();
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            if (tipo_CB.SelectedText == null)
            {
                MessageBox.Show("Seleccione el tipo de lista");

            }
            else
            {
                if (tipo_CB.SelectedIndex == 0) { tipo = "Interno"; }
                else { tipo = "Externo"; }
                if (listgrupo.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione el grado");
                }
                else
                {
                    grado = listgrupo.SelectedItem.ToString();
                    if (tipo == "Externo") { listadoPDF.llenadoExcelExterno(); }
                    if (tipo == "Interno") { listadoPDF.listainterna(); }
                    MessageBox.Show("¡LISTO!");
                }

            }

        }

        private void bimestre_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bimestre_CB.SelectedIndex == 0) { meses[0] = "Sept"; meses[1] = "Octu"; }
            if (bimestre_CB.SelectedIndex == 1) { meses[0] = "Novi"; meses[1] = "Dici"; }
            if (bimestre_CB.SelectedIndex == 2) { meses[0] = "Ener"; meses[1] = "Febr"; }
            if (bimestre_CB.SelectedIndex == 3) { meses[0] = "Marz"; meses[1] = "Abri"; }
            if (bimestre_CB.SelectedIndex == 4) { meses[0] = "Mayo"; meses[1] = "Juni"; }
            if (bimestre_CB.SelectedIndex ==-1)
            {
                meses[1] = "nada";
                //nada
            }
            else { mes_cb.SelectedIndex = -1; }
        }

        private void mes_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(mes_cb.SelectedIndex!=-1)
            { meses[0] = mes_cb.SelectedItem.ToString().Substring(0, 4); }
            if (mes_cb.SelectedIndex == -1)
            {
                //nada
            }
            else
            {
                bimestre_CB.SelectedIndex = -1;
            }
            
        }
    }
}
 