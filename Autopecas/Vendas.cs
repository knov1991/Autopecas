using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autopecas
{
    public partial class Vendas : Form
    {
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
            VendasBuscar ListarProdutos = new VendasBuscar(this);
            ListarProdutos.Show();

        }

        //ADICIONA PRODUTOS
        private void btn_addProduto_Click(object sender, EventArgs e)
        {
            dataGridView_Carrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ValidacaoCampos();
            calculaSubTotal();
        }

        //REMOVE PRODUTOS
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

            finalizarValidacao();

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

        private void finalizarValidacao() 
        {
            if(dataGridView_Carrinho.Rows.Count == 0)
            {
                MessageBox.Show("O carrinho de compras está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                VendasPagamento Pagamento = new VendasPagamento(this);
                Pagamento.Show();
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

        private void textBox_CodigoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContasReceber receber = new ContasReceber();
            receber.Show();
        }
    }
}
