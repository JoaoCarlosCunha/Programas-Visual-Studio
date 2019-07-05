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
using Andafap.Apresentacao;

namespace Andafap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
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
                string comando = "select count (*) from USUARIO where Usuario = '" + txbNome.Text + "'and Senha ='" + txbSenha.Text + "'";

                SqlCommand objConsultar = new SqlCommand(comando, conn);

                //verificador de cadastro, ele conta os registros de executescalar
                if ((int)objConsultar.ExecuteScalar() > 0)

                {

                    Modelo.Estatico.logado = (true);
                    frmEscolha objMenu = new frmEscolha();
                    Modelo.Estatico.num = "2";
                    this.Hide();
                    objMenu.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Usuario ou senha Incorreto !");
                    txbNome.Text = "";
                    txbSenha.Text = "";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmFlash frm = new frmFlash();
            frm.Show();
            frm.Update();
            System.Threading.Thread.Sleep(5100);
            frm.Close();
            this.Visible = true;
        }
    }
   
}
