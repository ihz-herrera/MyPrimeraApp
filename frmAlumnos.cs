using MyPrimeraApp.Contextos;
using MyPrimeraApp.Entidades;

namespace MyPrimeraApp
{
    public partial class frmAlumnos : Form
    {

        List<Alumno> Alumnos = new List<Alumno>();


        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object senderr, EventArgs e)
        {

            var alumno = new Alumno(txtNombre.Text, txtApellido.Text);

            var edad = 0;
            int.TryParse(cmbEdad.Text, out edad);

            alumno.Edad = edad;
            GuardarAlumnoSqlite(alumno);

            MessageBox.Show("El nombre es: " + alumno.Nombre + " " + alumno.Apellido
                + " \nEdad:" + alumno.Edad, "Mensaje Alumnos");
        }

        private void GuardarAlumnoSqlite(Alumno alumno)
        {
            var contexto = new Context();

            alumno.id = 0;

            var result = contexto.Alumnos.Where(x => x.Nombre == alumno.Nombre 
                        && x.Apellido == alumno.Apellido).FirstOrDefault();

            if (result != null)
            {
                MessageBox.Show("El alumno ya existe", "Mensaje Alumnos");
                return;
            }


            contexto.Alumnos.Add(alumno);
            contexto.SaveChanges();
        }


        private void GuardarAlumnoTxt(Alumno alumno)
        {
            //Validar que el alumno no existe
            if (Alumnos.Any(x => x.Nombre == alumno.Nombre && x.Apellido == alumno.Apellido))
            {
                MessageBox.Show("El alumno ya existe", "Mensaje Alumnos");
                return;
            }

            using (StreamWriter sw = new StreamWriter("C:\\BaseDeDatos\\Alumnos.txt", true))
            {
                sw.WriteLine(alumno.Nombre + "," + alumno.Apellido + "," + alumno.Edad);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ConsultarTodosSqlite();

        }

        private void ConsultarTodosSqlite()
        {
            var contexto = new Context();

            Alumnos = contexto.Alumnos.ToList();

          
        }

        private void ConsultarTodosTxt()
        {
            using (StreamReader sr = new StreamReader("C:\\BaseDeDatos\\Alumnos.txt"))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    var valores = linea.Split(',');

                    var alumno = new Alumno(valores[0], valores[1], int.Parse(valores[2]));

                    Alumnos.Add(alumno);

                    MessageBox.Show("El nombre es: " + valores[0] + " " + valores[1]
                        + " \nEdad:" + valores[2], "Mensaje Alumnos");
                }
            }
        }
    }
}
