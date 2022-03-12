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
    public partial class FormContaReceber : Form
    {
        public FormContaReceber()
        {
            InitializeComponent();
        }
        conexao conecta = new conexao();
        MySqlDataAdapter da;
        DataTable dt;
        string codigo,codigo2;
  
        public void exibirClientes()
        {
            MySqlConnection conn = conecta.Conecta();
            String query = "SELECT Pes_in_codigo AS 'Codigo',Pes_st_tipo AS 'Tipo',Pes_st_Nome AS 'Nome',Pes_in_cpf AS 'CPF' FROM mec_vw_cliente where  Pes_st_tipo in ('Cliente')";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            dataCliente.DataSource = dt;
            conecta.Desconecta();
        }
        public void exibirContasr()
        {
            MySqlConnection conn = conecta.Conecta();
            String query = "SELECT ContaR_in_codigo AS 'Cod Conta',venda_in_codigo AS 'Cod Venda',ContaR_st_status AS 'Status'," +
                "ContaR_re_totalPag AS 'Valor',ContaR_date_dataVenc AS 'Data Vencimento',ContaR_re_juros AS 'Juros',ContaR_st_formaPag AS 'Forma pagamento',ContaR_st_observacao AS 'Obs'	" +
                " FROM mec_tb_contasreceber where Venda_in_codigo='" + txtCodCr.Text + "' ";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conecta.Desconecta();

        }
        public void exibirVendas()
        {
        
            MySqlConnection conn = conecta.Conecta();
            String query = "SELECT Venda_in_codigo AS 'Cod Vendas',pes_in_codigo AS 'Cod Cliente',Venda_date_data AS 'Data',Venda_re_valorTotal AS 'Valor Total'  FROM mec_tb_vendas where Pes_in_codigo='" + txtCodigo.Text+"'";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            dataConta.DataSource = dt;
            conecta.Desconecta();

        }
        public void exibirItensPArcela()
        {
            double valorP;
            MySqlConnection conn = conecta.Conecta();
            String query = "SELECT 	ItemParc_in_codigo,Venda_in_codigo,ItemParc_in_numeroParc,ItemParc_re_Valor,ItemParc_date_dataVenc FROM mec_tb_itemparcela where Venda_in_codigo='" + txtCodCr.Text + "' ";

            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            foreach (DataRow dr in dt.Rows)
            {
                Double.TryParse(txtValorT.Text, out valorP);
                valorP =Convert.ToDouble( dr["ItemParc_re_Valor"].ToString());
                txtValorParc.Text = valorP.ToString("C");
                txtQtde.Text = dr["ItemParc_in_numeroParc"].ToString();
            }
            conecta.Desconecta();

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void FormContaReceber_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            exibirClientes();
              dataCliente.Visible = true;
            dataCliente.Enabled = true;
            dataConta.Visible = false;
            dataGridView1.Visible = false;
            btnAltera.Enabled = true;
            txtCodigo.Text = "";
            txtNome.Text = "";
            TipoPagamento.Text = "";
            Status.Text = "";
            txtCodCr.Text = "";
            txtJuros.Text = "";
            txtValorParc.Text = "";
            txtQtde.Text = "";
            txtData.Text = "";
            txtValorT.Text = "";
            txtObs.Text = "";
        }


    
    public void mudarStatus()
    {
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conecta.Conecta();



        cmd.CommandText = "UPDATE mec_tb_contasreceber set ContaR_st_status='" + Status.Text + "' where Venda_in_codigo='" + txtCodCr.Text + "'";

        cmd.ExecuteNonQuery();


        conecta.Desconecta();

    }
    private void dataCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

          
         
                if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataCliente.Rows[e.RowIndex];


                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                //para verificar se cliente possue alguma venda efetuada
                MySqlConnection conn = conecta.Conecta();
                String query = "SELECT * FROM mec_tb_vendas where Pes_in_codigo='" + txtCodigo.Text + "'";
                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    codigo2 = dr["Pes_in_codigo"].ToString();

                }
                conecta.Desconecta();
                DialogResult Contas = MessageBox.Show("Deseja Exbir Vendas feitas para esse Cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               

                    if (Contas == DialogResult.Yes)
                    {
                    if (codigo2 == txtCodigo.Text)
                    {

                        exibirVendas();
                        dataConta.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Cliente não possue vendas");
                    }
                }
                    else
                    {
                        exibirClientes();

                    }
                
             }
            
        }

        private void dataConta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataConta.Rows[e.RowIndex];


                txtCodCr.Text = row.Cells["Cod Vendas"].Value.ToString();
                DialogResult Contas = MessageBox.Show("Deseja Exbir Conta?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Contas == DialogResult.Yes)
                {
                    exibirContasr();
                    dataConta.Visible = false;
                    dataGridView1.Visible = true;
                    dataGridView1.Enabled = true;
                    dataCliente.Enabled = false;

                    

                }
            }

            }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double valorT;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row2 = this.dataGridView1.Rows[e.RowIndex];
                //  txtCodCr.Text = row2.Cells["venda_in_codigo"].Value.ToString();
                TipoPagamento.Text = row2.Cells["Forma pagamento"].Value.ToString();
                Status.Text = row2.Cells["Status"].Value.ToString();

                txtJuros.Text = row2.Cells["Juros"].Value.ToString();
                //txtValorParc.Text
                /// txtQtde.Text
                txtData.Text = row2.Cells["Data Vencimento"].Value.ToString();

                Double.TryParse(txtValorT.Text, out valorT);
                valorT=Convert.ToDouble(row2.Cells["Valor"].Value.ToString());
                txtValorT.Text = valorT.ToString("C");
                txtObs.Text = row2.Cells["Obs"].Value.ToString();
                btnAltera.Enabled = true;
                conecta.Desconecta();
                MySqlConnection conn = conecta.Conecta();
                String query = "SELECT * FROM mec_tb_itemparcela where Venda_in_codigo='" + txtCodCr.Text + "' ";

                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    codigo = dr["Venda_in_codigo"].ToString();

                }
                conecta.Desconecta();
                //verifica se o codigo da conta existe na tabela de itemparcela, se existe exibe senão vai para mensagem
                if (codigo == txtCodCr.Text)
                {
                    DialogResult exemplo1 = MessageBox.Show("Deseja exibir parcelas?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (exemplo1 == DialogResult.Yes)
                    {

                        exibirItensPArcela();
                        dataGridView1.Enabled = false;
                        //bloquear datagrid do cliente
                        dataCliente.Enabled = false;
                        btnAltera.Enabled = false;

                    }
                }
                else
                {
                    MessageBox.Show("Conta não tem parcelas");

                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnbusca_Click(object sender, EventArgs e)
        {
            dataConta.Visible = false;
            dataGridView1.Visible = false;
            dataCliente.Visible = true;

            try
            {
                if (txtbusca.Text != "")
                {
                    MySqlConnection conn = conecta.Conecta();
                    String query = "SELECT Pes_in_codigo as Codigo,Pes_st_tipo as Tipo,Pes_st_Nome as Nome,Pes_in_cpf as Cpf ,Pes_st_sexo as Sexo,Pes_st_cidade as Cidade, Pes_st_Bairro as Bairro,Pes_st_rua as Rua ,Pes_in_numero as Numero, Pes_st_complemento as Complemento, Pes_st_uf as Uf FROM mec_vw_cliente where Pes_st_Nome like '" + txtbusca.Text + "%' and Pes_st_tipo in ('Cliente')";
                    dt = new DataTable();
                    da = new MySqlDataAdapter(query, conn);
                    da.Fill(dt);
                    dataCliente.DataSource = dt;
                    conecta.Desconecta();
                }
                else
                {
                    MessageBox.Show("Campo de busca Vazio", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtbusca_Click(object sender, EventArgs e)
        {
            txtbusca.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mudarStatus();
            MessageBox.Show("Status Alterado");
           // btnAltera.Enabled = false;
            exibirContasr();
          //  dataCliente.Visible = true;
           // dataConta.Visible = false;
           // dataGridView1.Visible = false;
        }
    }
}
