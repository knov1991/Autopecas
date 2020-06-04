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
        MySqlDataAdapter da;
        MySqlDataReader dr;
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

        public void habilitaItens()
        {
            txtProduto.Enabled = true;
            txtDataEntrada.Enabled = true;
            txtCategoria.Enabled = true;
            txtFornecedor.Enabled = true;
            btn_listar.Enabled = true;
            txtvalorProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtMotivo.Enabled = true;
            comboBoxTIpo.Enabled = true;
        }

        public void desabilitaItens()
        {
            txtProduto.Enabled = false;
            txtDataEntrada.Enabled = false;
            txtCategoria.Enabled = false;
            txtFornecedor.Enabled = false;
            btn_listar.Enabled = false;
            txtvalorProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            txtMotivo.Enabled = false;
            comboBoxTIpo.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitaItens();
            txtQuantidade.Enabled = false;
            btnAtualizar.Enabled = false;
            txtMotivo.Enabled = false;
            comboBoxTIpo.Enabled = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            quantidadeProdutos = Convert.ToInt32(txtQuantidade.Text);
            desabilitaItens();
            txtMotivo.Enabled = true;
            btnEditar.Enabled = false;
            btnAtualizar.Enabled = false;
            txtQuantidade.Enabled = true;
            comboBoxTIpo.Enabled = true;

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int quantidade;
            quantidade = Convert.ToInt32(txtQuantidade.Text);
            if (quantidade < quantidadeProdutos || quantidade > quantidadeProdutos)
            {
                atualizaQuantidade();
                atualizaControleEstoque();
                MessageBox.Show("Alteração concluída com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else if(quantidade == quantidadeProdutos)
            {
                atualizaDados();
            }
        }

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

        public void atualizaDados()
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "UPDATE ESTOQUE SET QUANTIDADE=@PRODUTO WHERE ID=@ID";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", idProduto);
                comando.Parameters.AddWithValue("@PRODUTO", txtProduto.Text);


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

        public void atualizaControleEstoque()
        {

        }
    }
}
