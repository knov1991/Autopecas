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
    public partial class ListaProdutos : Form
    {
        Vendas instanciaVendas;
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public ListaProdutos(Vendas vendas)
        {
            InitializeComponent();
            dataGridView_buscaProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            instanciaVendas = vendas;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_buscaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                strSQL = "SELECT * FROM ESTOQUE";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_buscaProdutos.DataSource = dt;
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
            DataGridViewRow dr = dataGridView_buscaProdutos.SelectedRows[0];
            instanciaVendas.textBox_CodigoProduto.Text = dr.Cells[0].Value.ToString();
            instanciaVendas.textBox_NomeProduto.Text = dr.Cells[1].Value.ToString();
            instanciaVendas.textBox_ValorProduto.Text = dr.Cells[2].Value.ToString();
            Close();
        }

        public void procurarItem(string valorBusca)
        {
            conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");

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
            if (radioButton_filtroNome.Checked || radioButton_filtroFornecedor.Checked || radioButton_Categoria.Checked)
            {
                da = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_buscaProdutos.DataSource = dt;
            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string valorBusca = textBox_filtroBusca.Text.ToString();
            procurarItem(valorBusca);
        }
    }
}
