using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Castro
{
    public class Facultad
    {
        public string Nombre { get; set; }
        public string Sede { get; set; }
        public DateTime Fundacion { get; set; }
        public Direccion Direccion { get; set; }
        public Tamanio Dimenciones { get; set; }
    }
}
