using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeGastos.Modelos
{
    public class Conceptos
    {
        public int Id { get; set; } // propiedades de tipo get y set que permiten de for,a interna se pueden agregar y leer o setear elementos a ellas
        public string Nombre { get; set; }
        public bool Visibilidad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime ModifiedDate { get; set; }


    }
}
