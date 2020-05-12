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
    class Conectar
    {
        public static void ConectarMysql()
        {
            MySqlConnection connection;
            try
            {
                connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //Home.labelConectar.Text = "Conectado!";
                    //Home.labelConectar.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
