using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Castro
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Año { get; set; }
        public int CargaHoraria { get; set; }
        public Comision Comision { get; set; }
    }
}
