using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Castro
{
    public class EstadoAcademico
    {
        public int Legajo { get; set; }
        public int MateriasAprobadas { get; set; }
        public List <Nota> Notas { get; set; }
    }
}
