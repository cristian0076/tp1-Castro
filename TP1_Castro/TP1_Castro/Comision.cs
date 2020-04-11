using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Castro
{
    public class Comision
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadAlumnos { get; set; }
        public Aula Aula { get; set; }
        public char Turno { get; set; }
        public DateTime Horario  { get; set; }
     
    }
}
