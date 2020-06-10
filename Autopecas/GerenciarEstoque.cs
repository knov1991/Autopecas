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
    public partial class GerenciarEstoque : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        Estoque instanciaEstoque;
        string strSQL;
        public int idProduto;
        int quantidadeProdutos;

        public GerenciarEstoque(Estoque estoque)
        {
            InitializeComponent();
            instanciaEstoque = estoque;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void habilitaItens()
        {
            txtProduto.Enabled = true;
            txtDataEntrada.Enabled = true;
            txtCategoria.Enabled = true;
            btn_listar.Enabled = true;
            txtvalorProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtMotivo.Enabled = true;
            comboBoxTIpo.Enabled = true;
        }

        private void atualizaValores()
        {
            quantidadeProdutos = Convert.ToInt32(txtQuantidade.Text);
            comboBoxTIpo.SelectedIndex = 0;
        }

        //VALIDA CAMPOS
        private void validacaoCampos()
        {
            if (txtMotivo.Text.Length == 0 && comboBoxTIpo.SelectedIndex == 0)
            {
                MessageBox.Show("Campos motivo ou tipo inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                atualizaQuantidade();
                atualizaDados();
                criarRelatorioEstoque();
                MessageBox.Show("Alterações salvas com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        //EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            atualizaValores();
            habilitaItens();
            btnSalvar.Enabled = true;
        }

        //SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int quantidade;
            quantidade = Convert.ToInt32(txtQuantidade.Text);

            if(quantidade != quantidadeProdutos)
            {
                validacaoCampos();
            }
            else
            {
                atualizaDados();
                MessageBox.Show("Alterações salvas com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

        }

        //ATUALIZA QUANTIDADE E GERA RELATÓRIO
        public void atualizaQuantidade()
        {

            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "UPDATE ESTOQUE SET QUANTIDADE=@QUANTIDADE WHERE ID=@ID";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", idProduto);
                comando.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text);

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

        //ATUALIZA CAMPOS DE TEXTO
        public void atualizaDados()
        {
            try
            {
                DateTime dt = DateTime.Parse(txtDataEntrada.Text);

                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "UPDATE ESTOQUE SET PRODUTO=@PRODUTO, VALORPRODUTO=@VALORPRODUTO, DATA_ENTRADA=@DATA_ENTRADA, CATEGORIA=@CATEGORIA, " +
                "QUANTIDADE=@QUANTIDADE, FORNECEDOR=@FORNECEDOR WHERE ID=@ID";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", idProduto);
                comando.Parameters.AddWithValue("@PRODUTO", txtProduto.Text);
                comando.Parameters.AddWithValue("@VALORPRODUTO", txtvalorProduto.Text);
                comando.Parameters.AddWithValue("@DATA_ENTRADA", dt);
                comando.Parameters.AddWithValue("@CATEGORIA", txtCategoria.Text);
                comando.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text);
                comando.Parameters.AddWithValue("@FORNECEDOR", txtFornecedor.Text);

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

        //CRIA RELATÓRIO
        public void criarRelatorioEstoque()
        {
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            int diferenca = 0;

            //ENTRADA
            if(comboBoxTIpo.SelectedIndex == 1)
            {
                diferenca = quantidade - quantidadeProdutos;
            }

            //SAIDA
            if (comboBoxTIpo.SelectedIndex == 2)
            {
                diferenca = quantidadeProdutos - quantidade;
            }

            try
            {
                DateTime date = DateTime.Now;

                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "INSERT INTO RELATORIOESTOQUE (NOMEPRODUTO, FORNECEDOR, MOTIVO, TIPO, QUANTIDADE, DATA) VALUES(@NOMEPRODUTO, @FORNECEDOR, @MOTIVO, @TIPO, @QUANTIDADE, @DATA)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOMEPRODUTO", txtProduto.Text);
                comando.Parameters.AddWithValue("@FORNECEDOR", txtFornecedor.Text);
                comando.Parameters.AddWithValue("@MOTIVO", txtMotivo.Text);
                comando.Parameters.AddWithValue("@TIPO", comboBoxTIpo.Text);
                comando.Parameters.AddWithValue("@QUANTIDADE", diferenca);
                comando.Parameters.AddWithValue("@DATA", date);
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

    }
}
