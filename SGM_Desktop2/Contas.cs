using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGM_Desktop2
{


   public class Contas
    {
        conexao c = new conexao();

        private string juros;
        private int codigoForn,codigoConta,qtde;
        private string dataVenc;
        private string tipoPag;
        private string status;
        private string observacao;
        private string valor,valorPac;

        public string TipoPag { get => tipoPag; set => tipoPag = value; }
        public string Status { get => status; set => status = value; }
        public string Observacao { get => observacao; set => observacao = value; }
     
        public string Juros { get => juros; set => juros = value; }
        public int CodigoForn { get => CodigoForn1; set => CodigoForn1 = value; }
        public string DataVenc { get => dataVenc; set => dataVenc = value; }
        public int CodigoForn1 { get => CodigoForn2; set => CodigoForn2 = value; }
        public int CodigoConta { get => CodigoConta1; set => CodigoConta1 = value; }
        public int CodigoForn2 { get => codigoForn; set => codigoForn = value; }
        public int CodigoConta1 { get => codigoConta; set => codigoConta = value; }
        public int Qtde { get => qtde; set => qtde = value; }

        public string ValorPac { get => valorPac; set => valorPac = value; }
        public string Valor { get => valor; set => valor = value; }
        public string data;

      
        public void inserirConta()
        {


            
           data= DateTime.Now.ToShortDateString();

            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = c.Conecta();


            cmd3.CommandText = "INSERT INTO mec_tb_contaspagar (pes_in_codigo,ContaP_st_status,ContaP_re_totalPag,ContaP_re_juros,ContaP_st_formaPag,Contap_st_observacao," +
                    "ContaP_date_dataVenc) values ('" + CodigoForn1 + "','" + status + "','" + Valor + "','" + juros + "','" + tipoPag + "','" + observacao + "',@data1 )";

            cmd3.Parameters.AddWithValue("data1", DateTime.Parse(data).ToString("yyyy-MM-dd"));
            cmd3.ExecuteNonQuery();
            c.Desconecta();
            if (tipoPag == "Parcelado")
            {
         
                cmd3.Connection = c.Conecta();
                object id = cmd3.LastInsertedId;
                cmd3.CommandText = "INSERT INTO mec_tb_itemparcela (ContaP_in_codigo,ItemParc_in_numeroParc,	ItemParc_re_Valor,ItemParc_date_dataVenc) values ('" + id + "','" + Qtde + "','" + ValorPac + "',@datavencit)";
                cmd3.Parameters.AddWithValue("datavencit", DateTime.Parse(DataVenc).ToString("yyyy-MM-dd"));
                cmd3.ExecuteNonQuery();


                c.Desconecta();
            }
        }

        public void mudarStatus()
        {

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c.Conecta();



            cmd.CommandText = "UPDATE mec_tb_contaspagar set ContaP_st_status='" +Status+ "' where ContaP_in_codigo='" + CodigoConta1 + "'";

            cmd.ExecuteNonQuery();

        
            c.Desconecta();

        }
        public void deletarConta()
        {

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c.Conecta();



            cmd.CommandText = "delete from mec_tb_contaspagar  where ContaP_in_codigo='" + CodigoConta1 + "'";

            cmd.ExecuteNonQuery();


            c.Desconecta();

        }
    }



}
