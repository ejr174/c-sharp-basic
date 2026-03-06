namespace BuscarElementosArray
{
    public partial class Form1 : Form
    {
        private string[] nombres = { "Emmanuel", "Salo", "Pava", "Rosa Emilia" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.Visible = false;
        }

        private void btnEncontrar_Click(object sender, EventArgs e)
        {
            string nombreBuscado = txtEncontrar.Text;

            bool encontrado = false;

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i].Equals(nombreBuscado))
                {
                    encontrado = true;
                }
            }

            if (encontrado)
                
            {
                lblMensaje.Visible = true;
                lblMensaje.ForeColor  = Color.Green;
                lblMensaje.Text = "Ohhh!! tu compañero" + nombreBuscado + " fue encontra con éxito!";
            } else
            {
                lblMensaje.Visible = true;
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Ohhh!! tu compañero" + nombreBuscado + " no fue encontrado, lo sentimos :(";
            }
        }
    }
}
