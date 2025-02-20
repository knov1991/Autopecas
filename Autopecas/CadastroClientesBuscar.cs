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
    public partial class CadastroClientesBuscar : Form
    {
        CadastroClientes instanciaClientes;
        MySqlConnection conexao;
        MySqlDataAdapter da;
        string strSQL;

        public CadastroClientesBuscar(CadastroClientes cliente)
        {
            InitializeComponent();
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            instanciaClientes = cliente;
        }

        //Fechar a Tela Listar
        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void atualizaTituloGrid()
        {
            dgvDados.Columns[0].HeaderText = "ID";
            dgvDados.Columns[1].HeaderText = "Nome";
            dgvDados.Columns[2].HeaderText = "Razão Social";
            dgvDados.Columns[3].HeaderText = "Tipo";
            dgvDados.Columns[4].HeaderText = "CPF/CNPJ";
            dgvDados.Columns[5].HeaderText = "RG/IE";
            dgvDados.Columns[6].HeaderText = "CEP";
            dgvDados.Columns[7].HeaderText = "Estado";
            dgvDados.Columns[8].HeaderText = "Cidade";
            dgvDados.Columns[9].HeaderText = "Rua";
            dgvDados.Columns[10].HeaderText = "Número";
            dgvDados.Columns[11].HeaderText = "Bairro";
            dgvDados.Columns[12].HeaderText = "E-mail";
            dgvDados.Columns[13].HeaderText = "Celular";
            dgvDados.Columns[14].HeaderText = "Telefone";
        }


        private void carregaGrid()
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM CLIENTES";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvDados.DataSource = dt;
                atualizaTituloGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
            }
        }

        public void procurarCliente(string valorBusca)
        {
            conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");

            if (String.IsNullOrEmpty(valorBusca) == false)
            {
                if (rbNome.Checked)
                {
                    strSQL = "SELECT * FROM CLIENTES WHERE nome like '%" + valorBusca + "%'";
                }
                else if (rbCPF.Checked)
                {
                    strSQL = "SELECT * FROM CLIENTES WHERE cpfcnpj like '%" + valorBusca + "%'";
                }
                else if (rbTipo.Checked)
                {
                    strSQL = "SELECT * FROM CLIENTES WHERE tipo like '%" + valorBusca + "%'";
                }
                else
                {
                    MessageBox.Show("Selecione um filtro de busca.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                da = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvDados.DataSource = dt;
                atualizaTituloGrid();
            }
            else
            {
                MessageBox.Show("O campo de busca está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valorBusca = txtBusca.Text.ToString();
            procurarCliente(valorBusca);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dgvDados.SelectedRows.Count != 0)
            {
                DataGridViewRow dr = dgvDados.SelectedRows[0];
                //Envia os Dados para Clientes_Cadastrar
                instanciaClientes.idCliente = Convert.ToInt32(dr.Cells[0].Value.ToString());
                instanciaClientes.txtNome.Text = dr.Cells[1].Value.ToString();
                instanciaClientes.txtRSocial.Text = dr.Cells[2].Value.ToString();
                instanciaClientes.txtCPFCNPJ.Text = dr.Cells[3].Value.ToString();
                instanciaClientes.txtRGIE.Text = dr.Cells[4].Value.ToString();
                instanciaClientes.txtCep.Text = dr.Cells[5].Value.ToString();
                instanciaClientes.txtEstado.Text = dr.Cells[6].Value.ToString();
                instanciaClientes.txtCidade.Text = dr.Cells[7].Value.ToString();
                instanciaClientes.txtRua.Text = dr.Cells[8].Value.ToString();
                instanciaClientes.txtNumero.Text = dr.Cells[9].Value.ToString();
                instanciaClientes.txtBairro.Text = dr.Cells[10].Value.ToString();
                instanciaClientes.txtEmail.Text = dr.Cells[11].Value.ToString();
                instanciaClientes.txtCelular.Text = dr.Cells[12].Value.ToString();
                instanciaClientes.txtTelefone.Text = dr.Cells[13].Value.ToString();
                //Atualiza os Campos e Botões
                instanciaClientes.HabilitaCampos();
                instanciaClientes.txtNome.Focus();
                instanciaClientes.btnSalvar.Enabled = false;
                instanciaClientes.btnInserir.Enabled = false;
                Close();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
