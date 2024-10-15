using MyPrimeraApp.Contextos;
using MyPrimeraApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrimeraApp.Repositorio
{
    public class MaestroRepository :Repository<Maestro>, IMaestroRepository
    {

        public MaestroRepository(Context contexto):base(contexto)
        {
        }

  
    }
}
