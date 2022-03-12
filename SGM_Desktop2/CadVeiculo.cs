using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SGM_Desktop2
{
    class CadVeiculo
    {
        public string tipo;
        public string marca;
        public string modelo;
        public string placa;
        public string ano;
        public string id;
        public string idVeiculo;
        public string idSe;
        public string mensagem = "";
        conexao c = new conexao();

        public CadVeiculo()
        {

        }

        public CadVeiculo( string idSe, string tipo, string marca, string modelo, string placa, string ano, string id, string idVeiculo)
        {
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.ano = ano;
            this.id = id;
            this.idVeiculo = idVeiculo;
            this.idSe = idSe;
        }
        public void CadastrarV()
        {

            MySqlCommand cmd3 = new MySqlCommand();

            cmd3.Connection = c.Conecta();
                cmd3.CommandText = "INSERT INTO mec_tb_veiculos (Pes_in_codigo,Vec_st_tipo ,Vec_st_marca ,Vec_st_modelo ,Vec_st_placa ,Vec_in_ano)  VALUES ('" + id + "','" + tipo + "','"
                + marca + "','" + modelo + "','" + placa + "','" + ano + "')";
                cmd3.ExecuteNonQuery();
                c.Desconecta();

           
           
        }

        public void delVeic()
        {
            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = c.Conecta();

           

            

            cmd3.CommandText = "delete from mec_tb_servicos  where vec_in_codigo =  '" + idVeiculo + "'";
            cmd3.ExecuteNonQuery();

            cmd3.CommandText = "delete from mec_tb_veiculos  where vec_in_codigo=  '" + idVeiculo + "'";
            cmd3.ExecuteNonQuery();
            c.Desconecta();

        }

        public void AlterVeic()
        {
            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = c.Conecta();

            cmd3.CommandText = "UPDATE mec_tb_veiculos SET Vec_st_marca='" + marca + "',Vec_st_modelo= '" + modelo + "',Vec_st_placa='" + placa + "',Vec_in_ano='" + ano + "',Vec_st_tipo='" + tipo + "' where  vec_in_codigo = '" + idVeiculo + "' ";

            cmd3.ExecuteNonQuery();
            c.Desconecta();
        }





    }
}
