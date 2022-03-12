using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGM_Desktop2
{
   public class User
    {
      public  string usuario, senha, tipo,idusu;

        conexao c = new conexao();

        public void cadastraUser()
        {

            MySqlCommand cmd = new MySqlCommand();
           cmd.Connection= c.Conecta();
            cmd.CommandText = "insert into mec_tb_usuario ( 	usu_st_login , 	usu_se_senha ,usu_st_tipo,usu_st_status ) values" +
                " ('" + usuario + "','" + senha + "','" + tipo + "','Ativo')";
            cmd.ExecuteNonQuery();
            c.Desconecta();
        }

        public void alterauser() {


            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c.Conecta();
            cmd.CommandText = "update mec_tb_usuario set usu_st_login = '" + usuario + "', 	usu_se_senha = '" + senha + "', usu_st_tipo = '" + tipo + "' where usu_in_codigo= '"+idusu+"'" ;
            cmd.ExecuteNonQuery();
            c.Desconecta();


        }



        public void deletaUsuario() {


            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = c.Conecta();
           cmd3.CommandText = "update mec_tb_usuario set  usu_st_status = 'Desativado' where usu_in_codigo =  " + idusu + "";
            cmd3.ExecuteNonQuery();
            c.Desconecta();
        }




    }
}
