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
    public partial class ContasPagar : Form

    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public ContasPagar()
        {
            InitializeComponent();
        }

       

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ContasPagarListar Pagar = new ContasPagarListar(this);
            Pagar.Show();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "INSERT INTO CONTASPAGAR (FORNECEDOR, DATAOPERACAO, DATAVENCIMENTO, NATUREZA, VALOR) VALUES(@FORNECEDOR, @DATAOPERACAO, @DATAVENCIMENTO, @NATUREZA, @VALOR)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@FORNECEDOR", txtFornecedor.Text);
                comando.Parameters.AddWithValue("@DATAOPERACAO", txtDataOperacao.Text);
                comando.Parameters.AddWithValue("@DATAVENCIMENTO", txtDataVencimento.Text);
                comando.Parameters.AddWithValue("@NATUREZA", txtNatureza.Text);
                comando.Parameters.AddWithValue("@VALOR", txtValor.Text);


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
                conexao = null;
                comando = null;

            }
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "UPDATE CONTASPAGAR SET FORNECEDOR = @FORNECEDOR, DATAOPERACAO = @DATAOPERACAO, DATAVENCIMENTO = @QDATAVENCIMENTO, NATUREZA = @NATUREZA WHERE ID = @ID ";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtId.Text);
                comando.Parameters.AddWithValue("@FORNECEDOR", txtFornecedor.Text);
                comando.Parameters.AddWithValue("@DATAOPERACAO", txtDataOperacao.Text);
                comando.Parameters.AddWithValue("@DATAVENCIMENTO", txtDataVencimento.Text);
                comando.Parameters.AddWithValue("@NATUREZA", txtNatureza.Text);


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
                conexao = null;
                comando = null;

            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "DELETE FROM CONTASPAGAR WHERE ID = @ID ";
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
                conexao = null;
                comando = null;

            }
        }

        private void txtConsultar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("SERVER=localhost; DATABASE=piii; UID=root; PWD=root");
                strSQL = "SELECT * FROM CONTASPAGAR WHERE ID = @ID ";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtId.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtFornecedor.Text = Convert.ToString(dr["fornecedor"]);
                    txtDataOperacao.Text = Convert.ToString(dr["DataOperacao"]);
                    txtDataVencimento.Text = Convert.ToString(dr["DataVencimento"]);
                    txtNatureza.Text = Convert.ToString(dr["natureza"]);
                    txtValor.Text = Convert.ToString(dr["valor"]);


                }

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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ContasPagarBuscarFornecedor BuscarFornecedor = new ContasPagarBuscarFornecedor(this);
            BuscarFornecedor.Show();
        }
    }
}

