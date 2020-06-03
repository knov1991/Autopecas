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
    public partial class GerenciarEstoque : Form
    {
        public int idProduto;
        Estoque instanciaEstoque;
        public GerenciarEstoque(Estoque estoque)
        {
            InitializeComponent();
            instanciaEstoque = estoque;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void habilitaItens()
        {
            txtProduto.Enabled = true;
            txtDataEntrada.Enabled = true;
            txtCategoria.Enabled = true;
            txtFornecedor.Enabled = true;
            btn_listar.Enabled = true;
            txtvalorProduto.Enabled = true;
            comboBoxStatus.Enabled = true;
            txtQuantidade.Enabled = true;
            txtMotivo.Enabled = true;
            comboBoxTIpo.Enabled = true;
        }

        public void desabilitaItens()
        {
            txtProduto.Enabled = false;
            txtDataEntrada.Enabled = false;
            txtCategoria.Enabled = false;
            txtFornecedor.Enabled = false;
            btn_listar.Enabled = false;
            txtvalorProduto.Enabled = false;
            comboBoxStatus.Enabled = false;
            txtQuantidade.Enabled = false;
            txtMotivo.Enabled = false;
            comboBoxTIpo.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitaItens();
            txtQuantidade.Enabled = false;
            txtMotivo.Enabled = false;
            comboBoxTIpo.Enabled = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            desabilitaItens();
            txtMotivo.Enabled = true;
            txtQuantidade.Enabled = true;
            comboBoxTIpo.Enabled = true;

        }
    }
}
