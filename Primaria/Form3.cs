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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Primaria
{
    public partial class Form2 : Form
    {
        PdfReader lect;FileStream fr;PdfWriter escritor;
        int mes2 = 0, mes3 = 0, mes4 = 0, mes5 = 0, mes6 = 0, mes7 = 0, mes8 = 0, mes9 = 0, mes10 = 0;
        DataTable grado;
        string grad = "";
        int conmat = 0;
        MySqlDataAdapter resultado;
        MySqlCommand comando;
        int valor, contador, a, b = 1, materias_exis, c, d, f,materias_exis_sep;
        int g, h, i, j, k, l, m, n;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Primaria.Menu frm = new Primaria.Menu();
            frm.Show();
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            button1.Visible = false;
            generarpdf_btn.Visible = false;
        }

        bool respuesta = false;
        Double calif, aux2,aux3;
        //PARA LA GENERACIÓN DE BOLETAS
        string curpCalif = "";
        int contadorMatEne = 0;

        private void generarpdf_btn_Click(object sender, EventArgs e)
        {

            if(comboBox1.SelectedItem.ToString()!="0")
            {
                grad = comboBox1.SelectedItem.ToString();
               // BoletaPrimero();
            }
           
           
        }

        string curp, clave_mat, aux, veces_regis, veces_regis_ante;

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
            comboBox1.SelectedItem = null;
        }
        private void cb_periodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (d == cb_periodo.SelectedIndex && respuesta == true)
            {
                MessageBox.Show("CAMBIE DE PERIODO ESCOLAR");
            }
            else
            {
                cb_periodo.Enabled = false;

                if (cb_periodo.SelectedItem != null)
                {
                    if(cb_periodo.SelectedIndex == 0)
                    {
                        llenar_materias(2);
                        comprobar_calif();
                    }
                    else{
                        llenar_materias(1);
                        comprobar_calif();
                    }
                    
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
                   // MessageBox.Show("" + materias_exis + "", "" + veces_regis + "");
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
                            cb_decimal.Enabled = false;

                        }
                        else
                        {
                            LIMPIAR_REI();
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
            {
                Consulta("select nombre_alumno as nombre,ap_pat_alumno as ap_paterno,ap_mat_alumno as ap_materno from alumno where (grado_grupo = '" + valor + "');");//MUESTRA EN EL DATAGRIDVIEW A LOS ALUMNOS DEL GRADO SELECCIONADO

                // Consulta("select distinct nombre_alumno as nombre,ap_pat_alumno as ap_paterno,ap_mat_alumno as ap_materno FROM alumno INNER JOIN calificacion on(alumno.curp_alumno != calificacion.curp_alumno and alumno.grado_grupo = '" + valor + "' and calificacion.calif_materia != '')");
            }

            {//1
                llenar_materias(2);
                llenar_materias(1);
                /*comboBox2.Items.Clear();
                string query = "SELECT nombre_materia from materia where(grado_grupo = '" + valor + "');";

                resultado = new MySqlDataAdapter(query, Conexion.conectar());
                DataTable materias = new DataTable();
                resultado.Fill(materias);
                foreach (DataRow row in materias.Rows)
                {
                    string wine = string.Format("{0}", row.ItemArray[0]);//ALMACENA EN UN ARREGLO LO QUE GUADA DE LA COLUMNA 0
                    comboBox2.Items.Add(wine);//AGREGA A LOS ITEMS LO QUE ALMACENA WINE

                }
                materias_exis = comboBox2.Items.Count;*/
                //comboBox2.SelectedIndex = 0;//SELECCIONA EL PRIMER ELEMENTO
            }//1        LLENADO DE COMBOBOX PARA MATERIAS

        }
        public void Consulta(string instruccion)
        {

            resultado = new MySqlDataAdapter(instruccion, Conexion.conectar());
            grado = new DataTable();
            resultado.Fill(grado);
            dataGridView1.DataSource = grado;

        }


        public void elemen_combobox()
        {
            cb_periodo.Items.Add("Diag");
            cb_periodo.Items.Add("Sept");
            cb_periodo.Items.Add("Octu");
            cb_periodo.Items.Add("Novi");
            cb_periodo.Items.Add("Dici");
            cb_periodo.Items.Add("Ener");
            cb_periodo.Items.Add("Febr");
            cb_periodo.Items.Add("Marz");
            cb_periodo.Items.Add("Abri");
            cb_periodo.Items.Add("Mayo");
            cb_periodo.Items.Add("Juni");
           

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
            else {
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
                    if(comboBox2.Enabled == true)
                    {
                        cb_periodo.Enabled = false;
                    }
                   

                }
                else
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex]; //obtiene los valores de las filas a partir del datagridview que se tiene.
                    tb_nombre.Text = row.Cells["nombre"].Value.ToString();
                    tb_apP.Text = row.Cells["ap_paterno"].Value.ToString();
                    tb_apM.Text = row.Cells["ap_materno"].Value.ToString();
                    contador = 1;

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
            int seleccion_cbperiodo = cb_periodo.SelectedIndex - 1;
            //OBTENGO CURP
            comando = new MySqlCommand(string.Format("select * from alumno where (nombre_alumno = '" + tb_nombre.Text + "' and ap_pat_alumno = '" + tb_apP.Text + "' and ap_mat_alumno = '" + tb_apM.Text + "');"), Conexion.conectar());
            MySqlDataReader read = comando.ExecuteReader(); read.Read();
            curp = read[0].ToString();//obtengo curp
            read.Close();
            //OBTENGO LAS VECES QUE ESTÁ REGISTRADO DENTRO DE LA TABLA CALIFICACIONES, SI ES = A EL # DE MATERIAS, YA COMPLETO SU REGISTRO
            comando = new MySqlCommand(string.Format("select count(curp_alumno) from calificacion where (curp_alumno = '" + curp + "' and mes_calificacion = '" + cb_periodo.SelectedItem + "' );"), Conexion.conectar());
            read = comando.ExecuteReader(); read.Read();
            veces_regis = read[0].ToString();//verifico cuantas veces está registrado
            //MessageBox.Show("" + materias_exis + "cantidad de materia", "" + veces_regis + "veces registrado");
            aux2 = Convert.ToDouble(veces_regis);
            read.Close();
            //OBTENGO LAS VECES QUE ESTÁ REGISTRADO DENTRO DE LA TABLA CALIFICACIONES, SI ES = A EL # DE MATERIAS, YA COMPLETO SU REGISTRO EN EL MES ANTERIOR DEL SELECCIONADO
            if (cb_periodo.SelectedIndex != 0)
            {
                
                comando = new MySqlCommand(string.Format("select count(curp_alumno) from calificacion where (curp_alumno = '" + curp + "' and mes_calificacion = '" + cb_periodo.Items[cb_periodo.SelectedIndex-1]+ "' );"), Conexion.conectar());
                read = comando.ExecuteReader(); read.Read();
                veces_regis_ante = read[0].ToString();//verifico cuantas veces está registrado del mes pasado
                aux3 = Convert.ToDouble(veces_regis_ante);
              //  MessageBox.Show("" + aux3 + "", ""+materias_exis+ "cantidad de veces registrado en periodo anterior");
                read.Close();
            }
            


            if (materias_exis == aux2)
            {
                MessageBox.Show("ALUMNO YA COMPLETO TODOS SUS REGISTROS EN EL PERIODO SELECCIONADO");
                d = cb_periodo.SelectedIndex;
                respuesta = true;
                if (MessageBox.Show("¿DESEA REGISTRAR EN OTRO PERIODO?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                if (cb_periodo.SelectedIndex == 1)
                {
                    if (materias_exis_sep == aux3)
                    {
                        f = 1;
                        comboBox2.Enabled = true;
                        cb_periodo.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("ALUMNO NO HA COMPLETADO TODOS SUS REGISTROS EN EL PERIODO ANTERIOR");
                        d = cb_periodo.SelectedIndex;
                        respuesta = true;
                        if (MessageBox.Show("¿DESEA REGISTRAR EN OTRO PERIODO?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cb_periodo.Enabled = true;
                        }
                        else
                        {
                            LIMPIAR_REI();
                        }
                    }
                }
                else
                {
                    if (cb_periodo.SelectedIndex != 0 && cb_periodo.SelectedIndex != 1)
                    {
                        if (materias_exis == aux3)
                        {
                            f = 1;
                            comboBox2.Enabled = true;
                            cb_periodo.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("ALUMNO NO HA COMPLETADO TODOS SUS REGISTROS EN EL PERIODO ANTERIOR");
                            d = cb_periodo.SelectedIndex;
                            respuesta = true;
                            if (MessageBox.Show("¿DESEA REGISTRAR EN OTRO PERIODO?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                cb_periodo.Enabled = true;
                            }
                            else
                            {
                                LIMPIAR_REI();
                            }
                        }
                    }
                    else
                    {
                        f = 1;
                        comboBox2.Enabled = true;
                        cb_periodo.Enabled = false;
                    }
                }
                
            }
        }

        public void comprobar_calif2()
        {
            if (comboBox2.SelectedItem != null)
            {
                //MessageBox.Show("" + f + "");
                // OBTENGO CLAVE MATERIA
                comando = new MySqlCommand(string.Format("select clave_materia from materia where (nombre_materia = '" + comboBox2.SelectedItem + "' and grado_grupo = '" + comboBox1.SelectedItem + "');"), Conexion.conectar());
                MySqlDataReader read = comando.ExecuteReader(); read.Read();
                clave_mat = read[0].ToString();//clave materia
               // MessageBox.Show("" + clave_mat + "");
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
            //MessageBox.Show("" + f + "");

        }

        public void llenar_materias(int desicion)
        {
            if(desicion == 2)
            {
                  comboBox2.Items.Clear();
                  string query = "SELECT nombre_materia from materia where(grado_grupo = '" + valor + "' and especif_materia = 'SEP');";

                resultado = new MySqlDataAdapter(query, Conexion.conectar());
                DataTable materias = new DataTable();
                 resultado.Fill(materias);
                foreach (DataRow row in materias.Rows)
                {
                    string wine = string.Format("{0}", row.ItemArray[0]);//ALMACENA EN UN ARREGLO LO QUE GUADA DE LA COLUMNA 0
                    comboBox2.Items.Add(wine);//AGREGA A LOS ITEMS LO QUE ALMACENA WINE

                }
                materias_exis_sep =materias_exis= comboBox2.Items.Count;
            }
            else
            {
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
            }
            
        }
     /*   public void BoletaPrimero()
        {

            if (grad == "1") { conmat = 10; }
            int cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0, cont6 = 0, cont7 = 0, cont8 = 0, cont9 = 0, cont10 = 0;
            Calificaciones.Primero ob = new Calificaciones.Primero();
            List<Calificaciones.Primero> lista = new List<Calificaciones.Primero>();
            MySqlCommand obtenerCurp = new MySqlCommand(string.Format("SELECT curp_alumno from alumno where nombre_alumno='{0}' and ap_pat_alumno='{1}' and ap_mat_alumno='{2}';", tb_nombre.Text, tb_apP.Text, tb_apM.Text), Conexion.conectar());
            curp = (string)obtenerCurp.ExecuteScalar();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT COUNT(*) from calificacion where mes_calificacion='Sept' && curp_alumno='{0}';", curp), Conexion.conectar());
            int cont = Convert.ToInt16( comando.ExecuteScalar());
            if (tb_apM.Text.Equals("") || tb_apP.Text.Equals("") || tb_nombre.Text.Equals("")) { MessageBox.Show("Seleccione un alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if(cont<conmat)
            {
                MessageBox.Show("El alumno no tiene ningun periodo completado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {   
               
                MySqlCommand consultarCalif = new MySqlCommand(string.Format("SELECT calificacion.calif_materia, materia.nombre_materia,calificacion.mes_calificacion from calificacion,materia where  curp_alumno='{0}' && calificacion.clave_materia=materia.clave_materia ORDER BY materia.nombre_materia ASC;", curp), Conexion.conectar());
                MySqlDataReader lector = consultarCalif.ExecuteReader();
                while(lector.Read())
                {
                    ob.calificacion = lector.GetFloat(0);
                    ob.nommat = lector.GetString(1);
                    ob.fecha = lector.GetString(2);
                    lista.Add(ob);
                }
                for(int i=0;i<lista.Count;i++)
                {
                    if(lista[i].fecha.Equals("Oct"))
                    {
                        cont2++;
                    }
                    else if (lista[i].fecha.Equals("Nov"))
                    {
                        cont3++;
                    }
                    else if (lista[i].fecha.Equals("Dic"))
                    {
                        cont4++;
                    }
                    else if (lista[i].fecha.Equals("Ene"))
                    {
                        cont5++;
                    }
                    else if (lista[i].fecha.Equals("Feb"))
                    {
                        cont6++;
                    }
                    else if (lista[i].fecha.Equals("Mar"))
                    {
                        cont7++;
                    }
                    else if (lista[i].fecha.Equals("Abr"))
                    {
                        cont8++;
                    }
                    else if (lista[i].fecha.Equals("May"))
                    {
                        cont9++;
                    }
                    else if (lista[i].fecha.Equals("Jun"))
                    {
                        cont10++;
                    }

                }
                if (cont2 == conmat) { mes2 = 1; }
                if (cont3 == conmat) { mes3 = 1; }
                if (cont4 == conmat) { mes4 = 1; }
                if (cont5 == conmat) { mes5 = 1; }
                if (cont6 == conmat) { mes6 = 1; }
                if (cont7 == conmat) { mes7 = 1; }
                if (cont8 == conmat) { mes8 = 1; }
                if (cont9 == conmat) { mes9 = 1; }
                if (cont10 == conmat) { mes10 = 1; }


                //Empezamos con el pdf
                string boleta1Vieja = "C:\\Users\\erick\\Documents\\Primaria\\Primaria\\BOLETA1vieja.pdf";
                string boleta1Nueva = "C:\\Users\\erick\\Documents\\Primaria\\Primaria\\BOLETA1nueva.pdf";
                string boleta2Vieja = "C:\\Users\\erick\\Documents\\Primaria\\Primaria\\BOLETA2vieja.pdf";
                string boleta2Nueva = "C:\\Users\\erick\\Documents\\Primaria\\Primaria\\BOLETA2nueva.pdf";
               
                if (grad == "1") { lect = new PdfReader(boleta1Vieja); }
                else if (grad == "2") { lect = new PdfReader(boleta2Vieja); }
                var tam = lect.GetPageSizeWithRotation(1);
                Document doc = new Document(tam);
                if (grad == "1") { fr = new FileStream(boleta1Nueva, FileMode.Create, FileAccess.Write); }
                else if (grad == "2") { fr = new FileStream(boleta2Nueva, FileMode.Create, FileAccess.Write); }
                escritor = PdfWriter.GetInstance(doc, fr);
                doc.Open();
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                if(grad=="1")
                {
                    PdfContentByte espa = escritor.DirectContent;
                    espa.SetColorFill(BaseColor.BLACK);
                    espa.SetFontAndSize(bf, 8);
                    PdfContentByte mate = escritor.DirectContent;
                    mate.SetColorFill(BaseColor.BLACK);
                    mate.SetFontAndSize(bf, 8);
                    PdfContentByte nat = escritor.DirectContent;
                    nat.SetColorFill(BaseColor.BLACK);
                    nat.SetFontAndSize(bf, 8);
                    PdfContentByte cye = escritor.DirectContent;
                    cye.SetColorFill(BaseColor.BLACK);
                    cye.SetFontAndSize(bf, 8);
                    PdfContentByte eduart = escritor.DirectContent;
                    eduart.SetColorFill(BaseColor.BLACK);
                    eduart.SetFontAndSize(bf, 8);
                    PdfContentByte pun = escritor.DirectContent;
                    pun.SetColorFill(BaseColor.BLACK);
                    pun.SetFontAndSize(bf, 8);
                    PdfContentByte comp = escritor.DirectContent;
                    comp.SetColorFill(BaseColor.BLACK);
                    comp.SetFontAndSize(bf, 8);
                    PdfContentByte tarea = escritor.DirectContent;
                    tarea.SetColorFill(BaseColor.BLACK);
                    tarea.SetFontAndSize(bf, 8);
                    PdfContentByte uni = escritor.DirectContent;
                    uni.SetColorFill(BaseColor.BLACK);
                    uni.SetFontAndSize(bf, 8);
                    int coordY = 577, coordX = 158;
                    for(int i=0;i<lista.Count;i++)
                    {
                        if(lista[i].nommat.Equals("ESPAÑOL 1")&&lista[i].fecha.Equals("Sept"))
                        {
                            espa.BeginText();
                            espa.ShowTextAligned(1,Convert.ToString( lista[i].calificacion), coordX, coordY, 0);
                            espa.EndText();
                        }
                        if (lista[i].nommat.Equals("MATEMATICAS 1") && lista[i].fecha.Equals("Sept"))
                        {   coordY =557;
                            mate.BeginText();
                            mate.ShowTextAligned(1, Convert.ToString(lista[i].calificacion), coordX, coordY, 0);
                            mate.EndText();
                        }
                    }
                    PdfImportedPage pagina = escritor.GetImportedPage(lect, 1);
                    espa.AddTemplate(pagina, 0, 0);
                    doc.Close();
                    fr.Close();
                    escritor.Close();
                    lect.Close();
                }
                


            }*/

                
            }
        
    }


