using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SGM_Desktop2
{
    class conexao
    {
     
        MySqlConnection cone = new MySqlConnection();

        public  MySqlConnection Conecta()
        {
        cone.ConnectionString = "server=localhost;port=3306;user id=root;database=mecanica;password=;";

        
                if (cone.State == System.Data.ConnectionState.Closed)
                {
                    cone.Open();

                }
           
                return cone;
          
           
          
        }

        public MySqlConnection Desconecta()
        {
            if (cone.State == System.Data.ConnectionState.Open)
            {
                cone.Close();
            }
            return cone;
        }




    }
}
