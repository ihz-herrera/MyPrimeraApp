using BISoft.MiPrimeraApp.Aplicacion.Servicios;
using MyPrimeraApp.Contextos;
using MyPrimeraApp.Entidades;
using MyPrimeraApp.Repositorio;

namespace MyPrimeraApp
{
    public partial class frmAlumnos : Form
    {
        private AlumnoService _service;

        public frmAlumnos(AlumnoService service)
        {
            InitializeComponent();

            _service = service;
        }

        private void btnGuardar_Click(object senderr, EventArgs e)
        {
            try
            {
                var alumno =  _service.CrearAlumno(txtNombre.Text, txtApellido.Text, txtCorreo.Text);

                MessageBox.Show("El nombre es: " + alumno.Nombre + " " + alumno.Apellido
                    + " \nEdad:" + alumno.Edad, "Mensaje Alumnos");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
            
        }



     

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //ConsultarTodosSqlite();

        }

   
          

    }
}
