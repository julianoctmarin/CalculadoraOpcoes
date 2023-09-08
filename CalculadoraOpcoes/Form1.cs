namespace CalculadoraOpcoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            txtX.Clear();
            txtY.Clear();
            txtTotal.ReadOnly = true;
            txtX.Focus();
            rdbSomar.Checked = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x, y, total;


            if (!double.TryParse(txtX.Text, out x))
            {
                MessageBox.Show("Informe um valor válido no X", "Calculadora", MessageBoxButtons.OK);
                txtX.Clear();
                txtX.Focus();
                return;
            }
            if (!double.TryParse(txtY.Text, out y))
            {
                MessageBox.Show("Informe um valor válido no Y", "Calculadora", MessageBoxButtons.OK);
                txtY.Clear();
                txtY.Focus();
                return;
            }

            if (rdbSomar.Checked)
            {
                total = x + y;
                lstHistorico.Items.Add($"Operação: {x} + {y} = {total}");
            }
            else if (rdbSubtrair.Checked)
            {
                total = x - y;
                lstHistorico.Items.Add($"Operação: {x} - {y} = {total}");
            }
            else if (rdbMultiplicar.Checked)
            {
                total = x * y;
                lstHistorico.Items.Add($"Operação: {x} * {y} = {total}");
            }
            else
            {
                if (y == 0)
                {
                    txtTotal.Text = "Divisão por 0";
                    return;
                }
                total = x / y;
                lstHistorico.Items.Add($"Operação: {x} / {y} = {total}");
            }
            txtTotal.Text = total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}