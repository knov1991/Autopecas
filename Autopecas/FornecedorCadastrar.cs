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

        public void AlteraBotao(int op)
        {
            btnInserir.Enabled = false;
            btnLocalizar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

            if(op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if(op == 2)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if(op == 3)
            {
                btnExcluir.Enabled = true;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
            }

        }

        //Função Habilita Campos do Formulário de Fornecedor
        public void HabilitaCampos()
        {
            txtNome.Enabled = true;
            txtRSocial.Enabled = true;
            txtCnpj.Enabled = true;
            txtIe.Enabled = true;
            txtCep.Enabled = true;
            txtEstado.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            txtRua.Enabled = true;
            txtNumero.Enabled = true;
            txtEmail.Enabled = true;
            txtCelular.Enabled = true;
            txtTelefone.Enabled = true;
        }

        //Função Desabilita Campos do Formulário de Fornecedor
        public void DesabilitaCampos()
        {
            txtNome.Enabled = false;
            txtRSocial.Enabled = false;
            txtCnpj.Enabled = false;
            txtIe.Enabled = false;
            txtCep.Enabled = false;
            txtEstado.Enabled = false;
            txtCidade.Enabled = false;
            txtBairro.Enabled = false;
            txtRua.Enabled = false;
            txtNumero.Enabled = false;
            txtEmail.Enabled = false;
            txtCelular.Enabled = false;
            txtTelefone.Enabled = false;
        }

        //Método Limpa Campos do Formulário de Fornecedor
        public void LimpaCampos()
        {
            txtNome.Clear();
            txtRSocial.Clear();
            txtCnpj.Clear();
            txtIe.Clear();
            txtCep.Clear();
            txtEstado.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtEmail.Clear();
            txtCelular.Clear();
            txtTelefone.Clear();
        }


        //Método Load do Formulário de Cadastro de Fornecedor
        private void FornecedorCadastrar_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlteraBotao(1);
        }

        //Método Botão Inserir
        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.txtNome.Focus();
            this.HabilitaCampos();
            this.AlteraBotao(2);
        }

        //Método Botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            this.AlteraBotao(1);
            this.txtNome.Focus();
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
