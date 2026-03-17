namespace Asociaciones_Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Cliente cliente1 = new Cliente("Enrique", "Gonzales", "001", "5434566");
            Fecha fecha1 = new Fecha(05,05,1996);

            //Atributos  de tipo objeto
            Venta venta1 = new Venta(1,15000, cliente1,fecha1);


            Venta venta2 = new Venta(2, 20000, new Cliente("Maria", "Restrepo", "002", "2134342"), new Fecha(10, 10, 2020));

            MessageBox.Show("Num Venta 1: " + venta1.getNumeroVenta() + " - " + "Total: " + venta1.getTotal() + " - " + "Cliente: " + venta1.getCliente().getNombre() + " - " + venta1.getFecha().getDia() + "/" + venta1.getFecha().getMes() + "/" + venta1.getFecha().getAnio());
        }
    }
}
