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

namespace Enfermagem.Apresentacao
{
    public partial class frmLoginADM : Form
    {
        public frmLoginADM()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
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
                string comando = "select count (*) from adm where Nome = '" + txbNome.Text + "'and Senha ='" + txbSenha.Text + "'";

                SqlCommand objConsultar = new SqlCommand(comando, conn);


                

                //verificador de cadastro, ele conta os registros de executescalar
                if ((int)objConsultar.ExecuteScalar() > 0)

                {
                    Modelo.Estatico.logado = (true);
                    Apresentacao.frmEscolhas objMenu = new Apresentacao.frmEscolhas();
                    this.Hide();
                    Modelo.Estatico.num = "1";
                    Modelo.Conexao.Aluno = txbNome.Text;
                    objMenu.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Nome ou senha Incorreto !");
                    txbNome.Text = "";
                    txbSenha.Text = "";
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmPrimeiraEscolha frp = new frmPrimeiraEscolha();
            this.Hide();
            frp.ShowDialog();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
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
                string comando = "select count (*) from adm where Nome = '" + txbNome.Text + "'and Senha ='" + txbSenha.Text + "'";

                SqlCommand objConsultar = new SqlCommand(comando, conn);




                //verificador de cadastro, ele conta os registros de executescalar
                if ((int)objConsultar.ExecuteScalar() > 0)

                {
                    Modelo.Estatico.logado = (true);
                    Apresentacao.frmEscolhas objMenu = new Apresentacao.frmEscolhas();
                    this.Hide();
                    Modelo.Estatico.num = "1";
                    Modelo.Conexao.Aluno = txbNome.Text;
                    objMenu.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Nome ou senha Incorreto !");
                    txbNome.Text = "";
                    txbSenha.Text = "";
                }
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrimeiraEscolha frp = new frmPrimeiraEscolha();
            this.Hide();
            frp.ShowDialog();
        }
    }
}
