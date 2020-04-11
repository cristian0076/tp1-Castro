using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Castro
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Documento { get; set; }
        public DateTime FechaNacimiento{ get; set; }
        public Direccion Direccion { get; set; }
        public string Sexo { get; set; }
        public  string Nacionalidad { get; set; }

    }
}
