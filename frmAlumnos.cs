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

            var alumno = new Alumno(txtNombre.Text,txtApellido.Text);

            var edad = 0;
            int.TryParse(cmbEdad.Text,out edad );

            alumno.Edad = edad;

            //Validar que el alumno no existe
            if (Alumnos.Any(x => x.Nombre == alumno.Nombre && x.Apellido == alumno.Apellido))
            {
                MessageBox.Show("El alumno ya existe", "Mensaje Alumnos");
                return;
            }

            using (StreamWriter sw = new StreamWriter("C:\\BaseDeDatos\\Alumnos.txt", true))
            {
                sw.WriteLine( alumno.Nombre + "," + alumno.Apellido + "," + alumno.Edad);
            }


            MessageBox.Show("El nombre es: " + alumno.Nombre + " " + alumno.Apellido
                + " \nEdad:" + alumno.Edad, "Mensaje Alumnos");
        }

        private void btnCargar_Click(object sender, EventArgs e)
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
