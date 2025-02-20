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
    public partial class CadastroFornecedoresBuscar : Form
    {
        CadastroFornecedor instanciaFornecedores;
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public CadastroFornecedoresBuscar(CadastroFornecedor fornecedor)
        {
            InitializeComponent();
            dataGridView_buscaFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            instanciaFornecedores = fornecedor;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_listarTodos_Click(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void atualizaTituloGrid()
        {
            dataGridView_buscaFornecedor.Columns[0].HeaderText = "ID";
            dataGridView_buscaFornecedor.Columns[1].HeaderText = "Nome";
            dataGridView_buscaFornecedor.Columns[2].HeaderText = "Razão Social";
            dataGridView_buscaFornecedor.Columns[3].HeaderText = "CNPJ";
            dataGridView_buscaFornecedor.Columns[4].HeaderText = "IE";
            dataGridView_buscaFornecedor.Columns[5].HeaderText = "CEP";
            dataGridView_buscaFornecedor.Columns[6].HeaderText = "Estado";
            dataGridView_buscaFornecedor.Columns[7].HeaderText = "Cidade";
            dataGridView_buscaFornecedor.Columns[8].HeaderText = "Rua";
            dataGridView_buscaFornecedor.Columns[9].HeaderText = "Número";
            dataGridView_buscaFornecedor.Columns[10].HeaderText = "Bairro";
            dataGridView_buscaFornecedor.Columns[11].HeaderText = "E-mail";
            dataGridView_buscaFornecedor.Columns[12].HeaderText = "Celular";
            dataGridView_buscaFornecedor.Columns[13].HeaderText = "Telefone";
        }

        private void carregaGrid()
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM fornecedores";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_buscaFornecedor.DataSource = dt;
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
                comando = null;

            }
        }

        public void procurarItem(string valorBusca)
        {
            conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");

            if (String.IsNullOrEmpty(valorBusca) == false)
            {

                if (radioButton_filtroNome.Checked)
                {
                    strSQL = "SELECT * FROM FORNECEDORES WHERE nome like '%" + valorBusca + "%'";
                }

                else if (radioButton_filtroDoc.Checked)
                {
                    strSQL = "SELECT * FROM FORNECEDORES WHERE cnpj like '%" + valorBusca + "%'";
                }

                else
                {
                    MessageBox.Show("Selecione um filtro de busca.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                da = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_buscaFornecedor.DataSource = dt;
            }

            else
            {
                MessageBox.Show("O campo de busca está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string valorBusca = textBox_filtroBusca.Text.ToString();
            procurarItem(valorBusca);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView_buscaFornecedor.SelectedRows.Count != 0) 
            { 
                DataGridViewRow dr = dataGridView_buscaFornecedor.SelectedRows[0];
                //Envia os Dados para FornecedorCadastrar
                instanciaFornecedores.idFornecedor = Convert.ToInt32(dr.Cells[0].Value.ToString());
                instanciaFornecedores.txtNome.Text = dr.Cells[1].Value.ToString();
                instanciaFornecedores.txtRSocial.Text = dr.Cells[2].Value.ToString();
                instanciaFornecedores.txtCnpj.Text = dr.Cells[3].Value.ToString();
                instanciaFornecedores.txtIe.Text = dr.Cells[4].Value.ToString();
                instanciaFornecedores.txtCep.Text = dr.Cells[5].Value.ToString();
                instanciaFornecedores.txtEstado.Text = dr.Cells[6].Value.ToString();
                instanciaFornecedores.txtCidade.Text = dr.Cells[7].Value.ToString();
                instanciaFornecedores.txtRua.Text = dr.Cells[8].Value.ToString();
                instanciaFornecedores.txtNumero.Text = dr.Cells[9].Value.ToString();
                instanciaFornecedores.txtBairro.Text = dr.Cells[10].Value.ToString();
                instanciaFornecedores.txtEmail.Text = dr.Cells[11].Value.ToString();
                instanciaFornecedores.txtCelular.Text = dr.Cells[12].Value.ToString();
                instanciaFornecedores.txtTelefone.Text = dr.Cells[13].Value.ToString();
                //Atualiza os Campos e Botões
                instanciaFornecedores.HabilitaCampos();
                instanciaFornecedores.txtNome.Focus();
                instanciaFornecedores.btnSalvar.Enabled = false;
                instanciaFornecedores.btnInserir.Enabled = false;
                Close();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_buscaFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton_filtroDoc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_filtroNome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_filtro_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_filtroBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_listaFornecedores_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_listaProdutos_Enter(object sender, EventArgs e)
        {

        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
