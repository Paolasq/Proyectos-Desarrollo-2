using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeGastos
{
    public class Pago
    {
        public int Id { get; set; } // propiedades de tipo get y set que permiten de for,a interna se pueden agregar y leer o setear elementos a ellas
        public string Metodo { get; set; }
        public bool Visibilidad { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
