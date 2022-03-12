using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace SGM_Desktop2
{
   
    
    public class CadastroPessoa
    {
    


        public string tipo;
        public string nome, razaosocial, nomefantasia, cnpj, bairro, rua, complemento, cidade, uf, sexo,email;
        public string numero;
        public string cpf ;
        public string telefone;
        public string celular;
        public string codigo,idcontato;

        conexao c = new conexao();
      
       

        public CadastroPessoa()
        {

        }

        public CadastroPessoa(string idcontato, string tipo, string nome,string numero,string cpf,string bairro,
            string nomefantasia,string razaosocial,string cnpj,string rua, string complemento,
            string cidade,string uf, string sexo,string email, string telefone, string celular,string codigo)
        {
            this.tipo = tipo;
            this.nome = nome;
            this.numero = numero;
            this.cpf = cpf;
            this.bairro = bairro;
            this.nomefantasia = nomefantasia;
            this.razaosocial = razaosocial;
            this.cnpj = cnpj;
            this.rua = rua;
            this.complemento = complemento;
            this.cidade = cidade;
            this.uf = uf;
            this.sexo = sexo;
            this.telefone = telefone;
            this.celular = celular;
            this.email = email;
            this.codigo = codigo;
            this.idcontato = idcontato;

        }
        MySqlCommand cmd = new MySqlCommand();
        public void CadPf() {
          
            cmd.Connection = c.Conecta();
           

            cmd.CommandText = "INSERT INTO mec_tb_Pessoa (Pes_st_tipo, Pes_st_Nome,Pes_in_cpf," +
                "Pes_st_bairro,Pes_st_rua,Pes_in_numero,Pes_st_complemento,Pes_st_cidade,Pes_st_uf,Pes_st_sexo) VALUES ('" +
            tipo+ "', '" 
           + nome +"','"+cpf+"','"+bairro+"','"+rua+"','"+numero+"','"+complemento+"','"+cidade+"','"+uf+"','"+sexo+ "')";
           cmd.ExecuteNonQuery();

            object id = cmd.LastInsertedId;

            cmd.CommandText = "INSERT INTO mec_tb_contato (Pes_in_codigo,cont_in_tel,cont_in_cel,cont_st_email)  VALUES ('" + id + "','"
            + telefone + "','" + celular + "','" + email + "')";
            cmd.ExecuteNonQuery();
            c.Desconecta();

        }
        public void cadPj()
        {
           
            cmd.Connection = c.Conecta();


            cmd.CommandText = "INSERT INTO mec_tb_pessoas (Pes_st_tipo,Pes_st_razaosocial,Pes_st_cnpj,Pes_st_nomefantasia, Pes_st_bairro," +
                "Pes_st_rua,Pes_in_numero,Pes_st_complemento,Pes_st_cidade,Pes_st_uf) VALUES ('" +
            tipo+"','"+razaosocial +"','"+cnpj+ "', '" + nomefantasia +"','"+  bairro + "','" + rua + "','" + numero + "','" + complemento + "','" + cidade + "','" + uf+ "')";
            cmd.ExecuteNonQuery();
            object id = cmd.LastInsertedId;

            cmd.CommandText = "INSERT INTO mec_tb_contato (Pes_in_codigo,cont_in_tel,cont_in_cel,cont_st_email)  VALUES ('" + id + "','"
            + telefone + "','" + celular + "','" + email + "')";
            cmd.ExecuteNonQuery();
            c.Desconecta();

        }


        public void delCliente()
        {


            cmd.Connection = c.Conecta();
            cmd.CommandText = "delete from mec_tb_contato  where pes_in_codigo=  '" + codigo + "'";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "delete from mec_tb_pessoas  where Pes_in_codigo=  '" + codigo + "'";
            cmd.ExecuteNonQuery();

            cmd.Connection = c.Desconecta();

        }
        public void AdNovoContato()
        {
            cmd.Connection = c.Conecta();


            cmd.CommandText = "INSERT INTO mec_tb_contato (Pes_in_codigo,cont_in_tel,cont_in_cel,cont_st_email)  VALUES ('" + codigo + "','"
        + telefone + "','" + celular + "','" + email + "')";
            cmd.ExecuteNonQuery();
            c.Desconecta();

        }

         public void alteraContato()
        {
            cmd.Connection = c.Conecta();


            cmd.CommandText = "UPDATE mec_tb_contato SET  cont_in_tel = '"
        + telefone + "', cont_in_cel = '" + celular + "', cont_st_email = '" + email + "' where cont_in_codigo = '"+idcontato+"'";
            cmd.ExecuteNonQuery();
            c.Desconecta();
        }
        
        public void delContato()
        {

            cmd.Connection = c.Conecta();
            cmd.CommandText = "delete from mec_tb_contato  where cont_in_codigo=  '" + idcontato+ "'";
            cmd.ExecuteNonQuery();
            c.Desconecta();

        }


        public void delForne()
        {

            cmd.Connection = c.Conecta();
            cmd.CommandText = "delete from mec_tb_contato  where pes_in_codigo=  '" + codigo + "'";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "delete from mec_tb_contaspagar  where pes_in_codigo=  '" + codigo + "'";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "delete from mec_tb_pessoas  where Pes_in_codigo=  '" + codigo + "'";
            cmd.ExecuteNonQuery();

            cmd.Connection = c.Desconecta();

        }
     

    }
}
