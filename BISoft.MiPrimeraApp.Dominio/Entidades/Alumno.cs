﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrimeraApp.Entidades
{
    public class Alumno:Entidad
    {
        public string Email { get; set; }
        public int Edad { get; set; } = 12; //Regla de negocio


        public Alumno(string nombre, string apellido, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = 12;//Regla de negocio

          
            //usar regex para validar email
            if(string.IsNullOrEmpty(email) && !email.Contains("@"))
            {
                throw new InvalidOperationException("El email no es valido");
            }

            Email = email;
        }

        //Sobrecarga de constructor
        public Alumno(string nombre, string apellido,string email,int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Edad = edad;
        }

        public override string ToString()
        {
            return Nombre + "," + Apellido + "," + Edad + "," + Email;
        }

    }
}
