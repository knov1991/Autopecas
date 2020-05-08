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
            ValidacaoCampos();
            calculaSubTotal();
        }

        private void btn_finalizaVenda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja concluir essa venda?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                concluirVenda();
            }
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
            }

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
                textBox_subTotal.Text = SubTotal().ToString("0.00");
        }
        
        private void concluirVenda()
        {
            int i = 0;
            for (i = 0; i < dataGridView_Carrinho.Rows.Count; i++)
            {
                string constring = "SERVER=localhost; DATABASE=piii; UID=root; PWD=root";
                string query = "insert into vendas (idVendas, nomeProduto, quantidade, valorProduto, valorTotal, formaPagamento) values (?, ?, ?, ?, ?, ?);";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                MySqlDataReader myReader;

                cmdDataBase.Parameters.AddWithValue("@nomeProduto", dataGridView_Carrinho.Rows[i].Cells["nome"].Value);
                cmdDataBase.Parameters.AddWithValue("@quantidade", dataGridView_Carrinho.Rows[i].Cells["quantidade"].Value);
                cmdDataBase.Parameters.AddWithValue("@valorProduto", Convert.ToDecimal(dataGridView_Carrinho.Rows[i].Cells["valorUnitario"].Value));
                cmdDataBase.Parameters.AddWithValue("@valorTotal", Convert.ToDecimal(dataGridView_Carrinho.Rows[i].Cells["valorTotal"].Value));
                cmdDataBase.Parameters.AddWithValue("@formaPagamento", comboBox_FormaPagamento.Text);
                //cmdDataBase.Parameters.Clear();

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {

                }
                conDataBase.Close();
            }
        }

    }
}
