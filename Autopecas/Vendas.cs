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
    public partial class Vendas : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Vendas()
        {
            InitializeComponent();
            formataTextBox();
        }
        private void textBox_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacaoCaracteres(e);
        }

        private void textBox_CodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacaoCaracteres(e);
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            ListaProdutos ListarProdutos = new ListaProdutos(this);
            ListarProdutos.Show();

        }

        private void btn_addProduto_Click(object sender, EventArgs e)
        {
            dataGridView_Carrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ValidacaoCampos();
            calculaSubTotal();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            // verificar se existe alguma linha selecionada
            if (dataGridView_Carrinho.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum item selecionado", "Atenção");
                return;
            }
            else{ 
                dataGridView_Carrinho.Rows.RemoveAt(dataGridView_Carrinho.CurrentRow.Index);
            }
        }

        private void btn_finalizaVenda_Click(object sender, EventArgs e)
        {
         
            Pagamento Pagamento = new Pagamento(this);
            Pagamento.Show();

        }

        private void formataTextBox()
        {
            textBox_subTotal.Text = "R$ 0.00";
            textBox_ValorProduto.Text = "R$ 0.00";
        }

        private void validacaoCaracteres(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidacaoCampos()
        {
            if (textBox_CodigoProduto.Text.Length == 0 || textBox_NomeProduto.Text.Length == 0 || textBox_Quantidade.Text.Length == 0 || textBox_ValorProduto.Text.Length == 0)
            {

                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                dataGridView_Carrinho.Rows.Add(textBox_CodigoProduto.Text, textBox_NomeProduto.Text, textBox_Quantidade.Text, textBox_ValorProduto.Text, (Convert.ToDecimal(textBox_Quantidade.Text) * Convert.ToDecimal(textBox_ValorProduto.Text)));
                limpaCampos();
            }

        }
        private void limpaCampos()
        {
            textBox_CodigoProduto.Text = string.Empty;
            textBox_NomeProduto.Text = string.Empty;
            textBox_Quantidade.Text = string.Empty;
            textBox_ValorProduto.Text = string.Empty;

        }
        private decimal SubTotal()
        {
            decimal subTotal = 0;
            int i = 0;
            for (i = 0; i < dataGridView_Carrinho.Rows.Count; i++)
            {
                subTotal = subTotal + (Convert.ToDecimal(dataGridView_Carrinho.Rows[i].Cells["valorUnitario"].Value) * Convert.ToDecimal(dataGridView_Carrinho.Rows[i].Cells["quantidade"].Value));
            }
            return subTotal;
        }

        private void calculaSubTotal()
        {
            if (dataGridView_Carrinho.Rows.Count > 0)
                textBox_subTotal.Text = SubTotal().ToString("C2");
        }

        private void concluirVenda()
        {
            try
            {
                int i = 0;
                for (i = 0; i < dataGridView_Carrinho.Rows.Count; i++)
                {
                    conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                    strSQL = "insert into vendas (nomeProduto, quantidade, valorProduto, valorTotal, formaPagamento) values (@nomeProduto, @quantidade, @valorProduto, @valorTotal, @formaPagamento);";
                    comando = new MySqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@nomeProduto", dataGridView_Carrinho.Rows[i].Cells["nome"].Value);
                    comando.Parameters.AddWithValue("@quantidade", dataGridView_Carrinho.Rows[i].Cells["quantidade"].Value);
                    comando.Parameters.AddWithValue("@valorProduto", Convert.ToDecimal(dataGridView_Carrinho.Rows[i].Cells["valorUnitario"].Value));
                    comando.Parameters.AddWithValue("@valorTotal", Convert.ToDecimal(dataGridView_Carrinho.Rows[i].Cells["valorTotal"].Value));
                    //comando.Parameters.AddWithValue("@formaPagamento", comboBox_FormaPagamento.Text);
                    //cmdDataBase.Parameters.Clear();

                    conexao.Open();
                    comando.ExecuteNonQuery();
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

        private void dataGridView_Carrinho_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView_Carrinho.Rows.Count == 0)
            {
                textBox_subTotal.Text = "R$ 0.00";
            }
            else
            {
                calculaSubTotal();
            }
        }
    }
}
