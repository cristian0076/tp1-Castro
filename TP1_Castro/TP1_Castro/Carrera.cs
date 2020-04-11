using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Castro
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public DateTime Alta { get; set; }
        public List<Materia> Materias  { get; set; }
    }
}
