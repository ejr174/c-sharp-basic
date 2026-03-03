namespace CondicionalSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresarValor_Click(object sender, EventArgs e)
        {
            int valorIngresado = Convert.ToInt16(txtMesIngresado.Text);

            switch (valorIngresado)
            {
                case 0:
                    {
                        MessageBox.Show("El valor ingresado es 0");
                        break;
                    }

                case 100:
                    {
                        MessageBox.Show("El valor ingresado es 100");
                        break;
                    }

                default:
                    {
                        MessageBox.Show("El valor ingresado no es ni 0 ni 100");
                        break;
                    }
            }
        }

        private void cmbMesSeleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcion = int.Parse(cmbMesSeleccionado.SelectedItem.ToString());

            switch (opcion)
            {

                case 0:
                    {
                        txtMesIngresado.Text = ("El mes seleccionado no existe");
                        break;
                    }

                case 1:
                    {
                        txtMesIngresado.Text = ("El mes seleccionado es Enero");
                        break;
                    }
                case 2:
                    {
                        txtMesIngresado.Text = ("El mes seleccionado es Febrero");
                        break;  
                    }
                case 3:
                    {
                        txtMesIngresado.Text = ("El mes seleccionado es Marzo");
                        break;
                    }
                case 4:
                    {
                        txtMesIngresado.Text = ("El mes seleccionado es Abril");
                        break;
                    }
                case 5:
                    {
                        txtMesIngresado.Text = ("El mes seleccionado es Mayo");
                        break;
                    }
                case 6:
                    {
                        txtMesIngresado.Text = ("El mes seleccionado es Junio");
                        break;
                    }
                case 7:
                    {
                        txtMesIngresado.Text = ("El mes seleccionado es Julio");
                        break;
                    }
                case 8:
                    {
                        txtMesIngresado.Text = ("El mes seleccionado es Agosto");
                        break;
                    }
                case 9:
                    {
                        txtMesIngresado.Text = ("El mes seleccionado es Septiembre");
                        break;
                    }
                case 10:
                    {
                        txtMesIngresado.Text = ("El mes seleccionado es Octubre");
                        break;
                    }
                case 11:
                    {
                        txtMesIngresado.Text = ("El mes seleccionado es Noviembre");
                        break;
                    }
                case 12:
                    {
                        txtMesIngresado.Text = ("El mes seleccionado es Diciembre");
                        break;
                    }
            }
        }
    }
}
