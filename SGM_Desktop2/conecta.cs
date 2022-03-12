using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SGM_Desktop2
{
    public class conecta
    {
      string con = "server=localhost;port=3306;user id=root;database=mecanica;password=";
        MySqlConnection conectar = null;
        MySqlCommand comando = null;

        public void conexao()
        {
            try
            {
                conectar = new MySqlConnection(con);
                conectar.Open();
                System.Windows.Forms.MessageBox.Show("conectado");

            }
            catch(Exception error)
            {
                throw error;


            }
            finally
            {
                conectar.Close();
            }

        }

    





    }
}
