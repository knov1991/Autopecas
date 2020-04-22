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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            escondeMenu();
        }

        private void escondeMenu()
        {
            painelEstoque.Visible = false;
        }

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

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            mostraMenu(painelEstoque);
        }

        private void btnEstoqueAdd_Click(object sender, EventArgs e)
        {
            openChildForm(new Estoque());
            //..
            //your codes
            //..
            escondeMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
