using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOS_CEDULA
{
    internal class Ciudadano // clase publica (podra ser accesible desde cualquier otra clase), donde crearemos espacios para guardar los datos ingresados en cada campo
    {
        public Guid Id { get; set; } // Guid representa un identificador unico global, el cual diferencia a cada ciudadano ingresado
        public string Nombre { get; set; } // los descriptores de acceso get y set seran usados para acceder (get) y asignar (set) valores a una propiedad (nombre) que se encuentra en clases privadas
        public string LugarNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string Ocupacion { get; set; }
        public string Sangre { get; set; } // combobox que almacena strings
        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public char Sexo { get; set; }

        public DateTime FechaExpiracion { get; set; }
    }
}
