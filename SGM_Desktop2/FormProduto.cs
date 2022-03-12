using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGM_Desktop2
{
    public partial class FormProduto : Form
    {
        
     
        public FormProduto()
        {
            InitializeComponent();
        }
        conexao conecta = new conexao();
        MySqlDataAdapter da;
        DataTable dt;   

        public void limpaForm()
        {
           txtIdProd.Text = "";
           // txtIdForne.Text = "";
            txtProd.Text = "";
            txtDesc.Text = "";
            txtMarca.Text = "";
            txtValorV.Text = "";
            txtValorC.Text = "";
           
        }

        public void display_Fornecedor()
        {
            try
            {
                MySqlConnection conn = conecta.Conecta();
                String query = "SELECT Pes_in_codigo As 'Codigo',Pes_st_razaosocial As 'Razao Social',Pes_st_nomefantasia As 'Nome Fantasia', Pes_st_cnpj As 'CNPJ',Pes_st_cidade As 'Cidade',Pes_st_bairro As 'Bairro',Pes_st_rua As 'Rua',Pes_in_numero As 'Numero',Pes_st_uf As 'UF',Pes_st_complemento As 'Complemento' FROM mec_tb_pessoas where  Pes_st_tipo in ('Fornecedor')";
                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dataGriProd.DataSource = dt;
                conecta.Desconecta();
            }
            catch
            {
                MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void display_Produto()
        {
            try
            {


                txtIdProd.Text = "0";
                MySqlConnection conn = conecta.Conecta();
                String query = "SELECT prod_in_codigo As 'Codigo',pes_in_codigo As 'Fornecedor',prod_st_nome As 'Produto',prod_st_descricao As 'Descricao',prod_st_marca As 'Fabricante',prod_re_valorcompra As 'Valor',prod_re_valorvenda 'Venda',prod_re_quantidade As 'Quantidade' FROM mec_tb_produtos where Pes_in_codigo = '" + txtIdForne.Text + "'";
                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dataGriProd.DataSource = dt;
                conecta.Desconecta();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        string fornecedor;
        private void button1_Click(object sender, EventArgs e)
        {
            txtIdProd.Text = "";
            //  txtIdForne.Text = "";
            txtProd.Text = "";
            txtDesc.Text = "";
            txtMarca.Text = "";
            txtValorV.Text = "";
            txtValorC.Text = "";
            try
            {


                MySqlConnection conn = conecta.Conecta();
                String query = "SELECT Pes_in_codigo As 'Codigo',Pes_st_razaosocial As 'Razao Social',Pes_st_nomefantasia As 'Nome Fantasia', Pes_st_cnpj As 'CNPJ',Pes_st_cidade As 'Cidade',Pes_st_bairro As 'Bairro',Pes_st_rua As 'Rua',Pes_in_numero As 'Numero',Pes_st_uf As 'UF',Pes_st_complemento As 'Complemento' FROM mec_tb_pessoas where Pes_st_nomefantasia like'" + txtFornecedor.Text + "%' and Pes_st_tipo in ('Fornecedor')";
                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                // dataGriProd.DataSource = dt;
                // conecta.Desconecta();
                //txtFornecedor.Text = "";
                foreach (DataRow dr in dt.Rows)
                {
                    fornecedor = txtFornecedor.Text;

                }
                conecta.Desconecta();
                if (txtFornecedor.Text == "")
                {
                    MessageBox.Show("Campo vazio");
                    txtFornecedor.Text = "";
                }
                else if (txtFornecedor.Text != fornecedor)
                {

                    MessageBox.Show("Forncedor não existe");
                    txtFornecedor.Text = "";
                }
                else
                {

                    dataGriProd.DataSource = dt;
                    txtFornecedor.Text = "";
                    conecta.Desconecta();
                }

                txtQtde.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

                private void label9_Click(object sender, EventArgs e)
        {

        }
        CadastroProduto cdP = new CadastroProduto();
        private void button2_Click(object sender, EventArgs e)
        {
            

        


                cdP.idForne = txtIdForne.Text;
                cdP.nomeProd = txtProd.Text;
                cdP.descricaoProd = txtDesc.Text;
                cdP.marcaProd = txtMarca.Text;
                cdP.qtdeProd = Convert.ToInt32(txtQtde.Text);
                string valorC = txtValorC.Text;//declara variavel
                valorC = valorC.Replace("R$", "");// troca R$ por vazio
                valorC = valorC.Replace(".", "");//troca (ponto) por vazio
                valorC = valorC.Replace(",", ".");//troca (virgula) por (ponto)
                cdP.valorCompra = valorC;

                string valorV = txtValorV.Text;//declara variavel
                valorV = valorV.Replace("R$", "");// troca R$ por vazio
                valorV = valorV.Replace(".", "");//troca (ponto) por vazio
                valorV = valorV.Replace(",", ".");//troca (virgula) por (ponto)
                cdP.valorVenda = valorV;

                if (txtIdForne.Text != "")
                {

                    if (txtDesc.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (txtProd.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (txtMarca.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (txtValorC.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (txtValorV.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        try
                        {

                            cdP.cadProd();
                            MessageBox.Show("cadastrado com sucesso");
                            limpaForm();
                            display_Produto();
                            conecta.Desconecta();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }




                }
                else
                {
                    MessageBox.Show("selecione um Fornecedor");

                }

            


        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            limpaForm();
            display_Fornecedor();

            txtQtde.Enabled = true;
        }

        private void txtValorC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {



        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtd_TextChanged(object sender, EventArgs e)
        {


        }

        
      

        private void button3_Click(object sender, EventArgs e)
        {
  

        }

       
        private void button3_Click_1(object sender, EventArgs e)
        {
            limpaForm();
            display_Fornecedor();
           
            txtQtde.Enabled = true;
            btnCad.Enabled = true;


        }

        private void txtQtde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpaForm();
            display_Produto();
        }

        private void btExcluirProd_Click(object sender, EventArgs e)
        {
            cdP.idProd = txtIdProd.Text;

            if(txtIdProd.Text != "")
            {
                if (MessageBox.Show("Deseja efetuar a Exclusão", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {


                       
                        cdP.deletaProd();

                        txtIdProd.Text = "";
                        //  txtIdForne.Text = "";
                        txtProd.Text = "";
                        txtDesc.Text = "";
                        txtMarca.Text = "";
                        txtValorV.Text = "";
                        txtValorC.Text = "";
                        MessageBox.Show("deletado com Sucesso");
                        display_Produto();
                        txtQtde.Enabled = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                    
            }
            else
            {
                MessageBox.Show("Selecione um produto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btAlteraProd_Click(object sender, EventArgs e)
        {
           

            cdP.idProd = txtIdProd.Text;
            cdP.idForne = txtIdForne.Text;
            cdP.nomeProd = txtProd.Text;
            cdP.descricaoProd = txtDesc.Text;
            cdP.marcaProd = txtMarca.Text;
            string valorC = txtValorC.Text;//declara variavel
            valorC = valorC.Replace("R$", "");// troca R$ por vazio
            valorC = valorC.Replace(".", "");//troca (ponto) por vazio
            valorC = valorC.Replace(",", ".");//troca (virgula) por (ponto)
            cdP.valorCompra = valorC;
            string valorV = txtValorV.Text;//declara variavel
            valorV = valorV.Replace("R$", "");// troca R$ por vazio
            valorV = valorV.Replace(".", "");//troca (ponto) por vazio
            valorV = valorV.Replace(",", ".");//troca (virgula) por (ponto)
            cdP.valorVenda = valorV;

            if(txtIdProd.Text != "")
            {
                if (MessageBox.Show("Deseja efetuar a Alteração", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        
                        cdP.alteraProd();
                        MessageBox.Show("alterado com sucesso");
                        display_Produto();
                        btnCad.Enabled = true;
                        txtQtde.Enabled = true;
                        conecta.Desconecta();
                    }
                    catch
                    {
                        MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                   
            }
            else
            {
                MessageBox.Show("selecione um Produto","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
       
        }
        double valorc, valorv;
        private void dataGriProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtIdProd.Text == "")
            {
                DataGridViewRow row = this.dataGriProd.Rows[e.RowIndex];
                txtIdForne.Text = row.Cells["Codigo"].Value.ToString();
                display_Produto();
            }
            else if (txtIdProd.Text != "")
            {
                DataGridViewRow row = this.dataGriProd.Rows[e.RowIndex];
                txtIdProd.Text = row.Cells["Codigo"].Value.ToString();
                txtIdForne.Text = row.Cells["Fornecedor"].Value.ToString();
                txtProd.Text = row.Cells["Produto"].Value.ToString();
                txtDesc.Text = row.Cells["Descricao"].Value.ToString();
                txtMarca.Text = row.Cells["Fabricante"].Value.ToString();
                txtQtde.Text = row.Cells["Quantidade"].Value.ToString();

               valorc =Convert.ToDouble( row.Cells["Valor"].Value.ToString());
                txtValorC.Text = valorc.ToString("C");
                valorv= Convert.ToDouble( row.Cells["Venda"].Value.ToString());
                txtValorV.Text = valorv.ToString("C");
                btnCad.Enabled = false;
                txtQtde.Enabled = false;

            }
        }

        private void dataGriProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGriProd_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btLimp_Click(object sender, EventArgs e)
        {
            txtIdProd.Text = "";
            //  txtIdForne.Text = "";
            txtProd.Text = "";
            txtDesc.Text = "";
            txtMarca.Text = "";
            txtValorV.Text = "";
            txtValorC.Text = "";
            btnCad.Enabled = true;
            txtQtde.Enabled = true;

        }

        private void btVolta_Click(object sender, EventArgs e)
        {
            limpaForm();
            display_Fornecedor();
            txtQtde.Value = 0;
            txtQtde.Enabled = true;
            btnCad.Enabled = true;
        }

        private void txtValorC_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void txtValorV_MaskChanged(object sender, EventArgs e)
        {

        }

        private void txtValorC_MaskChanged(object sender, EventArgs e)
        {

        }

        private void txtValorC_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtValorV_MouseClick(object sender, MouseEventArgs e)
        {
         
            string procuraponto = txtValorC.Text;
            if (procuraponto.Contains("."))
            {
                MessageBox.Show("Use virgula nos números");
                txtValorC.Text = "";
            }
            else //if (procuraponto.Contains(","))
            {
                try
                {
                    txtValorC.Text = Convert.ToDouble(txtValorC.Text).ToString("C");
                }
                catch
                {
                    MessageBox.Show("Preencha o campo de valor de Compra");
                }
            }
        }

        private void FormProduto_Click(object sender, EventArgs e)
        {
            string procuraponto = txtValorV.Text;
            if (procuraponto.Contains("."))
            {
                MessageBox.Show("Use virgula nos números");
                txtValorV.Text = "";
            }
            else //if (procuraponto.Contains(","))
            {
                try
                {
                    txtValorV.Text = Convert.ToDouble(txtValorV.Text).ToString("C");
                }
                catch
                {
                    MessageBox.Show("Preencha o campo de valor de venda");
                }
            }
        }

        private void txtFornecedor_Click(object sender, EventArgs e)
        {
            txtFornecedor.Clear();
        }
    }
}
