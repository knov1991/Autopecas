using System;
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
    public partial class Clientes : Form
    {
        public string operacao;


        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;

        public Clientes()
        {
            InitializeComponent();
        }


        //Função Habilita Campos do Formulário de Fornecedor
        public void HabilitaCampos()
        {
            rbTipo.Enabled = true;
            txtId.Enabled = true;
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
            txtId.Enabled = false;
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

        //Método Limpa Campos do Formulário de Fornecedor
        public void LimpaCampos()
        {
            txtId.Clear();
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
        }

        //Método do Botão Localizar Para o Formulário de Listar Clientes
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ClientesListar c = new ClientesListar();
            c.ShowDialog();
            c.Dispose();
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

                comando.Parameters.AddWithValue("@ID", txtId.Text);
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
            /*ControlesGerais c = new ControlesGerais();
            if (c.campoVazio(txtNome, "Nome"))
                return;
            if (c.campoVazio(txtCep, "CEP"))
                return;
            if (c.campoVazio(txtCelular, "Celular"))
                return;
            if (c.campoVazio(txtTelefone, "Telefone"))
                return;*/

            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "INSERT INTO CLIENTES (NOME, RSOCIAL, TIPO, CPFCNPJ, RGIE, CEP, ESTADO, CIDADE, RUA, NUMERO, BAIRRO, EMAIL, CELULAR, TELEFONE) VALUES(@NOME," +
                    " @RSOCIAL, @TIPO, @CPFCNPJ, @RGIE, @CEP, @ESTADO, @CIDADE, @RUA, @NUMERO, @BAIRRO, @EMAIL, @CELULAR, @TELEFONE)";


                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@RSOCIAL", txtRSocial.Text);
                if(rbFisico.Checked == true)
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
                MessageBox.Show("Cadastro feito com sucesso.");
                this.LimpaCampos();
                this.txtNome.Focus();
                conexao = null;
                comando = null;
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

                comando.Parameters.AddWithValue("@ID", txtId.Text);

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
        }

        //NÚMERO MÁXIMO DE CARACTERES PARA O CPF/CNPJ
        private void txtCPFCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
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
    }
}
