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
    public partial class frmPCrianca : Form
    {
        public frmPCrianca()
        {
            InitializeComponent();
        }

        private void FrmPCrianca_Load(object sender, EventArgs e)
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
                    da = new SqlDataAdapter("SELECT * FROM mulher", Modelo.Conexao.connString);
                    da.Fill(dt);
                    dgvALUNO.DataSource = dt;

                }

                catch (Exception)
                {
                    MessageBox.Show("Erro.");
                    Modelo.Conexao.FecharConexao();
                }



            }
        }
    

        private void DgvALUNO_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txbDP_Nome.Text = dgvALUNO.CurrentRow.Cells[0].Value.ToString();
            txbCE_Data.Text = dgvALUNO.CurrentRow.Cells[1].Value.ToString();
            txbDP_DataN.Text = dgvALUNO.CurrentRow.Cells[3].Value.ToString();
            txbDP_Idade.Text = dgvALUNO.CurrentRow.Cells[4].Value.ToString();
            txbDP_EstadoC.Text = dgvALUNO.CurrentRow.Cells[5].Value.ToString();
            txbDP_Escolaridade.Text = dgvALUNO.CurrentRow.Cells[06].Value.ToString();
            txbDP_Filhos.Text = dgvALUNO.CurrentRow.Cells[7].Value.ToString();
            txbDP_Religiao.Text = dgvALUNO.CurrentRow.Cells[8].Value.ToString();
            txbDP_UnidadeB.Text = dgvALUNO.CurrentRow.Cells[9].Value.ToString();
            txbDP_Endereco.Text = dgvALUNO.CurrentRow.Cells[10].Value.ToString();
            txbDP_Telefone.Text = dgvALUNO.CurrentRow.Cells[11].Value.ToString();
            txbH_Tabagismo.Text = dgvALUNO.CurrentRow.Cells[12].Value.ToString();
            txbH_Tabagismo_Parou.Text = dgvALUNO.CurrentRow.Cells[13].Value.ToString();
            txbH_Etilismo.Text = dgvALUNO.CurrentRow.Cells[14].Value.ToString();
            txbH_Etilismo_Parou.Text = dgvALUNO.CurrentRow.Cells[15].Value.ToString();
            txbH_Diabetes.Text = dgvALUNO.CurrentRow.Cells[16].Value.ToString();
            txbH_Dislipidemias.Text = dgvALUNO.CurrentRow.Cells[17].Value.ToString();
            txbH_Cardiovascular.Text = dgvALUNO.CurrentRow.Cells[18].Value.ToString();
            txbH_Musculoesquelética.Text = dgvALUNO.CurrentRow.Cells[19].Value.ToString();
            txbH_Neurologica.Text = dgvALUNO.CurrentRow.Cells[20].Value.ToString();
            txbH_Respiratoria.Text = dgvALUNO.CurrentRow.Cells[21].Value.ToString();
            txbH_Renal.Text = dgvALUNO.CurrentRow.Cells[22].Value.ToString();
            txbH_Disfuncao.Text = dgvALUNO.CurrentRow.Cells[23].Value.ToString();
            txbH_Outros.Text = dgvALUNO.CurrentRow.Cells[24].Value.ToString();
            txbA_uligesta.Text = dgvALUNO.CurrentRow.Cells[25].Value.ToString();
            txbA_Gestacao.Text = dgvALUNO.CurrentRow.Cells[26].Value.ToString();
            txbA_PN.Text = dgvALUNO.CurrentRow.Cells[27].Value.ToString();
            txbA_PC.Text = dgvALUNO.CurrentRow.Cells[28].Value.ToString();
            txbA_Forceps.Text = dgvALUNO.CurrentRow.Cells[29].Value.ToString();
            txbA_Aborto.Text = dgvALUNO.CurrentRow.Cells[30].Value.ToString();
            txbA_Leucorreia_Coloracao.Text = dgvALUNO.CurrentRow.Cells[31].Value.ToString();
            txbA_Odor.Text = dgvALUNO.CurrentRow.Cells[32].Value.ToString();
            txbA_IST.Text = dgvALUNO.CurrentRow.Cells[33].Value.ToString();
            txbA_pap.Text = dgvALUNO.CurrentRow.Cells[34].Value.ToString();
            txbA_DUM.Text = dgvALUNO.CurrentRow.Cells[35].Value.ToString();
            txbA_Menopausa.Text = dgvALUNO.CurrentRow.Cells[36].Value.ToString();
            txbF_Diabetes.Text = dgvALUNO.CurrentRow.Cells[37].Value.ToString();
            txbF_Dislipdemias.Text = dgvALUNO.CurrentRow.Cells[38].Value.ToString();
            txbF_Cardiovascular.Text = dgvALUNO.CurrentRow.Cells[39].Value.ToString();
            txbF_Remal.Text = dgvALUNO.CurrentRow.Cells[40].Value.ToString();
            txbF_Neurologicas.Text = dgvALUNO.CurrentRow.Cells[41].Value.ToString();
            txbC_Frutas.Text = dgvALUNO.CurrentRow.Cells[42].Value.ToString();
            txbC_VexzesD_Frutas.Text = dgvALUNO.CurrentRow.Cells[43].Value.ToString();
            txbC_leite.Text = dgvALUNO.CurrentRow.Cells[40].Value.ToString();
            txbC_VezesD_Leite.Text = dgvALUNO.CurrentRow.Cells[45].Value.ToString();
            txbC_Legumes.Text = dgvALUNO.CurrentRow.Cells[46].Value.ToString();
            txbC_VezesD_Legumes.Text = dgvALUNO.CurrentRow.Cells[47].Value.ToString();
            txbC_Proteina.Text = dgvALUNO.CurrentRow.Cells[48].Value.ToString();
            txbC_VezesD_Proteina.Text = dgvALUNO.CurrentRow.Cells[49].Value.ToString();
            txbC_Massas.Text = dgvALUNO.CurrentRow.Cells[50].Value.ToString();
            txbC_VezesD_Massas.Text = dgvALUNO.CurrentRow.Cells[51].Value.ToString();
            txbC_Liquidos.Text = dgvALUNO.CurrentRow.Cells[52].Value.ToString();
            txbC_LitroD.Text = dgvALUNO.CurrentRow.Cells[53].Value.ToString();
            txbAF_Fisica.Text = dgvALUNO.CurrentRow.Cells[54].Value.ToString();
            txbAF_Qual.Text = dgvALUNO.CurrentRow.Cells[55].Value.ToString();
            txbAF_Vezes.Text = dgvALUNO.CurrentRow.Cells[56].Value.ToString();
            txbAF_Sexual.Text = dgvALUNO.CurrentRow.Cells[57].Value.ToString();
            txbAF_Preservativo.Text = dgvALUNO.CurrentRow.Cells[58].Value.ToString();
            txbS_Dorme.Text = dgvALUNO.CurrentRow.Cells[59].Value.ToString();
            txbS_Remdeio_Sono.Text = dgvALUNO.CurrentRow.Cells[60].Value.ToString();
            txbS_Qual.Text = dgvALUNO.CurrentRow.Cells[61].Value.ToString();
            txbUR_Medicamentos.Text = dgvALUNO.CurrentRow.Cells[62].Value.ToString();
            txbUR_Profissional.Text = dgvALUNO.CurrentRow.Cells[63].Value.ToString();
            txbUR_Frequencia.Text = dgvALUNO.CurrentRow.Cells[64].Value.ToString();
            txbSP_data.Text = dgvALUNO.CurrentRow.Cells[65].Value.ToString();
            txbUR_Tempo.Text = dgvALUNO.CurrentRow.Cells[66].Value.ToString();
            txbSP_Motivo.Text = dgvALUNO.CurrentRow.Cells[67].Value.ToString();
            txbDA_PA.Text = dgvALUNO.CurrentRow.Cells[68].Value.ToString();
            txbDA_FC.Text = dgvALUNO.CurrentRow.Cells[69].Value.ToString();
            txbDA_FR.Text = dgvALUNO.CurrentRow.Cells[70].Value.ToString();
            txbDA_FR.Text = dgvALUNO.CurrentRow.Cells[71].Value.ToString();
            txbDA_T.Text = dgvALUNO.CurrentRow.Cells[72].Value.ToString();
            txbDA_DOR.Text = dgvALUNO.CurrentRow.Cells[73].Value.ToString();
            txbDA_Peso.Text = dgvALUNO.CurrentRow.Cells[74].Value.ToString();
            txbDA_Estatura.Text = dgvALUNO.CurrentRow.Cells[75].Value.ToString();
            txbDA_IMC.Text = dgvALUNO.CurrentRow.Cells[76].Value.ToString();
            txbDA_Glicemia.Text = dgvALUNO.CurrentRow.Cells[77].Value.ToString();
            txbCB_Limpo.Text = dgvALUNO.CurrentRow.Cells[78].Value.ToString();
            txbCB_C_Sujidade.Text = dgvALUNO.CurrentRow.Cells[79].Value.ToString();
            txbCB_Integro.Text = dgvALUNO.CurrentRow.Cells[80].Value.ToString();
            txbCB_C_Lesao.Text = dgvALUNO.CurrentRow.Cells[81].Value.ToString();
            txbCB_Pediculose.Text = dgvALUNO.CurrentRow.Cells[82].Value.ToString();
            txbCB_Alopecia.Text = dgvALUNO.CurrentRow.Cells[83].Value.ToString();
            txbCB_Seborreia.Text = dgvALUNO.CurrentRow.Cells[84].Value.ToString();
            txbOS_Oculos.Text = dgvALUNO.CurrentRow.Cells[85].Value.ToString();
            txbOS_P_Secrecao.Text = dgvALUNO.CurrentRow.Cells[86].Value.ToString();
            txbOS_Aspecto.Text = dgvALUNO.CurrentRow.Cells[87].Value.ToString();
            txbOS_Pupilas.Text = dgvALUNO.CurrentRow.Cells[88].Value.ToString();
            txbOV_Limpo.Text = dgvALUNO.CurrentRow.Cells[89].Value.ToString();
            C_Sujidade.Text = dgvALUNO.CurrentRow.Cells[90].Value.ToString();
            txbOV_A_Auditivo.Text = dgvALUNO.CurrentRow.Cells[91].Value.ToString();
            txbOV_P_Auditiva.Text = dgvALUNO.CurrentRow.Cells[92].Value.ToString();
            txbOV_N_Perda.Text = dgvALUNO.CurrentRow.Cells[93].Value.ToString();
            txbbc_Corada.Text = dgvALUNO.CurrentRow.Cells[94].Value.ToString();
            txbbc_Descorada.Text = dgvALUNO.CurrentRow.Cells[95].Value.ToString();
            txbbc_Integra.Text = dgvALUNO.CurrentRow.Cells[96].Value.ToString();
            txbbc_Lesao.Text = dgvALUNO.CurrentRow.Cells[97].Value.ToString();
            txbbc_D_Completa.Text = dgvALUNO.CurrentRow.Cells[98].Value.ToString();
            txbbc_Incompleta.Text = dgvALUNO.CurrentRow.Cells[99].Value.ToString();
            txbbc_P_Dentaria.Text = dgvALUNO.CurrentRow.Cells[100].Value.ToString();
            d.Text = dgvALUNO.CurrentRow.Cells[101].Value.ToString();
            txbbc_Inferior.Text = dgvALUNO.CurrentRow.Cells[102].Value.ToString();
            txbPC__P_Integra.Text = dgvALUNO.CurrentRow.Cells[103].Value.ToString();
            txbPC_C_Lesao.Text = dgvALUNO.CurrentRow.Cells[104].Value.ToString();
            txbPC_Palpacap.Text = dgvALUNO.CurrentRow.Cells[105].Value.ToString();
            txbPC_R_Gangglionar.Text = dgvALUNO.CurrentRow.Cells[106].Value.ToString();
            txbPC_Trraqueia.Text = dgvALUNO.CurrentRow.Cells[107].Value.ToString();
            txbPC_Mobilidade.Text = dgvALUNO.CurrentRow.Cells[108].Value.ToString();
            txbPC_Tireoide.Text = dgvALUNO.CurrentRow.Cells[109].Value.ToString();
            txbPC_Nodulo.Text = dgvALUNO.CurrentRow.Cells[110].Value.ToString();
            txbMM_P_Integra.Text = dgvALUNO.CurrentRow.Cells[111].Value.ToString();
            txbMM_Simetricas.Text = dgvALUNO.CurrentRow.Cells[112].Value.ToString();
            txbMM_Assimetricas.Text = dgvALUNO.CurrentRow.Cells[113].Value.ToString();
            txbMM_C_Lesao.Text = dgvALUNO.CurrentRow.Cells[114].Value.ToString();
            txbMM_Mamilos.Text = dgvALUNO.CurrentRow.Cells[115].Value.ToString();
            txbMM_N_Palpavel.Text = dgvALUNO.CurrentRow.Cells[116].Value.ToString();
            txbMM_E_Papila.Text = dgvALUNO.CurrentRow.Cells[117].Value.ToString();
            txbMM_A_Materno.Text = dgvALUNO.CurrentRow.Cells[118].Value.ToString();
            txbTX_E_Bilateral.Text = dgvALUNO.CurrentRow.Cells[119].Value.ToString();
            txbTX_Simetrico.Text = dgvALUNO.CurrentRow.Cells[120].Value.ToString();
            txbTX_Assimetrico.Text = dgvALUNO.CurrentRow.Cells[121].Value.ToString();
            txbTX_Integro.Text = dgvALUNO.CurrentRow.Cells[122].Value.ToString();
            txbTX_C_Lesao.Text = dgvALUNO.CurrentRow.Cells[123].Value.ToString();
            txbTX_Sopro.Text = dgvALUNO.CurrentRow.Cells[124].Value.ToString();
            txbAM_Integra.Text = dgvALUNO.CurrentRow.Cells[125].Value.ToString();
            txbAM_C_Lesao.Text = dgvALUNO.CurrentRow.Cells[126].Value.ToString();
            txbAM_Timpanico.Text = dgvALUNO.CurrentRow.Cells[127].Value.ToString();
            txbAM_Macico.Text = dgvALUNO.CurrentRow.Cells[128].Value.ToString();
            txbAM_Plano.Text = dgvALUNO.CurrentRow.Cells[129].Value.ToString();
            txbAM_Globoso.Text = dgvALUNO.CurrentRow.Cells[130].Value.ToString();
            txbAM_Flacido.Text = dgvALUNO.CurrentRow.Cells[131].Value.ToString();
            txbAM_Distendido.Text = dgvALUNO.CurrentRow.Cells[132].Value.ToString();
            txbAM_Rigido.Text = dgvALUNO.CurrentRow.Cells[133].Value.ToString();
            txbD_Enfermagem.Text = dgvALUNO.CurrentRow.Cells[134].Value.ToString();
            txbD_Prescricao.Text = dgvALUNO.CurrentRow.Cells[135].Value.ToString();
            txbEvolucao.Text = dgvALUNO.CurrentRow.Cells[136].Value.ToString();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEscolhas frm = new frmEscolhas();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
