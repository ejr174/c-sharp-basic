namespace Asociaciones_Herencia
{
    public partial class Form1 : Form
    {
        private Almacen almacen = new Almacen();
        // Instanciar el ErrorProvider aquí está bien, pero asegúrate de que esté configurado en el diseñador
        private ErrorProvider errorProvider = new ErrorProvider();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensajes.Visible = false; // Ocultamos el label de mensajes al cargar el formulario
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario()) return;

            // 1. Creación directa del cliente
            var cliente = new Cliente(txtNombres.Text, txtApellidos.Text, txtNumId.Text, txtCelular.Text);

            // 2. Simplificación de la fecha
            DateTime ahora = DateTime.Now;
            var fechaVenta = new Fecha(ahora.Day, ahora.Month, ahora.Year);

            // 3. Proceso de venta
            almacen.crearVenta(2500, cliente, fechaVenta);

            // 4. Feedback final
            LimpiarCampos();
            MostrarMensajeExito("Venta creada exitosamente.");
        }

        // --- MÉTODOS DE APOYO (REUTILIZABLES) ---

        private bool ValidarFormulario()
        {
            errorProvider.Clear();
            lblMensajes.Visible = false;

            // Validamos uno a uno. Si uno falla, el método retorna false de inmediato.
            // Esto es mucho más limpio y fácil de leer.
            if (!ValidarCampo(txtNombres, "El nombre es obligatorio")) return false;
            if (!ValidarCampo(txtApellidos, "El apellido es obligatorio")) return false;
            if (!ValidarCampo(txtNumId, "La identificación es obligatoria")) return false;
            if (!ValidarCampo(txtCelular, "El celular es obligatorio")) return false;
            if (!ValidarCampo(txtTotalVenta, "El total de la venta es obligatorio")) return false;

            return true;
        }

        private bool ValidarCampo(TextBox campo, string mensaje)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                errorProvider.SetError(campo, mensaje);
                lblMensajes.Text = mensaje;
                lblMensajes.ForeColor = Color.Red;
                lblMensajes.Visible = true;
                campo.Focus(); // Pone el cursor en el campo que falló (Buen UX)
                return false;
            }
            return true;
        }

        private void MostrarMensajeExito(string mensaje)
        {
            lblMensajes.Text = mensaje;
            lblMensajes.ForeColor = Color.Green;
            lblMensajes.Visible = true;
        }

        public void LimpiarCampos()
        {
            // En lugar de uno por uno, puedes limpiar todos los TextBox del formulario
            foreach (Control c in this.Controls)
            {
                if (c is TextBox) c.Text = string.Empty;
            }

            errorProvider.Clear();
            lblMensajes.Visible = false;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
