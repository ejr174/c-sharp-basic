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

            // List

            /**
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
            **/

           
            // LinkedList: Maneja una lista enlazada, es decir,
            // cada elemento tiene una referencia al siguiente elemento, lo que permite una inserción y eliminación más eficiente
            // en comparación con List, pero no permite el acceso aleatorio a los elementos.


            LinkedList<Cliente> clientes2 = new LinkedList<Cliente>();

            // Agregar elementos al inicio y al final de la lista
            clientes2.AddFirst(new Cliente("Cristiano", "Ronaldo", "1111", "344546556"));
            clientes2.AddLast(new Cliente("Lionel", "Messi", "2222", "344546556"));

            // Agregar elementos con un nodo específico: La diferencia con List es que en LinkedList se puede agregar un nodo específico,
            // mientras que en List solo se puede agregar un elemento en una posición específica
            LinkedListNode<Cliente> nodoNeymar = new LinkedListNode<Cliente>(new Cliente("Neymar", "Junior", "3333", "344546556"));
            clientes2.AddLast(nodoNeymar);
          

            // Colas - Queues:
            // Maneja una colección de elementos
            // en la que el primer elemento agregado es el primero en ser eliminado (FIFO - First In, First Out).

            Queue<Cliente> clientes3 = new Queue<Cliente>();
            clientes3.Enqueue(new Cliente("Cristiano", "Ronaldo", "1111", "344546556"));
            clientes3.Enqueue(new Cliente("Lionel", "Messi", "2222", "344546556"));
            clientes3.Enqueue(new Cliente("Neymar", "Junior", "3333", "344546556"));

            clientes3.Dequeue(); // Elimina el primer elemento agregado (Cristiano Ronaldo)

            // Stack - Pilas: 
            Stack<Cliente> clientes4 = new Stack<Cliente>();
            clientes4.Push(new Cliente("Cristiano", "Ronaldo", "1111", "344546556"));
            clientes4.Push(new Cliente("Lionel", "Messi", "2222", "344546556"));
            clientes4.Push(new Cliente("Neymar", "Junior", "3333", "344546556"));

            clientes4.Pop(); // Elimina el último elemento agregado (Neymar Junior)

            foreach (Cliente cliente in clientes4)
            {
                MessageBox.Show("Cliente: " + cliente.Nombres + " " + cliente.Apellidos);
            }
        }
    }
}
