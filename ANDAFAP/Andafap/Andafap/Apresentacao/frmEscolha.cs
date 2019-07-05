using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andafap.Apresentacao
{
    public partial class frmEscolha : Form
    {
        public frmEscolha()
        {
            InitializeComponent();
        }

        private void MnsFormularios_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TrocarDeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();


        }

        private void FuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarFunc frm = new frmCadastrarFunc();
            this.Hide();
            frm.ShowDialog();
        }

        private void CriançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCrianca frm = new frmCadastroCrianca();
            this.Hide();
            frm.ShowDialog();
        }

        private void PesquisarCriançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmoqfazer frm = new frmoqfazer();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
