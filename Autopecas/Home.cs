using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Autopecas
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            EsconderMenu();
        }

        // MOVER JANELA SEM BARRA DE TITULO PADRÃO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // MOSTRAR MENU LATERAL
        private void MostrarMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        // ESCONDE MENU LATERAL
        private void EsconderMenu()
        {
            painelFornecedor.Visible = false;
        }


        // ABRIR MODULO NA TELA PRINCIPAL
        public static void AbrirModal(object Modulo)
        {
            if (Home.painelPrincipal.Controls.Count > 0)
                Home.painelPrincipal.Controls.RemoveAt(0);
            Form mod = Modulo as Form;
            mod.TopLevel = false;
            mod.Dock = DockStyle.Fill;
            Home.painelPrincipal.Controls.Add(mod);
            Home.painelPrincipal.Tag = mod;
            mod.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelFornecedor);
        }
        private void btnVendas_Click(object sender, EventArgs e)
        {
            AbrirModal(new Vendas());
        }
        private void btnFornecedorCadastrar_Click(object sender, EventArgs e)
        {
            AbrirModal(new FornecedorCadastrar());
        }
        private void btnFornecedorListar_Click(object sender, EventArgs e)
        {
            AbrirModal(new FornecedorListar());
        }
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            AbrirModal(new Estoque());
        }
        private void btnControleFinanceiro_Click(object sender, EventArgs e)
        {
            AbrirModal(new ControleFinanceiro());
        }

        // FECHAR SOFTWARE
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
