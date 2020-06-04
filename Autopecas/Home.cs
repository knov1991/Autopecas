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
        DateTime dataHora;
        public Home()
        {
            InitializeComponent();
            EsconderMenu();
            Conectar.ConectarMysql();
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
            painelCadastros.Visible = false;
        }

        // ABRIR MODULO NA TELA PRINCIPAL
        public void AbrirModal(object Modulo)
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
            AbrirModal(new FornecedorCadastrar());
        }
        private void btnVendas_Click(object sender, EventArgs e)
        {
            AbrirModal(new Vendas());
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

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirModal(new Clientes());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirModal(new Compras());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataHora = DateTime.Now;
            lbHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelCadastros);
        }

        //PERMITE MOVER FORMULÁRIO
        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X <= 2 && e.Y <= 2) || (e.X + 2 >= this.Width && e.Y + 2 >= this.Height))
            {
                this.Cursor = Cursors.SizeNWSE;
            }
            else if ((e.X + 2 >= this.Width && e.Y <= 2) || (e.X <= 2 && e.Y + 2 >= this.Height))
            {
                this.Cursor = Cursors.SizeNESW;
            }
            else if (e.X <= 2 || e.X + 2 >= this.Width)
            {
                this.Cursor = Cursors.SizeWE;
            }
            else if (e.Y <= 2 || e.Y + 2 >= this.Height)
            {
                this.Cursor = Cursors.SizeNS;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
