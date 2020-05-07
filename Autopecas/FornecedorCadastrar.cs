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
    public partial class FornecedorCadastrar : Form
    {
        public string operacao;


        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public FornecedorCadastrar()
        {
            InitializeComponent();
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
            txtId.Clear();
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
        }

        //Método Botão Inserir
        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.txtNome.Focus();
            this.HabilitaCampos();
        }

        //Método do Botão Localizar Para o Formulário de Listar Fornecedores
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            FornecedorListar f = new FornecedorListar();
            f.ShowDialog();
            f.Dispose();
        }

       //Botão Para Alterar Os Dados
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");

                strSQL = "UPDATE FORNECEDORES SET NOME=@NOME, RSOCIAL=@RSOCIAL, CNPJ=@CNPJ, IE=@IE, CEP=@CEP, ESTADO=@ESTADO, CIDADE=@CIDADE," +
                    "RUA=@RUA, NUMERO=@NUMERO, BAIRRO=@BAIRRO, EMAIL=@EMAIL, CELULAR=@CELULAR, TELEFONE=@TELEFONE WHERE ID=@ID";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", txtId.Text);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@RSOCIAL", txtRSocial.Text);
                comando.Parameters.AddWithValue("@CNPJ", txtCnpj.Text);
                comando.Parameters.AddWithValue("@IE", txtIe.Text);
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
            if (c.campoVazio(txtRSocial, "Razão Social"))
                return;
            if (c.campoVazio(txtCnpj, "CNPJ"))
                return;
            if (c.campoVazio(txtIe, "IE"))
                return;
            if (c.campoVazio(txtCep, "CEP"))
                return;
            if (c.campoVazio(txtBairro, "Bairro"))
                return;
            if (c.campoVazio(txtRua, "Rua"))
                return;
            if (c.campoVazio(txtNumero, "Número"))
                return;
            if (c.campoVazio(txtEmail, "Email"))
                return;
            if (c.campoVazio(txtCelular, "Celular"))
                return;
            if (c.campoVazio(txtTelefone, "Telefone"))
                return;

            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "INSERT INTO FORNECEDORES (NOME, RSOCIAL, CNPJ, IE, CEP, ESTADO, CIDADE, RUA, NUMERO, BAIRRO, EMAIL, CELULAR, TELEFONE) VALUES(@NOME," +
                    " @RSOCIAL, @CNPJ, @IE, @CEP, @ESTADO, @CIDADE, @RUA, @NUMERO, @BAIRRO, @EMAIL, @CELULAR, @TELEFONE)";

               
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                    comando.Parameters.AddWithValue("@RSOCIAL", txtRSocial.Text);
                    comando.Parameters.AddWithValue("@CNPJ", txtCnpj.Text);
                    comando.Parameters.AddWithValue("@IE", txtIe.Text);
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

                strSQL = "DELETE FROM FORNECEDORES WHERE ID=@ID";

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
                MessageBox.Show("Fornecedor excluído");
                conexao = null;
                comando = null;
            }
        }

        //Método Botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
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
                MessageBox.Show(ex.Message, "Foi dectado um erro!");
            }
        }

       

        

        
    }
}
