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
    public partial class Insercion : Form
    {
        public Insercion()
        {
            InitializeComponent();
            bloquear(); //inicializa bloqueando la escritura a los elementos
            bloqueartutor();
        }
        int validarinfoalum = 0;

        private void Insercion_Load(object sender, EventArgs e)
        {
            bloquear();
           /* GpTutor_gp.Visible = false; //Esconde el groupbox, si se elige se muestra, si no, no.
            if (Primaria.Menu.datos.Equals("inscripcion")) //Pregunta para que tabla se tiene que presentar la información
            {
                tab_txt.Text = ""; //En el titulo de formulario se visualizará tutores
                GpTutor_gp.Visible = true; //Como se eligio tutores, mostramos su groupbox
            }
            else
            {
                tab_txt.Text = "Prueba";
            }*/
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void GpTutor_gp_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            try //Intentamos ingresar los datos.
            {
                //Evaluar si el alumno puede inscribirse al grado pedido
                string permiso;
                permiso = ObtenerDatos.GetPermiso(FechaNacAlum_txt.Text, listgrado.SelectedItem.ToString());
                if (permiso == "n")
                {
                    MessageBox.Show("El alumno no cumple con la edad para el grupo solicitado", "¡No se puede registrar el alumno en el grado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //consultamos si el tutor existe
                    int c = 0;
                    c = ObtenerDatos.ExistenciaTutor(curpT_txt.Text);
                    if (c == 0&&validarinfoalum==0)
                    {    //inserción de datos
                        MySqlCommand insertutor = new MySqlCommand(string.Format("insert into tutor (curp_tutor,ap_pat_tutor,ap_mat_tutor,nombre_tutor,tel_cel_tutor,tel_casa_tutor," +
                            "tel_extra_tutor,email_tutor,email_extra_tutor,municipio_direc,colonia_direc,calle_direc,cp_direc,numcalle_direc) values" +
                            "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}');", curpT_txt.Text.Trim(), ApTutor_txt.Text.Trim(), AmTutor_txt.Text.Trim(), NombreTutor_txt.Text.Trim(), TelCelTutor_txt.Text.Trim(), TelCasa_tutor.Text.Trim(), TelExTutor_txt.Text.Trim(), EmailTutor_txt.Text.Trim(), EmailExTutor_txt.Text.Trim(), MunicipioTutor_txt.Text.Trim(), ColTutor_txt.Text.Trim(), CalleTutor_txt.Text.Trim(), CpTutor_txt.Text.Trim(), NumTutor_txt.Text.Trim()), Conexion.conectar());
                        insertutor.ExecuteNonQuery(); //Datos del tutor

                        //Obtener sexo del alumno:
                        string sexo;
                        sexo = ObtenerDatos.GetSexo(listsexo.SelectedItem.ToString());
                        //obtener grado
                        string grado;
                        grado = ObtenerDatos.Getgrado(listgrado.SelectedItem.ToString());
                        //obtener profesor
                        string profe;
                        profe = ObtenerDatos.GetProfesor(listgrado.SelectedItem.ToString());
                        MySqlCommand inseralumno = new MySqlCommand(string.Format("insert into alumno (curp_alumno,ap_pat_alumno,ap_mat_alumno,nombre_alumno,edad_alumno,fecha_nacimiento_alumno," +
                            "sexo_alumno,tipo_sangre,enfer_alergi,curp_tutor,grado_grupo) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}');", curpA_txt.Text.Trim(), ApellidoPAlum_txt.Text.Trim(), ApellidoMAlum_txt.Text.Trim(),
                            NomAlum_txt.Text.Trim(), EdadAlum_txt.Text.Trim(), FechaNacAlum_txt.Text.Trim(), sexo, SangreAlum_txt.Text.Trim(), EnfAlgAlum_txt.Text.Trim(), curpT_txt.Text.Trim(),grado), Conexion.conectar());
                        inseralumno.ExecuteNonQuery();//Datos del alumno

                       /* MySqlCommand insergrupo = new MySqlCommand(string.Format("insert into grupo (grado_grupo,nombre_profesor,curp_alumno) values ('{0}','{1}','{2}');", grado, profe, curpA_txt.Text.Trim()), Conexion.conectar());
                        insergrupo.ExecuteNonQuery();//Datos del grupo*/
                        MessageBox.Show("¡Datos registrados correctamente!", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        curpT_txt.Text = ""; ApTutor_txt.Text = ""; AmTutor_txt.Text = ""; NombreTutor_txt.Text = ""; TelCelTutor_txt.Text = "";
                        TelCasa_tutor.Text = ""; TelExTutor_txt.Text = ""; MunicipioTutor_txt.Text = ""; CpTutor_txt.Text = ""; ColTutor_txt.Text = "";
                        CalleTutor_txt.Text = ""; NumTutor_txt.Text = "";

                        curpA_txt.Text = ""; ApellidoPAlum_txt.Text = ""; ApellidoMAlum_txt.Text = ""; NomAlum_txt.Text = ""; EdadAlum_txt.Text = "";
                        FechaNacAlum_txt.Text = ""; SangreAlum_txt.Text = ""; EnfAlgAlum_txt.Text = "";
                    }
                    else
                    {
                        if (c == 1 && validarinfoalum == 1)
                        {
                            //Obtener sexo del alumno:
                            string sexo;
                            sexo = ObtenerDatos.GetSexo(listsexo.SelectedItem.ToString());
                            //obtener grado
                            string grado;
                            grado = ObtenerDatos.Getgrado(listgrado.SelectedItem.ToString());
                            //obtener profesor
                            string profe;
                            profe = ObtenerDatos.GetProfesor(listgrado.SelectedItem.ToString());
                            MySqlCommand inseralumno = new MySqlCommand(string.Format("insert into alumno (curp_alumno,ap_pat_alumno,ap_mat_alumno,nombre_alumno,edad_alumno,fecha_nacimiento_alumno," +
                                "sexo_alumno,tipo_sangre,enfer_alergi,curp_tutor,grado_grupo) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}');", curpA_txt.Text.Trim(), ApellidoPAlum_txt.Text.Trim(), ApellidoMAlum_txt.Text.Trim(),
                                NomAlum_txt.Text.Trim(), EdadAlum_txt.Text.Trim(), FechaNacAlum_txt.Text.Trim(), sexo, SangreAlum_txt.Text.Trim(), EnfAlgAlum_txt.Text.Trim(), curpT_txt.Text.Trim(), grado), Conexion.conectar());
                            inseralumno.ExecuteNonQuery();//Datos del alumno

                            /* MySqlCommand insergrupo = new MySqlCommand(string.Format("insert into grupo (grado_grupo,nombre_profesor,curp_alumno) values ('{0}','{1}','{2}');", grado, profe, curpA_txt.Text.Trim()), Conexion.conectar());
                             insergrupo.ExecuteNonQuery();//Datos del grupo*/
                            MessageBox.Show("¡Datos registrados correctamente!", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            curpT_txt.Text = ""; ApTutor_txt.Text = ""; AmTutor_txt.Text = ""; NombreTutor_txt.Text = ""; TelCelTutor_txt.Text = "";
                            TelCasa_tutor.Text = ""; TelExTutor_txt.Text = ""; MunicipioTutor_txt.Text = ""; CpTutor_txt.Text = ""; ColTutor_txt.Text = "";
                            CalleTutor_txt.Text = ""; NumTutor_txt.Text = "";

                            curpA_txt.Text = ""; ApellidoPAlum_txt.Text = ""; ApellidoMAlum_txt.Text = ""; NomAlum_txt.Text = ""; EdadAlum_txt.Text = "";
                            FechaNacAlum_txt.Text = ""; SangreAlum_txt.Text = ""; EnfAlgAlum_txt.Text = "";
                            
                        }
                    }
                }
            }
            catch (Exception) //Si hay un error, muestra el mensaje
            {
                MessageBox.Show("Parece que hemos tenido un problema.", "INFORMACIÓN NO REGISTRADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            curpT_txt.Text = ""; ApTutor_txt.Text = ""; AmTutor_txt.Text = ""; NombreTutor_txt.Text = ""; TelCelTutor_txt.Text = "";
            TelCasa_tutor.Text = ""; TelExTutor_txt.Text = ""; MunicipioTutor_txt.Text = ""; CpTutor_txt.Text = ""; ColTutor_txt.Text = "";
            CalleTutor_txt.Text = ""; NumTutor_txt.Text = ""; EmailExTutor_txt.Text = ""; EmailTutor_txt.Text = "";

            curpA_txt.Text = ""; ApellidoPAlum_txt.Text = ""; ApellidoMAlum_txt.Text = ""; NomAlum_txt.Text = ""; EdadAlum_txt.Text = "";
            FechaNacAlum_txt.Text = ""; SangreAlum_txt.Text = ""; EnfAlgAlum_txt.Text = "";
            curpA_txt.Enabled = true; NomAlum_txt.Enabled = true; ApellidoPAlum_txt.Enabled = true; ApellidoMAlum_txt.Enabled = true;
            curpT_txt.Enabled = true;
            ApTutor_txt.Enabled = true;
            AmTutor_txt.Enabled = true;
            NombreTutor_txt.Enabled = true;
            listsexo.Enabled = true;
        }

        private void atras_Click(object sender, EventArgs e)
        {
            Primaria.Menu frm = new Primaria.Menu();
            frm.Show();
            Close();
        }

        private void mayu(object sender, EventArgs e)
        {
            curpT_txt.Text = curpT_txt.Text.ToUpper();
        }

        private void curpT_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            curpT_txt.Text = curpT_txt.Text.ToUpper();
        }

        private void curpA_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            curpA_txt.Text = curpA_txt.Text.ToUpper();
        }

        private void EdadAlum_txt_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TelCelTutor_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TelCasa_tutor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TelExTutor_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CpTutor_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void NumTutor_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void FechaNacAlum_txt_KeyPress(object sender, KeyPressEventArgs V)
        {
            if (Char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }



            else if (V.KeyChar.ToString().Equals("-"))
            {

                V.Handled = false;
            }
            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
            }
        }

        private void ApTutor_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void AmTutor_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void NombreTutor_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void MunicipioTutor_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void ApellidoPAlum_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
            
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void ApellidoMAlum_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void NomAlum_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void SangreAlum_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (e.KeyChar.ToString().Equals("-") || e.KeyChar.ToString().Equals("+"))
            {

                e.Handled = false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ColTutor_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void validar_alu_Click(object sender, EventArgs e)
        {
           
            int exi = 0, exi1 = 0;
            string sexo;
            try { sexo = listsexo.SelectedItem.ToString(); } catch { MessageBox.Show("SELECCIONE SEXO"); return; }
             sexo = listsexo.SelectedItem.ToString();
            if (NomAlum_txt.Text == "" || curpA_txt.Text == "" || ApellidoMAlum_txt.Text == "" || ApellidoPAlum_txt.Text == "" )
            {
                MessageBox.Show("Llene los campos correspondientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                exi = ObtenerDatos.ExistenciaAlumno(curpA_txt.Text.Trim());
                exi1 = ObtenerDatos.ExistenciaTutor(curpT_txt.Text.Trim());
                int lenght = curpA_txt.Text.Length;
                if (curpA_txt.Text.Equals("") || lenght < 18)
                {
                    MessageBox.Show("ESCRIBA UNA CURP VALIDA (18 CARACTERES)", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label28.Text = "CURP ERRONEA";
                    label28.ForeColor = Color.Red;
                    validarinfoalum = 1;

                }

                else
                {
                    if (exi == 0)
                    {
                        exi1 = ObtenerDatos.ExistenciaTutor(curpA_txt.Text.Trim());
                        if (exi1 == 1)
                        {
                            MessageBox.Show("CURP REGISTRADA EN UN TUTOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            validarinfoalum = 1;
                        }
                        else
                        {
                            int x;
                            sexo = listsexo.SelectedItem.ToString();
                            x = ObtenerDatos.ComprobarCURP(curpA_txt.Text, NomAlum_txt.Text, ApellidoPAlum_txt.Text, ApellidoMAlum_txt.Text, sexo);
                            if (x == 2)
                            {
                                MessageBox.Show("La CURP no concuerda con los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                label28.Text = "CURP ERRONEA";
                                label28.ForeColor = Color.Red;
                                validarinfoalum = 1;
                            }
                            else
                            {
                                permitir();
                                label28.Text = "CURP CORRECTA";
                                label28.ForeColor = Color.Green;
                                curpA_txt.Enabled = false;
                                NomAlum_txt.Enabled = false;
                                ApellidoMAlum_txt.Enabled = false;
                                ApellidoPAlum_txt.Enabled = false;
                                listsexo.Enabled = false;
                                //Si la curp pasa los filtros anteriores vamos a obtener la edad y fecha de nacimiento a partir de ella

                                datos.EdadFechaNac resultados = ObtenerDatos.DatosNac(curpA_txt.Text);
                                EdadAlum_txt.Text = resultados.Edad;
                                FechaNacAlum_txt.Text = resultados.AnnoNac + "-" + resultados.MesNac + "-" + resultados.DiaNac;
                                validarinfoalum = 0;
                            }


                        }

                    }
                    else
                    {
                        MessageBox.Show("El alumno ya esta inscrito", "No validado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        curpA_txt.Text = "";
                        validarinfoalum = 1;
                    }


                }
            }
        }

        private void permitir() //habilita la escritura a los elementos 
        {
            //ApellidoPAlum_txt.Enabled = true;
            //ApellidoMAlum_txt.Enabled = true;
            //NomAlum_txt.Enabled = true;
           // EdadAlum_txt.Enabled = true;
           // FechaNacAlum_txt.Enabled = true;
           // listsexo.Enabled = true;
            SangreAlum_txt.Enabled = true;
            EnfAlgAlum_txt.Enabled = true;
            listgrado.Enabled = true;
        }

        private void bloquear() //deshabilita la escritura a los elementos
        {
           // ApellidoPAlum_txt.Enabled = false;
            //ApellidoMAlum_txt.Enabled = false;
            //NomAlum_txt.Enabled = false;
            EdadAlum_txt.Enabled = false;
            FechaNacAlum_txt.Enabled = false;
            //listsexo.Enabled = false;
            SangreAlum_txt.Enabled = false;
            EnfAlgAlum_txt.Enabled = false;
            listgrado.Enabled = false;
        }

        private void bloqueartutor() //deshabilita la escritura a los elementos
        {
            //ApTutor_txt.Enabled = false;
            //AmTutor_txt.Enabled = false;
            //NombreTutor_txt.Enabled = false;
            TelCelTutor_txt.Enabled = false;
            TelCasa_tutor.Enabled = false;
            TelExTutor_txt.Enabled = false;
            EmailTutor_txt.Enabled = false;
            EmailExTutor_txt.Enabled = false;
            MunicipioTutor_txt.Enabled = false;
            CpTutor_txt.Enabled = false;
            ColTutor_txt.Enabled = false;
            CalleTutor_txt.Enabled = false;
            NumTutor_txt.Enabled = false;
        }
        private void permitirtutor() //deshabilita la escritura a los elementos
        {
            ApTutor_txt.Enabled = true;
            AmTutor_txt.Enabled = true;
            NombreTutor_txt.Enabled = true;
            TelCelTutor_txt.Enabled = true;
            TelCasa_tutor.Enabled = true;
            TelExTutor_txt.Enabled = true;
            EmailTutor_txt.Enabled = true;
            EmailExTutor_txt.Enabled = true;
            MunicipioTutor_txt.Enabled = true;
            CpTutor_txt.Enabled = true;
            ColTutor_txt.Enabled = true;
            CalleTutor_txt.Enabled = true;
            NumTutor_txt.Enabled = true;
        }

        private void btnval_Click(object sender, EventArgs e)
        {
            int exi = 0, exi1 = 0;


            int lenght = curpT_txt.Text.Length;
            if (curpT_txt.Text.Equals("") || lenght < 18)
            {
                MessageBox.Show("ESCRIBA UNA CURP VALIDO (18 CARACTERES)", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label29.Text = "CURP ERRONEA";
                label29.ForeColor = Color.Red;
            }
           
                exi = ObtenerDatos.ExistenciaTutor(curpT_txt.Text.Trim());
            if (curpT_txt.Text == "" || NombreTutor_txt.Text == "" || ApTutor_txt.Text == "" || AmTutor_txt.Text == "") { MessageBox.Show("Introduzca la información necesaria", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); validarinfoalum = 1; }
            else if (curpA_txt.Text == curpT_txt.Text)
            {
                MessageBox.Show("No puede repetir la CURP de un alumno y un tutor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label29.Text = "CURP ERRONEA";
                label29.ForeColor = Color.Red;
            }
            else
            {
                int validarcurp = ObtenerDatos.ComprobarCurpTutor(curpT_txt.Text, NombreTutor_txt.Text, ApTutor_txt.Text, AmTutor_txt.Text);
                if (validarcurp == 2)
                {
                    MessageBox.Show("CURP no concuerda con los datos introducidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label29.Text = "CURP INCORRECTA";
                    label29.ForeColor = Color.Red;
                    validarinfoalum = 1;
                    bloqueartutor();
                }
                else
                {
                    if (exi == 0)
                    {
                        exi1 = ObtenerDatos.ExistenciaAlumno(curpT_txt.Text.Trim());
                        if (exi1 == 1)
                        {
                            MessageBox.Show("CURP REGISTRADA EN UN ALUMNO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            label29.Text = "CURP ERRONEA";
                            label29.ForeColor = Color.Red;
                            validarinfoalum = 1;

                        }
                        else
                        {
                            //permitir();
                            label29.Text = "CURP CORRECTA";
                            label29.ForeColor = Color.Green;
                            permitirtutor();
                            validarinfoalum = 0;
                            curpT_txt.Enabled = false;
                            ApTutor_txt.Enabled = false;
                            AmTutor_txt.Enabled = false;
                            NombreTutor_txt.Enabled = false;


                        }

                    }
                    else
                    {
                        MessageBox.Show("Tutor ya registrado en el sistema", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //curpA_txt.Text = "";
                        LlenarDatos();
                        validarinfoalum = 1;
                    }

                    
                }
            }
            
        }
        
        private void LlenarDatos() //obtiene los datos de un tutor
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Conexion.conectar();
            comando.CommandText = "select * from tutor where curp_tutor = '"+curpT_txt.Text.Trim()+"'";
            MySqlDataReader read = comando.ExecuteReader(); read.Read();
            ApTutor_txt.Text = read[1].ToString();
            AmTutor_txt.Text = read[2].ToString();
            NombreTutor_txt.Text = read[3].ToString();
            TelCelTutor_txt.Text = read[4].ToString();
            TelCasa_tutor.Text = read[5].ToString();
            TelExTutor_txt.Text = read[6].ToString();
            EmailTutor_txt.Text = read[7].ToString();
            EmailExTutor_txt.Text = read[8].ToString();
            MunicipioTutor_txt.Text = read[9].ToString();
            CpTutor_txt.Text = read[10].ToString();
            ColTutor_txt.Text = read[11].ToString();
            CalleTutor_txt.Text = read[12].ToString();
            NumTutor_txt.Text = read[13].ToString();
        }

        
            

        
    }
    }



