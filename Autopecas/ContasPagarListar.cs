using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Autopecas
{
    public partial class ContasPagarListar : Form
    {
        ContasPagar instanciaPagar;
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public ContasPagarListar(ContasPagar pagar)
        {
            InitializeComponent();
            dataGridView_contasPagar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            instanciaPagar = pagar;
        }

        private void label_listaFornecedores_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_filtro_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox_listaProdutos_Enter(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_buscaFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_listarTodos_Click_1(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM CONTASPAGAR";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_contasPagar.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;

            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView_contasPagar.SelectedRows.Count != 0)
            {
                DataGridViewRow dr = dataGridView_contasPagar.SelectedRows[0];
                //Envia os Dados para Contas a Receber

                instanciaPagar.idContaPagar = Convert.ToInt32(dr.Cells[0].Value.ToString());
                instanciaPagar.txtFornecedor.Text = dr.Cells[1].Value.ToString();
                instanciaPagar.txtDataOperacao.Text = dr.Cells[2].Value.ToString();
                instanciaPagar.txtDataVencimento.Text = dr.Cells[3].Value.ToString();
                instanciaPagar.txtNatureza.Text = dr.Cells[4].Value.ToString();
                instanciaPagar.txtValor.Text = dr.Cells[4].Value.ToString();
                Close();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
