using BISoft.MiPrimeraApp.Aplicacion.Servicios;
using MyPrimeraApp.Fabrica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyPrimeraApp.Fabrica.AlumnoRepositoryFactory;

namespace BISoft.MiPrimeraApp.Aplicacion.Fabrica
{
    public class ServiceFactory
    {

        public static AlumnoService CrearAlumnoService(DBType type = DBType.Txt)
        {

            var repo = AlumnoRepositoryFactory.CrearAlumnoRepository(type);

            return new AlumnoService(repo);
        }

    }
}
