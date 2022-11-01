using Cadenas;
namespace winAppCadena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string cadena1, cadena2;

        private void txtCadena2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtCadena2.Text != "")
                {
                    cadena2 = txtCadena2.Text;
                    cadenas objcadenas = new cadenas(cadena1, cadena2);
                    lblConcatenada.Text = objcadenas.getConcatenada();
                    lblLongitud.Text = objcadenas.getLongitud().ToString();
                    lblPalindromo.Text = objcadenas.verificarPalindromo();
                }
                else
                    MessageBox.Show("Ingrese una cadena");
            }
        }

        private void txtCadena1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtCadena1.Text != "")
                {
                    cadena1 = txtCadena1.Text;
                    txtCadena2.Focus();
                }
                else
                    MessageBox.Show("Ingrese una cadena");
            }
        }
    }
}