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
    public partial class ContasReceberListar : Form
    {
        ContasReceber instanciaReceber;
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public int idContasReceber;

        public ContasReceberListar(ContasReceber receber)
        {
            InitializeComponent();
            dataGridView_contasReceber.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            instanciaReceber = receber;
        }


        private void btn_listarTodos_Click(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM CONTASRECEBER";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_contasReceber.DataSource = dt;

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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView_contasReceber.SelectedRows.Count != 0)
            {
                DataGridViewRow dr = dataGridView_contasReceber.SelectedRows[0];
                //Envia os Dados para Contas a Receber
                
                instanciaReceber.idContasReceber = Convert.ToInt32(dr.Cells[0].Value.ToString());
                instanciaReceber.txtCliente.Text = dr.Cells[1].Value.ToString();
                instanciaReceber.txtDataOperacao.Text = dr.Cells[2].Value.ToString();
                instanciaReceber.txtDataVencimento.Text = dr.Cells[3].Value.ToString();
                instanciaReceber.txtNatureza.Text = dr.Cells[4].Value.ToString();
                instanciaReceber.txtValor.Text = dr.Cells[4].Value.ToString();
                Close();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
