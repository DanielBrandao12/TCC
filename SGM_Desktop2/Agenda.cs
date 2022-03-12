using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SGM_Desktop2
{
   public class Agenda
    {
        conexao con = new conexao();

        public string IdAgenda;
        public string idClien;
        public string IdUsuario;
        public string nome;
        public string contato;
        public string Data;
        public string Hora;
        public string descricao;
        public string atribuir;

        public void agenCliente()
        {
            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = con.Conecta();


            cmd3.CommandText = "INSERT INTO mec_tb_agenda (Pes_in_codigo,usu_in_codigo,agen_dt_data,agen_tm_hora ,agen_st_descricao,agen_st_nome,agen_in_contato,agen_in_funcionario)  VALUES ('" + idClien + "','" + IdUsuario + "',@data,'" + Hora + "','" + descricao + "','"+ nome + "','"+ contato + "','"+ atribuir + "')";

            cmd3.Parameters.AddWithValue("data", DateTime.Parse(Data).ToString("yyyy-MM-dd"));
            cmd3.ExecuteNonQuery();
            con.Desconecta();


        }

        public void desmarcar()
        {

            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = con.Conecta();

            cmd3.CommandText = "delete from mec_tb_agenda  where agen_in_codigo =  '" + IdAgenda + "'";
            cmd3.ExecuteNonQuery();
            con.Desconecta();

        }



    }
}
