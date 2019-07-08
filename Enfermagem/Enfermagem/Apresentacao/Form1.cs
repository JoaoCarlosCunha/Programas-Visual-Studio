using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enfermagem
{
    public partial class frmPrimeiraEscolha : Form
    {
        public frmPrimeiraEscolha()
        {
            InitializeComponent();
        }
        private void FrmPrimeiraEscolha_Load(object sender, EventArgs e)
        {
            this.Hide();
            Apresentacao.frmFlash frm = new Apresentacao.frmFlash();
            frm.Show();
            frm.Update();
            System.Threading.Thread.Sleep(5100);
            frm.Close();
            this.Visible = true;
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Apresentacao.frmLoginAlumo fra = new Apresentacao.frmLoginAlumo();
            this.Hide();
            fra.ShowDialog();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Apresentacao.frmLoginADM frp = new Apresentacao.frmLoginADM();
            this.Hide();
            frp.ShowDialog();
        }

    }
}
