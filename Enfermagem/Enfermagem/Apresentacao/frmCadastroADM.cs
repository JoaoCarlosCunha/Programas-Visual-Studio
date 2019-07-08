using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enfermagem.Apresentacao
{
    public partial class frmCadastroADM : Form
    {


        public frmCadastroADM()
        {
            InitializeComponent();
        }
        private void frmCadastroADM_Load(object sender, EventArgs e)
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
                        da = new SqlDataAdapter("SELECT * FROM adm", Modelo.Conexao.connString);
                        da.Fill(dt);
                        dgvADM.DataSource = dt;

                    }
                    
                    catch (Exception)
                    {
                    MessageBox.Show("Erro.");
                    Modelo.Conexao.FecharConexao();
                    }



                }
            }


        }
     private void DgvADM_DoubleClick(object sender, EventArgs e)
        {
            txbNome.Text = dgvADM.CurrentRow.Cells[0].Value.ToString();
            txbSenha.Text = dgvADM.CurrentRow.Cells[1].Value.ToString();
        }
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
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

                string inserir = "insert into adm (Nome, Senha) values ('" + txbNome.Text + "','" + txbSenha.Text + "' )";

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
                            da = new SqlDataAdapter("SELECT * FROM adm", Modelo.Conexao.connString);
                            da.Fill(dt);
                            dgvADM.DataSource = dt;

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

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
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
                        cmd = new SqlCommand("sp_ExcluirValor", Modelo.Conexao.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nome", txbSenha.Text);

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
                                    da = new SqlDataAdapter("SELECT * FROM adm", Modelo.Conexao.connString);
                                    da.Fill(dt);
                                    dgvADM.DataSource = dt;

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
                    txbNome.Text = "";
                    txbSenha.Text = "";


                }
            }
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmEscolhas frm = new frmEscolhas();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
     
