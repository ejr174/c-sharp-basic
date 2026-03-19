namespace Asociaciones_Herencia
{
    public partial class Form1 : Form
    {
        private Almacen almacen = new Almacen();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
           // validarCampos();

            Cliente cl = new Cliente("Emmaunel", "Jaramillo Resrepo", "123", "300556676");

            DateTime fecha = DateTime.Now;
            int day = fecha.Day;
            int month = fecha.Month;
            int year = fecha.Year;  

            Fecha fch = new Fecha(day, month, year);

            almacen.crearVenta(2500, cl, fch);

        }
        
        public void validarCampos()
        {
                if (string.IsNullOrEmpty(lblTitulo.Text) || string.IsNullOrEmpty(lblNombres.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de crear la venta.");
                    return;
                }

            // Aquí puedes agregar más validaciones según sea necesario
        }
    }
}
