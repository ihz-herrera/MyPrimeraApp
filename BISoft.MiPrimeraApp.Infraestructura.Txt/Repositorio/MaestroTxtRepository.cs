using MyPrimeraApp.Entidades;

namespace MyPrimeraApp.Repositorio
{
    public class MaestroTxtRepository : IMaestroRepository
    {

        public void Guardar(Maestro maestro)
        {
            ////Validar que el alumno no existe
            //if (Obtener().Any(x => x.Email == alumno.Email))
            //{
            //    throw new InvalidOperationException(  "El alumno ya existe");
            //}

            using (StreamWriter sw = new StreamWriter("C:\\BaseDeDatos\\maestro.txt", true))
            {
                sw.WriteLine(maestro.Nombre + "," + maestro.Apellido + "," + maestro.Telefono + "," + maestro.Direccion);
            }
        }

        public Maestro Obtener(int id)
        {
            return Obtener().FirstOrDefault(x => x.Id == id);
        }

        public List<Maestro> Obtener()
        {

            var maestros = new List<Maestro>();

            using (StreamReader sr = new StreamReader("C:\\BaseDeDatos\\Maestro.txt"))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    var valores = linea.Split(',');

                    var maestro = new Maestro(valores[0], valores[1], valores[2], valores[3]);

                    maestros.Add(maestro);

                   
                }
            }

            return maestros;
        }

       
    }
}
