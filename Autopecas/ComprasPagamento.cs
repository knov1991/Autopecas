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
    public partial class ComprasPagamento : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        Compras instanciaCompras;
        string strSQL;
        public ComprasPagamento(Compras compras)
        {
            InitializeComponent();
            instanciaCompras = compras;
        }

        private void ComprasPagamento_Load(object sender, EventArgs e)
        {
            inicializaValores();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void inicializaValores()
        {
            textBox_subTotal.Text = instanciaCompras.textBox_subTotal.Text;
            textBox_total.Text = textBox_subTotal.Text;
            comboBox_formaPagamento.SelectedIndex = 0;
            comboBox_parcelas.SelectedIndex = 0;
        }

        private void comboBox_formaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_formaPagamento.SelectedIndex == 0 || comboBox_formaPagamento.SelectedIndex == 2)
            {
                label_parcelado.Visible = false;
                comboBox_parcelas.Visible = false;
            }

            if (comboBox_formaPagamento.SelectedIndex == 1)
            {
                label_parcelado.Visible = true;
                comboBox_parcelas.Visible = true;
            }

            if (comboBox_formaPagamento.SelectedIndex == 3)
            {
                label_parcelado.Visible = true;
                comboBox_parcelas.Visible = true;
                ContasReceber Receber = new ContasReceber();
                Receber.Show();
            }

        }
        private void atualizaEstoque()
        {
            int i = 0;
            for (i = 0; i < instanciaCompras.dataGridView_Carrinho.Rows.Count; i++)
            {
                int qtde = Convert.ToInt32(instanciaCompras.dataGridView_Carrinho.Rows[i].Cells["quantidade"].Value);
                int id = Convert.ToInt32(instanciaCompras.dataGridView_Carrinho.Rows[i].Cells["codProduto"].Value);
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "UPDATE estoque SET quantidade = quantidade + '" + qtde + "' WHERE id = '" + id + "'";
                comando = new MySqlCommand(strSQL, conexao);

                conexao.Open();
                comando.ExecuteNonQuery();

            }

        }

        private void concluirVenda()
        {
            try
            {
                int i = 0;
                for (i = 0; i < instanciaCompras.dataGridView_Carrinho.Rows.Count; i++)
                {
                    DateTime date = DateTime.Now;

                    conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                    strSQL = "INSERT INTO compras (nomeProduto, quantidade, valorProduto, valorTotal, formaPagamento, parcelado, dataCompra) VALUES (@nomeProduto, @quantidade, @valorProduto, @valorTotal, @formaPagamento, @parcelado, @dataCompra);";
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@nomeProduto", instanciaCompras.dataGridView_Carrinho.Rows[i].Cells["nome"].Value);
                    comando.Parameters.AddWithValue("@quantidade", instanciaCompras.dataGridView_Carrinho.Rows[i].Cells["quantidade"].Value);
                    comando.Parameters.AddWithValue("@valorProduto", Convert.ToDecimal(instanciaCompras.dataGridView_Carrinho.Rows[i].Cells["valorUnitario"].Value));
                    comando.Parameters.AddWithValue("@valorTotal", Convert.ToDecimal(instanciaCompras.dataGridView_Carrinho.Rows[i].Cells["valorTotal"].Value));
                    comando.Parameters.AddWithValue("@formaPagamento", comboBox_formaPagamento.Text);
                    comando.Parameters.AddWithValue("@parcelado", comboBox_parcelas.Text);
                    comando.Parameters.AddWithValue("@dataCompra", date);
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
        private void limpaCampos()
        {
            instanciaCompras.dataGridView_Carrinho.Rows.Clear();
            instanciaCompras.textBox_subTotal.Text = "R$ 0,00";
        }
        private void btn_concluirVenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você deseja confirmar essa venda?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.No)
            {
                MessageBox.Show("Compra cancelada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                concluirVenda();
                atualizaEstoque();
                limpaCampos();
                Close();
                MessageBox.Show("Compra concluída com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
