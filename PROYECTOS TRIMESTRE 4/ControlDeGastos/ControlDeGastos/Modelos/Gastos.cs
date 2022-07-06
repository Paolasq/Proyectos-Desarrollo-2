using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeGastos
{
    public class Gastos
    {
        public int ID { get; set; } // propiedades de tipo get y set que permiten de for,a interna se pueden agregar y leer o setear elementos a ellas
        public string Gasto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int Monto { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
