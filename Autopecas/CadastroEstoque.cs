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
    public partial class CadastroEstoque : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public string idEstoque;
        
        public CadastroEstoque()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            validacaoCampos();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            ListaFornecedor Fornecedor = new ListaFornecedor(this);
            Fornecedor.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void validacaoCampos()
        {
            if (txtProduto.Text.Length == 0 || txtCategoria.Text.Length == 0 || txtFornecedor.Text.Length == 0 || txtQuantidade.Text.Length == 0 || txtvalorProduto.Text.Length == 0 || txtFornecedor.Text.Length == 0 || txtDataEntrada.Text.Length == 0)
            {
                MessageBox.Show("Verifique todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    DateTime dt = DateTime.Parse(txtDataEntrada.Text);

                    conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                    strSQL = "INSERT INTO ESTOQUE (PRODUTO, CATEGORIA, QUANTIDADE, VALORPRODUTO, FORNECEDOR, DATA_ENTRADA) VALUES(@PRODUTO, @CATEGORIA, @QUANTIDADE, @VALORPRODUTO, @FORNECEDOR, @DATA_ENTRADA)";
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@PRODUTO", txtProduto.Text);
                    comando.Parameters.AddWithValue("@CATEGORIA", txtCategoria.Text);
                    comando.Parameters.AddWithValue("@VALORPRODUTO", txtvalorProduto.Text);
                    comando.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text);
                    comando.Parameters.AddWithValue("@FORNECEDOR", txtFornecedor.Text);
                    comando.Parameters.AddWithValue("@DATA_ENTRADA", dt);

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
                MessageBox.Show("Cadastro efetuado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

    }
    
}
