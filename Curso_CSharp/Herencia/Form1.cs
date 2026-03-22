namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente client1 = new Cliente("Emmanuel", "Jaramillo Restrepo", "34234", "cll 50 # 35-24", "2345434", 50);
            Empleado empleado1 = new Empleado("Juan", "Perez", "12345", "carrea falsa # 29-31", "3004355", 20000);

            // MessageBox.Show("El cliente " + client1.getNombres() + " tiene " + client1.getPuntos() + " puntos.");
            //MessageBox.Show("El empleado " + empleado1.getNombres() + " tiene un salario de " + empleado1.getSalario() + ".");

            //client1.getInfo();
            //empleado1.getInfo(); 

            // Ejemplo super clase OBJECT  y Casting
            Object salome = new Cliente("Salome", "Medina Patino", "954065", "cll 50 # 35-24", "2345434", 50);

            // Casting
            Cliente clienteSalome = (Cliente) salome;

            clienteSalome.getInfo();


        }
    }
}
