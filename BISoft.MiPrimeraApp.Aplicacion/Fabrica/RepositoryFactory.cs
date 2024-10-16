using Microsoft.EntityFrameworkCore;
using MyPrimeraApp.Contextos;
using MyPrimeraApp.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrimeraApp.Fabrica
{
    public class RepositoryFactory
    {

        public static IAlumnoRepository CrearAlumnoRepository(DBType type = DBType.Txt )
        {

            switch (type)
            {
                case DBType.SqlServer:
                    var options = new DbContextOptionsBuilder<Context>()
                        .UseSqlServer("server=.;database = Escuela;Encrypt=false; Trusted_connection=true")
                        .Options;
                    var context = new Context(options);

                    return new AlumnoRepository(context);
                case DBType.Sqlite:
                    var optionsSqlite = new DbContextOptionsBuilder<Context>()
                        .UseSqlite("source= C:\\BaseDeDatos\\Escuela.db")
                        .Options;
                    var contextSqlite = new Context(optionsSqlite);
                    return new AlumnoRepository(contextSqlite);
                default:
                    return new AlumnoTxtRepository();
            }

        }

        public enum DBType
        {
            Sqlite,
            SqlServer,
            Txt
        }


    }





}
