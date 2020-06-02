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
    public partial class ControleFinanceiro : Form
    {
        public ControleFinanceiro()
        {
            InitializeComponent();
        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            ContasReceber Receber = new ContasReceber();
            Receber.Show();
        }

        private void btnContasPagar_Click(object sender, EventArgs e)
        {
            ContasPagar Pagar = new ContasPagar();
            Pagar.Show();
        }
    }
}
