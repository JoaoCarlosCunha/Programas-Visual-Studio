using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enfermagem.Apresentacao
{
    public partial class frmEscolhas : Form
    {
        public frmEscolhas()
        {
            InitializeComponent();
        }

        private void FrmEscolhas_Load(object sender, EventArgs e)
        {
            lblNome.Text = Modelo.Conexao.Aluno;
        }

        private void ADMProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modelo.Estatico.num != "1")
            {
                MessageBox.Show("Você não tem permisão");

            }
            else
            {
                Apresentacao.frmCadastroADM frm = new Apresentacao.frmCadastroADM();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void AlunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modelo.Estatico.num != "1")
            {
                MessageBox.Show("Você não tem permisão");

            }
            else
            {
                Apresentacao.frmCadastrarUsuario frm = new Apresentacao.frmCadastrarUsuario();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void MulherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMulher frm = new frmMulher();
            this.Hide();
            frm.ShowDialog();
        }

        private void AlterarLoginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrimeiraEscolha frm = new frmPrimeiraEscolha();
            this.Hide();
            frm.ShowDialog();
        }

        private void GestanteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGestante frm = new frmGestante();
            this.Hide();
            frm.ShowDialog();
        }

        private void HomemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHomem frm = new frmHomem();
            this.Hide();
            frm.ShowDialog();
        }

        private void IdosoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIdoso frm = new frmIdoso();
            this.Hide();
            frm.ShowDialog();
        }

        private void CriançaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCrianca frm = new frmCrianca();
            this.Hide();
            frm.ShowDialog();
        }

        private void HomemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPHomem frm = new frmPHomem();
            this.Hide();
            frm.ShowDialog();
        }

        private void MulherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPMulher frm = new frmPMulher();
            this.Hide();
            frm.ShowDialog();
        }

        private void GestanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPGestante frm = new frmPGestante();
            this.Hide();
            frm.ShowDialog();
        }

        private void CriançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPCrianca frm = new frmPCrianca();
            this.Hide();
            frm.ShowDialog();
        }

        private void IdosoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPIdoso frm = new frmPIdoso();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
