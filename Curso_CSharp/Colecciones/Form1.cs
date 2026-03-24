namespace Colecciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(new Cliente("Cristiano", "Ronaldo", "1111", "344546556"));
            clientes.Add(new Cliente("Lionel", "Messi", "2222", "344546556"));

            foreach (Cliente cliente in clientes) {
                MessageBox.Show("Cliente: " + cliente.Nombres + " " + cliente.Apellidos);
            }

            MessageBox.Show("Clientes agregados: " + clientes.Count);

            clientes.Insert(1, new Cliente("Neymar", "Junior", "3333", "344546556"));
            clientes.Insert(3, new Cliente("Kylian", "Mbappe", "4444", "344546556"));

            foreach (Cliente cliente in clientes)
            {
                MessageBox.Show("Cliente: " + cliente.Nombres + " " + cliente.Apellidos);
            }

            MessageBox.Show("Clientes agregados: " + clientes.Count);

            clientes.RemoveAt(3);
            MessageBox.Show("Clientes agregados: " + clientes.Count);

        }
    }
}
