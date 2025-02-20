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
    public partial class ContasPagar : Form

    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public int idContaPagar;
        public ContasPagar()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ContasPagarListar Pagar = new ContasPagarListar(this);
            Pagar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpaCampos()
        {
            txtDataOperacao.Text = string.Empty;
            txtDataVencimento.Text = string.Empty;
            txtFornecedor.Text = string.Empty;
            txtNatureza.Text = string.Empty;
            txtValor.Text = string.Empty;
        }

        public void salvarDados()
        {
            try
            {
                DateTime dtOperacao = DateTime.Parse(txtDataOperacao.Text);
                DateTime dtVencimento = DateTime.Parse(txtDataVencimento.Text);

                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "INSERT INTO CONTASPAGAR (FORNECEDOR, DATAOPERACAO, DATAVENCIMENTO, NATUREZA, VALOR) VALUES(@FORNECEDOR, @DATAOPERACAO, @DATAVENCIMENTO, @NATUREZA, @VALOR)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@FORNECEDOR", txtFornecedor.Text);
                comando.Parameters.AddWithValue("@DATAOPERACAO", dtOperacao);
                comando.Parameters.AddWithValue("@DATAVENCIMENTO", dtVencimento);
                comando.Parameters.AddWithValue("@NATUREZA", txtNatureza.Text);
                comando.Parameters.AddWithValue("@VALOR", txtValor.Text);


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

        private void alterarDados()
        {
            try
            {
                DateTime dtOperacao = DateTime.Parse(txtDataOperacao.Text);
                DateTime dtVencimento = DateTime.Parse(txtDataVencimento.Text);

                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "UPDATE CONTASPAGAR SET FORNECEDOR = @FORNECEDOR, DATAOPERACAO = @DATAOPERACAO, DATAVENCIMENTO = @DATAVENCIMENTO, NATUREZA = @NATUREZA WHERE ID = @ID ";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", idContaPagar);
                comando.Parameters.AddWithValue("@FORNECEDOR", txtFornecedor.Text);
                comando.Parameters.AddWithValue("@DATAOPERACAO", dtOperacao);
                comando.Parameters.AddWithValue("@DATAVENCIMENTO", dtVencimento);
                comando.Parameters.AddWithValue("@NATUREZA", txtNatureza.Text);


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

        private void excluirDados()
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "DELETE FROM CONTASPAGAR WHERE ID = @ID ";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", idContaPagar);

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

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (txtFornecedor.TextLength == 0 || txtDataOperacao.TextLength == 0 || txtDataVencimento.TextLength == 0 || txtNatureza.TextLength == 0 || txtValor.TextLength == 0)
            {
                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                salvarDados();
                MessageBox.Show("Dados salvos com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaCampos();
            }
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            if (txtFornecedor.TextLength == 0 || txtDataOperacao.TextLength == 0 || txtDataVencimento.TextLength == 0 || txtNatureza.TextLength == 0 || txtValor.TextLength == 0)
            {
                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                alterarDados();
                MessageBox.Show("Dados alterados com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaCampos();
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            excluirDados();
            limpaCampos();
            MessageBox.Show("Dados excluidos com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ContasPagarBuscarFornecedor BuscarFornecedor = new ContasPagarBuscarFornecedor(this);
            BuscarFornecedor.Show();
        }
    }
}

