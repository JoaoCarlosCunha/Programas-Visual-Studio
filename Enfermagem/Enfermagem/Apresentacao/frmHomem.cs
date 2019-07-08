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
    public partial class frmHomem : Form
    {
        public frmHomem()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEscolhas frm = new frmEscolhas();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
