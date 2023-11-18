namespace Informatica_EJN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDescuento.Enabled = false;
            txtValorCD.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valorC  = int.Parse(txtValorC.Text);

            double descuento = 0;
            double valorCD = 0;
            if (valorC > 100)
            {
                descuento = valorC * 0.05;
            }
            else if (valorC >= 150)
            {
                descuento = valorC * 0.1;
            }
            else if(valorC >= 200)
            {
                descuento = valorC * 0.15;
            }

            valorCD = valorC - descuento;

            txtDescuento.Text = descuento.ToString();
            txtValorCD.Text = valorCD.ToString();
        }
    }
}