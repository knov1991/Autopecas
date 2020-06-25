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
    public partial class GerenciarEstoqueRelatorio : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public GerenciarEstoqueRelatorio()
        {
            InitializeComponent();
            atualizaDatePicker();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void atualizaDatePicker()
        {
            DateTime date = DateTime.Now;
            filtroData.Value = date;
        }

        private void atualizaTituloGrid()
        {
            dataGridView_relatorios.Columns["id"].Visible = false;
            dataGridView_relatorios.Columns[1].HeaderText = "Produto";
            dataGridView_relatorios.Columns[2].HeaderText = "Fornecedor";
            dataGridView_relatorios.Columns[3].HeaderText = "Motivo";
            dataGridView_relatorios.Columns[4].HeaderText = "Tipo";
            dataGridView_relatorios.Columns[5].HeaderText = "Quantidade";
            dataGridView_relatorios.Columns[6].HeaderText = "Data do Movimento";
        }

        private void carregaGrid()
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM RELATORIOESTOQUE";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_relatorios.DataSource = dt;
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
        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtroBusca();
    
        }

        private void filtroBusca()
        {
            try
            {
                DateTime MinhaData = DateTime.Parse(filtroData.Text);


                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM RELATORIOESTOQUE WHERE DATAMOV='"+ MinhaData.ToString("yyyy-MM-dd") + "'";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_relatorios.DataSource = dt;
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
    }
}
