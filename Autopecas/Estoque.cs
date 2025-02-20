﻿using System;
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
    public partial class Estoque : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Estoque()
        {
            InitializeComponent();
            dataGridView_buscaProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnGerenciar.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_listarTodos_Click(object sender, EventArgs e)
        {
            carregaGrid();
            btnGerenciar.Enabled = true;
        }

        private void carregaGrid()
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM estoque";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_buscaProdutos.DataSource = dt;
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

        public void procurarItem(string valorBusca)
        {
            conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");

            if (String.IsNullOrEmpty(valorBusca) == false)
            {
                if (checkBox_estoque.Checked && checkBox_foraEstoque.Checked)
                {
                    if (radioButton_filtroNome.Checked)
                    {
                        strSQL = "SELECT * FROM ESTOQUE WHERE produto like '%" + valorBusca + "%'";
                    }
                    if (radioButton_filtroFornecedor.Checked)
                    {
                        strSQL = "SELECT * FROM ESTOQUE WHERE fornecedor like '%" + valorBusca + "%'";
                    }
                    if (radioButton_Categoria.Checked)
                    {
                        strSQL = "SELECT * FROM ESTOQUE WHERE categoria like '%" + valorBusca + "%'";
                    }
                }

                else if (checkBox_estoque.Checked)
                {
                    if (radioButton_filtroNome.Checked)
                    {
                        strSQL = "SELECT * FROM ESTOQUE WHERE produto like '%" + valorBusca + "%' AND quantidade > 0";
                    }
                    if (radioButton_filtroFornecedor.Checked)
                    {
                        strSQL = "SELECT * FROM ESTOQUE WHERE fornecedor like '%" + valorBusca + "%' AND quantidade > 0";
                    }
                    if (radioButton_Categoria.Checked)
                    {
                        strSQL = "SELECT * FROM ESTOQUE WHERE categoria like '%" + valorBusca + "%' AND quantidade > 0";
                    }
                }

                else if (checkBox_foraEstoque.Checked)
                {
                    if (radioButton_filtroNome.Checked)
                    {
                        strSQL = "SELECT * FROM ESTOQUE WHERE produto like '%" + valorBusca + "%' AND quantidade = 0";
                    }
                    if (radioButton_filtroFornecedor.Checked)
                    {
                        strSQL = "SELECT * FROM ESTOQUE WHERE fornecedor like '%" + valorBusca + "%' AND quantidade = 0";
                    }
                    if (radioButton_Categoria.Checked)
                    {
                        strSQL = "SELECT * FROM ESTOQUE WHERE categoria like '%" + valorBusca + "%' AND quantidade = 0";
                    }

                }

                else
                {
                    MessageBox.Show("Selecione um filtro de busca.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                da = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_buscaProdutos.DataSource = dt;
                atualizaTituloGrid();
                btnGerenciar.Enabled = true;
            }

            else
            {
                MessageBox.Show("O campo de busca está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void atualizaTituloGrid()
        {
            dataGridView_buscaProdutos.Columns[0].HeaderText = "Código";
            dataGridView_buscaProdutos.Columns[1].HeaderText = "Nome";
            dataGridView_buscaProdutos.Columns[2].HeaderText = "Valor";
            dataGridView_buscaProdutos.Columns[3].HeaderText = "Data de Entrada";
            dataGridView_buscaProdutos.Columns[4].HeaderText = "Categoria";
            dataGridView_buscaProdutos.Columns[5].HeaderText = "Quantidade";
            dataGridView_buscaProdutos.Columns[6].HeaderText = "Fornecedor";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string valorBusca = textBox_filtroBusca.Text.ToString();
            procurarItem(valorBusca);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CadastroEstoque cadastro = new CadastroEstoque();
            cadastro.Show();
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            if (dataGridView_buscaProdutos.SelectedRows.Count != 0)
            {
                GerenciarEstoque Gerenciar = new GerenciarEstoque(this);
                Gerenciar.Show();

                DataGridViewRow dr = dataGridView_buscaProdutos.SelectedRows[0];
                //Envia os Dados para FornecedorCadastrar
                Gerenciar.idProduto = Convert.ToInt32(dr.Cells[0].Value.ToString());
                Gerenciar.txtProduto.Text = dr.Cells[1].Value.ToString();
                Gerenciar.txtvalorProduto.Text = dr.Cells[2].Value.ToString();
                Gerenciar.txtDataEntrada.Text = dr.Cells[3].Value.ToString();
                Gerenciar.txtCategoria.Text = dr.Cells[4].Value.ToString();
                Gerenciar.txtQuantidade.Text = dr.Cells[5].Value.ToString();
                Gerenciar.txtFornecedor.Text = dr.Cells[6].Value.ToString();
            }   
            else
            {
                MessageBox.Show("Selecione um produto para gerenciar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            GerenciarEstoqueRelatorio relatorio = new GerenciarEstoqueRelatorio();
            relatorio.Show();
        }

    }
}
