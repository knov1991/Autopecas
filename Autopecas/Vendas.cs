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


        }
        private void btn_listar_Click(object sender, EventArgs e)
        {
            ListaProdutos ListarProdutos = new ListaProdutos(this);
            ListarProdutos.Show();

        }

        private void btn_addProduto_Click(object sender, EventArgs e)
        {
            ValidacaoCampos();
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

            }
        }
    }
}
