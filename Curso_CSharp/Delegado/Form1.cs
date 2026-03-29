using Herencia;

namespace Delegado
{
    public partial class Form1 : Form

        
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ejemplo delegado
            delegadoSuma ds = sumar;
            int resultado = ds(5, 10);

            //MessageBox.Show("El resultado de la suma es: " + resultado);


            // Ejemplo delegado predicado
            List<Cliente> clientesTCC = new List<Cliente>();

            clientesTCC.Add(new Cliente("Juan", "Perez", "33", "cll falsa", "22343", 31));
            clientesTCC.Add(new Cliente("Maria", "Gomez", "28", "cll falsa 2", "22344", 25));
            clientesTCC.Add(new Cliente("Carlos", "Lopez", "40", "cll falsa 3", "22345", 35)); 
            clientesTCC.Add(new Cliente("Ana", "Martinez", "22", "cll falsa 4", "22346", 20));

            Predicate<Cliente> clientesPuntosMayor30 = new Predicate<Cliente>(puntosMayoresA30);

            foreach (Cliente cliente in clientesTCC)
            {
                if (clientesPuntosMayor30(cliente))
                {
                    MessageBox.Show("El cliente " + cliente.getNombres() + " tiene más de 30 puntos.");
                }
            }


        }

        public bool puntosMayoresA30(Cliente cliente)
        {
            int puntosCliente = Convert.ToInt32(cliente.getPuntos());

            return puntosCliente  > 30;
        }

        delegate int delegadoSuma(int a, int b);

        private int sumar(int a, int b)
        {
            return a + b;
        }
    }
}
