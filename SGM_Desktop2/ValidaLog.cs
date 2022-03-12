using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SGM_Desktop2
{
    class ValidaLog
    {
        public string usuario, senha,user;
        public bool Tem;
        public string mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        conexao c = new conexao();

        public bool Verifica(string usuario, string senha)
        {

            cmd.CommandText = "SELECT * FROM mec_tb_usuario WHERE usu_st_login ='" + usuario + "'AND usu_se_senha = '" + senha + "' ";




            try
            {
               
                cmd.Connection = c.Conecta();
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    user = dr.GetString("usu_st_login");
                    Tem = true;

                }

            }
            catch (MySqlException)
            {
                this.mensagem = "Verifique sua Conexão";
            }



            return Tem;


        }



    }
}
