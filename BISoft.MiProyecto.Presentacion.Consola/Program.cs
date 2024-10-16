// See https://aka.ms/new-console-template for more information







using BISoft.MiPrimeraApp.Aplicacion.Fabrica;

var service = ServiceFactory.CrearAlumnoService();


service.CrearAlumno("Juan", "Perez", "ivan@hotmail.com");



Console.WriteLine("Hello, World!");
