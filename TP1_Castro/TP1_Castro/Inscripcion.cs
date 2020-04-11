using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Castro
{
    public class Inscripcion
    {
        public int Id { get; set; }
        public DateTime Alta { get; set; }
        public bool Final { get; set; }
        public bool Cursada { get; set; }
        public Materia Materia { get; set; }
    }
}
