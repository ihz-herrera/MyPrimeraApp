﻿using BISoft.MiPrimeraApp.Aplicacion.Response;
using MyPrimeraApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.MiPrimeraApp.Aplicacion.Helpers
{
    public static class EntityExtensions
    {
        public static AlumnoDto ToDto(this Alumno alumno)
        {
            return new AlumnoDto(alumno.Id, alumno.Nombre, alumno.Apellido, alumno.Edad);
        }
    }
}
