using MyPrimeraApp.Contextos;
using MyPrimeraApp.Entidades;
using MyPrimeraApp.Repositorio;

namespace MyPrimeraApp
{
    public partial class frmAlumnos : Form
    {
        private IAlumnoRepository _alumnoRepository;

        public frmAlumnos(IAlumnoRepository repo)
        {
            InitializeComponent();
            _alumnoRepository = repo;

        }

        private void btnGuardar_Click(object senderr, EventArgs e)
        {

            var alumno = new Alumno(txtNombre.Text, txtApellido.Text);

            var edad = 0;
            int.TryParse(cmbEdad.Text, out edad);

            alumno.Edad = edad;
            _alumnoRepository.Guardar(alumno);

            MessageBox.Show("El nombre es: " + alumno.Nombre + " " + alumno.Apellido
                + " \nEdad:" + alumno.Edad, "Mensaje Alumnos");
        }



     

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //ConsultarTodosSqlite();

        }

   
          

    }
}
