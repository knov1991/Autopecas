﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Autopecas
{
    public partial class CadastroClientes : Form
    {
        public string operacao;
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public int idCliente;
        bool cnpjCheck = false;
        public CadastroClientes()
        {
            InitializeComponent();
        }


        //Função Habilita Campos do Formulário de Fornecedor
        public void HabilitaCampos()
        {
            rbTipo.Enabled = true;
            txtNome.Enabled = true;
            txtRSocial.Enabled = true;
            txtCPFCNPJ.Enabled = true;
            txtRGIE.Enabled = true;
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
            rbTipo.Enabled = false;
            txtNome.Enabled = false;
            txtRSocial.Enabled = false;
            txtCPFCNPJ.Enabled = false;
            txtRGIE.Enabled = false;
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

        //Habilita Botões do Formulário
        public void HabilitaBotoes()
        {
            btnAlterar.Enabled = true;
            btnLocalizar.Enabled = true;
            btnSalvar.Enabled = true;
            btnInserir.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //Método Limpa Campos do Formulário de Clientes
        public void LimpaCampos()
        {
            idCliente = 0;
            txtNome.Clear();
            txtRSocial.Clear();
            txtCPFCNPJ.Clear();
            txtRGIE.Clear();
            txtCep.Clear();
            txtEstado.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtEmail.Clear();
            txtCelular.Clear();
            txtTelefone.Clear();
            rbFisico.Checked = true;
        }

        //Método Load do Formulário de Cadastro de Clientes
        private void Clientes_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
        }

        //Método Botão Inserir
        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.HabilitaCampos();
            this.txtNome.Focus();
            this.btnInserir.Enabled = false;
            this.btnLocalizar.Enabled = false;
            this.btnAlterar.Enabled = false;
            this.btnExcluir.Enabled = false;
        }

        //Método do Botão Localizar Para o Formulário de Listar Clientes
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            CadastroClientesBuscar c = new CadastroClientesBuscar(this);
            c.ShowDialog();
        }

        //Botão Para Alterar Os Dados
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");

                strSQL = "UPDATE CLIENTES SET NOME=@NOME, RSOCIAL=@RSOCIAL, TIPO=@TIPO, CPFCNPJ=@CPFCNPJ, RGIE=@RGIE, CEP=@CEP, ESTADO=@ESTADO, CIDADE=@CIDADE," +
                    "RUA=@RUA, NUMERO=@NUMERO, BAIRRO=@BAIRRO, EMAIL=@EMAIL, CELULAR=@CELULAR, TELEFONE=@TELEFONE WHERE ID=@ID";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", idCliente);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@RSOCIAL", txtRSocial.Text);
                comando.Parameters.AddWithValue("@TIPO", rbTipo.Text);
                comando.Parameters.AddWithValue("@CPFCNPJ", txtCPFCNPJ.Text);
                comando.Parameters.AddWithValue("@RGIE", txtRGIE.Text);
                comando.Parameters.AddWithValue("@CEP", txtCep.Text);
                comando.Parameters.AddWithValue("@ESTADO", txtEstado.Text);
                comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                comando.Parameters.AddWithValue("@RUA", txtRua.Text);
                comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text);
                comando.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                comando.Parameters.AddWithValue("@CELULAR", txtCelular.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                MessageBox.Show("Alterado com sucesso!");
                this.LimpaCampos();
                this.txtNome.Focus();
                conexao = null;
                comando = null;

            }
        }

        //Botão Para Salvar Os Dados
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Verificação se tem algum campo vazio
            ControlesGerais c = new ControlesGerais();
            if (c.campoVazio(txtNome, "Nome"))
                return;
            if (c.campoVazio(txtCep, "CEP"))
                return;
            if (c.campoVazio(txtCelular, "Celular"))
                return;
            if (c.campoVazio(txtTelefone, "Telefone"))
                return;


            //CLIENTE JURIDICO
            if(rbJuridico.Checked == true)
            {
                if (ValidaCNPJ() == true)
                {
                    if (cnpjCheck == true)
                    {
                        try
                        {
                            conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                            strSQL = "INSERT INTO CLIENTES (NOME, RSOCIAL, TIPO, CPFCNPJ, RGIE, CEP, ESTADO, CIDADE, RUA, NUMERO, BAIRRO, EMAIL, CELULAR, TELEFONE) VALUES(@NOME," +
                                " @RSOCIAL, @TIPO, @CPFCNPJ, @RGIE, @CEP, @ESTADO, @CIDADE, @RUA, @NUMERO, @BAIRRO, @EMAIL, @CELULAR, @TELEFONE)";


                            comando = new MySqlCommand(strSQL, conexao);
                            comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                            comando.Parameters.AddWithValue("@RSOCIAL", txtRSocial.Text);
                            if (rbFisico.Checked == true)
                            {
                                comando.Parameters.AddWithValue("@TIPO", rbFisico.Text);
                            }
                            else
                            {
                                comando.Parameters.AddWithValue("@TIPO", rbJuridico.Text);
                            }
                            comando.Parameters.AddWithValue("@CPFCNPJ", txtCPFCNPJ.Text);
                            comando.Parameters.AddWithValue("@RGIE", txtRGIE.Text);
                            comando.Parameters.AddWithValue("@CEP", txtCep.Text);
                            comando.Parameters.AddWithValue("@ESTADO", txtEstado.Text);
                            comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                            comando.Parameters.AddWithValue("@RUA", txtRua.Text);
                            comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text);
                            comando.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                            comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                            comando.Parameters.AddWithValue("@CELULAR", txtCelular.Text);
                            comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);

                            conexao.Open();

                            comando.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            conexao.Close();
                            MessageBox.Show("Cadastrado com sucesso", "", MessageBoxButtons.OK);
                            this.LimpaCampos();
                            this.txtNome.Focus();
                            conexao = null;
                            comando = null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("CNPJ Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //CLIENTE FISICO
            else if(rbFisico.Checked == true)
            {
                if(validaCPF() == true)
                {
                    if(cnpjCheck == true) {
                        try
                        {
                            conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                            strSQL = "INSERT INTO CLIENTES (NOME, RSOCIAL, TIPO, CPFCNPJ, RGIE, CEP, ESTADO, CIDADE, RUA, NUMERO, BAIRRO, EMAIL, CELULAR, TELEFONE) VALUES(@NOME," +
                                " @RSOCIAL, @TIPO, @CPFCNPJ, @RGIE, @CEP, @ESTADO, @CIDADE, @RUA, @NUMERO, @BAIRRO, @EMAIL, @CELULAR, @TELEFONE)";


                            comando = new MySqlCommand(strSQL, conexao);
                            comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                            comando.Parameters.AddWithValue("@RSOCIAL", txtRSocial.Text);
                            if (rbFisico.Checked == true)
                            {
                                comando.Parameters.AddWithValue("@TIPO", rbFisico.Text);
                            }
                            else
                            {
                                comando.Parameters.AddWithValue("@TIPO", rbJuridico.Text);
                            }
                            comando.Parameters.AddWithValue("@CPFCNPJ", txtCPFCNPJ.Text);
                            comando.Parameters.AddWithValue("@RGIE", txtRGIE.Text);
                            comando.Parameters.AddWithValue("@CEP", txtCep.Text);
                            comando.Parameters.AddWithValue("@ESTADO", txtEstado.Text);
                            comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                            comando.Parameters.AddWithValue("@RUA", txtRua.Text);
                            comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text);
                            comando.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                            comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                            comando.Parameters.AddWithValue("@CELULAR", txtCelular.Text);
                            comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);

                            conexao.Open();

                            comando.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            conexao.Close();
                            MessageBox.Show("Cadastrado com sucesso", "", MessageBoxButtons.OK);
                            this.LimpaCampos();
                            this.txtNome.Focus();
                            conexao = null;
                            comando = null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("CPF Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        //Método Para Excluir Os Dados
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");

                strSQL = "DELETE FROM CLIENTES WHERE ID=@ID";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", idCliente);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                MessageBox.Show("Cliente excluído");
                this.LimpaCampos();
                this.txtNome.Focus();
                conexao = null;
                comando = null;
            }
        }

        //Método Botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            this.DesabilitaCampos();
            this.HabilitaBotoes();
        }

        //NÚMERO MÁXIMO DE CARACTERES PARA O CPF/CNPJ
        private void txtCPFCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(rbFisico.Checked == true)
            {
                if (char.IsNumber(e.KeyChar) == true)
                {
                    txtCPFCNPJ.MaxLength = 14;
                    switch (txtCPFCNPJ.TextLength)
                    {
                        case 0:
                            txtCPFCNPJ.Text = "";
                            break;

                        case 3:
                            txtCPFCNPJ.Text = txtCPFCNPJ.Text + ".";
                            txtCPFCNPJ.SelectionStart = 5;
                            break;

                        case 7:
                            txtCPFCNPJ.Text = txtCPFCNPJ.Text + ".";
                            txtCPFCNPJ.SelectionStart = 9;
                            break;

                        case 11:
                            txtCPFCNPJ.Text = txtCPFCNPJ.Text + "-";
                            txtCPFCNPJ.SelectionStart = 14;
                            break;

                    }
                }
            }
            else if(rbJuridico.Checked == true){
                if (char.IsNumber(e.KeyChar) == true)
                {
                    txtCPFCNPJ.MaxLength = 19;
                    switch (txtCPFCNPJ.TextLength)
                    {
                        case 0:
                            txtCPFCNPJ.Text = "";
                            break;

                        case 3:
                            txtCPFCNPJ.Text = txtCPFCNPJ.Text + ".";
                            txtCPFCNPJ.SelectionStart = 4;
                            break;

                        case 7:
                            txtCPFCNPJ.Text = txtCPFCNPJ.Text + ".";
                            txtCPFCNPJ.SelectionStart = 9;
                            break;

                        case 11:
                            txtCPFCNPJ.Text = txtCPFCNPJ.Text + "-";
                            txtCPFCNPJ.SelectionStart = 14;
                            break;

                    }
                }
            }
        }

        //NÚMERO MÁXIMO DE CARACTERES PARA O RG/IE
        private void txtRGIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(rbFisico.Checked == true)
            {
                if(char.IsNumber(e.KeyChar) == true)
                {
                    txtRGIE.MaxLength = 12;
                    switch (txtRGIE.TextLength)
                    {
                        case 0:
                            txtRGIE.Text = "";
                            break;
                        case 2:
                            txtRGIE.Text = txtRGIE.Text + ".";
                            txtRGIE.SelectionStart = 4;
                            break;
                        case 6:
                            txtRGIE.Text = txtRGIE.Text + ".";
                            txtRGIE.SelectionStart = 9;
                            break;
                        case 10:
                            txtRGIE.Text = txtRGIE.Text + "-";
                            txtRGIE.SelectionStart = 11;
                            break;
                    }
                }
            }
            else if(rbJuridico.Checked == true)
            {
                if(char.IsNumber(e.KeyChar) == true)
                {
                    txtRGIE.MaxLength = 11;
                    switch (txtRGIE.TextLength)
                    {
                    case 0:
                        txtRGIE.Text = "";
                        break;
                    case 8:
                        txtRGIE.Text = txtRGIE.Text + "-";
                        txtRGIE.SelectionStart = 10;
                        break;
                    }
                }
            }
        }

        //Número Máximo de Caracteres Para o CEP
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

        //Validaão do CEP
        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCep.Text);
                ds.ReadXml(xml);

                txtEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Número Máximo de Caracteres do Celular
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCelular.TextLength)
                {
                    case 0:
                        txtCelular.Text = txtCelular.Text + "(";
                        txtCelular.SelectionStart = txtCelular.Text.Length + 1;
                        break;
                    case 3:
                        txtCelular.Text = txtCelular.Text + ")";
                        txtCelular.SelectionStart = txtCelular.Text.Length + 1;
                        break;
                    case 9:
                        txtCelular.Text = txtCelular.Text + "-";
                        txtCelular.SelectionStart = txtCelular.Text.Length + 1;
                        break;
                }
            }
        }
        //Número Máximo de Caracteres do Telefone
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtTelefone.TextLength)
                {
                    case 0:
                        txtTelefone.Text = txtTelefone.Text + "(";
                        txtTelefone.SelectionStart = txtTelefone.Text.Length + 1;
                        break;
                    case 3:
                        txtTelefone.Text = txtTelefone.Text + ")";
                        txtTelefone.SelectionStart = txtTelefone.Text.Length + 1;
                        break;
                    case 9:
                        txtTelefone.Text = txtTelefone.Text + "-";
                        txtTelefone.SelectionStart = txtTelefone.Text.Length + 1;
                        break;
                }
            }
        }

        //Método Para Colocar e Tirar o TxtRSocial
        private void rbFisico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisico.Checked == true)
            {
                lbRSocial.Visible = false;
                txtRSocial.Visible = false;
                lbCPFCNPJ.Text = "CPF";
                lbRGIE.Text = "RG";
            }
            else
            {
                lbRSocial.Visible = true;
                txtRSocial.Visible = true;
                lbCPFCNPJ.Text = "CNPJ";
                lbRGIE.Text = "IE";
            }
        }

        //Evento de Foco Para o Nome ao Selecionar Cliente Jurídico
        private void rbJuridico_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        public bool ValidaCNPJ()
        {
            try
            {
                if (!(txtCPFCNPJ.Text.Length < 18))
                {
                    int n1 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(0, 1));
                    int n2 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(1, 1));
                    int n3 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(3, 1));
                    int n4 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(4, 1));
                    int n5 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(5, 1));
                    int n6 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(7, 1));
                    int n7 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(8, 1));
                    int n8 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(9, 1));
                    int n9 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(11, 1));
                    int n10 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(12, 1));
                    int n11 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(13, 1));
                    int n12 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(14, 1));

                    int digito1 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(16, 1));
                    int digito2 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(17, 1));

                    int Soma1 = n1 * 5 + n2 * 4 + n3 * 3 + n4 * 2 + n5 * 9 + n6 * 8 + n7 * 7 + n8 * 6 + n9 * 5 + n10 * 4 + n11 * 3 + n12 * 2;

                    int DigitoVerificador1 = Soma1 % 11;

                    if (DigitoVerificador1 < 2)
                    {
                        DigitoVerificador1 = 0;
                    }
                    else
                    {
                        DigitoVerificador1 = 11 - DigitoVerificador1;
                    }
                    int Soma2 = n1 * 6 + n2 * 5 + n3 * 4 + n4 * 3 + n5 * 2 + n6 * 9 + n7 * 8 + n8 * 7 + n9 * 6 + n10 * 5 + n11 * 4 + n12 * 3 + DigitoVerificador1 * 2;

                    int DigitoVereificador2 = Soma2 % 11;
                    if (DigitoVereificador2 < 2)
                    {
                        DigitoVereificador2 = 0;
                    }
                    else
                    {
                        DigitoVereificador2 = 11 - DigitoVereificador2;
                    }

                    if (digito1 == DigitoVerificador1 && digito2 == DigitoVereificador2)
                    {
                        cnpjCheck = true;
                        return true;
                    }
                    else
                    {
                        cnpjCheck = false;
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        bool validaCPF()
        {
            try
            {
                if (txtCPFCNPJ.Text.Length == 14)
                {
                    int n1 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(0, 1));
                    int n2 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(1, 1));
                    int n3 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(2, 1));
                    int n4 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(4, 1));
                    int n5 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(5, 1));
                    int n6 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(6, 1));
                    int n7 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(8, 1));
                    int n8 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(9, 1));
                    int n9 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(10, 1));

                    int n10 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(12, 1));
                    int n11 = Convert.ToInt16(txtCPFCNPJ.Text.Substring(13, 1));


                    //Se todos os números forem iguais, irá burlar o validador, e retornar true
                    if (n1 == n2 && n2 == n3 && n3 == n4 && n4 == n5 && n5 == n6 && n6 == n7 && n7 == n8 && n8 == n9)
                    {
                        return false;
                    }

                    //Somar todos o números multiplicados
                    int Soma1 = n1 * 10 + n2 * 9 + n3 * 8 + n4 * 7 + n5 * 6 + n6 * 5 + n7 * 4 + n8 * 3 + n9 * 2;

                    //Dividir por 11 e retornar o resto da divisão
                    int digitoVerificador1 = Soma1 % 11;

                    //verificar se o valor obtido é menor que 2 ou maior 
                    if (digitoVerificador1 < 2)
                    {
                        digitoVerificador1 = 0;
                    }
                    else
                    {
                        digitoVerificador1 = 11 - digitoVerificador1;
                    }

                    //Soma todos os números mutiplicados
                    int Soma2 = n1 * 11 + n2 * 10 + n3 * 9 + n4 * 8 + n5 * 7 + n6 * 6 + n7 * 5 + n8 * 4 + n9 * 3 + digitoVerificador1 * 2;

                    //Dividir por 11 e retornar o resto da divisão 
                    int digitoVerificador2 = Soma2 % 11;

                    //verificar se o valor obtido é menor ou maior que 2
                    if (digitoVerificador2 < 2)
                    {
                        digitoVerificador2 = 0;
                    }
                    else
                    {
                        digitoVerificador2 = 11 - digitoVerificador2;
                    }

                    //Verifica se os dois digítos são iguais aos do CPF digitando na txt
                    if (digitoVerificador1 == n10 && digitoVerificador2 == n11)
                    {
                        cnpjCheck = true;
                        return true;
                    }
                    else
                    {
                        cnpjCheck = false;
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            } 
        }
    }
}
