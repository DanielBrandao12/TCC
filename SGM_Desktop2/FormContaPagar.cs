using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGM_Desktop2
{
    public partial class FormContaPagar : Form
    {
        public FormContaPagar()
        {
            InitializeComponent();
        }
        conexao c = new conexao();
        MySqlDataAdapter da;
        DataTable dt;
        Contas Cp = new Contas();
        int codigo;
    
        private void dataFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            c.Desconecta();
                if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataFornecedor.Rows[e.RowIndex];


                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtRazao.Text = row.Cells["Razao Social"].Value.ToString();
                MySqlConnection conn = c.Conecta();
                String query = "SELECT Pes_in_codigo FROM mec_tb_contaspagar where Pes_in_codigo='" + txtCodigo.Text + "'  ";

                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    codigo =Convert.ToInt32( dr["Pes_in_codigo"].ToString());
                }
                c.Desconecta();
                DialogResult Contas = MessageBox.Show("Deseja Exbir contas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Contas == DialogResult.Yes)
                {

                        if (codigo == Convert.ToInt32(txtCodigo.Text))
                        {


                        dataFornecedor.Visible = false;
                        dataGridView1.Visible = true;
                        dataGridParcelas.Visible = false;
                        exibirContas();
                        btnSalva.Enabled = false;
                        btnAtualiza.Enabled = false;
                        TipoPagamento.Enabled = false;
                        txtValor.ReadOnly = true;
                        txtJuros.ReadOnly = true;
                        txtValorT.ReadOnly = true;
                    }
                        else 
                        {

                        // c.Desconecta();
                        MessageBox.Show("Não existe conta para este fornecedor!");

                        c.Desconecta();


                    }






                }

                else
                {
                    c.Desconecta();
                    exibifornecedor();
                    TipoPagamento.Enabled = true;

                    c.Desconecta();
                    dataFornecedor.Visible = true;
                    dataGridView1.Visible = false;
                }

               

            }

            }
      public void  exibirItensPArcela()
        {
           double vl;
            MySqlConnection conn = c.Conecta();
            String query = "SELECT 	ItemParc_in_codigo AS 'Cod Parcela',ContaP_in_codigo AS 'Numero Conta',ItemParc_in_numeroParc AS 'Quantidade de Parcelas',ItemParc_re_Valor AS 'Valor',ItemParc_date_dataVenc AS 'Data de Vencimento' FROM mec_tb_itemparcela where ContaP_in_codigo='" + txtCodCp.Text + "' ";

            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            dataGridParcelas.DataSource = dt;
            foreach (DataRow dr in dt.Rows)
            {
                Double.TryParse(txtValorParc.Text, out vl);

               vl =Convert.ToDouble( dr["Valor"].ToString());
                txtValorParc.Text = vl.ToString("C");
                txtQtde.Text= dr["Cod Parcela"].ToString();
                
            }
            c.Desconecta();
            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtCodCp.Text = "";
            txtCodigo.Text = "";
            txtRazao.Text = "";
            TipoPagamento.Text = "";
            Status.Text = "";
            txtValor.Text = "";
            txtValorParc.Text = "";
            txtValorT.Text = "";
            txtObs.Text = "";
            txtJuros.Text = "";
            txtData.Text = "";
            txtQtde.Enabled = true;
            btnAtualiza.Enabled = true;
            txtValor.ReadOnly = false;
            txtJuros.ReadOnly = false;

            exibifornecedor();
            
            dataGridView1.Visible = false;
            dataGridParcelas.Visible = false;
            dataFornecedor.Visible = true;
            txtQtde.Text = "";
            btnSalva.Enabled = true;

        }
        public void exibifornecedor(){

            MySqlConnection conn = c.Conecta();
            String query = "SELECT Pes_in_codigo AS 'Codigo',Pes_st_tipo AS 'Tipo',Pes_st_razaosocial AS 'Razao Social',Pes_st_nomefantasia AS 'Nome Fantasia',Pes_st_cnpj AS 'CNPJ' FROM mec_tb_pessoas where  Pes_st_tipo in ('Fornecedor')";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            dataFornecedor.DataSource = dt;
            c.Desconecta();
        }
        Double  juros, valorParcela,valortotal,res,valor;

        private void button5_Click(object sender, EventArgs e)
        {
            c.Desconecta();
            if (txtCodCp.Text == "")
            {
                MessageBox.Show("Nenhuma Conta selecionada");


            }
            else
            {
                DialogResult exemplo1 = MessageBox.Show("Deseja realmente mudar status da conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (exemplo1 == DialogResult.Yes)
                {
                    Cp.CodigoConta1 = Convert.ToInt32(txtCodCp.Text);
                    Cp.Status = Status.Text;
                    Cp.mudarStatus();
                    MessageBox.Show("Status da conta alterado com sucesso");
                    exibirContas();

                    c.Desconecta();
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // exibirItensPArcela();
            //exibirContas();
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           double vl;
            if (e.RowIndex >= 0)
                {
               
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    txtCodCp.Text = row.Cells["Numero Conta"].Value.ToString();
                    TipoPagamento.Text = row.Cells["Tipo Pagamento"].Value.ToString();
              
                    Status.Text = row.Cells["Status"].Value.ToString();

                    txtJuros.Text = row.Cells["Juros"].Value.ToString();
                    //txtValorParc.Text
                    /// txtQtde.Text
                    txtData.Text = row.Cells["Data vencimento"].Value.ToString();
                Double.TryParse(txtValorT.Text, out vl);
                vl = Convert.ToDouble(row.Cells["Valor"].Value.ToString());
                txtValorT.Text = vl.ToString("C");
                    txtObs.Text = row.Cells["Obs"].Value.ToString();
              

                }
            
        }
         string codigo2;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
                //Ele faz uma select para consultar as parcelas , e traz as informações na variavel codigo
                MySqlConnection conn = c.Conecta();
                String query = "SELECT * FROM mec_tb_itemparcela where ContaP_in_codigo='" + txtCodCp.Text + "' ";

                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    codigo2 = dr["ContaP_in_codigo"].ToString();

                }
                c.Desconecta();
                //verifica se o codigo da conta existe na tabela de itemparcela, se existe exibe senão vai para mensagem
                if (codigo2 == txtCodCp.Text)
                {
                    DialogResult exemplo1 = MessageBox.Show("Deseja Exbir conta parcelada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (exemplo1 == DialogResult.Yes)
                    {

                        exibirItensPArcela();
                    txtQtde.ReadOnly = true;
                    btnAtualiza.Enabled = false;
                    dataGridView1.Visible = false;
                    dataGridParcelas.Visible = true;

                    }
                }
                else
                {
                    MessageBox.Show("Conta não tem parcelas");

                }
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            
            if (txtCodCp.Text == "")
            {
                MessageBox.Show("Nenhuma conta selecionada");
                c.Desconecta();

            }
            else
            {
                
                DialogResult Contas = MessageBox.Show("Deseja deletar conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Contas == DialogResult.Yes)
                {
                    Cp.CodigoConta1 = Convert.ToInt32(txtCodCp.Text);
                    Cp.deletarConta();
                    MessageBox.Show("Conta numero '" + txtCodCp.Text + "' deletada");
                    exibirContas();
                    dataGridView1.Visible = true;
                }
            }
        }

        private void FormContaPagar_Load(object sender, EventArgs e)
        {

        }

        private void TipoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if para verificar se a conta é a vista , se for a vista ele executa os comandos, 
            //zera os campos, e traz a data do dia, e bloqueia os campos
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione um fornecedor");
                TipoPagamento.Text = "";
                TipoPagamento.Enabled = false;
            }
            else
            if (TipoPagamento.Text == "A vista")
            {
                txtValorParc.Text = "00.00";
                txtQtde.Text = "0";
                txtQtde.ReadOnly = true;
               // Cp.data= DateTime.Now.ToShortDateString();
                txtData.ReadOnly = true;

            }else if(TipoPagamento.Text == "Parcelado")
            {
                txtValorParc.Text = "";
                txtQtde.Text = "";
                txtQtde.ReadOnly = false;
                txtData.Text = "";
                txtData.ReadOnly = false;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtJuros_MouseClick(object sender, MouseEventArgs e)
        {
            string procuraponto = txtValor.Text;
            if (procuraponto.Contains("."))
            {
                MessageBox.Show("Use virgula nos números");
                txtValor.Text = "";
            }
            else //if (procuraponto.Contains(","))
            {
             
                Double.TryParse(txtValor.Text, out valor);
                txtValor.Text = valor.ToString("C");
            }

            
            
         
        }
        string razao;
        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = c.Conecta();
            String query = "SELECT Pes_in_codigo AS 'Codigo',Pes_st_tipo AS 'Tipo',Pes_st_razaosocial" +
                " AS 'Razao Social',Pes_st_nomefantasia AS 'Nome Fantasia',Pes_st_cnpj AS 'CNPJ' FROM mec_tb_pessoas" +
                " where Pes_st_razaosocial like'" + txtBusca.Text + "%' and Pes_st_tipo in ('Fornecedor')";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                razao = txtBusca.Text;

            }
            c.Desconecta();
            if (txtBusca.Text == "")
            {
                MessageBox.Show("Campo vazio");
            }
            else if (txtBusca.Text != razao)
            {
                MessageBox.Show("Forncedor não existe");

            } 
            else
            {
               
                dataFornecedor.DataSource = dt;
                c.Desconecta();
            }
        }

        private void txtJuros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        public void exibirContas()
        {
            c.Desconecta();
            MySqlConnection conn = c.Conecta();
            String query = "SELECT ContaP_in_codigo AS 'Numero Conta',pes_in_codigo AS 'Cod Fornecedor',	ContaP_st_status AS 'Status',ContaP_re_totalPag AS 'Valor',ContaP_re_juros AS 'Juros',ContaP_st_formaPag AS 'Tipo Pagamento'," +
                "Contap_st_observacao AS 'Obs',ContaP_date_dataVenc AS 'Data vencimento' FROM mec_tb_contaspagar where pes_in_codigo='" + txtCodigo.Text +"' ";

            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
               c.Desconecta();

        }

        private void txtBusca_Click(object sender, EventArgs e)
        {
            txtBusca.Clear();
        }

        telaprincipal tela = new telaprincipal();
        private void button1_Click(object sender, EventArgs e)
        {
          
                if (txtCodigo.Text == "")
                {

                    MessageBox.Show("Selecione um fornecedor");

                }
                
                else 
                {

                if (TipoPagamento.Text == string.Empty)
                {
                    MessageBox.Show("Campo Tipo de pagamento vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TipoPagamento.BackColor = Color.Blue;
                }
                else if (Status.Text == string.Empty)
                {
                    MessageBox.Show("Campo Status vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Status.BackColor = Color.Blue;

                }

                else if (txtValor.Text == string.Empty)
                {
                    MessageBox.Show("Campo Valor vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValor.BackColor = Color.Blue;
                }
                else if (txtJuros.Text == string.Empty)
                {
                    MessageBox.Show("Campo Juros vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtJuros.BackColor = Color.Blue;
                }
                else if (txtValorParc.Text == string.Empty)
                {
                    MessageBox.Show("Campo Valor da parcela vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValorParc.BackColor = Color.Blue;
                }
                else if (txtQtde.Text == string.Empty)
                {
                    MessageBox.Show("Campo Quantidade de parcela vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQtde.BackColor = Color.Blue;
                }
                else if (txtData.Text == string.Empty)
                {
                    MessageBox.Show("Campo data de vencimento vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtData.BackColor = Color.Blue;
                }
                else if (txtValor.Text == string.Empty)
                {
                    MessageBox.Show("Campo Valor vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValor.BackColor = Color.Blue;
                }
                else if (txtValorT.Text == string.Empty)
                {
                    MessageBox.Show("Campo Valor total  vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValorT.BackColor = Color.Blue;
                }
                else
                {
                    DialogResult exemplo1 = MessageBox.Show("Deseja salvar conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (exemplo1 == DialogResult.Yes)
                    {

                        c.Desconecta();
                        Cp.CodigoForn = Convert.ToInt32(txtCodigo.Text);
                        Cp.TipoPag = TipoPagamento.Text;
                        Cp.Status = Status.Text;
                        Cp.Juros = txtJuros.Text;
                        //Valor total
                        string valor2 = txtValorT.Text;//declara variavel
                        valor2 = valor2.Replace("R$", "");// troca R$ por vazio
                        valor2 = valor2.Replace(".", "");//troca (ponto) por vazio
                        valor2 = valor2.Replace(",", ".");//troca (virgula) por (ponto)

                        Cp.Valor = valor2;
                        //Valor da parcela
                        string valor3 = txtValorParc.Text;//declara variavel
                        valor3 = valor3.Replace("R$", "");// troca R$ por vazio
                        valor3 = valor3.Replace(".", "");//troca (ponto) por vazio
                        valor3 = valor3.Replace(",", ".");//troca (virgula) por (ponto)
                        Cp.ValorPac =valor3 ;
                        Cp.Qtde = Convert.ToInt32(txtQtde.Text);
                        Cp.Observacao = txtObs.Text;
                        Cp.DataVenc = txtData.Text;
                        Cp.inserirConta();
                    
                        MessageBox.Show("Conta salva com sucesso");
                        // telaprincipal tp = new telaprincipal();//teste
                        
                       // tp.Abrirformhijo(new FormContaPagar());//teste
                        exibirContas();
                      
                        txtCodCp.Text = "";
                        txtCodigo.Text = "";
                        txtRazao.Text = "";
                        TipoPagamento.Text = "";
                        Status.Text = "";
                        txtValor.Text = "";
                        txtValorParc.Text = "";
                        txtValorT.Text = "";
                        txtObs.Text = "";
                        txtJuros.Text = "";
                        txtData.Text = "";
                         txtQtde.Text = "";
                        
                        dataGridView1.Visible = true;
                        c.Desconecta();
                    }
                }
              }
        }

        int qtdeParcela;

        private void button4_Click(object sender, EventArgs e)
        {
            //vireifcação para poder atualizar valor no campo
            if (TipoPagamento.Text== "")
            {
                MessageBox.Show("Escolha o tipo de pagamento!");
            }else if (txtValor.Text=="" || txtJuros.Text=="")
            {

                MessageBox.Show("Campo valor ou juros vazio");
            }

            else if (TipoPagamento.Text == "A vista")
             {
                string valor2 = txtValor.Text;//declara variavel
                valor2 = valor2.Replace("R$", "");// troca R$ por vazio
                
      
                Double.TryParse(txtJuros.Text, out juros);

                 Double.TryParse(valor2, out valor);

                 Double.TryParse(txtValorT.Text, out valortotal);

                 valor = ((juros / 100) * valor) + valor;
                 valortotal = valor;
                 txtValorT.Text = valortotal.ToString("C");


             }
             else
                //Se o parcelado for selecionado ele irá fazer esse calculo
                if (TipoPagamento.Text == "Parcelado")
             {
                 int.TryParse(txtQtde.Text, out qtdeParcela);
                 Double.TryParse(txtJuros.Text, out juros);

                 Double.TryParse(txtValorParc.Text, out valorParcela);
                string valor2 = txtValor.Text;//declara variavel
                valor2 = valor2.Replace("R$", "");// troca R$ por vazio
                Double.TryParse(valor2, out valor);
                 Double.TryParse(txtValorT.Text, out valortotal);

                 //calculo quando for parcelado
                 res = valor / qtdeParcela;
                 valorParcela = ((juros / 100) * res) + res;
                 valortotal = valorParcela * qtdeParcela;
                 txtValorParc.Text = valorParcela.ToString("C");
                 txtValorT.Text = valortotal.ToString("C");
             }
        }
    }
}
