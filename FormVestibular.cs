using System;
using System.Windows.Forms;

namespace Exercicios_praticos_JoaoVitor
{
    public partial class FormVestibular : Form
    {
        public FormVestibular()
        {
            InitializeComponent();
        }

        // Método vazio adicionado para resolver o evento pendente no Designer
        private void txtArrecadacao_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtArrecadacao.Text, out double arrecadacao))
            {
                MessageBox.Show("Informe um valor numérico válido para a arrecadação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtArrecadacao.Focus();
                return;
            }

            if (!int.TryParse(txtFiscais.Text, out int fiscais))
            {
                MessageBox.Show("Informe uma quantidade válida de fiscais.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFiscais.Focus();
                return;
            }

            if (!double.TryParse(txtAlimentacao.Text, out double alimentacao))
            {
                MessageBox.Show("Informe um valor numérico válido para a alimentação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAlimentacao.Focus();
                return;
            }

            Vestibular v = new Vestibular();
            v.Arrecadacao = arrecadacao;
            v.QuantidadeFiscais = fiscais;
            v.ValorAlimentacao = alimentacao;

            double lucro = v.CalcularLucro();
            MessageBox.Show("O valor do lucro é: R$ " + lucro.ToString("N2"), "Lucro do Vestibular", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtArrecadacao.Clear();
            txtFiscais.Clear();
            txtAlimentacao.Clear();
            txtArrecadacao.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}