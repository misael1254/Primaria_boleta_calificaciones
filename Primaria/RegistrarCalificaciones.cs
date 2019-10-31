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

    public partial class RegistrarCalificaciones : Form
    {
        string[] meses = new string[] { "Diag", "Sept", "Octu", "Novi", "Dici", "Ener", "Febr", "Marz", "Abri", "Mayo", "Juni" };
       public static string mes = "", curp = "";
        string[] m = new string[13];
        public static string mesact = "";
        string[] calificaciones = new string[13];
        int contmes = 0;
        int ciclo = 0;
        public static string mm;
        public static string grado,dat;
        public static int pr = 0;

        private void CB_Val6_dec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public RegistrarCalificaciones()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            comboBox2.Items.Clear();
           
            MySqlDataAdapter grupo = new MySqlDataAdapter("Select curp_alumno,ap_pat_alumno,ap_mat_alumno,nombre_alumno from alumno where grado_grupo='" + comboBox1.SelectedItem.ToString() + "';", Conexion.conectar());
            DataTable tabla = new DataTable();
            grupo.Fill(tabla);
            dataGridView1.DataSource = tabla;



        }

        private void RegistrarCalificaciones_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (mesact != "Diag" && mesact!="FINALIZADO")
                {
                    groupBox1.Visible = true;
                    nom1();
                }  
                else 
                {
                    groupBox1.Visible = true;
                    diag1();
                }
            

        }
        public void diag1()
        {
            string val1 = "", val2 = "", val3 = "", val4 = "", val5 = "", val6 = "", val7 = "", val8 = "";
            if (comboBox1.SelectedItem.ToString() == "1")
            {
                val1 = "Educación Artística:"; val2 = "Educación Fisica:"; val3 = "Exploración de la Naturaleza y Sociedad :"; val4 = "Español 1:"; val5 = "Formación Civica y Etica:"; val6 = "Matematicas 1:";
            }
            else if (comboBox1.SelectedItem.ToString() == "2")
            {
                val1 = "Educación Artística:"; val2 = "Educación Fisica:"; val3 = "Exploración de la Naturaleza y Sociedad 2:"; val4 = "Español 2:"; val5 = "Formación Civica y Etica:"; val6 = "Matematicas 2:";
            }
            else if (comboBox1.SelectedItem.ToString() == "4")
            {
                val1 = "Ciencias Naturales 2:"; val2 = "Educación Artistica:"; val3 = "Educación fisica:"; val4 = "Español 4:"; val5 = "Formación Civica y Etica:"; val6 = "Geografía:"; val7 = "Historia:"; val8 = "Matematicas 4:";
            }
            else if (comboBox1.SelectedItem.ToString() == "5")
            {
                val1 = "Ciencias Naturales 3:"; val2 = "Educación Artistica:"; val3 = "Educación fisica:"; val4 = "Español 5:"; val5 = "Formación Civica y Etica:"; val6 = "Geografía 2:"; val7 = "Historia 2:"; val8 = "Matematicas 5:";
            }
            else if (comboBox1.SelectedItem.ToString() == "6")
            {
                val1 = "Ciencias Naturales 4:"; val2 = "Educación Artistica:"; val3 = "Educación fisica:"; val4 = "Español 6:"; val5 = "Formación Civica y Etica:"; val6 = "Geografía 3:"; val7 = "Historia 3:"; val8 = "Matematicas 6:";
            }
            else if (comboBox1.SelectedItem.ToString() == "3")
            {
                val1 = "Educación Artística:"; val2 = "Educación Fisica:"; val3 = "Ciencias Naturales 1:"; val4 = "Español 3:"; val5 = "Formación Civica y Etica:"; val6 = "Matematicas 3:"; val7 = "La Entidad en donde Vivo";
            }
            if (comboBox1.SelectedItem.ToString() == "1" || comboBox1.SelectedItem.ToString() == "2")
            {
                label4.Text = val1;
                label5.Text = val2;
                label6.Text = val3;
                label7.Text = val4;
                label8.Text = val5;
                label9.Text = val6;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                Cb_Val7_ent.Visible = false;
                CB_Val7_dec.Visible = false;
                Cb_Val8_ent.Visible = false;
                CB_Val8_dec.Visible = false;
                Cb_Val9_ent.Visible = false;
                CB_Val9_dec.Visible = false;
                Cb_Val10_ent.Visible = false;
                CB_Val10_dec.Visible = false;
                Cb_Val11_ent.Visible = false;
                CB_Val11_dec.Visible = false;
                CB_Val12_dec.Visible = false;
                Cb_Val12_ent.Visible = false;
                CB_Val12_dec.Visible = false;
                Cb_Val13_ent.Visible = false;
                CB_Val13_dec.Visible = false;
            }
            if (comboBox1.SelectedItem.ToString() == "4" || comboBox1.SelectedItem.ToString() == "5" || comboBox1.SelectedItem.ToString() == "6")
            {
                label4.Text = val1;
                label5.Text = val2;
                label6.Text = val3;
                label7.Text = val4;
                label8.Text = val5;
                label9.Text = val6;
                label10.Text = val7;
                label11.Text = val8;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                Cb_Val9_ent.Visible = false;
                CB_Val9_dec.Visible = false;
                Cb_Val10_ent.Visible = false;
                CB_Val10_dec.Visible = false;
                Cb_Val11_ent.Visible = false;
                CB_Val11_dec.Visible = false;
                CB_Val12_dec.Visible = false;
                Cb_Val12_ent.Visible = false;
                CB_Val12_dec.Visible = false;
                Cb_Val13_ent.Visible = false;
                CB_Val13_dec.Visible = false;
            }
            if (comboBox1.SelectedItem.ToString() == "3")
            {
                label4.Text = val1;
                label5.Text = val2;
                label6.Text = val3;
                label7.Text = val4;
                label8.Text = val5;
                label9.Text = val6;
                label10.Text = val7;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                Cb_Val8_ent.Visible = false;
                CB_Val8_dec.Visible = false;
                Cb_Val9_ent.Visible = false;
                CB_Val9_dec.Visible = false;
                Cb_Val10_ent.Visible = false;
                CB_Val10_dec.Visible = false;
                Cb_Val11_ent.Visible = false;
                CB_Val11_dec.Visible = false;
                CB_Val12_dec.Visible = false;
                Cb_Val12_ent.Visible = false;
                CB_Val12_dec.Visible = false;
                Cb_Val13_ent.Visible = false;
                CB_Val13_dec.Visible = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            curp = row.Cells["curp_alumno"].Value.ToString();
            comboBox2.Items.Clear();
            mesact = obtenermes(curp);
            if (mesact == "1")
            {
                MessageBox.Show("El alumno ya ha sido evaluado en su totalidad", "Evaluación completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox2.Items.Add("FINALIZADO");
                comboBox2.SelectedIndex = 0;
            }
            else
            {
                comboBox2.Items.Add(mesact);
                comboBox2.SelectedIndex = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.SelectedItem.ToString() == "3" && comboBox2.SelectedItem.ToString() != "Diag") { ciclo = 12; calificaciones[0] = Cb_Val1_ent.SelectedItem.ToString() + "." + CB_Val1_dec.SelectedItem.ToString(); calificaciones[1] = Cb_Val2_ent.SelectedItem.ToString() + "." + CB_Val2_dec.SelectedItem.ToString(); calificaciones[2] = Cb_Val3_ent.SelectedItem.ToString() + "." + CB_Val3_dec.SelectedItem.ToString(); calificaciones[3] = Cb_Val4_ent.SelectedItem.ToString() + "." + CB_Val4_dec.SelectedItem.ToString(); calificaciones[4] = Cb_Val5_ent.SelectedItem.ToString() + "." + CB_Val5_dec.SelectedItem.ToString(); calificaciones[5] = Cb_Val6_ent.SelectedItem.ToString() + "." + CB_Val6_dec.SelectedItem.ToString(); calificaciones[6] = Cb_Val7_ent.SelectedItem.ToString() + "." + CB_Val7_dec.SelectedItem.ToString(); calificaciones[7] = Cb_Val8_ent.SelectedItem.ToString() + "." + CB_Val8_dec.SelectedItem.ToString(); calificaciones[8] = Cb_Val9_ent.SelectedItem.ToString() + "." + CB_Val9_dec.SelectedItem.ToString(); calificaciones[9] = Cb_Val10_ent.SelectedItem.ToString() + "." + CB_Val10_dec.SelectedItem.ToString(); calificaciones[10] = Cb_Val11_ent.SelectedItem.ToString() + "." + CB_Val11_dec.SelectedItem.ToString(); calificaciones[11] = Cb_Val12_ent.SelectedItem.ToString() + "." + CB_Val12_dec.SelectedItem.ToString(); }
                if (comboBox1.SelectedItem.ToString() == "3" && comboBox2.SelectedItem.ToString() == "Diag") { ciclo = 7; calificaciones[0] = Cb_Val1_ent.SelectedItem.ToString() + "." + CB_Val1_dec.SelectedItem.ToString(); calificaciones[1] = Cb_Val2_ent.SelectedItem.ToString() + "." + CB_Val2_dec.SelectedItem.ToString(); calificaciones[2] = Cb_Val3_ent.SelectedItem.ToString() + "." + CB_Val3_dec.SelectedItem.ToString(); calificaciones[3] = Cb_Val4_ent.SelectedItem.ToString() + "." + CB_Val4_dec.SelectedItem.ToString(); calificaciones[4] = Cb_Val5_ent.SelectedItem.ToString() + "." + CB_Val5_dec.SelectedItem.ToString(); calificaciones[5] = Cb_Val6_ent.SelectedItem.ToString() + "." + CB_Val6_dec.SelectedItem.ToString(); calificaciones[6] = Cb_Val7_ent.SelectedItem.ToString() + "." + CB_Val7_dec.SelectedItem.ToString(); }
                if ((comboBox1.SelectedItem.ToString() == "1" || comboBox1.SelectedItem.ToString() == "2") && comboBox2.SelectedItem.ToString() != "Diag") { ciclo = 11; calificaciones[0] = Cb_Val1_ent.SelectedItem.ToString() + "." + CB_Val1_dec.SelectedItem.ToString(); calificaciones[1] = Cb_Val2_ent.SelectedItem.ToString() + "." + CB_Val2_dec.SelectedItem.ToString(); calificaciones[2] = Cb_Val3_ent.SelectedItem.ToString() + "." + CB_Val3_dec.SelectedItem.ToString(); calificaciones[3] = Cb_Val4_ent.SelectedItem.ToString() + "." + CB_Val4_dec.SelectedItem.ToString(); calificaciones[4] = Cb_Val5_ent.SelectedItem.ToString() + "." + CB_Val5_dec.SelectedItem.ToString(); calificaciones[5] = Cb_Val6_ent.SelectedItem.ToString() + "." + CB_Val6_dec.SelectedItem.ToString(); calificaciones[6] = Cb_Val7_ent.SelectedItem.ToString() + "." + CB_Val7_dec.SelectedItem.ToString(); calificaciones[7] = Cb_Val8_ent.SelectedItem.ToString() + "." + CB_Val8_dec.SelectedItem.ToString(); calificaciones[8] = Cb_Val9_ent.SelectedItem.ToString() + "." + CB_Val9_dec.SelectedItem.ToString(); calificaciones[9] = Cb_Val10_ent.SelectedItem.ToString() + "." + CB_Val10_dec.SelectedItem.ToString(); calificaciones[10] = Cb_Val11_ent.SelectedItem.ToString() + "." + CB_Val11_dec.SelectedItem.ToString(); }
                if ((comboBox1.SelectedItem.ToString() == "1" || comboBox1.SelectedItem.ToString() == "2") && comboBox2.SelectedItem.ToString() == "Diag") { ciclo = 6; calificaciones[0] = Cb_Val1_ent.SelectedItem.ToString() + "." + CB_Val1_dec.SelectedItem.ToString(); calificaciones[1] = Cb_Val2_ent.SelectedItem.ToString() + "." + CB_Val2_dec.SelectedItem.ToString(); calificaciones[2] = Cb_Val3_ent.SelectedItem.ToString() + "." + CB_Val3_dec.SelectedItem.ToString(); calificaciones[3] = Cb_Val4_ent.SelectedItem.ToString() + "." + CB_Val4_dec.SelectedItem.ToString(); calificaciones[4] = Cb_Val5_ent.SelectedItem.ToString() + "." + CB_Val5_dec.SelectedItem.ToString(); calificaciones[5] = Cb_Val6_ent.SelectedItem.ToString() + "." + CB_Val6_dec.SelectedItem.ToString(); }
                if ((comboBox1.SelectedItem.ToString() == "4" || comboBox1.SelectedItem.ToString() == "5" || comboBox1.SelectedItem.ToString() == "6") && comboBox2.SelectedItem.ToString() == "Diag") { ciclo = 8; calificaciones[0] = Cb_Val1_ent.SelectedItem.ToString() + "." + CB_Val1_dec.SelectedItem.ToString(); calificaciones[1] = Cb_Val2_ent.SelectedItem.ToString() + "." + CB_Val2_dec.SelectedItem.ToString(); calificaciones[2] = Cb_Val3_ent.SelectedItem.ToString() + "." + CB_Val3_dec.SelectedItem.ToString(); calificaciones[3] = Cb_Val4_ent.SelectedItem.ToString() + "." + CB_Val4_dec.SelectedItem.ToString(); calificaciones[4] = Cb_Val5_ent.SelectedItem.ToString() + "." + CB_Val5_dec.SelectedItem.ToString(); calificaciones[5] = Cb_Val6_ent.SelectedItem.ToString() + "." + CB_Val6_dec.SelectedItem.ToString(); calificaciones[6] = Cb_Val7_ent.SelectedItem.ToString() + "." + CB_Val7_dec.SelectedItem.ToString(); calificaciones[7] = Cb_Val8_ent.SelectedItem.ToString() + "." + CB_Val8_dec.SelectedItem.ToString(); }
                if ((comboBox1.SelectedItem.ToString() == "4" || comboBox1.SelectedItem.ToString() == "5" || comboBox1.SelectedItem.ToString() == "6") && comboBox2.SelectedItem.ToString() != "Diag") { ciclo = 13; calificaciones[0] = Cb_Val1_ent.SelectedItem.ToString() + "." + CB_Val1_dec.SelectedItem.ToString(); calificaciones[1] = Cb_Val2_ent.SelectedItem.ToString() + "." + CB_Val2_dec.SelectedItem.ToString(); calificaciones[2] = Cb_Val3_ent.SelectedItem.ToString() + "." + CB_Val3_dec.SelectedItem.ToString(); calificaciones[3] = Cb_Val4_ent.SelectedItem.ToString() + "." + CB_Val4_dec.SelectedItem.ToString(); calificaciones[4] = Cb_Val5_ent.SelectedItem.ToString() + "." + CB_Val5_dec.SelectedItem.ToString(); calificaciones[5] = Cb_Val6_ent.SelectedItem.ToString() + "." + CB_Val6_dec.SelectedItem.ToString(); calificaciones[6] = Cb_Val7_ent.SelectedItem.ToString() + "." + CB_Val7_dec.SelectedItem.ToString(); calificaciones[7] = Cb_Val8_ent.SelectedItem.ToString() + "." + CB_Val8_dec.SelectedItem.ToString(); calificaciones[8] = Cb_Val9_ent.SelectedItem.ToString() + "." + CB_Val9_dec.SelectedItem.ToString(); calificaciones[9] = Cb_Val10_ent.SelectedItem.ToString() + "." + CB_Val10_dec.SelectedItem.ToString(); calificaciones[10] = Cb_Val11_ent.SelectedItem.ToString() + "." + CB_Val11_dec.SelectedItem.ToString(); calificaciones[11] = Cb_Val12_ent.SelectedItem.ToString() + "." + CB_Val12_dec.SelectedItem.ToString(); calificaciones[12] = Cb_Val13_ent.SelectedItem.ToString() + "." + CB_Val13_dec.SelectedItem.ToString(); }
                if (comboBox1.SelectedItem.ToString() == "1") { m[0] = "EDA-1-SEP"; m[1] = "EDF-1-SEP"; m[2] = "ENS-1-SEP"; m[3] = "ESP-1-SEP"; m[4] = "FCE-1-SEP"; m[5] = "MAT-1-SEP"; m[6] = "CLE-1-EXT"; m[7] = "DIS-1-EXT"; m[8] = "PUN-1-EXT"; m[9] = "TAR-1-EXT"; m[10] = "UYA-1-EXT"; }
                else if (comboBox1.SelectedItem.ToString() == "2") { m[0] = "EDA-2-SEP"; m[1] = "EDF-2-SEP"; m[2] = "ENS-2-SEP"; m[3] = "ESP-2-SEP"; m[4] = "FCE-2-SEP"; m[5] = "MAT-2-SEP"; m[6] = "DIS-2-EXT"; m[7] = "ORT-2-EXT"; m[8] = "PAR-2-EXT"; m[9] = "TAR-2-EXT"; m[10] = "UYA-2-EXT"; }

                else if (comboBox1.SelectedItem.ToString() == "3") { m[0] = "CIN-3-SEP"; m[1] = "EDA-3-SEP"; m[2] = "EDF-3-SEP"; m[3] = "EDV-3-SEP"; m[4] = "ESP-3-SEP"; m[5] = "FCE-3-SEP"; m[6] = "MAT-3-SEP"; m[7] = "CLE-3-EXT"; m[8] = "DIS-3-EXT"; m[9] = "ORT-3-EXT"; m[10] = "TAR-3-EXT"; m[11] = "UYA-3-EXT"; }

                else if (comboBox1.SelectedItem.ToString() == "4") { m[0] = "CIN-4-SEP"; m[1] = "EDA-4-SEP"; m[2] = "EDF-4-SEP"; m[3] = "ESP-4-SEP"; m[4] = "FCE-4-SEP"; m[5] = "GEO-4-SEP"; m[6] = "HIS-4-SEP"; m[7] = "MAT-4-SEP"; m[8] = "CLE-4-EXT"; m[9] = "DIS-4-EXT"; m[10] = "ORT-4-EXT"; m[11] = "PAR-4-EXT"; m[12] = "TAR-4-EXT"; }

                else if (comboBox1.SelectedItem.ToString() == "5") { m[0] = "CIN-5-SEP"; m[1] = "EDA-5-SEP"; m[2] = "EDF-5-SEP"; m[3] = "ESP-5-SEP"; m[4] = "FCE-5-SEP"; m[5] = "GEO-5-SEP"; m[6] = "HIS-5-SEP"; m[7] = "MAT-5-SEP"; m[8] = "CLE-5-EXT"; m[9] = "ORT-5-EXT"; m[10] = "PAR-5-EXT"; m[11] = "TAR-5-EXT"; m[12] = "TRA-5-EXT"; }

                else if (comboBox1.SelectedItem.ToString() == "6") { m[0] = "CIN-6-SEP"; m[1] = "EDA-6-SEP"; m[2] = "EDF-6-SEP"; m[3] = "ESP-6-SEP"; m[4] = "FCE-6-SEP"; m[5] = "GEO-6-SEP"; m[6] = "HIS-6-SEP"; m[7] = "MAT-6-SEP"; m[8] = "CLE-6-EXT"; m[9] = "ORT-6-EXT"; m[10] = "PAR-6-EXT"; m[11] = "TAR-6-EXT"; m[12] = "UYA-6-EXT"; }




                MySqlCommand nombre = new MySqlCommand(string.Format("select ap_pat_alumno,ap_mat_alumno,nombre_alumno from alumno where curp_alumno='{0}';", curp), Conexion.conectar());
                MySqlDataReader le = nombre.ExecuteReader();
                string ap = "", am = "", nom = "";
                while (le.Read())
                {
                    ap = le.GetString(0);
                    am = le.GetString(1);
                    nom = le.GetString(2);
                }
                le.Close();
                dat = ap + " " + am + " " + nom;
                for (int i = 0; i < ciclo; i++)
                {
                    MySqlCommand com = new MySqlCommand(string.Format("insert into calificacion values('{0}','{1}','{2}','{3}');", calificaciones[i], mesact, m[i], curp), Conexion.conectar());
                    com.ExecuteNonQuery();
                    Conexion.cerrar();
                }

                mm = comboBox2.SelectedItem.ToString();
                grado = comboBox1.SelectedItem.ToString();

                if (mm == "Diag") { pr = 0; }
                if (mm == "Sept") { pr = 1; }
                if (mm == "Octu") { pr = 2; }
                if (mm == "Novi") { pr = 3; }
                if (mm == "Dici") { pr = 4; }
                if (mm == "Ener") { pr = 5; }
                if (mm == "Febr") { pr = 6; }
                if (mm == "Marz") { pr = 7; }
                if (mm == "Abri") { pr = 8; }
                if (mm == "Mayo") { pr = 9; }
                if (mm == "Juni") { pr = 10; }

                calif.pdf1ro();
                comboBox2.Items.Clear();
                mesact = obtenermes(curp);
                if (mesact == "1")
                {
                    MessageBox.Show("El alumno ya ha sido evaluado en su totalidad", "Evaluación completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox2.Items.Add("FINALIZADO");
                    comboBox2.SelectedIndex = 0;
                }
                else
                {
                    comboBox2.Items.Add(mesact);
                    comboBox2.SelectedIndex = 0;
                }
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = boletas.nuevo;
                proc.Start();
                proc.Close();
                limpiar();

            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            

            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Primaria.Menu frm = new Primaria.Menu();
            frm.Show();
            Close();
        }

        private void Cb_Val1_ent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cb_Val1_ent.SelectedIndex==5)
            {
                CB_Val1_dec.SelectedIndex = 0;
                CB_Val1_dec.Enabled = false;
            }
            else
            {
                CB_Val1_dec.Enabled = true;
            }
        }

        private void Cb_Val2_ent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Val2_ent.SelectedIndex == 5)
            {
                CB_Val2_dec.SelectedIndex = 0;
                CB_Val2_dec.Enabled = false;
            }
            else
            {
                CB_Val2_dec.Enabled = true;
            }
        }

        private void Cb_Val3_ent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Val3_ent.SelectedIndex == 5)
            {
                CB_Val3_dec.SelectedIndex = 0;
                CB_Val3_dec.Enabled = false;
            }
            else
            {
                CB_Val3_dec.Enabled = true;
            }
        }

        private void Cb_Val4_ent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Val4_ent.SelectedIndex == 5)
            {
                CB_Val4_dec.SelectedIndex = 0;
                CB_Val4_dec.Enabled = false;
            }
            else
            {
                CB_Val4_dec.Enabled = true;
            }
        }

        private void Cb_Val5_ent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Val5_ent.SelectedIndex == 5)
            {
                CB_Val5_dec.SelectedIndex = 0;
                CB_Val5_dec.Enabled = false;
            }
            else
            {
                CB_Val5_dec.Enabled = true;
            }
        }

        private void Cb_Val6_ent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Val6_ent.SelectedIndex == 5)
            {
                CB_Val6_dec.SelectedIndex = 0;
                CB_Val6_dec.Enabled = false;
            }
            else
            {
                CB_Val6_dec.Enabled = true;
            }
        }

        private void Cb_Val7_ent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Val7_ent.SelectedIndex == 5)
            {
                CB_Val7_dec.SelectedIndex = 0;
                CB_Val7_dec.Enabled = false;
            }
            else
            {
                CB_Val7_dec.Enabled = true;
            }
        }

        private void Cb_Val8_ent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Val8_ent.SelectedIndex == 5)
            {
                CB_Val8_dec.SelectedIndex = 0;
                CB_Val8_dec.Enabled = false;
            }
            else
            {
                CB_Val8_dec.Enabled = true;
            }
        }

        private void Cb_Val9_ent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Val9_ent.SelectedIndex == 5)
            {
                CB_Val9_dec.SelectedIndex = 0;
                CB_Val9_dec.Enabled = false;
            }
            else
            {
                CB_Val9_dec.Enabled = true;
            }
        }

        private void Cb_Val10_ent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Val10_ent.SelectedIndex == 5)
            {
                CB_Val10_dec.SelectedIndex = 0;
                CB_Val10_dec.Enabled = false;
            }
            else
            {
                CB_Val10_dec.Enabled = true;
            }
        }

        private void Cb_Val11_ent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Val11_ent.SelectedIndex == 5)
            {
                CB_Val11_dec.SelectedIndex = 0;
                CB_Val11_dec.Enabled = false;
            }
            else
            {
                CB_Val11_dec.Enabled = true;
            }
        }

        private void Cb_Val12_ent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Val12_ent.SelectedIndex == 5)
            {
                CB_Val12_dec.SelectedIndex = 0;
                CB_Val12_dec.Enabled = false;
            }
            else
            {
                CB_Val12_dec.Enabled = true;
            }
        }

        private void Cb_Val13_ent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Val13_ent.SelectedIndex == 5)
            {
                CB_Val13_dec.SelectedIndex = 0;
                CB_Val13_dec.Enabled = false;
            }
            else
            {
                CB_Val13_dec.Enabled = true;
            }
        }

        public void nom1()
        {
            string val1 = "", val2 = "", val3 = "", val4 = "", val5 = "", val6 = "", val7 = "", val8 = "", val9 = "", val10 = "", val11 = "", val12 = "", val13 = "";
            if (comboBox1.SelectedItem.ToString() == "1")
            {
                val1 = "Educación Artística:"; val2 = "Educación Fisica:"; val3 = "Exploración de la Naturaleza y Sociedad :"; val4 = "Español 1:"; val5 = "Formación Civica y Etica:"; val6 = "Matematicas 1:";val7 = "Comp. Lec:"; val8 = "Disciplina: ";val9 = "Puntualidad:";val10 = "Tareas:";val11 = "Uniforme y Aseo:";
            }
            else if (comboBox1.SelectedItem.ToString() == "2")
            {
                val1 = "Educación Artística:"; val2 = "Educación Fisica:"; val3 = "Exploración de la Naturaleza y Sociedad 2:"; val4 = "Español 2:"; val5 = "Formación Civica y Etica:"; val6 = "Matematicas 2:";val7 = "Disciplina:"; val8 = "Ortografía:";val9 = "Participación:"; val10 = "Tareas:"; val11 = "Uniforme y Aseo:";
            }
            else if (comboBox1.SelectedItem.ToString() == "4")
            {
                val1 = "Ciencias Naturales 2:"; val2 = "Educación Artistica:"; val3 = "Educación fisica:"; val4 = "Español 4:"; val5 = "Formación Civica y Etica:"; val6 = "Geografía:"; val7 = "Historia:"; val8 = "Matematicas 4:";val9 = "Comp. Lec:"; val10 = "Disciplina"; val11 = "Ortografía:";val12 = "Participación:"; val13 = "Tareas:";
            }
            else if (comboBox1.SelectedItem.ToString() == "5")
            {
                val1 = "Ciencias Naturales 3:"; val2 = "Educación Artistica:"; val3 = "Educación fisica:"; val4 = "Español 5:"; val5 = "Formación Civica y Etica:"; val6 = "Geografía 2:"; val7 = "Historia 2:"; val8 = "Matematicas 5:"; val9 = "Comp. Lec:"; val10 = "Disciplina"; val11 = "Ortografía:"; val12 = "Tareas:"; val13 = "Trabajos:";
            }
            else if (comboBox1.SelectedItem.ToString() == "6")
            {
                val1 = "Ciencias Naturales 4:"; val2 = "Educación Artistica:"; val3 = "Educación fisica:"; val4 = "Español 6:"; val5 = "Formación Civica y Etica:"; val6 = "Geografía 3:"; val7 = "Historia 3:"; val8 = "Matematicas 6:"; val9 = "Comp. Lec:"; val10 = "Ortografía:"; val11 = "Participación:"; val12 = "Tareas:"; val13 ="Uniforme y Aseo:";
            }
            else if (comboBox1.SelectedItem.ToString() == "3")
            {
                val1 = "Ciencias Naturales 1:"; val2 = "Educación Artistica:"; val3 = "Educación Fisica:"; val4 = "La Entidad en donde Vivo:"; val5 = "Español 3:"; val6 ="Formación Civica y Etica:"; val7 = "Matematicas 3: "; val8 = "Comp. Lect:";val9 = "Disciplina";val10 = "Ortografía:";val11 = "Tareas:";val12 = "Uniforme y Aseo:";
            }
            if (comboBox1.SelectedItem.ToString() == "1"|| comboBox1.SelectedItem.ToString() == "2")
            {
                label4.Text = val1;
                label5.Text = val2;
                label6.Text = val3;
                label7.Text = val4;
                label8.Text = val5;
                label9.Text = val6;
                label10.Text = val7;
                label11.Text = val8;
                label12.Text = val9;
                label13.Text = val10;
                label14.Text = val11;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = false;
                label16.Visible = false;
                Cb_Val7_ent.Visible = true;
                CB_Val7_dec.Visible = true;
                Cb_Val8_ent.Visible = true;
                CB_Val8_dec.Visible = true;
                Cb_Val9_ent.Visible = true;
                CB_Val9_dec.Visible = true;
                Cb_Val10_ent.Visible = true;
                CB_Val10_dec.Visible = true;
                Cb_Val11_ent.Visible = true;
                Cb_Val12_ent.Visible = false;
                CB_Val11_dec.Visible = true;
                CB_Val12_dec.Visible = false;
                Cb_Val13_ent.Visible = false;
                CB_Val13_dec.Visible = false;
            }
           else if (comboBox1.SelectedItem.ToString() == "4" || comboBox1.SelectedItem.ToString() == "5" || comboBox1.SelectedItem.ToString() == "6")
            {
                label4.Text = val1;
                label5.Text = val2;
                label6.Text = val3;
                label7.Text = val4;
                label8.Text = val5;
                label9.Text = val6;
                label10.Text = val7;
                label11.Text = val8;
                label12.Text = val9;
                label13.Text = val10;
                label14.Text = val11;
                label15.Text = val12;
                label16.Text = val13;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = false;
                label16.Visible = false;
                label15.Visible = true;
                label16.Visible = true;
                Cb_Val7_ent.Visible = true;
                CB_Val7_dec.Visible = true;
                Cb_Val8_ent.Visible = true;
                CB_Val8_dec.Visible = true;
                Cb_Val9_ent.Visible = true;
                CB_Val9_dec.Visible = true;
                Cb_Val10_ent.Visible = true;
                CB_Val10_dec.Visible = true;
                Cb_Val11_ent.Visible = true;
                CB_Val11_dec.Visible = true;
                Cb_Val12_ent.Visible = true;
                CB_Val12_dec.Visible = true;
                Cb_Val13_ent.Visible = true;
                CB_Val13_dec.Visible = true;
            }
            else if(comboBox1.SelectedItem.ToString() == "3")
            {
                
                    label4.Text = val1;
                    label5.Text = val2;
                    label6.Text = val3;
                    label7.Text = val4;
                    label8.Text = val5;
                    label9.Text = val6;
                    label10.Text = val7;
                    label11.Text = val8;
                    label12.Text = val9;
                    label13.Text = val10;
                    label14.Text = val11;
                    label15.Text = val12;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                Cb_Val8_ent.Visible = true;
                CB_Val8_dec.Visible = true;
                Cb_Val9_ent.Visible = true;
                CB_Val9_dec.Visible = true;
                Cb_Val10_ent.Visible = true;
                CB_Val10_dec.Visible = true;
                Cb_Val11_ent.Visible = true;
                CB_Val11_dec.Visible = true;
                Cb_Val12_ent.Visible = true;
                CB_Val12_dec.Visible = true;
                Cb_Val13_ent.Visible = true;
                CB_Val13_dec.Visible = true;
                label16.Visible = false;
                    Cb_Val13_ent.Visible = false;
                    CB_Val13_dec.Visible = false;
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boletas metodos = new boletas();
            metodos.enviarboletaspendientes();
        }

        public void limpiar()
        {
            Cb_Val1_ent.SelectedIndex = -1;
            Cb_Val2_ent.SelectedIndex = -1;
            Cb_Val3_ent.SelectedIndex = -1;
            Cb_Val4_ent.SelectedIndex = -1;
            Cb_Val5_ent.SelectedIndex = -1;
            Cb_Val6_ent.SelectedIndex = -1;
            Cb_Val7_ent.SelectedIndex = -1;
            Cb_Val8_ent.SelectedIndex = -1;
            Cb_Val9_ent.SelectedIndex = -1;
            Cb_Val10_ent.SelectedIndex = -1;
            Cb_Val11_ent.SelectedIndex = -1;
            Cb_Val12_ent.SelectedIndex = -1;
            Cb_Val13_ent.SelectedIndex = -1;

            CB_Val1_dec.SelectedIndex = -1;
            CB_Val2_dec.SelectedIndex = -1;
            CB_Val3_dec.SelectedIndex = -1;
            CB_Val4_dec.SelectedIndex = -1;
            CB_Val5_dec.SelectedIndex = -1;
            CB_Val6_dec.SelectedIndex = -1;
            CB_Val7_dec.SelectedIndex = -1;
            CB_Val8_dec.SelectedIndex = -1;
            CB_Val9_dec.SelectedIndex = -1;
            CB_Val10_dec.SelectedIndex = -1;
            CB_Val11_dec.SelectedIndex = -1;
            CB_Val12_dec.SelectedIndex = -1;
            CB_Val13_dec.SelectedIndex = -1;
        }
        public static string obtenermes (string crp)
        {
            int concurrencia = 0;
            string[] meses = new string[] { "Diag", "Sept", "Octu", "Novi", "Dici", "Ener", "Febr", "Marz", "Abri", "Mayo", "Juni" };
            for(int i=0;i<11;i++)
            {
                MySqlCommand consulta = new MySqlCommand(string.Format("SELECT COUNT(*) from calificacion where mes_calificacion='{0}' and curp_alumno='{1}';", meses[i], crp), Conexion.conectar());
                concurrencia = Convert.ToInt16(consulta.ExecuteScalar());
                if(concurrencia==0)
                {
                    return meses[i];
                }
            }
            return "1";
        }
        
    }
}
