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
            lblMensajes.Visible = false;
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            bool camposValidos = validarCampos();

            if (!camposValidos)
            {
                return;
            }

            Cliente cl = new Cliente(txtNombres.Text, txtApellidos.Text, txtNumId.Text, txtCelular.Text);

            DateTime fecha = DateTime.Now;
            int day = fecha.Day;
            int month = fecha.Month;
            int year = fecha.Year;

            Fecha fch = new Fecha(day, month, year);

            almacen.crearVenta(2500, cl, fch);

            limpiarCampos();

            lblMensajes.Text = "Venta creada exitosamente.";
            lblMensajes.ForeColor = Color.Green;
            lblMensajes.Visible = true;

        }


        public bool validarCampos()
        {
            lblMensajes.Visible = false;

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                MostrarError("El campo de apellidos no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                MostrarError("El campo de nombres no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumId.Text))
            {
                MostrarError("El campo de NumId no puede estar vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCelular.Text)) 
            {
                MostrarError("El campo de Celukar no puede estar vacío.");
                return false;
            }

            return true;

        }

        private void MostrarError(string mensaje)
        {
            lblMensajes.Text = mensaje;
            lblMensajes.Visible = true;
            lblMensajes.ForeColor = Color.Red;
        }

        public void limpiarCampos()
        {
            txtApellidos.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtNumId.Text = string.Empty;
            txtCelular.Text = string.Empty;
            lblMensajes.Visible = false;
        }
    }
}
