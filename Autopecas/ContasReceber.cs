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
    public partial class ContasReceber : Form

    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public int idContasReceber;
        public ContasReceber()
        {
            InitializeComponent();
        }

        private void limpaCampos()
        {
            txtDataOperacao.Text = string.Empty;
            txtDataVencimento.Text = string.Empty;
            txtCliente.Text = string.Empty;
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
                strSQL = "INSERT INTO CONTASRECEBER (CLIENTE, DATAOPERACAO, DATAVENCIMENTO, NATUREZA, VALOR) VALUES(@CLIENTE, @DATAOPERACAO, @DATAVENCIMENTO, @NATUREZA, @VALOR)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CLIENTE", txtCliente.Text);
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

        public void alterarDados()
        {
            try
            {
                DateTime dtOperacao = DateTime.Parse(txtDataOperacao.Text);
                DateTime dtVencimento = DateTime.Parse(txtDataVencimento.Text);

                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "UPDATE CONTASRECEBER SET CLIENTE = @CLIENTE, DATAOPERACAO = @DATAOPERACAO, DATAVENCIMENTO = @DATAVENCIMENTO, NATUREZA = @NATUREZA WHERE ID = @ID ";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", idContasReceber);
                comando.Parameters.AddWithValue("@CLIENTE", txtCliente.Text);
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

        public void excluirDados()
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "DELETE FROM CONTASRECEBER WHERE ID = @ID ";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", idContasReceber);

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCliente.TextLength == 0 || txtDataOperacao.TextLength == 0 || txtDataVencimento.TextLength == 0 || txtNatureza.TextLength == 0 || txtValor.TextLength == 0)
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCliente.TextLength == 0 || txtDataOperacao.TextLength == 0 || txtDataVencimento.TextLength == 0 || txtNatureza.TextLength == 0 || txtValor.TextLength == 0)
            {
                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                alterarDados();
                MessageBox.Show("Dados salvos com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaCampos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluirDados();
            limpaCampos();
            MessageBox.Show("Dados excluidos com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ContasReceberListar Receber = new ContasReceberListar(this);
            Receber.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ContasReceberBuscaClientes BuscarClientes = new ContasReceberBuscaClientes(this);
            BuscarClientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroClientes Clientes = new CadastroClientes();
            Clientes.Show();
        }
    }
}

   