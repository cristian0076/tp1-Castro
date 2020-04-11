using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Castro
{
   public class Aviso
    {
        public string Titulo { get; set; }
        public string Asunto { get; set; }
        public string Emisor { get; set; }

        public List<Alumno> DestinoAlumnos { get; set; }

        public List<Profesor> DestinoProfesor { get; set; }

        public string CuerpoMensaje { get; set; }

        public string Importancia { get; set; }

    }
}
