using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SGM_Desktop2
{
    public class CadastroProduto
    {
        conexao c = new conexao();

       public string idProd ,idForne,nomeProd, descricaoProd, marcaProd;
       public int qtdeProd;
       public string valorCompra, valorVenda;

        public CadastroProduto()
        {
        }

        public CadastroProduto(string idProd, string idForne,string nomeProd, string descricaoProd, string marcaProd, int qtdeProd, string valorCompra, string valorVenda)
        {
            this.idProd = idProd;
            this.idForne = idForne;
            this.nomeProd = nomeProd;
            this.descricaoProd = descricaoProd;
            this.marcaProd = marcaProd;
            this.qtdeProd = 0;
            this.valorCompra = valorCompra;
            this.valorVenda = valorVenda;
        }

 

        public void cadProd()
        {

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c.Conecta();

            cmd.CommandText = "INSERT INTO mec_tb_produtos (Pes_in_codigo,prod_st_nome,prod_st_descricao," +
                "prod_st_marca,prod_re_quantidade,prod_re_valorcompra,prod_re_valorvenda) VALUES " +
                "('"+idForne+"','" + nomeProd + "','" + descricaoProd + "','" + marcaProd +"','"+qtdeProd+"','"+valorCompra+
                "','"+valorVenda+"');";
            cmd.ExecuteNonQuery();
            cmd.Connection = c.Desconecta();

        }

        public void deletaProd()
        {

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c.Conecta();

            cmd.CommandText = "delete from mec_tb_produtos where prod_in_codigo =  '" + idProd + "'";
            cmd.ExecuteNonQuery();
            cmd.Connection = c.Desconecta();

        }
        public void alteraProd()
        {

            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = c.Conecta();

            cmd3.CommandText = "UPDATE mec_tb_produtos SET prod_st_nome='" + nomeProd + "',prod_st_descricao= '" + descricaoProd + "',prod_st_marca='" + marcaProd + "',prod_re_valorcompra ='" + valorCompra + "',prod_re_valorvenda ='" + valorVenda + "'  where  prod_in_codigo = '" + idProd + "' ";

            cmd3.ExecuteNonQuery();
            c.Desconecta();
        }
    }
}
