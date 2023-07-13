namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            lblResultado.Text = "Resultado: ";
            txtValor1.Focus();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            float valor1, valor2, resultado;
            try
            {
                valor1 = Convert.ToSingle(txtValor1.Text);
                try
                {
                    valor2 = Convert.ToSingle(txtValor2.Text);
                    resultado = valor1 + valor2;
                    lblResultado.Text = "Resultado: " + resultado;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Valor 2 inválido", "Valor 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValor2.SelectAll();
                    txtValor2.Focus();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Valor 1 inválido", "Valor 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor1.SelectAll();
                txtValor1.Focus();
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            float valor1, valor2, resultado;
            try
            {
                valor1 = Convert.ToSingle(txtValor1.Text);
                try
                {
                    valor2 = Convert.ToSingle(txtValor2.Text);
                    resultado = valor1 - valor2;
                    lblResultado.Text = "Resultado: " + resultado;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Valor 2 inválido", "Valor 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValor2.SelectAll();
                    txtValor2.Focus();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Valor 1 inválido", "Valor 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor1.SelectAll();
                txtValor1.Focus();
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            float valor1, valor2, resultado;
            try
            {
                valor1 = Convert.ToSingle(txtValor1.Text);
                try
                {
                    valor2 = Convert.ToSingle(txtValor2.Text);
                    resultado = valor1 * valor2;
                    lblResultado.Text = "Resultado: " + resultado;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Valor 2 inválido", "Valor 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValor2.SelectAll();
                    txtValor2.Focus();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Valor 1 inválido", "Valor 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor1.SelectAll();
                txtValor1.Focus();
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            float valor1, valor2, resultado;
            try
            {
                valor1 = Convert.ToSingle(txtValor1.Text);
                try
                {
                    valor2 = Convert.ToSingle(txtValor2.Text);
                    resultado = valor1 / valor2;
                    lblResultado.Text = "Resultado: " + resultado;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Valor 2 inválido", "Valor 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValor2.SelectAll();
                    txtValor2.Focus();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Valor 1 inválido", "Valor 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor1.SelectAll();
                txtValor1.Focus();
            }
        }
    }
}