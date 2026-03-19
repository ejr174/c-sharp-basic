namespace Asociaciones_Herencia
{
    public partial class Form1 : Form
    {
        private Almacen almacen = new Almacen();
        private ErrorProvider errorProvider = new ErrorProvider();

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
            errorProvider.Clear();

            string mensaje = "";

            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                mensaje = "El campo de nombres no puede estar vacío.";
                MostrarError(mensaje);
                errorProvider.SetError(txtNombres, mensaje);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                mensaje = "El campo de apellidos no puede estar vacío.";
                MostrarError(mensaje);
                errorProvider.SetError(txtApellidos, mensaje);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumId.Text))
            {   
                mensaje = "El campo de número de NumId no puede estar vacío.";
                MostrarError(mensaje);
                errorProvider.SetError(txtNumId, mensaje);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCelular.Text)) 
            {
                mensaje = "El campo de Celular no puede estar vacío.";
                MostrarError(mensaje);
                errorProvider.SetError(txtCelular, mensaje);
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

            errorProvider.Clear();

            if (lblMensajes != null) lblMensajes.Visible = false;
        }
    }
}
