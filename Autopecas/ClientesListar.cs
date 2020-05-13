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
        MySqlConnection conexao;
        MySqlDataAdapter da;
        string strSQL;

        public ClientesListar()
        {
            InitializeComponent();
            Listar();
        }

        //Fechar a Tela Listar
        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        //Listar os Clientes na Tela de Listar
        private void Listar()
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

        
    }
}
