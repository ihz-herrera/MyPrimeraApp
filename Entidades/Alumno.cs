using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrimeraApp.Entidades
{
    public class Alumno
    {
        public int id;
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; } = 12; //Regla de negocio


        public Alumno(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = 12;//Regla de negocio
        }

        //Sobrecarga de constructor
        public Alumno(string nombre, string apellido,int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

    }
}
