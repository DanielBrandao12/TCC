using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace SGM_Desktop2
{
    public partial class telaInicia : Form
    {
        public telaInicia()
        {
            InitializeComponent();
        }
        conexao c = new conexao();
        MySqlDataAdapter da;
        DataTable dt, Ca;

        public void display_Stoque()
        {
            try
            {

                String query = "SELECT prod_in_codigo As Codigo,prod_st_nome As Item,prod_st_marca As Fabricante, prod_re_quantidade As Quantidade FROM mec_tb_Produtos  ";
                dt = new DataTable();
                da = new MySqlDataAdapter(query, c.Conecta());
                da.Fill(dt);
                // datastoque.DataSource = dt;
                bunifuCustomDataGrid1.DataSource = dt;

                c.Desconecta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void display_Agenda(){

            String query = "SELECT p.prod_st_nome As Produto, COUNT(m.Prod_in_codigo) AS 'Vendas',p.prod_re_quantidade AS ' Em Estoque' FROM mec_tb_movimenta m JOIN mec_tb_produtos p on(p.prod_in_codigo = m.Prod_in_codigo) where m.Mov_st_Tipo = 'Saida' GROUP BY m.Prod_in_codigo LIMIT 10 ";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, c.Conecta());
            da.Fill(dt);
            // datastoque.DataSource = dt;
           DataGridAgen.DataSource = dt;

            c.Desconecta();


        }






        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hora_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();


        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void telaInicia_Load(object sender, EventArgs e)
        {
            try{
                MySqlCommand cmd3 = new MySqlCommand();
                cmd3.Connection = c.Conecta();

                cmd3.CommandText = "SELECT COUNT(pes_in_codigo) from mec_tb_pessoas WHERE pes_st_tipo = 'Cliente'";
                int cout = Convert.ToInt32(cmd3.ExecuteScalar());
                labClien.Text = Convert.ToString(cout);

                cmd3.CommandText = "SELECT COUNT(prod_in_codigo) from mec_tb_produtos";
                int cout2 = Convert.ToInt32(cmd3.ExecuteScalar());
                labEstoque.Text = Convert.ToString(cout2);

                cmd3.CommandText = "SELECT COUNT(pes_in_codigo) from mec_tb_pessoas WHERE pes_st_tipo ='Fornecedor'";
                int cout3 = Convert.ToInt32(cmd3.ExecuteScalar());
                labFone.Text = Convert.ToString(cout3);

                //verifica se tem algo no banco
                cmd3.CommandText = "SELECT Venda_re_valorTotal FROM mec_tb_vendas";
                string tem = Convert.ToString(cmd3.ExecuteScalar());
                if (tem == "")
                {
                    labelVen.Text = "0";

                }
                else
                {
                    cmd3.CommandText = "SELECT SUM(Venda_re_valorTotal) FROM mec_tb_vendas";
                    Double cout4 = Convert.ToInt32(cmd3.ExecuteScalar());
                    labelVen.Text = Convert.ToDouble(Convert.ToString(cout4)).ToString("c");
                }
                c.Desconecta();
                display_Stoque();
                display_Agenda();


            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao efetuar o cadastro, Verifique sua conexão!!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }












            c.Desconecta();
        }
    }
}
