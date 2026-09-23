using System;
using System.Windows.Forms;

namespace Exercicios_praticos_JoaoVitor
{
    public partial class FormPlacar : Form
    {
        private Placar placar = new Placar();

        public FormPlacar()
        {
            InitializeComponent();
        }

        private void ProcessarLinha(TextBox txtGols1, TextBox txtGols2, string time1, string time2, Label lblResultado)
        {
            if (int.TryParse(txtGols1.Text, out int g1) && int.TryParse(txtGols2.Text, out int g2))
            {
                lblResultado.Text = placar.Verificar(g1, g2, time1, time2);
            }
            else
            {
                lblResultado.Text = "";
            }
        }

        public void Lease()
        {
            ProcessarLinha(txtGols1_1, txtGols1_2, "São Paulo", "Grêmio", lblResultado1);
            ProcessarLinha(txtGols2_1, txtGols2_2, "Corinthians", "Bahia", lblResultado2);
            ProcessarLinha(txtGols3_1, txtGols3_2, "Palmeiras", "Sport", lblResultado3);
            ProcessarLinha(txtGols4_1, txtGols4_2, "Santos", "Flamengo", lblResultado4);
            ProcessarLinha(txtGols5_1, txtGols5_2, "Ponte Preta", "Botafogo", lblResultado5);
        }

        private void txtGols_TextChanged(object sender, EventArgs e)
        {
            Lease();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtGols1_1.Clear(); txtGols1_2.Clear(); lblResultado1.Text = "";
            txtGols2_1.Clear(); txtGols2_2.Clear(); lblResultado2.Text = "";
            txtGols3_1.Clear(); txtGols3_2.Clear(); lblResultado3.Text = "";
            txtGols4_1.Clear(); txtGols4_2.Clear(); lblResultado4.Text = "";
            txtGols5_1.Clear(); txtGols5_2.Clear(); lblResultado5.Text = "";
            txtGols1_1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}