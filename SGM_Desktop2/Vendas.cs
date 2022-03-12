using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGM_Desktop2
{
   public class Vendas
    {
        conexao c = new conexao();

        int qtde;

        public int Qtde { get => qtde; set => qtde = value; }
        
       
     
       
      
        public string Descricao { get => descricao; set => descricao = value; }
        public int CodigoCli { get => codigoCli; set => codigoCli = value; }
        public int CodigoProd { get => codigoProd; set => codigoProd = value; }
        public int CodigoVenda { get => codigoVenda; set => codigoVenda = value; }
        
        public string ValorTotal1 { get => valorTotal; set => valorTotal = value; }
        public string ValorServico2 { get => ValorServico; set => ValorServico = value; }
        public string ValorParc2 { get => ValorParc; set => ValorParc = value; }
        public string ValorTotalProd2 { get => ValorTotalProd; set => ValorTotalProd = value; }
        public string Desconto { get => desconto; set => desconto = value; }
        public int CodigoVeiculo { get => codigoVeiculo; set => codigoVeiculo = value; }
        public string Data { get => data; set => data = value; }
        public int QtdeParc { get => qtdeParc; set => qtdeParc = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public string Juros { get => juros; set => juros = value; }
        public string DataV { get => dataV; set => dataV = value; }
        public string DescriRel1 { get => DescriRel; set => DescriRel = value; }
        public string ObsRel1 { get => ObsRel; set => ObsRel = value; }
        public int KmA1 { get => KmA; set => KmA = value; }
        public int KmP1 { get => KmP; set => KmP = value; }
        public string Parcela { get => parcela; set => parcela = value; }
        public string Status { get => status; set => status = value; }

        string parcela,status;
        string descricao, observacao;
        string desconto, valorTotal, ValorServico,  ValorParc,ValorTotalProd,juros,DescriRel,ObsRel;
        int qtdeParc,codigoCli, codigoProd, codigoVenda,codigoVeiculo,quantidade,KmA,KmP;
        string dataV,data;

        MySqlCommand cmd = new MySqlCommand();

        telaprincipal tp = new telaprincipal();
        public void novaVenda()
        {
            /*Vai gera codigo de venda para a inserção de itens, mas gera só o codigo, os outros campos da tabela ficam vazios pro enquanto,
            depois que a venda for comfirmada os outros campos serão preenchidos */


            try
            {
                cmd.Connection = c.Conecta();
                cmd.CommandText = "INSERT INTO mec_tb_vendas (Venda_in_codigo) values ('" + codigoVenda + "') ";

                cmd.ExecuteNonQuery();
                //vai pegar ultimo codigo gerado
                object id = cmd.LastInsertedId;
                codigoVenda = Convert.ToInt32(id);
                c.Desconecta();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              

            }
     

        }

        //limpa tabela de venda se for cancelado uma venda
        public void limpaVenda()
        {
        



            cmd.Connection = c.Conecta();
            cmd.CommandText = "delete  from mec_tb_vendas where Venda_in_codigo='" +codigoVenda+ "'";

            cmd.ExecuteNonQuery();
        
            c.Desconecta();



        }
        //baixa na quantidade de produto no estoque
        public void baixaProduto()
        {
            cmd.Connection = c.Conecta();



            cmd.CommandText = "UPDATE mec_tb_produtos set prod_re_quantidade='"+Qtde+"' where prod_in_codigo='"+CodigoProd+"'";

            cmd.ExecuteNonQuery();

            c.Desconecta();


        }


        public void deletarItem()
        {


                    cmd.Connection = c.Conecta();
                 cmd.CommandText = "delete  from mec_tb_itemven where Prod_in_codigo='"+CodigoProd+"'";

             cmd.ExecuteNonQuery();

             c.Desconecta();




        }
        //limpar tabela de itens
        MySqlDataAdapter da, ct;
        DataTable dt;
        int codigoProd2;
        int quantidade2,codigoI;
        public void limpaItem()
        {
         
             MySqlConnection conn = c.Conecta();
            string  query = "select * from mec_tb_itemven where Prod_in_codigo";
            dt = new DataTable();
            ct = new MySqlDataAdapter(query, cmd.Connection);
            ct.Fill(dt);


            foreach (DataRow db in dt.Rows)
            {

                codigoI = Convert.ToInt32(db["Item_int_codigo"].ToString());
                    codigoProd2  =Convert.ToInt32( db["Prod_in_codigo"].ToString());
                quantidade2 =Convert.ToInt32( db["Item_int_qtde"].ToString());
                for (int i = codigoI; i <= codigoI; i++)
                {
                    c.Desconecta();
                    cmd.Connection = c.Conecta();
                    cmd.CommandText = "UPDATE mec_tb_produtos set prod_re_quantidade= prod_re_quantidade +'" + quantidade2 + "' where prod_in_codigo='" + codigoProd2 + "'";

                    cmd.ExecuteNonQuery();
                    c.Desconecta();


                    cmd.Connection = c.Conecta();



                    cmd.CommandText = "delete  from mec_tb_itemven where Prod_in_codigo='" + codigoProd2 + "'";

                    cmd.ExecuteNonQuery();

                    c.Desconecta();
                }
               
            }
       
           

       
          
         


        }

        //Metodo para inserir novoitem
        public void novoItem()
        {

           
                cmd.Connection = c.Conecta();



                cmd.CommandText = "INSERT INTO mec_tb_itemven (Prod_in_codigo,Venda_in_codigo,Item_int_qtde) values ('" + CodigoProd + "','" + codigoVenda + "','" + Qtde + "')";

                cmd.ExecuteNonQuery();
            
            c.Desconecta();
     



        }
     
    
   
        public void confirmaVenda()
        {

   
            cmd.Connection = c.Conecta();



            cmd.CommandText = "update mec_tb_vendas set pes_in_codigo='"+CodigoCli+"', Venda_bool_parcela='"+Parcela+"', " +
                "	Venda_int_qtdeParcela='"+QtdeParc+"', Venda_re_valorTotal='"+ValorTotal1+ "' where Venda_in_codigo='"+CodigoVenda+"'";

            cmd.ExecuteNonQuery();
          //  cmd.CommandText = "INSERT INTO mec_tb_servicos (serv_st_descricao,Serv_re_Vdesc,Serv_re_VServico) values ('" + parcela + "','" + qtdeParc + "','" + ValorTotal + "')";

           // cmd.ExecuteNonQuery();

            c.Desconecta();
        }
            //salvar serviço
        public void salvarServico()
        {



            cmd.Connection = c.Conecta();


            cmd.CommandText = "INSERT INTO mec_tb_servicos (venda_in_codigo,vec_in_codigo,pes_in_codigo,serv_st_descricao,Serv_re_Vdesc,Serv_re_VServico) " +
                "values ('"+CodigoVenda+"','"+CodigoVeiculo+"','"+CodigoCli+"','" + descricao + "','" +Desconto+ "','" + ValorServico2 + "')";

             cmd.ExecuteNonQuery();


            object id = cmd.LastInsertedId;

            cmd.CommandText = "INSERT INTO mec_tb_relatorio (Serv_in_codigo,rel_st_descricao,rel_int_kmatual,rel_int_kmprevisto,rel_st_observacoes) " +
                "values ('" + id + "','" + Descricao + "','" + KmA1 + "','" + KmP1 + "','" + Observacao + "')";

            cmd.ExecuteNonQuery();

            c.Desconecta();
        }
        public void gerarCR()
        {
            cmd.Connection = c.Conecta();



            cmd.CommandText = "INSERT INTO mec_tb_contasreceber (venda_in_codigo,ContaR_date_dataVenc,ContaR_st_status,	ContaR_re_totalPag,ContaR_re_juros,ContaR_st_formaPag,ContaR_st_observacao) values ('" + CodigoVenda + "', @data ,'"+Status+"','"+valorTotal+"','"+Juros+"','"+Parcela+"','"+Observacao+"')";

            cmd.Parameters.AddWithValue("data", DateTime.Parse(DataV).ToString("yyyy-MM-dd"));
            cmd.ExecuteNonQuery();


            c.Desconecta();

           

        }

        public void itemParcela()
        {
            cmd.Connection = c.Conecta();



            cmd.CommandText = "INSERT INTO mec_tb_itemparcela (venda_in_codigo,ItemParc_in_numeroParc,	ItemParc_re_Valor,ItemParc_date_dataVenc) values ('" + CodigoVenda + "','" + QtdeParc + "','" + ValorParc + "',@datavenc )";

            cmd.Parameters.AddWithValue("datavenc", DateTime.Parse(Data).ToString("yyyy-MM-dd"));
            cmd.ExecuteNonQuery();


            c.Desconecta();

        }

  

    }
}
