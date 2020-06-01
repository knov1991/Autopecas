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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "INSERT INTO ESTOQUE (PRODUTO, CATEGORIA, QUANTIDADE, VALORPRODUTO, FORNECEDOR, DATA_ENTRADA) VALUES(@PRODUTO, @CATEGORIA, @QUANTIDADE, @VALORPRODUTO, @FORNECEDOR, @DATA_ENTRADA)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@PRODUTO", txtProduto.Text);
                comando.Parameters.AddWithValue("@CATEGORIA", txtCategoria.Text);
                comando.Parameters.AddWithValue("@VALORPRODUTO", txtvalorProduto.Text);
                comando.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text);
                comando.Parameters.AddWithValue("@FORNECEDOR", txtFornecedor.Text);
                comando.Parameters.AddWithValue("@DATA_ENTRADA", txtDataEntrada.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

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

      
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM ESTOQUE";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGrid.DataSource = dt;
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

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "UPDATE ESTOQUE SET PRODUTO = @PRODUTO, CATEGORIA = @CATEGORIA, QUANTIDADE = @QUANTIDADE, VALORPRODUTO = @VALORPRODUTO, FORNECEDOR = @FORNECEDOR, DATA_ENTRADA = @DATA_ENTRADA WHERE ID = @ID ";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtId.Text);
                comando.Parameters.AddWithValue("@PRODUTO", txtProduto.Text);
                comando.Parameters.AddWithValue("@CATEGORIA", txtCategoria.Text);
                comando.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text);
                comando.Parameters.AddWithValue("@VALORPRODUTO", txtvalorProduto.Text);
                comando.Parameters.AddWithValue("@FORNECEDOR", txtFornecedor.Text);
                comando.Parameters.AddWithValue("@DATA_ENTRADA", txtDataEntrada.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

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

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "DELETE FROM ESTOQUE WHERE ID = @ID ";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtId.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

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

        private void txtConsultar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM ESTOQUE WHERE ID = @ID ";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtId.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtProduto.Text = Convert.ToString(dr["produto"]);
                    txtCategoria.Text = Convert.ToString(dr["categoria"]);
                    txtQuantidade.Text = Convert.ToString(dr["quantidade"]);
                    txtQuantidade.Text = Convert.ToString(dr["valorProduto"]);
                    txtFornecedor.Text = Convert.ToString(dr["Fornecedor"]);
                    txtDataEntrada.Text = Convert.ToString(dr["data_entrada"]);


                }

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

        private void btn_listar_Click(object sender, EventArgs e)
        {
            ListaFornecedor Fornecedor = new ListaFornecedor(this);
            Fornecedor.Show();

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void PRODUTO_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_CadastroFornecedor_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtvalorProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
