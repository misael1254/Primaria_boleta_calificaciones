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
    public partial class Form1 : Form
    {
       
        public static int c=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Verificar_btn_Click(object sender, EventArgs e)
        {
            if (NomUsuN_txt.Text == "")
            {
                MessageBox.Show("ASEGURESE DE INTRODUCIR UN NOMBRE DE USUARIO", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              
                MySqlCommand verificar = new MySqlCommand(string.Format("select nom_usuario from usuarios where nom_usuario='" + NomUsuN_txt.Text + "';"), Conexion.conectar());
                MySqlDataReader checador = verificar.ExecuteReader();
                while (checador.Read())
                {
                    c++;
                }
                if (c == 0)
                {
                    disp_lb.ForeColor = Color.Green;
                    disp_lb.Text = "Usuario disponible";
                    

                }
                else
                {
                    disp_lb.ForeColor = Color.Red;
                    disp_lb.Text = "Usuario no disponible X";
                    
                }
            }
        }
        private void Acceso_btn_Click(object sender, EventArgs e)
        {
            //Acceder a la base de datos
            int c = 0; //contador de coincidencias.
            MySqlCommand comando = new MySqlCommand(string.Format("select nom_usuario from usuarios where nom_usuario='" + Nom_usutxt.Text + "' and contraseña='" + Cont_usutxt.Text + "';"), Conexion.conectar());
            MySqlDataReader lec = comando.ExecuteReader();
            while(lec.Read())
            {
                c++;
            }
            if(c==0)
            {
                MessageBox.Show("ASEGURESE DE INTRODUCIR LOS DATOS CORRECTAMENTE", "¡DATOS INCORRECTOS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                DateTime f = DateTime.Now;
                string fechaingreso = f.ToString("yyyy-MM-dd HH:mm:ss");
                MessageBox.Show("BIENVENIDO", "ACCESANDO A LA BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MySqlCommand inser = new MySqlCommand(string.Format("insert into bitacora (usuario,entrada,salida) values('{0}','{1}','{2}');", Nom_usutxt.Text, fechaingreso, "nada"), Conexion.conectar());
                inser.ExecuteNonQuery();
                Primaria.Menu frm = new Primaria.Menu();
                frm.Show();
                this.Hide();
                
            }
        }

       public void Reg_btn_Click(object sender, EventArgs e)
        {
            datos.op = "inser_usu";
            if(Validar.seguir==false&&Validar.permiso.Equals("n"))
            {
                datos.val1 = NomUsuN_txt.Text; datos.val2 = ContusuN_txt.Text; datos.val3 = ConfCont_txt.Text;
            }
            if ((datos.val1.Equals("")||datos.val2.Equals("")||datos.val3.Equals(""))&&Validar.seguir==true)
            {

                MessageBox.Show("No puede dejar datos en blanco", "¡DATOS INCORRECTOS!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else { 
            if (Validar.seguir == false)
            {
                Validar frm = new Validar();
                frm.Show();
                 
                }
                //Registro de nuevos usuarios
                if (Validar.seguir == true)
                {
                   try
                    {
                        
                        if (c>0)
                        {
                            MessageBox.Show("Parece que el nombre de usuario " + datos.val1 + " ya esta ocupado.", "¡Usuario no registrado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Validar.seguir = false;
                        }
                        else
                        {
                            if (Validar.permiso.Equals("s")&&Validar.seguir)
                            {
                                //Inserción del nuevo usuario
                                if (datos.val2.Equals(datos.val3))
                                {

                                    MySqlCommand insercion = new MySqlCommand(string.Format("insert into usuarios (nom_usuario,contraseña) values ('{0}','{1}');", datos.val1, datos.val2), Conexion.conectar());
                                    insercion.ExecuteNonQuery();
                                    MessageBox.Show("Usuario registrado", "¡Registro exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Validar.seguir = false;
                                }
                                else
                                {
                                    MessageBox.Show("Parece que las contraseñas no coinciden", "¡Vaya, ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Validar.seguir = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("La clave de autorización no es correcta", "¡Ha ocurrido un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Validar.seguir = false;
                            }
                        }

                   }
                    catch (Exception)
                    {
                        MessageBox.Show("Usuario no registrado", "Se ha producido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validar.seguir = false;
                    }
                }
            }
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisU_gp.Visible = false;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void registr_btn_Click(object sender, EventArgs e)
        {
            RegisU_gp.Visible = true;
           
        }

       
    }
}
