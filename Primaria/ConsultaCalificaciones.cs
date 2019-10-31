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
    public partial class ConsultaCalificaciones : Form
    {
        public ConsultaCalificaciones()
        {
            InitializeComponent();
        }
        string mes = "";
        private void Cb_grad_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter("SELECT ap_pat_alumno,ap_mat_alumno,nombre_alumno from alumno where grado_grupo='"+ Cb_grad.SelectedItem.ToString()+"';", Conexion.conectar());
            DataTable tabla = new DataTable();
            consulta.Fill(tabla);
            alumnodgv.DataSource = tabla;
        }

        private void alumnodgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Cb_mes.SelectedIndex!=-1)
            {
                mes = Cb_mes.SelectedItem.ToString();
            }
            else { mes = ""; }
            DataGridViewRow row = this.alumnodgv.Rows[e.RowIndex];
            string nombre = "", apP = "", apM = "";
            apP = row.Cells["ap_pat_alumno"].Value.ToString();
            apM = row.Cells["ap_mat_alumno"].Value.ToString();
            nombre = row.Cells["nombre_alumno"].Value.ToString();
            if(mes!="")
            {
               
                
                string CurpCon = "";
                MySqlCommand curp = new MySqlCommand(string.Format("SELECT curp_alumno from alumno where ap_pat_alumno='{0}'and ap_mat_alumno='{1}'and nombre_alumno='{2}';", apP, apM, nombre), Conexion.conectar());
                CurpCon =Convert.ToString( curp.ExecuteScalar());
                MySqlDataAdapter calificaciones = new MySqlDataAdapter(string.Format("select materia.especif_materia, materia.nombre_materia,calificacion.calif_materia from alumno INNER JOIN calificacion on(calificacion.curp_alumno = alumno.curp_alumno and(calificacion.mes_calificacion = '{0}' and(calificacion.curp_alumno ='{1}')))  INNER JOIN materia on(materia.clave_materia = calificacion.clave_materia) ORDER BY FIELD(materia.especif_materia,'EXT');", mes,CurpCon), Conexion.conectar());
                DataTable tab = new DataTable();
                calificaciones.Fill(tab);
                Califdgv.DataSource = tab;
                MySqlCommand com = new MySqlCommand(string.Format("SELECT AVG(calif_materia) from calificacion,materia where curp_alumno='{0}' and materia.clave_materia=calificacion.clave_materia and materia.especif_materia='SEP' and mes_calificacion='{1}';",CurpCon,mes), Conexion.conectar());
                string prom =Convert.ToString( com.ExecuteScalar());
                MySqlCommand com2 = new MySqlCommand(string.Format("SELECT AVG(calif_materia) from calificacion,materia where curp_alumno='{0}' and materia.clave_materia=calificacion.clave_materia and materia.especif_materia='EXT' and mes_calificacion='{1}';", CurpCon, mes), Conexion.conectar());
                string prom2 = Convert.ToString(com2.ExecuteScalar());
                label6.Visible = false; //calsep.Visible = false;
                label7.Visible = false; //calext.Visible = false;
                if (prom!=""&&prom!="0")
                {
                    calsep.Text = prom.Substring(0, 1);

                }
                else { prom = "0.0";  calsep.Text = prom; }

                if (prom2 != ""&&prom2!="0") { calext.Text = prom2.Substring(0, 1); } else { prom2 = "0.0"; calext.Text = prom2; }
                
                label6.Visible = true;
                label7.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Tiene que elegir un MES", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaCalificaciones_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void alumnodgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Primaria.Menu frm = new Primaria.Menu();
            frm.Show();
            Close();
        }
    }
}
