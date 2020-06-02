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
    public partial class ClientesListar : Form
    {
        ClientesListar instanciaClientes;
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public ClientesListar()
        {
            InitializeComponent();
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                else if (rbRSocial.Checked)
                {
                    strSQL = "SELECT * FROM CLIENTES WHERE rsocial like '%" + valorBusca + "%'";
                }
                else
                {
                    MessageBox.Show("Selecione um filtro de busca.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                da = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvDados.DataSource = dt;
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
    }
}
