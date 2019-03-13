using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soma_2_numero.Modelo;

namespace Soma_2_numero
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbPrimeiroNumero.Text, txbSegundonumero.Text);
            if (controle.Mensagem.Equals(""))
            {
                lblResultado.Text = controle.Resultado;
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }
        }

        private void lblPrimeiroNumero_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSubitrair_Click(object sender, EventArgs e)
        {
            
        }
    }
}
