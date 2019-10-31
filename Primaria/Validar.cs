using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaria
{
    public partial class Validar : Form
    {
        public static string permiso="n";
        public static bool seguir = false;
        public Validar()
        {
            InitializeComponent();
        }

        private void Validar_Load(object sender, EventArgs e)
        {
            Validar frm = new Validar();
            frm.DesktopLocation = new Point(400, 400);
        }

        private void validar_btn_Click(object sender, EventArgs e)
        {
            if(clave_txt.Text.Equals("directoradmin"))
            {
                permiso = "s";
                seguir = true;
              if(datos.op=="baja")
                {
                    var ob = new Bajas();
                    ob.pictureBox3_Click(this, null);
                }
              else if(datos.op=="inser_usu")
                {
                    var ob = new Form1();
                    ob.Reg_btn_Click(this, null);
                }
                else if (datos.op.Equals("mod"))
                {
                    var ob = new Modificar();
                    ob.Modificar_pic_Click(this, null);
                }
            }
            else
            {
                permiso = "n";
                seguir = true;
                if (datos.op == "baja")
                {
                    var ob = new Bajas();
                    ob.pictureBox3_Click(this, null);
                }
                else if (datos.op == "inser_usu")
                {
                    var ob = new Form1();
                    ob.Reg_btn_Click(this, null);
                }
                else if(datos.op.Equals("mod"))
                {
                    var ob = new Modificar();
                    ob.Modificar_pic_Click(this, null);
                }
            }
            Close();
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            permiso = "n";
            seguir = false;
            Close();
        }
    }
}
