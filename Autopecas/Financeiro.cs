using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Autopecas
{
    public partial class Financeiro : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Financeiro()
        {
            InitializeComponent();
        }

        private void Financeiro_Load(object sender, EventArgs e)
        {
            atualizaDados();
            carregaGrid();
            totalMov();
        }

        private void atualizaDados()
        {
            DateTime data = DateTime.Now;
            labelDataInicio.Text = data.ToString("dd-MM-yyyy");
            filtroDataInicio.Value = data;
            labelDataFinal.Text = data.ToString("dd-MM-yyyy");
            filtroDataFinal.Value = data;

        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            ContasReceber Receber = new ContasReceber();
            Receber.Show();
        }

        private void btnContasPagar_Click(object sender, EventArgs e)
        {
            ContasPagar Pagar = new ContasPagar();
            Pagar.Show();
        }

        private void carregaGrid()
        {
            try
            {
                DateTime data = DateTime.Now;

                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM VENDAS WHERE DATAVENDA= '" + data.ToString("yyyy-MM-dd") + "'";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_totalVendas.DataSource = dt;
                atualizaTituloGrid();
                totalMov();

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

        private void filtroBusca()
        {
            try
            {
                DateTime DataInicio = DateTime.Parse(filtroDataInicio.Text);
                DateTime DataFinal = DateTime.Parse(filtroDataFinal.Text);

                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM VENDAS WHERE DATAVENDA BETWEEN '" + DataInicio.ToString("yyyy-MM-dd") + "' AND '" + DataFinal.ToString("yyyy-MM-dd") + "'";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView_totalVendas.DataSource = dt;
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
        private decimal Total()
        {
            decimal subTotal = 0;
            int i = 0;
            for (i = 0; i < dataGridView_totalVendas.Rows.Count; i++)
            {
                subTotal =  subTotal + Convert.ToDecimal(dataGridView_totalVendas.Rows[i].Cells["valorTotal"].Value);
            }
            return subTotal;
        }

        private void totalMov()
        {
            if (dataGridView_totalVendas.Rows.Count > 0)
                TotalDiario.Text = Total().ToString("C2");
        }

        private void atualizaTituloGrid()
        {
            dataGridView_totalVendas.Columns["idVendas"].Visible = false;
            dataGridView_totalVendas.Columns[1].HeaderText = "Produto";
            dataGridView_totalVendas.Columns[2].HeaderText = "Quantidade";
            dataGridView_totalVendas.Columns[3].HeaderText = "Valor do Produto";
            dataGridView_totalVendas.Columns[4].HeaderText = "Valor Total";
            dataGridView_totalVendas.Columns["formaPagamento"].Visible = false;
            dataGridView_totalVendas.Columns["parcelado"].Visible = false;
            dataGridView_totalVendas.Columns[7].HeaderText = "Data da Venda";

        }

        private void atualizaValores()
        {
            TotalDiario.Text = "R$ 0,00";
            totalMov();
        }

        private void dataInicio_ValueChanged(object sender, EventArgs e)
        {
            filtroBusca();
            atualizaValores();
            labelDataInicio.Text = filtroDataInicio.Text;
            filtroDataFinal.Value = filtroDataInicio.Value;
        }

        private void dataFinal_ValueChanged(object sender, EventArgs e)
        {
            filtroBusca();
            atualizaValores();
            labelDataFinal.Text = filtroDataFinal.Text;
        }
    }
}
