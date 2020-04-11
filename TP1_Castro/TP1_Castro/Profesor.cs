using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Castro
{
    public class Profesor : Persona
    {
        public int Legajo { get; set; }
        public List<Materia> Catedras { get; set; }
        public  DateTime Horario { get; set; }
        public Contacto Contacto { get; set; }
        public Usuario User { get; set; }
    }
}
