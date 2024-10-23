using MyPrimeraApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.MiPrimeraApp.Infraestructura.Txt.Repositorio
{
    public class Repository<T> : IRepository<T> where T : Entidad
    {
        public void Guardar(T entidad)
        {

            var filename =entidad.GetType().Name;
            using (StreamWriter sw = new StreamWriter($"C:\\BaseDeDatos\\{entidad.GetType().Name}.bst", true))
            {
                sw.WriteLine(entidad.TxtSerializer());
            }
        }

        public T Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> Obtener()
        {
            throw new NotImplementedException();
        }
    }
}
