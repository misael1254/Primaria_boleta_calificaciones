using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primaria
{
   public class datos
    {

        public static string op; //lo voy a ocupar para las validaciones, saber que operación estoy realizando
        public static string val1;
        public static string val2;
        public static string val3;//va aguardar algún valor a operar 
        //Para modificar
        public static string Curp;
        public static string Paterno;
        public static string Materno;
        public static string Nombre;
        public static string Sangre;
        public static string Alergia;
        public static string NuevaC;
        public struct directorio
        {

            public string paterno;
            public string materno;
            public string nombre;
            public string alergia;
            public string sangre;
            public string celular;
            public string email;
            public string nombretutor;
            string Patern
            {
                get { return paterno; }
                set { paterno = value; }
            }
            string Matern
            {
                get { return materno; }
                set { materno = value; }
            }
            string Nom
            {
                get { return nombre; }
                set { nombre = value; }
            }
            string Alergia
            {
                get { return alergia; }
                set { alergia = value; }
            }
            string Sangre
            {
                get { return sangre; }
                set { sangre = value; }
            }
            string Celular
            {
                get { return celular; }
                set { celular = value; }
            }
            string Email
            {
                get { return email; }
                set { email = value; }
            }

        }
        //Datos de fecha nacimiento y edad del alumno, para poder retornar más de un valor
        public struct EdadFechaNac
            {
            private string edad;
            private string annoNac;
            private string mesNac;
            private string diaNac;
            public string Edad
            {
                get { return edad; }
                set { edad = value; }
            }
            public string AnnoNac
            {
                get { return annoNac; }
                set { annoNac = value; }
            }
            public string MesNac
            {
                get { return mesNac; }
                set { mesNac = value; }
            }
            public string DiaNac
            {
                get { return diaNac; }
                set { diaNac = value; }
            }
            string NombreTutor
            {
                get { return NombreTutor; }
                set { NombreTutor = value; }
            }
        }
        public string curp_alumno { get; set; }
        public string ap_pat_alumno { get; set; }
        public string ap_mat_alumno { get; set; }
        public string nombre_alumno { get; set; }
        public int edad_alumno { get; set; }
        public string fecha_nacimiento_alumno { get; set; }
        public string sexo_alumno { get; set; }
        public string tipo_sangre { get; set; }
        public string enfer_alergi { get; set; }
        public string curp_tutor { get; set; }
        public datos(){}
        public datos(string dcurp,string dap,string dam, string dnm, int dedad, string dfecha, string dsexo, string dtipo, string denfer, string dcurpt)
        {
            this.curp_alumno = dcurp;
            this.ap_pat_alumno = dap;
            this.ap_mat_alumno = dam;
            this.nombre_alumno = dnm;
            this.edad_alumno = dedad;
            this.fecha_nacimiento_alumno = dfecha;
            this.sexo_alumno = dsexo;
            this.tipo_sangre = dtipo;
            this.enfer_alergi = denfer;
            this.curp_tutor = dcurpt;
        }
    
    }// clase datos
    public class tutor
    {
        public string curp_tutor { get; set; }
        public string ap_pat_tutor { get; set; }
        public string ap_mat_tutor { get; set; }
        public string nombre_tutor { get; set; }
        public string tel_cel_tutor { get; set; }
        public string tel_casa_tutor { get; set; }
        public string tel_extra_tutor { get; set; }
        public string email_tutor { get; set; }
        public string email_extra_tutor { get; set; }
        public string municipio_direc { get; set; }
        public string colonia_direc { get; set; }
        public string calle_direc { get; set; }
        public string cp_direc { get; set; }
        public string numcalle_direc { get; set; }

        public tutor() { }
        public tutor(string curptuto, string appattuto, string apmattuto, string nomtuto,
                            string telceltut, string telcastuto, string telextuto, string emailtuto, string emailextuto, string munidir, string coldir,
                            string calldir, string cpdic, string numcal)

        {
            this.curp_tutor = curptuto;

        }

    }


}