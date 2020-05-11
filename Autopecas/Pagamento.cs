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
    public partial class Pagamento : Form
    {
        Vendas instanciaVendas;
        public Pagamento(Vendas vendas)
        {
            InitializeComponent();
            instanciaVendas = vendas;
            atualizaValores();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void atualizaValores()
        {
            textBox_subTotal.Text = instanciaVendas.textBox_subTotal.Text;
        }
    }
}
