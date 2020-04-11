using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Castro
{
   public class Ayudante : Persona
    {
        public int Legajo { get; set; }
        public DateTime AltaAyudante { get; set; }
        public DateTime BajaAyudante { get; set; }
        public Contacto Contacto { get; set; }
        public bool  EsAlumno { get; set; }
        public DateTime Horario { get; set; }
        public Usuario User { get; set; }
    }
}
