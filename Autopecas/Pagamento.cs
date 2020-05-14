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
            atualizaValores();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void atualizaValores()
        {
            textBox_subTotal.Text = instanciaVendas.textBox_subTotal.Text;
            textBox_total.Text = textBox_subTotal.Text;
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
    }
}
