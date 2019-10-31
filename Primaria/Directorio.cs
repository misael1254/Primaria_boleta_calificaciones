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
   
    public partial class Directorio : Form
    {
        public Directorio()
        {
            InitializeComponent();
        }
      
        
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItems.Count>0)
            {
                MySqlDataAdapter consulta = new MySqlDataAdapter("SELECT alumno.ap_pat_alumno,alumno.ap_mat_alumno,alumno.nombre_alumno,alumno.enfer_alergi,tutor.colonia_direc,tutor.tel_cel_tutor,tutor.email_tutor,tutor.nombre_tutor from alumno INNER JOIN tutor on tutor.curp_tutor=alumno.curp_tutor where alumno.grado_grupo='" + listBox1.SelectedItem.ToString() + "';", Conexion.conectar());
                DataTable tabla = new DataTable();
                consulta.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            else
            {
                MessageBox.Show("Seleccione un grado por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pdf_btn_Click(object sender, EventArgs e)
        {
            datos.directorio ob = new datos.directorio();
            
            
            List<datos.directorio> lista = new List<datos.directorio>();
           
            MySqlCommand consulta = new MySqlCommand(string.Format("SELECT alumno.ap_pat_alumno,alumno.ap_mat_alumno,alumno.nombre_alumno,alumno.enfer_alergi,alumno.tipo_sangre,tutor.tel_cel_tutor,tutor.nombre_tutor from alumno INNER JOIN tutor on tutor.curp_tutor=alumno.curp_tutor where alumno.grado_grupo='" + listBox1.SelectedItem.ToString() + "' ORDER BY ap_pat_alumno ASC;"), Conexion.conectar());
            MySqlDataReader lec = consulta.ExecuteReader();
            while(lec.Read())
            {
                ob.paterno = lec.GetString(0).ToString();
                ob.materno = lec.GetString(1).ToString();
                ob.nombre = lec.GetString(2).ToString();
                ob.alergia = lec.GetString(3).ToString();
                ob.sangre = lec.GetString(4).ToString();
                ob.celular = lec.GetString(5).ToString();
                //ob.email = lec.GetString(6).ToString();
                ob.nombretutor = lec.GetString(6).ToString();
               
                lista.Add(ob);
            }
            string viejo = Application.StartupPath + "\\Primaria\\directorio.pdf";
            
            string nuevo = Application.StartupPath + "\\Primaria\\directorionuevo.pdf";
            PdfReader lector = new PdfReader(viejo);
            var tam = lector.GetPageSizeWithRotation(1);
            Document documento = new Document(tam);  //se creo un documento con el tamaño del otro pdf
            //se abre la escritura
            try {
                FileStream fs = new FileStream(nuevo, FileMode.Create, FileAccess.Write);
                PdfWriter escritor = PdfWriter.GetInstance(documento, fs);
                documento.Open();
                string gdgp = listBox1.SelectedItem.ToString();
                PdfContentByte grado = escritor.DirectContent;
                //propiedades de escritura
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                grado.SetColorFill(BaseColor.DARK_GRAY);
                grado.SetFontAndSize(bf, 8);
                //contenido

                //---------------------Varabiables de escritura en el pdf son 8----------------------------
                PdfContentByte cb = escritor.DirectContent;
                //propiedades de escritura
                cb.SetColorFill(BaseColor.DARK_GRAY);
                cb.SetFontAndSize(bf, 8);
                //---------------------------------------DOS----------------------------------------------
                PdfContentByte mat = escritor.DirectContent;
                mat.SetColorFill(BaseColor.DARK_GRAY);
                mat.SetFontAndSize(bf, 8);
                //---------------------------------------TRES----------------------------------------------
                PdfContentByte nom = escritor.DirectContent;
                nom.SetColorFill(BaseColor.DARK_GRAY);
                nom.SetFontAndSize(bf, 8);
                //---------------------------------------CUATRO---------------------------------------------
                PdfContentByte enfer = escritor.DirectContent;
                enfer.SetColorFill(BaseColor.DARK_GRAY);
                enfer.SetFontAndSize(bf, 8);
                //---------------------------------------CINCO----------------------------------------------
                PdfContentByte sangre = escritor.DirectContent;
                sangre.SetColorFill(BaseColor.DARK_GRAY);
                sangre.SetFontAndSize(bf, 8);
                //---------------------------------------SEIS----------------------------------------------
                PdfContentByte cel = escritor.DirectContent;
                cel.SetColorFill(BaseColor.DARK_GRAY);
                cel.SetFontAndSize(bf, 8);
                //---------------------------------------SIETE----------------------------------------------
                PdfContentByte email = escritor.DirectContent;
                email.SetColorFill(BaseColor.DARK_GRAY);
                email.SetFontAndSize(bf, 8);
                //---------------------------------------OCHO----------------------------------------------
                PdfContentByte nomtu = escritor.DirectContent;
                nomtu.SetColorFill(BaseColor.BLACK);
                nomtu.SetFontAndSize(bf, 8);
                //---------------------ESCRIBIR EL GRADO DEL ALUMNO----------------------------------------
                grado.BeginText();
                grado.ShowTextAligned(1, gdgp, 340, 510, 0);
                grado.EndText();
                //COORDENADAS
                int cont = 0, cordY = 0, aux = 0, aux1 = 0;
                //----------------------ESCRIBIR EL GRADO DEL ALUMNO---------------------------------------
                for (int i = 0; i < lista.Count; i++)
                {
                    if (i == 0) { aux = cordY = 420; }
                    else if (i == 1) { aux1 = cordY = aux - 12; }
                    else if (i == 2) { cordY = 0; cordY = aux1 - 14; aux = 394; cont = 1; }
                    else
                    {

                        cordY = aux - (13 * cont); cont++;
                    }

                    cb.BeginText();

                    //Alieneación con cordenadas
                    cb.ShowTextAligned(1, lista[i].paterno + " " + lista[i].materno + " " + lista[i].nombre, 136, cordY, 0);
                    cb.EndText();
                    enfer.BeginText();
                    enfer.ShowTextAligned(1, lista[i].alergia, 350, cordY, 0);
                    enfer.EndText();
                    sangre.BeginText();
                    sangre.ShowTextAligned(1, lista[i].sangre, 507, cordY, 0);
                    sangre.EndText();
                    cel.BeginText();
                    cel.ShowTextAligned(1, lista[i].celular, 567, cordY, 0);
                    cel.EndText();
                    nomtu.BeginText();
                    nomtu.ShowTextAligned(1, lista[i].nombretutor, 667, cordY, 0);
                    nomtu.EndText();
                }

                //crear nueva pagina
                PdfImportedPage page = escritor.GetImportedPage(lector, 1);
                cb.AddTemplate(page, 0, 0);
                //Cerrar
                documento.Close();
                fs.Close();
                escritor.Close();
                lector.Close();
                MessageBox.Show("FINALIZADO");
                System.Diagnostics.Process.Start("explorer", nuevo);
            }
            catch
            {
                MessageBox.Show("CIERRA EL DOCUMENTO ANTES");
            }
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Primaria.Menu frm = new Primaria.Menu();
            frm.Show();
            Close();
        }

        private void Directorio_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
