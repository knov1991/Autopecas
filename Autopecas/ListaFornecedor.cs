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
    public partial class ListaFornecedor : Form
    {
        Estoque instanciaEstoque;
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public ListaFornecedor(Estoque fornecedores)
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
    }
}
