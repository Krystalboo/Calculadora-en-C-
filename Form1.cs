namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;
        public Form1()
        {
            InitializeComponent();
        }
        private void agregarNumero(object sender, EventArgs e)
        {
            /*
             * Realizamos esto para no tener que llamar la función en cada boton 
             * Si no que los botones se redirigan a ella 
           */

            var boton = ((Button)sender);

            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += boton.Text;
        }
        /*Operaciones*/

        private void buttonresult_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtResultado.Text);

            if (Operador == '+')
            {
                txtResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);

            }
            else if (Operador == '-')
            {
                txtResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == 'X')
            {
                txtResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '/')
            {
                /*
                 Esto es para que no se pueda dividir entre 0 */
                if(txtResultado.Text != "0")
                {
                    txtResultado.Text = (Numero1 / Numero2).ToString();
                    Numero1 = Convert.ToDouble(txtResultado.Text);
                }
                else
                {
                    MessageBox.Show("SintaxError");
                }
            }


        }
        /*Botton Quitar un solo Caracter*/
        private void button10_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length- 1);

            }
            else
            {
                txtResultado.Text = "0";
            }
        }
        /*Botton Borrar todos lo carcateres*/
        private void buttonBorrartodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            txtResultado.Text = "0";

        }
        /*Botton Borrar solo la operación*/
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void buttonpunto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";           }
        }
        /*Botton cambio de signo*/
        private void buttonmorethanless_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Numero1 *= -1;
            txtResultado.Text = Numero1.ToString();
        }

        /*
        * Reutilizamos la misma función para no tener que llamar cada boton y que realizara una operación diferente,
        * Si no que esta función realizara la operación dependiendo del signo que se utilice 
        */

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                txtResultado.Text = Numero1.ToString();         
            }
            else if (Operador == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                txtResultado.Text = Numero1.ToString();
            }
            else 
            {
              
               txtResultado.Text = "0";
            }
 

        }

    }
}
