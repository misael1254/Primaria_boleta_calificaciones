using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primaria
{
    public class Calificaciones
    {
        public struct Primero
        {
            public float calificacion;
            public string nommat;
            public string fecha;
            float Calificacion
            {
                get { return calificacion; }
                set { calificacion = value; }
            }
            string NomMat
            {
                get { return nommat; }
                set { nommat = value; }
            }
            string Fecha
            {
                get { return fecha; }
                set { fecha = value; }
            }
        }
    }
}
