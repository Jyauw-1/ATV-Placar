using System;
using System.Windows.Forms;

namespace Exercicios_praticos_JoaoVitor
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCalculoVestibular_Click(object sender, EventArgs e)
        {
            FormVestibular formVestibular = new FormVestibular();
            formVestibular.ShowDialog();
        }

        private void btnPlacarJogo_Click(object sender, EventArgs e)
        {
            FormPlacar formPlacar = new FormPlacar();
            formPlacar.ShowDialog();
        }

        private void btnFinalizarSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}