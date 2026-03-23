using static Enumerados_Enum.Cliente;

namespace Enumerados_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente cliente1 = new Cliente("Juan", "Pérez", "12345678", "987654321", TipoCliente.Premium);

            //MessageBox.Show(cliente1.TIPODECLIENTE.ToString());

            ClaseGenerica<Cliente> cl = new ClaseGenerica<Cliente>(cliente1);
            
            MessageBox.Show(cl.getObjeto().NOMBRES);

        }
    }
}
