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
    public partial class FornecedorCadastrar : Form
    {
        public FornecedorCadastrar()
        {
            InitializeComponent();
        }

        //NÚMERO MÁXIMO DE CARACTERES PARA O CNPJ
        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCnpj.TextLength)
                {
                    case 0:
                        txtCnpj.Text = "";
                        break;
                    case 2:
                        txtCnpj.Text = txtCnpj.Text + ".";
                        txtCnpj.SelectionStart = 4;
                        break;
                    case 6:
                        txtCnpj.Text = txtCnpj.Text + ".";
                        txtCnpj.SelectionStart = 8;
                        break;
                    case 10:
                        txtCnpj.Text = txtCnpj.Text + "/";
                        txtCnpj.SelectionStart = 14;
                        break;
                    case 15:
                        txtCnpj.Text = txtCnpj.Text + "-";
                        txtCnpj.SelectionStart = 18;
                        break;
                }
            }
        }

        //NÚMERO MÁXIMO DE CARACTERES PARA O IE
        private void txtIe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtIe.TextLength)
                {
                    case 0:
                        txtIe.Text = "";
                        break;
                    case 8:
                        txtIe.Text = txtIe.Text + "-";
                        txtIe.SelectionStart = 10;
                        break;
                }
            }
        }

        //NÚMERO MÁXIMO DE CARACTERES PARA O CEP
        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCep.TextLength)
                {
                    case 0:
                        txtCep.Text = "";
                        break;
                    case 5:
                        txtCep.Text = txtCep.Text + "-";
                        txtCep.SelectionStart = 7;
                        break;
                }
            }
        }
    }
}
