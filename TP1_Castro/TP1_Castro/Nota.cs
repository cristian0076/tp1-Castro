using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Castro
{
    public class Nota
    {
        public  Materia Materia { get; set; }
        public bool Final  { get; set; }
        public bool Parcial { get; set; }
        public bool Recuperatorio { get; set; }
        public DateTime Fecha { get; set; }
        public int Calificacion { get; set; }

    }
}
