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
    public partial class ContasReceberBuscaClientes : Form
    {
        ContasReceber instanciaContasReceber;
        MySqlConnection conexao;
        MySqlDataAdapter da;
        string strSQL;
        public ContasReceberBuscaClientes(ContasReceber buscar)
        {
            InitializeComponent();
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            instanciaContasReceber = buscar;
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
            if (dgvDados.SelectedRows.Count != 0)
            {
                DataGridViewRow dr = dgvDados.SelectedRows[0];
                //Envia os Dados para Contas a Receber
                instanciaContasReceber.txtCliente.Text = dr.Cells[1].Value.ToString();
                Close();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
