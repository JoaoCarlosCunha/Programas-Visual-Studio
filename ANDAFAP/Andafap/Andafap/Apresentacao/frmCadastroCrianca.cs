using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andafap.Apresentacao
{
    public partial class frmCadastroCrianca : Form
    {
        public frmCadastroCrianca()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            frmEscolha frm = new frmEscolha();
            this.Hide();
            frm.ShowDialog();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text == ("") || txbIdade.Text == ("") || txbNascimento.Text == ("") || txbEndereco.Text == ("") || txbTelefone.Text == ("") || txbResponsavel.Text == ("")||txbEESCOLARIDADE.Text == ("")||txbRGMAE.Text == (""))
            {
                MessageBox.Show("Alguma campos não foi corretamente Preenchido.");
            }
            else
            { 
                           
                // vamos obter a conexão com o banco de dados
                SqlConnection conn = Modelo.Conexao.obterConexao();

                // a conexão foi efetuada com sucesso?
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
                }
                else
                {

                    string inserir = "insert into CRIANCA (Nome, Telefone, idade, nascimento, endereco, responsavel, RGMae, Escolaridades) values ('" + txbNome.Text + "','" + txbTelefone.Text + "','" + txbIdade.Text + "','" + txbNascimento.Text + "' ,'" + txbEndereco.Text + "','" + txbResponsavel.Text + "','" + txbRGMAE.Text + "','" + txbEESCOLARIDADE.Text + "')";
                    SqlCommand cmdInserir = new SqlCommand(inserir, conn);

                    cmdInserir.ExecuteNonQuery();
                    MessageBox.Show("Cadastrado com sucesso!");
                    txbNome.Text = "";
                    txbTelefone.Text = "";
                    txbIdade.Text = "";
                    txbNascimento.Text = "";
                    txbEndereco.Text = "";
                    txbResponsavel.Text = "";
                    txbEESCOLARIDADE.Text = "";
                    txbRGMAE.Text = "";
                }
            }
        }
    }
}
