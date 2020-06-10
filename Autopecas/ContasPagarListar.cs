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
    public partial class ContasPagarListar : Form
    {
        ContasPagar instanciaPagar;
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public ContasPagarListar(ContasPagar pagar)
        {
            InitializeComponent();
            dataGridView_buscaFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            instanciaPagar = pagar;
        }

        private void label_listaFornecedores_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_filtro_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox_listaProdutos_Enter(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_buscaFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_listarTodos_Click_1(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM CONTASPAGAR";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_buscaFornecedor.DataSource = dt;

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

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
