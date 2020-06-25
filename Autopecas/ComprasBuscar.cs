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
    public partial class ComprasBuscar : Form
    {
        Compras instanciaCompras;
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public ComprasBuscar(Compras compras)
        {
            InitializeComponent();
            dataGridView_buscaCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            instanciaCompras = compras;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string valorBusca = textBox_filtroBusca.Text.ToString();
            procurarItem(valorBusca);
        }

        private void btn_listarTodos_Click(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM COMPRAS WHERE quantidade > 0";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_buscaCompras.DataSource = dt;

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


        private void atualizaTituloGrid()
        {
            dataGridView_buscaCompras.Columns[0].HeaderText = "Código";
            dataGridView_buscaCompras.Columns[1].HeaderText = "Nome";
            dataGridView_buscaCompras.Columns[2].HeaderText = "Valor";
            dataGridView_buscaCompras.Columns[3].HeaderText = "Data de Entrada";
            dataGridView_buscaCompras.Columns[4].HeaderText = "Categoria";
            dataGridView_buscaCompras.Columns[5].HeaderText = "Quantidade";
            dataGridView_buscaCompras.Columns[6].HeaderText = "Fornecedor";
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView_buscaCompras.SelectedRows[0];

            instanciaCompras.textBox_CodigoProduto.Text = dr.Cells[0].Value.ToString();
            instanciaCompras.textBox_NomeProduto.Text = dr.Cells[1].Value.ToString();
            instanciaCompras.textBox_ValorProduto.Text = dr.Cells[2].Value.ToString();
            Close();
        }

        public void procurarItem(string valorBusca)
        {
            conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");

            if (String.IsNullOrEmpty(valorBusca) == false)
            {
                if (checkBox_estoque.Checked && checkBox_foraEstoque.Checked)
                {
                    if (radioButton_filtroNome.Checked)
                    {
                        strSQL = "SELECT * FROM COMPRAS WHERE produto like '%" + valorBusca + "%'";
                    }
                    if (radioButton_filtroFornecedor.Checked)
                    {
                        strSQL = "SELECT * FROM COMPRAS WHERE fornecedor like '%" + valorBusca + "%'";
                    }
                    if (radioButton_Categoria.Checked)
                    {
                        strSQL = "SELECT * FROM COMPRAS WHERE categoria like '%" + valorBusca + "%'";
                    }
                }

                else if (checkBox_estoque.Checked)
                {
                    if (radioButton_filtroNome.Checked)
                    {
                        strSQL = "SELECT * FROM COMPRAS WHERE produto like '%" + valorBusca + "%' AND quantidade > 0";
                    }
                    if (radioButton_filtroFornecedor.Checked)
                    {
                        strSQL = "SELECT * FROM COMPRAS WHERE fornecedor like '%" + valorBusca + "%' AND quantidade > 0";
                    }
                    if (radioButton_Categoria.Checked)
                    {
                        strSQL = "SELECT * FROM COMPRAS WHERE categoria like '%" + valorBusca + "%' AND quantidade > 0";
                    }
                }

                else if (checkBox_foraEstoque.Checked)
                {
                    if (radioButton_filtroNome.Checked)
                    {
                        strSQL = "SELECT * FROM COMPRAS WHERE produto like '%" + valorBusca + "%' AND quantidade = 0";
                    }
                    if (radioButton_filtroFornecedor.Checked)
                    {
                        strSQL = "SELECT * FROM COMPRAS WHERE fornecedor like '%" + valorBusca + "%' AND quantidade = 0";
                    }
                    if (radioButton_Categoria.Checked)
                    {
                        strSQL = "SELECT * FROM COMPRAS WHERE categoria like '%" + valorBusca + "%' AND quantidade = 0";
                    }

                }

                else
                {
                    MessageBox.Show("Selecione um filtro de busca.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                da = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_buscaCompras.DataSource = dt;
            }

            else
            {
                MessageBox.Show("O campo de busca está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
