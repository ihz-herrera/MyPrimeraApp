﻿using BISoft.MiPrimeraApp.Aplicacion.Helpers;
using BISoft.MiPrimeraApp.Aplicacion.Response;
using MyPrimeraApp.Entidades;
using MyPrimeraApp.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.MiPrimeraApp.Aplicacion.Servicios
{
    public class AlumnoService
    {


        private readonly IAlumnoRepository _repo;

        public AlumnoService(IAlumnoRepository repo)
        {
            _repo = repo;
        }

        public AlumnoDto CrearAlumno(string nombre, string apellido, string email)
        {
            //var existeAlumno = _repo.Obtener().Any(x => x.Email == email);
            //if (existeAlumno)
            //{
            //    throw new Exception("El alumno ya existe");
            //}

            var alumno = new Alumno(nombre, apellido, email);
            _repo.Guardar(alumno);

            return alumno.ToDto();
        }

        public List<AlumnoDto> ObtenerAlumnos()
        {

            var lista = new List<AlumnoDto>();


            var alumnos = _repo.Obtener();

            foreach (var alumno in alumnos)
            {
                lista.Add(alumno.ToDto());
            }

            return lista;
        }

        private AlumnoDto ConvertToAlumnoDto(Alumno alumno)
        {
            return new AlumnoDto(alumno.Id, alumno.Nombre, alumno.Apellido, alumno.Edad);
        }
    }
}
