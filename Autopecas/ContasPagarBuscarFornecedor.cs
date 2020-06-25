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
    public partial class ContasPagarBuscarFornecedor : Form
    {
        ContasPagar instanciaContasPagar;
        MySqlConnection conexao;
        MySqlDataAdapter da;
        string strSQL;
        public ContasPagarBuscarFornecedor(ContasPagar buscar)
        {
            InitializeComponent();
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            instanciaContasPagar = buscar;
        }

        private void atualizaTituloGrid()
        {
            dgvDados.Columns[0].HeaderText = "ID";
            dgvDados.Columns[1].HeaderText = "Nome";
            dgvDados.Columns[2].HeaderText = "Razão Social";
            dgvDados.Columns[3].HeaderText = "CNPJ";
            dgvDados.Columns[4].HeaderText = "IE";
            dgvDados.Columns[5].HeaderText = "CEP";
            dgvDados.Columns[6].HeaderText = "Estado";
            dgvDados.Columns[7].HeaderText = "Cidade";
            dgvDados.Columns[8].HeaderText = "Rua";
            dgvDados.Columns[9].HeaderText = "Número";
            dgvDados.Columns[10].HeaderText = "Bairro";
            dgvDados.Columns[11].HeaderText = "E-mail";
            dgvDados.Columns[12].HeaderText = "Celular";
            dgvDados.Columns[13].HeaderText = "Telefone";
        }

        public void procurarFornecedor(string valorBusca)
        {
            conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");

            if (String.IsNullOrEmpty(valorBusca) == false)
            {
                if (rbNome.Checked)
                {
                    strSQL = "SELECT * FROM FORNECEDORES WHERE nome like '%" + valorBusca + "%'";
                }
                else if (rbCPF.Checked)
                {
                    strSQL = "SELECT * FROM FORNECEDORESWHERE cpfcnpj like '%" + valorBusca + "%'";
                }
                else if (rbTipo.Checked)
                {
                    strSQL = "SELECT * FROM FORNECEDORES WHERE tipo like '%" + valorBusca + "%'";
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
            procurarFornecedor(valorBusca);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count != 0)
            {
                DataGridViewRow dr = dgvDados.SelectedRows[0];
                //Envia os Dados para Contas a Pagar
                instanciaContasPagar.txtFornecedor.Text = dr.Cells[1].Value.ToString();
                Close();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
