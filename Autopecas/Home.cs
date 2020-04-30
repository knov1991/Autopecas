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
            escondeMenu();
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
        private void mostraMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                escondeMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        // ESCONDE MENU LATERAL
        private void escondeMenu()
        {
            painelEstoque.Visible = false;
            painelFornecedor.Visible = false;
        }


        // ABRIR MODULO NA TELA PRINCIPAL
        private void abrirModal(object Modulo)
        {
            if (this.painelPrincipal.Controls.Count > 0)
                this.painelPrincipal.Controls.RemoveAt(0);
            Form mod = Modulo as Form;
            mod.TopLevel = false;
            mod.Dock = DockStyle.Fill;
            this.painelPrincipal.Controls.Add(mod);
            this.painelPrincipal.Tag = mod;
            mod.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            mostraMenu(painelFornecedor);
        }
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            mostraMenu(painelEstoque);
        }
        private void btnRequisicao_Click(object sender, EventArgs e)
        {
            //abrirModal(new nomeModulo());
        }
        private void btnVendas_Click(object sender, EventArgs e)
        {
            //abrirModal(new nomeModulo());
        }
        private void btnFornecedorCadastrar_Click(object sender, EventArgs e)
        {
            //abrirModal(new nomeModulo());
        }
        private void btnFornecedorListar_Click(object sender, EventArgs e)
        {
            //abrirModal(new nomeModulo());
        }
        private void btnEstoqueAdicionar_Click(object sender, EventArgs e)
        {
            //abrirModal(new nomeModulo());
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
