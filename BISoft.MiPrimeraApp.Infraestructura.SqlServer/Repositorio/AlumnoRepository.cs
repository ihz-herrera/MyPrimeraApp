using MyPrimeraApp.Contextos;
using MyPrimeraApp.Entidades;

namespace MyPrimeraApp.Repositorio
{
    internal class AlumnoRepository : Repository<Alumno>, IAlumnoRepository
    {

        public AlumnoRepository(Context contexto) : base(contexto)
        {
        }

    }

}
