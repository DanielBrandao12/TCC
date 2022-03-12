using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGM_Desktop2
{
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }


        Estoque Est = new Estoque();
        conexao c = new conexao();
        MySqlDataAdapter da;
        DataTable dt;
        public void display_data()
        {


            MySqlConnection conn = c.Conecta();
            String query = "SELECT prod_in_codigo AS 'Codigo Produto',pes_in_codigo AS 'Codigo Fornecedor',prod_st_nome AS 'Produto',prod_st_descricao AS 'Descricao'," +
                "prod_st_marca AS 'Marca',prod_re_valorcompra AS 'Valor Compra'	,prod_re_valorvenda AS 'Valor venda'," +
                "prod_re_quantidade AS 'Quantidade',prod_date_data AS 'Data' from mec_tb_produtos ";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            DataProduto.DataSource = dt;

            c.Desconecta();
        }
        public void display_data2()
        {


            MySqlConnection conn = c.Conecta();
            String query = "SELECT Mov_in_codigo as 'Codigo', Mov_st_Tipo as 'Entrada/Saida',prod_in_codigo as 'Codigo do produto',	prod_st_nome as 'Produto', prod_st_marca as 'Fabricante', Mov_in_QtdeAnterior AS 'Quantidade Anterior', Mov_in_QtdeAtual as 'Quantidade Movimentada',	Mov_in_QtdeNova as 'Quantidade atual',	Mov_date_data as 'Data da movimentacao' from mec_vw_movimenta ";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            DataProduto.DataSource = dt;
        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int qtde, qtdeEs;

        private void button2_Click(object sender, EventArgs e)
        {
            display_data();
            btnBusca.Enabled = true;
            btnBusca.Visible = true;
            txtBusca.Visible = true;
            labelProd.Visible = true;
            btBuscaData.Visible = false;
            btBuscaData.Enabled = false;
            dataM.Visible = false;
            btFim.Visible = false;
            DataProduto.Enabled = true;
            c.Desconecta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display_data2();
            btnBusca.Enabled = false;
            btnBusca.Visible = false;
            txtBusca.Visible = false;
            labelProd.Visible = false;
            btBuscaData.Visible = true;
            btBuscaData.Enabled = true;

            dataM.Visible = true;
            btFim.Visible = true;

            c.Desconecta();
        }

        private void DataProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                if (txtBusca.Visible == false)
                {
                    DataGridViewRow row2 = this.DataProduto.Rows[e.RowIndex];
                    txtCodigo.Text = "";

                    txtQtdeEs.Text = "";

                    txtNome.Text = "";




                }
                else
                {

                    DataGridViewRow row = this.DataProduto.Rows[e.RowIndex];
                    txtCodigo.Text = "";

                    txtQtdeEs.Text = "";

                    txtNome.Text = "";

                    txtCodigo.Text = row.Cells["Codigo Produto"].Value.ToString();

                    txtQtdeEs.Text = row.Cells["Quantidade"].Value.ToString();

                    txtNome.Text = row.Cells["Produto"].Value.ToString();

                }


            }

            // c.Desconecta();
        }
        public void buscaData()
        {
            MySqlConnection conn = c.Conecta();
            DateTime dtt = DateTime.Parse(dataM.Text);
            DateTime dtf = DateTime.Parse(btFim.Text);
            
            string str2 = dtt.ToString("yyyy/MM/dd");
            string fim = dtf.ToString("yyyy/MM/dd");


            String query = "SELECT Mov_in_codigo as 'Codigo',prod_in_codigo as 'Codigo do produto',prod_st_nome as 'Produto', prod_st_marca as 'Fabricante', Mov_in_QtdeAnterior AS 'Quantidade Anterior', Mov_in_QtdeAtual as 'Quantidade Movimentada',	Mov_in_QtdeNova as 'Quantidade atual',Mov_st_Tipo as 'Entrada/Saida',	Mov_date_data as 'Data da movimentacao' FROM mec_vw_movimenta where Mov_date_data  BETWEEN '" + str2+"' AND '"+fim+"'";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            DataProduto.DataSource = dt;
            c.Desconecta();

            if (DataProduto.RowCount == 0)
            {
                MessageBox.Show("Não existe Nenhuma movimentação para data: " + dataM.Text + " ");
                c.Desconecta();
            }


        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {

        }
        MySqlDataAdapter ct;
        DataTable dtt;
        string produto;
        private void button1_Click(object sender, EventArgs e)
        {




            if (txtBusca.Text == "")
            {
                MessageBox.Show("Preencha o campo para fazer a pesquisa");

            }


            else if (txtBusca.Text != "")
            {

                MySqlConnection conn = c.Conecta();
                String query = "SELECT prod_in_codigo AS 'Codigo Produto',pes_in_codigo AS 'Codigo Fornecedor',prod_st_nome AS 'Produto',prod_st_descricao AS 'Descricao'," +
                "prod_st_marca AS 'Marca',prod_re_valorcompra AS 'Valor Compra'	,prod_re_valorvenda AS 'Valor venda'," +
                "prod_re_quantidade AS 'Quantidade',prod_date_data AS 'Data'  FROM mec_tb_produtos where prod_st_nome like'" + txtBusca.Text + "%'  ";
                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);


                foreach (DataRow db in dt.Rows)
                {
                    produto = txtBusca.Text;
                }
                if (produto == txtBusca.Text)
                {
                    DataProduto.DataSource = dt;
                    c.Desconecta();
                    txtBusca.Text = "";
                }
                else
                {

                    MessageBox.Show("Não existe Produto");
                }




            }
            c.Desconecta();

        }

        private void btBuscaData_Click(object sender, EventArgs e)
        {
            buscaData();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void DataProduto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusca_Click(object sender, EventArgs e)
        {
            txtBusca.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string procuraponto = txtQtde.Text;
            if (procuraponto.Contains(".") || procuraponto.Contains(","))
            {
                MessageBox.Show("Não use ponto nem virgulas para numero inteiro");
                txtQtde.Text = "";
            }
            else
            {
                if (txtCodigo.Text == "")
                {
                    MessageBox.Show("Selecione Produto");

                }
                else
            if (TipoMov.Text == "")
                {

                    MessageBox.Show("Selecione se é ENTRADA ou SAiDA");
                }
                else if (txtQtde.Text == "")
                {
                    MessageBox.Show("Insira quantidade");

                }
                else
                {

                    Est.CodProd1 = Convert.ToInt32(txtCodigo.Text);
                    Est.TipoMov1 = TipoMov.Text;
                    Est.QtdeEs1 = Convert.ToInt32(txtQtdeEs.Text);
                    Est.Qtde1 = Convert.ToInt32(txtQtde.Text);

                    Int32.TryParse(txtQtde.Text, out qtde);
                    Int32.TryParse(txtQtdeEs.Text, out qtdeEs);




                    if (TipoMov.Text == "Entrada")
                    {
                        if (qtde < 0)
                        {

                            MessageBox.Show("Impossivel inserir numero negativo");
                        }
                        else
                        {

                            Est.QtdeNova1 = qtdeEs + qtde;
                            Est.Movimento();
                            Est.alteraQtde();
                            display_data();
                            c.Desconecta();
                            txtNome.Text = "";
                            txtCodigo.Text = "";
                            txtQtde.Text = "";
                            txtQtdeEs.Text = "";
                            TipoMov.Text = "";

                            MessageBox.Show("Quantidade inserida com sucesso!");
                        }
                    }
                    else if (TipoMov.Text == "Saída")
                    {
                        if (qtdeEs < qtde)
                        {

                            MessageBox.Show("Quantidade não permitida!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            Est.QtdeNova1 = qtdeEs - qtde;
                            Est.Movimento();
                            Est.alteraQtde();
                            display_data();
                            c.Desconecta();
                            txtNome.Text = "";
                            txtCodigo.Text = "";
                            txtQtde.Text = "";
                            txtQtdeEs.Text = "";
                            TipoMov.Text = "";
                            MessageBox.Show("Quantidade removida com sucesso!");
                        }

                    }

                }
            }
        }
    }
}
