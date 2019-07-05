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
    public partial class frmCadastrarFunc : Form
    {
        public frmCadastrarFunc()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            frmEscolha frm = new frmEscolha();
            this.Hide();
            frm.ShowDialog();
        }

        private void BtnCadastra_Click(object sender, EventArgs e)
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

                string inserir = "insert into USUARIO (Usuario, Senha) values ('" + txbNome.Text + "','" + txbSenha.Text + "' )";

                SqlCommand cmdInserir = new SqlCommand(inserir, conn);

                cmdInserir.ExecuteNonQuery();
                MessageBox.Show("Cadastrado com sucesso!");
                txbNome.Text = "";
                txbSenha.Text = "";
                {
                    Listar();
                }


                void Listar()
                {

                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = default(SqlDataAdapter);
                        try
                        {
                            Modelo.Conexao.obterConexao();
                            da = new SqlDataAdapter("SELECT * FROM USUARIO", Modelo.Conexao.connString);
                            da.Fill(dt);
                            dgvMostar.DataSource = dt;


                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Erro.");
                            Modelo.Conexao.FecharConexao();
                        }

                    }
                }
            }
        }

        private void TxbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblNome_Click(object sender, EventArgs e)
        {

        }

        private void LblSenha_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastrarFunc_Load(object sender, EventArgs e)
        {
            {
                Listar();
            }


            void Listar()
            {

                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = default(SqlDataAdapter);
                    try
                    {
                        Modelo.Conexao.obterConexao();
                        da = new SqlDataAdapter("SELECT * FROM USUARIO", Modelo.Conexao.connString);
                        da.Fill(dt);
                        dgvMostar.DataSource = dt;


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro.");
                        Modelo.Conexao.FecharConexao();
                    }

                }
            }
        }

        private void DgvMostar_DoubleClick(object sender, EventArgs e)
        {

            txbNome.Text = dgvMostar.CurrentRow.Cells[0].Value.ToString();
            txbSenha.Text = dgvMostar.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            if (txbNome.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        Modelo.Conexao.obterConexao();
                        cmd = new SqlCommand("sp_ExcluirUsuario", Modelo.Conexao.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nome", txbNome.Text);

                        cmd.Parameters.Add("@Mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                        cmd.ExecuteNonQuery();

                        string msg = cmd.Parameters["@Mensagem"].Value.ToString();
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

                        {
                            Listar();
                        }


                        void Listar()
                        {

                            {
                                DataTable dt = new DataTable();
                                SqlDataAdapter da = default(SqlDataAdapter);
                                try
                                {
                                    Modelo.Conexao.obterConexao();
                                    da = new SqlDataAdapter("SELECT * FROM USUARIO", Modelo.Conexao.connString);
                                    da.Fill(dt);
                                    dgvMostar.DataSource = dt;


                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Erro.");
                                    Modelo.Conexao.FecharConexao();
                                }

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir os dados " + ex.Message);
                        Modelo.Conexao.FecharConexao();
                    }
                }
            }
        }

        private void DgvMostar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
