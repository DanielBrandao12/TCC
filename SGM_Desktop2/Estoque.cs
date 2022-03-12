using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGM_Desktop2
{
   public class Estoque
    {

        conexao c = new conexao();
        int CodProd, QtdeEs, Qtde, QtdeNova;
        string TipoMov;

        public int CodProd1 { get => CodProd; set => CodProd = value; }
        public int QtdeEs1 { get => QtdeEs; set => QtdeEs = value; }
        public int Qtde1 { get => Qtde; set => Qtde = value; }
        public int QtdeNova1 { get => QtdeNova; set => QtdeNova = value; }
        public string TipoMov1 { get => TipoMov; set => TipoMov = value; }

        public void Movimento()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c.Conecta();

            cmd.CommandText = "INSERT INTO mec_tb_movimenta (Prod_in_codigo,Mov_st_Tipo,Mov_in_QtdeAnterior,Mov_in_QtdeAtual,Mov_in_QtdeNova) VALUES " +
                "('" + CodProd1 + "','" + TipoMov1 + "','" + QtdeEs1+ "','" + Qtde1+ "','" + QtdeNova1 + "');";
            cmd.ExecuteNonQuery();
            cmd.Connection = c.Desconecta();


        }
        public void alteraQtde()
        {

            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = c.Conecta();

            cmd3.CommandText = "UPDATE mec_tb_produtos SET   prod_re_quantidade = '" + QtdeNova1 + "' where  prod_in_codigo = '" + CodProd1 + "' ";

            cmd3.ExecuteNonQuery();
            c.Desconecta();
        }

    }
}
