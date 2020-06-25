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
    public partial class CadastroFornecedorListar : Form
    {
        CadastroEstoque instanciaEstoque;
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public CadastroFornecedorListar(CadastroEstoque fornecedores)
        {
            InitializeComponent();
            dataGridView_buscaFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            instanciaEstoque = fornecedores;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_listarTodos_Click(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void atualizaTituloGrid()
        {
            dataGridView_buscaFornecedor.Columns[0].HeaderText = "ID";
            dataGridView_buscaFornecedor.Columns[1].HeaderText = "Nome";
            dataGridView_buscaFornecedor.Columns[2].HeaderText = "Razão Social";
            dataGridView_buscaFornecedor.Columns[3].HeaderText = "CNPJ";
            dataGridView_buscaFornecedor.Columns[4].HeaderText = "IE";
            dataGridView_buscaFornecedor.Columns[5].HeaderText = "CEP";
            dataGridView_buscaFornecedor.Columns[6].HeaderText = "Estado";
            dataGridView_buscaFornecedor.Columns[7].HeaderText = "Cidade";
            dataGridView_buscaFornecedor.Columns[8].HeaderText = "Rua";
            dataGridView_buscaFornecedor.Columns[9].HeaderText = "Número";
            dataGridView_buscaFornecedor.Columns[10].HeaderText = "Bairro";
            dataGridView_buscaFornecedor.Columns[11].HeaderText = "E-mail";
            dataGridView_buscaFornecedor.Columns[12].HeaderText = "Celular";
            dataGridView_buscaFornecedor.Columns[13].HeaderText = "Telefone";
        }

        private void carregaGrid()
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM fornecedores";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_buscaFornecedor.DataSource = dt;
                atualizaTituloGrid();
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

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView_buscaFornecedor.SelectedRows[0];
            instanciaEstoque.txtFornecedor.Text= dr.Cells[1].Value.ToString();
            Close();
        }

        public void procurarItem(string valorBusca)
        {
            conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");

            if (String.IsNullOrEmpty(valorBusca) == false)
            {

                if (radioButton_filtroNome.Checked)
                {
                    strSQL = "SELECT * FROM FORNECEDORES WHERE nome like '%" + valorBusca + "%'";
                }

                else if (radioButton_filtroDoc.Checked)
                {
                    strSQL = "SELECT * FROM FORNECEDORES WHERE cnpj like '%" + valorBusca + "%'";
                }

                else
                {
                    MessageBox.Show("Selecione um filtro de busca.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                da = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_buscaFornecedor.DataSource = dt;
            }

            else
            {
                MessageBox.Show("O campo de busca está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string valorBusca = textBox_filtroBusca.Text.ToString();
            procurarItem(valorBusca);
        }
    }
}
