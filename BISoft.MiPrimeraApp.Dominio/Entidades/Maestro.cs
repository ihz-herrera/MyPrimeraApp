using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrimeraApp.Entidades
{
    public class Maestro:Entidad
    {
      
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Maestro(string nombre, string apellido, string telefono, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return Nombre + "," + Apellido + "," + Telefono + "," + Direccion + "," + Email;
        }

        public override string TxtSerializer()
        {
            return Nombre + "," + Apellido + "," + Telefono + "," + Direccion + "," + Email;
        }
    }
}
