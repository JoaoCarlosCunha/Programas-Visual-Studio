using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Andafap.Apresentacao
{
    public partial class frmoqfazer : Form
    {
        public frmoqfazer()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            frmEscolha frm = new frmEscolha();
            this.Hide();
            frm.ShowDialog();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
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
                        da = new SqlDataAdapter("SELECT * FROM CRIANCA", Modelo.Conexao.connString);
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

        private void DgvMostar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frmoqfazer_Load(object sender, EventArgs e)
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
                        da = new SqlDataAdapter("SELECT * FROM CRIANCA", Modelo.Conexao.connString);
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

        private void DgvMostar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txbNome.Text = dgvMostar.CurrentRow.Cells[0].Value.ToString();
            txbTelefone.Text = dgvMostar.CurrentRow.Cells[1].Value.ToString();
            txbIdade.Text = dgvMostar.CurrentRow.Cells[2].Value.ToString();
            txbNascimento.Text = dgvMostar.CurrentRow.Cells[3].Value.ToString();
            txbEndereco.Text = dgvMostar.CurrentRow.Cells[4].Value.ToString();
            txbResponsavel.Text = dgvMostar.CurrentRow.Cells[5].Value.ToString();
            txbRGMAE.Text = dgvMostar.CurrentRow.Cells[6].Value.ToString();
            txbEESCOLARIDADE.Text = dgvMostar.CurrentRow.Cells[7].Value.ToString();
            txbAtividade.Text = dgvMostar.CurrentRow.Cells[8].Value.ToString();
            
            if (txbAtividade.Text == "") 
            {
                txbAtividade.Text = "";
            }

 
        }

        private void Frmoqfazer_Click(object sender, EventArgs e)
        {
            


        }


        private void BtnAtividade_Click(object sender, EventArgs e)
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
                                    da = new SqlDataAdapter("SELECT * FROM CRIANCA", Modelo.Conexao.connString);
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

        private void TxbAtividade_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
            txbTelefone.Text = "";
            txbIdade.Text = "";
            txbNascimento.Text = "";
            txbEndereco.Text = "";
            txbResponsavel.Text = "";
            txbEESCOLARIDADE.Text = "";
            txbRGMAE.Text = "";
            txbAtividade.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            if (txbNome.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja Colocar uma nova Atividade?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        Modelo.Conexao.obterConexao();
                        cmd = new SqlCommand("sp_ExcluirValor", Modelo.Conexao.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nome", txbNome.Text);

                        cmd.Parameters.Add("@Mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                        cmd.ExecuteNonQuery();

                        string msg = cmd.Parameters["@Mensagem"].Value.ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir os dados " + ex.Message);
                        Modelo.Conexao.FecharConexao();
                    }
                }
                if (txbNome.Text == ("") || txbIdade.Text == ("") || txbNascimento.Text == ("") || txbEndereco.Text == ("") || txbTelefone.Text == ("") || txbResponsavel.Text == ("") || txbEESCOLARIDADE.Text == ("") || txbRGMAE.Text == (""))
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

                        string inserir = "insert into CRIANCA (Nome, Telefone, idade, nascimento, endereco, responsavel, RGMae, Escolaridades, Atividades) values ('" + txbNome.Text + "','" + txbTelefone.Text + "','" + txbIdade.Text + "','" + txbNascimento.Text + "' ,'" + txbEndereco.Text + "','" + txbResponsavel.Text + "','" + txbRGMAE.Text + "','" + txbEESCOLARIDADE.Text + "','"+txbAtividade.Text+"')";
                        SqlCommand cmdInserir = new SqlCommand(inserir, conn);

                        cmdInserir.ExecuteNonQuery();
                        txbNome.Text = "";
                        txbTelefone.Text = "";
                        txbIdade.Text = "";
                        txbNascimento.Text = "";
                        txbEndereco.Text = "";
                        txbResponsavel.Text = "";
                        txbEESCOLARIDADE.Text = "";
                        txbRGMAE.Text = "";
                        txbAtividade.Text = "";
                        

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
                                    da = new SqlDataAdapter("SELECT * FROM CRIANCA", Modelo.Conexao.connString);
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
            }
        }
    }
}
