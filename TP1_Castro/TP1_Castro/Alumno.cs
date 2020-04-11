using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Castro
{
    public class Alumno : Persona
    {
        public int Legajo { get; set; }
        public  DateTime Alta { get; set; }

        public Carrera Carrera { get; set; }

        public  Contacto Contacto { get; set; }

        public List<Nota> Notas { get; set; }

        public Usuario User { get; set; }

    }
}
