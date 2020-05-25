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

namespace Autopecas
{
    public partial class Pagamento : Form
    {
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
    }
}
