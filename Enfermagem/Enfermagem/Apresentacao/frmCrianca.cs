﻿using System;
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
    public partial class frmCrianca : Form
    {
        public frmCrianca()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEscolhas frm = new frmEscolhas();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
