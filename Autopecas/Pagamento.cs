using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Autopecas
{
    public partial class Pagamento : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        Vendas instanciaVendas;
        public Pagamento(Vendas vendas)
        {
            InitializeComponent();
            instanciaVendas = vendas;
    
        }
        private void Pagamento_Load(object sender, EventArgs e)
        {
            inicializaValores();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void inicializaValores()
        {
            textBox_subTotal.Text = instanciaVendas.textBox_subTotal.Text;
            textBox_total.Text = textBox_subTotal.Text;
            comboBox_formaPagamento.SelectedIndex = 0;
            comboBox_parcelas.SelectedIndex = 0;
        }

        private void textBox_desconto_TextChanged(object sender, EventArgs e)
        {
            calculaValores();
        }

        private void calculaValores()
        {

            textBox_subTotal.Text = textBox_subTotal.Text.Replace("R$", "").Trim();
            textBox_total.Text = textBox_total.Text.Replace("R$", "").Trim();

            decimal total = Convert.ToDecimal(textBox_subTotal.Text);
            decimal desconto = Convert.ToDecimal(textBox_desconto.Text);
            decimal Pedido;
            Pedido = total - desconto;

   
            textBox_total.Text = Pedido.ToString("C2");

        }

        private void comboBox_formaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
          if(comboBox_formaPagamento.SelectedIndex == 0 || comboBox_formaPagamento.SelectedIndex == 2)
            {
                label_vencimentoBoleto.Visible = false;
                label_parcelado.Visible = false;
                dateTimePicke_Pagamentos.Visible = false;
                comboBox_parcelas.Visible= false;
            }

            if (comboBox_formaPagamento.SelectedIndex == 1)
            {
                label_vencimentoBoleto.Visible = false;
                label_parcelado.Visible = true;
                dateTimePicke_Pagamentos.Visible = false;
                comboBox_parcelas.Visible = true;
            }

            if (comboBox_formaPagamento.SelectedIndex == 3)
            {
                label_vencimentoBoleto.Visible = true;
                label_parcelado.Visible = true;
                dateTimePicke_Pagamentos.Visible = true;
                comboBox_parcelas.Visible = true;
            }

        }
        private void atualizaEstoque()
        {
            int i = 0;
            for (i = 0; i < instanciaVendas.dataGridView_Carrinho.Rows.Count; i++)
            {
                int qtde = Convert.ToInt32(instanciaVendas.dataGridView_Carrinho.Rows[i].Cells["quantidade"].Value);
                int id =  Convert.ToInt32(instanciaVendas.dataGridView_Carrinho.Rows[i].Cells["codProduto"].Value);
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "UPDATE estoque SET quantidade = quantidade - '" + qtde + "' WHERE id = '" + id + "'";
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
                for (i = 0; i < instanciaVendas.dataGridView_Carrinho.Rows.Count; i++)
                {
                    DateTime date = DateTime.Now;

                    conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                    strSQL = "INSERT INTO vendas (nomeProduto, quantidade, valorProduto, valorTotal, formaPagamento, parcelado, dataVenda) VALUES (@nomeProduto, @quantidade, @valorProduto, @valorTotal, @formaPagamento, @parcelado, @dataVenda);";
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@nomeProduto", instanciaVendas.dataGridView_Carrinho.Rows[i].Cells["nome"].Value);
                    comando.Parameters.AddWithValue("@quantidade", instanciaVendas.dataGridView_Carrinho.Rows[i].Cells["quantidade"].Value);
                    comando.Parameters.AddWithValue("@valorProduto", Convert.ToDecimal(instanciaVendas.dataGridView_Carrinho.Rows[i].Cells["valorUnitario"].Value));
                    comando.Parameters.AddWithValue("@valorTotal", Convert.ToDecimal(instanciaVendas.dataGridView_Carrinho.Rows[i].Cells["valorTotal"].Value));
                    comando.Parameters.AddWithValue("@formaPagamento", comboBox_formaPagamento.Text);
                    comando.Parameters.AddWithValue("@parcelado", comboBox_parcelas.Text);
                    comando.Parameters.AddWithValue("@dataVenda", date);
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
            instanciaVendas.dataGridView_Carrinho.Rows.Clear();
            instanciaVendas.textBox_subTotal.Text = "R$ 0,00";
        }
        private void btn_concluirVenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você deseja confirmar essa venda?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(DialogResult == DialogResult.No)
            {
                MessageBox.Show("Venda cancelada.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                concluirVenda();
                atualizaEstoque();
                limpaCampos();
                Close();
                MessageBox.Show("Venda concluída com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
