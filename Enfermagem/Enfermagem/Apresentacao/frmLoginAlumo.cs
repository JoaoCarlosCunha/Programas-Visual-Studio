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
    public partial class frmLoginAlumo : Form
    {
        public frmLoginAlumo()
        {
            InitializeComponent();
        }

        private void btnLogarAluno_Click(object sender, EventArgs e)
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
                string comando = "select count (*) from Aluno where Nome = '" + txbNomeAluno.Text + "'and Senha ='" + txbSenhaAluno.Text + "'";

                

                SqlCommand objConsultar = new SqlCommand(comando, conn);

                //verificador de cadastro, ele conta os registros de executescalar
                if ((int)objConsultar.ExecuteScalar() > 0)

                {

                    Modelo.Estatico.logado = (true);
                    frmEscolhas objMenu = new frmEscolhas();
                    Modelo.Estatico.num = "2";
                    Modelo.Conexao.Aluno = txbNomeAluno.Text;
                    this.Hide();
                    objMenu.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Usuario ou senha Incorreto !");
                    txbNomeAluno.Text = "";
                    txbSenhaAluno.Text = "";
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
                string comando = "select count (*) from Aluno where Nome = '" + txbNomeAluno.Text + "'and Senha ='" + txbSenhaAluno.Text + "'";



                SqlCommand objConsultar = new SqlCommand(comando, conn);

                //verificador de cadastro, ele conta os registros de executescalar
                if ((int)objConsultar.ExecuteScalar() > 0)

                {

                    Modelo.Estatico.logado = (true);
                    frmEscolhas objMenu = new frmEscolhas();
                    Modelo.Estatico.num = "2";
                    Modelo.Conexao.Aluno = txbNomeAluno.Text;
                    this.Hide();
                    objMenu.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Usuario ou senha Incorreto !");
                    txbNomeAluno.Text = "";
                    txbSenhaAluno.Text = "";
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
