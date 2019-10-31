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
    public partial class Form2 : Form
    {
        DataTable grado;
        MySqlDataAdapter resultado;
        MySqlCommand comando;
        int valor, contador,a, b = 1, materias_exis,c, d, f;
        int  g, h, i, j, k, l, m, n;
        bool respuesta=false;
        Double calif,aux2;
        string curp,clave_mat,aux,veces_regis;

        public Form2()
        {
            InitializeComponent();
            elemen_combobox();
            comboBox1.SelectedIndex = 0;
            cb_decimal.SelectedIndex = 0;
            cb_decimal.Enabled = false;
            cb_entero.SelectedIndex = 0;
            cb_periodo.SelectedItem = null;
            GUARDAR.Enabled = false;
        }
        private void cb_periodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(d == cb_periodo.SelectedIndex && respuesta ==true)
            {
                MessageBox.Show("CAMBIE DE PERIODO ESCOLAR");
            }
            else
            {
                cb_periodo.Enabled = false; 
                if (cb_periodo.SelectedItem != null)
                {
                comprobar_calif();
                }
            }
            
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            f++;
            if (f != 0)
            {
                comprobar_calif2();
            }
            
            
        }//COMBOBOX DE MATERIAS

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            if (c == comboBox2.SelectedIndex)
            {
                MessageBox.Show("CAMBIE A OTRA MATERIA");
            }
            else
            {
                aux = cb_entero.SelectedItem.ToString() + "." + cb_decimal.SelectedItem.ToString(); //CONCATENO LA CALIFICACION
                calif = Convert.ToDouble(aux);
                // MessageBox.Show("" + calif + "");
                try
                {

                    comando = new MySqlCommand(String.Format("INSERT INTO calificacion (calif_materia,mes_calificacion,clave_materia,curp_alumno) values ('{0}','{1}','{2}','{3}')", calif, cb_periodo.SelectedItem, clave_mat.Trim(), curp), Conexion.conectar());
                    comando.ExecuteNonQuery();
                    /*comboBox2.SelectedItem = null;
                    cb_periodo.SelectedItem = null;*/
                    MessageBox.Show("REGISTRADO CON EXITO", "REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //BUSQUEDA SI EL ALUMNO YA CUMPLIO CON TODAS SUS CALIFICACIONES REGISTRADAS
                    comando = new MySqlCommand(string.Format("select count(curp_alumno) from calificacion where (curp_alumno = '" + curp + "' and mes_calificacion = '" + cb_periodo.SelectedItem + "' );"), Conexion.conectar());
                    MySqlDataReader read = comando.ExecuteReader(); read.Read();
                    veces_regis = read[0].ToString();//verifico cuantas veces está registrado
                    MessageBox.Show("" + materias_exis + "", "" + veces_regis + "");
                    aux2 = Convert.ToDouble(veces_regis);
                    read.Close();
                    if (materias_exis == aux2)
                    {
                        MessageBox.Show("ALUMNO YA COMPLETO TODOS SUS REGISTROS EN EL PERIODO SELECCIONADO");
                        LIMPIAR_REI();
                    }
                    else
                    {
                        if (MessageBox.Show("¿DESEA SEGUIR CALIFICANDO ALUMNO?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            f = -1;//variable para que hasta que se seleccione un elemento de las materias se compruebe si ya tiene una calificacion seleccionada
                            //habilita los controles para seguir calificando
                            comboBox2.SelectedItem = null;
                            comboBox2.Enabled = true;
                            cb_entero.Enabled = false;
                            cb_decimal.Enabled = false;
                            cb_decimal.SelectedIndex = 0;
                            cb_entero.SelectedIndex = 0;

                        }
                    }
                        

                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR AL REGISTRAR CALIFICACIÓN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            comboBox2.Enabled = false;
            cb_periodo.Enabled = false;
            cb_entero.Enabled = false;
            cb_decimal.Enabled = false;
            valor = comboBox1.SelectedIndex + 1;
            contador = 0;
            //MessageBox.Show("" + valor + "");
            LIMPIAR_REI();//LIMPIA TODOS LOS OBJETOS DE LA PANTALLA AL CAMBIAR DE GRUPO
        }
        public void Consulta(string instruccion)
        {
            
            resultado = new MySqlDataAdapter(instruccion, Conexion.conectar());
            grado = new DataTable();
            resultado.Fill(grado);
            dataGridView1.DataSource = grado;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            { 
            Consulta("select nombre_alumno as nombre,ap_pat_alumno as ap_paterno,ap_mat_alumno as ap_materno from alumno where (grado_grupo = '" + valor + "');");//MUESTRA EN EL DATAGRIDVIEW A LOS ALUMNOS DEL GRADO SELECCIONADO

               // Consulta("select distinct nombre_alumno as nombre,ap_pat_alumno as ap_paterno,ap_mat_alumno as ap_materno FROM alumno INNER JOIN calificacion on(alumno.curp_alumno != calificacion.curp_alumno and alumno.grado_grupo = '" + valor + "' and calificacion.calif_materia != '')");
            }

            {//1
                comboBox2.Items.Clear();
                string query = "SELECT nombre_materia from materia where(grado_grupo = '" + valor + "');";

                resultado = new MySqlDataAdapter(query, Conexion.conectar());
                DataTable materias = new DataTable();
                resultado.Fill(materias);
                foreach (DataRow row in materias.Rows)
                {
                    string wine = string.Format("{0}", row.ItemArray[0]);//ALMACENA EN UN ARREGLO LO QUE GUADA DE LA COLUMNA 0
                    comboBox2.Items.Add(wine);//AGREGA A LOS ITEMS LO QUE ALMACENA WINE
                    
                }
                materias_exis = comboBox2.Items.Count;
                //comboBox2.SelectedIndex = 0;//SELECCIONA EL PRIMER ELEMENTO
            }//1        LLENADO DE COMBOBOX PARA MATERIAS


        }


        public void elemen_combobox()
        {

            cb_periodo.Items.Add("Ene-Feb");
            cb_periodo.Items.Add("Feb-Mar");
            cb_periodo.Items.Add("Mar-Abr");
            cb_periodo.Items.Add("Abr-May");
            cb_periodo.Items.Add("May-Jun");
            cb_periodo.Items.Add("Jun-Jul");
            cb_periodo.Items.Add("Jul-Ago");
            cb_periodo.Items.Add("Ago-Sep");
            cb_periodo.Items.Add("Sep-Oct");
            cb_periodo.Items.Add("Oct-Nov");
            cb_periodo.Items.Add("Nov-Dic");
            cb_periodo.Items.Add("Dic-Ene");
            //cb_periodo.SelectedIndex = 0;

            cb_entero.Items.Add("5");
            cb_entero.Items.Add("6");
            cb_entero.Items.Add("7");
            cb_entero.Items.Add("8");
            cb_entero.Items.Add("9");
            cb_entero.Items.Add("10");

            cb_decimal.Items.Add("0");
            cb_decimal.Items.Add("1");
            cb_decimal.Items.Add("2");
            cb_decimal.Items.Add("3");
            cb_decimal.Items.Add("4");
            cb_decimal.Items.Add("5");
            cb_decimal.Items.Add("6");
            cb_decimal.Items.Add("7");
            cb_decimal.Items.Add("8");
            cb_decimal.Items.Add("9");
        }


        private void cb_entero_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cb_entero.SelectedIndex == 5)//verifica si el usuario selecciono la calificación 10, si fue así deshabilita el decimal poniendolo en 0
            {
                cb_decimal.SelectedIndex = 0;
                cb_decimal.Enabled = false;
                b++;
            }
            if (b == 1)
            {
                cb_decimal.Enabled = false;
                b = 0;
            }
            else{
                if (cb_entero.SelectedIndex == 5)//verifica si el usuario selecciono la calificación 10, si fue así deshabilita el decimal poniendolo en 0
                {
                    cb_decimal.SelectedIndex = 0;
                    cb_decimal.Enabled = false;
                }
                else { cb_decimal.Enabled = true; }

                 }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //se utiliza el evento CELLMOUSECLICK
            //CADA QUE SE SELECCIONE UNA DATO, SE MOSTRARÁ EN LOS TEXT BOX SIN NECESIDAD DE ESTAR HACIENDO CONSULTAS, SINO QUE SE RELLENA DE 1 SOLO RESULTADO YA DADO.
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show(""+e.RowIndex+"");

                cb_periodo.Enabled = true;
                if (contador == 1)
                {
                        
                        MessageBox.Show("Asegurese de completar el registro o presione el boton 'Reinciar' ", "Revise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.Enabled = false;
                    
                }
                else
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex]; //obtiene los valores de las filas a partir del datagridview que se tiene.
                    tb_nombre.Text = row.Cells["nombre"].Value.ToString();
                    tb_apP.Text = row.Cells["ap_paterno"].Value.ToString();
                    tb_apM.Text = row.Cells["ap_materno"].Value.ToString();
                    contador=1;
                    
                }
                
                
                
                
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            //BOTON DE REINICIAR
            LIMPIAR_REI();
        }

        public void comprobar_calif()
        {
            //OBTENGO CURP
            comando = new MySqlCommand(string.Format("select * from alumno where (nombre_alumno = '" + tb_nombre.Text + "' and ap_pat_alumno = '" + tb_apP.Text + "' and ap_mat_alumno = '" + tb_apM.Text + "');"), Conexion.conectar());
            MySqlDataReader read = comando.ExecuteReader(); read.Read();
            curp = read[0].ToString();//obtengo curp
            read.Close();
            //OBTENGO LAS VECES QUE ESTÁ REGISTRADO DENTRO DE LA TABLA CALIFICACIONES, SI ES = A EL # DE MATERIAS, YA COMPLETO SU REGISTRO
            comando = new MySqlCommand(string.Format("select count(curp_alumno) from calificacion where (curp_alumno = '" + curp + "' and mes_calificacion = '" + cb_periodo.SelectedItem + "' );"), Conexion.conectar());
            read = comando.ExecuteReader(); read.Read();
            veces_regis = read[0].ToString();//verifico cuantas veces está registrado
            MessageBox.Show("" + materias_exis + "", "" + veces_regis + "");
            aux2 = Convert.ToDouble(veces_regis);
            read.Close();

            if (materias_exis == aux2)
            {
                MessageBox.Show("ALUMNO YA COMPLETO TODOS SUS REGISTROS EN EL PERIODO SELECCIONADO");
                d = cb_periodo.SelectedIndex;
                respuesta = true;
                if(MessageBox.Show("¿DESEA REGISTRAR EN OTRO PERIODO?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cb_periodo.Enabled = true;
                }
                else
                {
                    LIMPIAR_REI();
                }
            }
            else
            {
                f = 1;
                comboBox2.Enabled = true;
                cb_periodo.Enabled = false;
                
            }
        }

        public void comprobar_calif2()
        {
            MessageBox.Show("" + f + "");
            // OBTENGO CLAVE MATERIA
            comando = new MySqlCommand(string.Format("select clave_materia from materia where (nombre_materia = '" + comboBox2.SelectedItem + "' and grado_grupo = '" + comboBox1.SelectedItem + "');"), Conexion.conectar());
            MySqlDataReader read = comando.ExecuteReader(); read.Read();
            clave_mat = read[0].ToString();//clave materia
            MessageBox.Show("" + clave_mat + "");
            read.Close();

            //VERIFICO SI LA CLAVE MATERIA CON LA CURP CORRESPONDIENTE ESTÁ DENTRO DE LA TABLA CALIFICACIONES
            comando = new MySqlCommand(string.Format("select calif_materia from calificacion where(curp_alumno = '" + curp.Trim() + "' and mes_calificacion = '" + cb_periodo.SelectedItem + "' and clave_materia ='" + clave_mat.Trim() + "');"), Conexion.conectar());
            read = comando.ExecuteReader();
            while (read.Read())
            {
                a++;
            }
            if (a > 0)
            {
                read.Close();
                MessageBox.Show("ALUMNO YA CUENTA CON CALIFICACIÓN EN PERIODO SELECCIONADO DE ESTA MATERIA", "SELECCIONE OTRA MATERIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                a = 0;
                c = comboBox2.SelectedIndex;
            }
            else
            {
                //HABILITA LOS CONTROLS PARA INGRESAR LA CALIFICACION Y GUARDAR
                comboBox2.Enabled = false;
                cb_entero.Enabled = true;
                cb_decimal.Enabled = true;
                GUARDAR.Enabled = true;
                f = -1;
            }
        }
        public void LIMPIAR_REI()
        {
            dataGridView1.Enabled = true;
            tb_nombre.Text = "";
            tb_apP.Text = "";
            tb_apM.Text = "";
            cb_decimal.SelectedIndex = 0;
            cb_entero.SelectedIndex = 0;
            cb_entero.Enabled = false;
            cb_decimal.Enabled = false;
            cb_periodo.Enabled = false;
            contador--; //auxiliar que lleva el control de que no se presionen dos alumnos hasta haber acabado uno
            b = 0;//auxiliar para que no se habilite el cb_decimal desde el principio
            comboBox2.SelectedItem = null;
            cb_periodo.SelectedItem = null;
            c = -1;//reinicio variable que lleva el control de seleccionar un periodo correcto
            GUARDAR.Enabled = false;//boton de guardar se deshabilita 
            comboBox2.Enabled = false;
            d = 0;//GUARDA EL VALOR PARA LLEVAR EL CONTROL DE QUE SI QUIERE CAMBIAR DE PERIODO PERO SI HA ESCOGIDO EL MISMO, NO SE REALICE LA OPERACION
            f = -1; //LLEVA EL CONTROL DEL COMBOBOX2 DE SI ES 0(NUEVO REGISTRO AL REINICIAR) NO SE EJECUTE COMPROVAR_CALF2
            respuesta = false;
            MessageBox.Show("" + f + "");

        }
    }
}
