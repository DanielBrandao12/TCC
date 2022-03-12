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
using SGM_Desktop2.webCEP;

namespace SGM_Desktop2
{
    public partial class AlteraFornecedor : Form
    {
        public AlteraFornecedor()
        {
            InitializeComponent();
        }

        conexao conecta = new conexao();
        MySqlDataAdapter da, ct;
        DataTable dt, Ca;

        //faz a buca pelo nome do Fornecedor
        private void btnbusca_Click(object sender, EventArgs e)
        {
            if (txtbusca.Text != "")
            {
                try
                {
                    MySqlConnection conn = conecta.Conecta();
                    String query = "SELECT Pes_in_codigo As 'Codigo',Pes_st_razaosocial As 'Razao Social',Pes_st_nomefantasia As 'Nome Fantasia', Pes_st_cnpj As 'CNPJ',Pes_st_cidade As 'Cidade',Pes_st_bairro As 'Bairro',Pes_st_rua As 'Rua',Pes_in_numero As 'Numero',Pes_st_uf As 'UF',Pes_st_complemento As 'Complemento' FROM mec_tb_pessoas where Pes_st_nomefantasia like '" + txtbusca.Text + "%' and Pes_st_tipo in ('Fornecedor')";
                    dt = new DataTable();
                    da = new MySqlDataAdapter(query, conn);
                    da.Fill(dt);
                    dtg.DataSource = dt;
                    conecta.Desconecta();
                }
                catch
                {
                    MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Porfavor Informe a Razão Social", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //altera o fornecedor
        private void button5_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                MessageBox.Show("Selecione um fornecedor");

            }
            else
            {
                if (MessageBox.Show("Deseja efetuar a Alteração", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    conexao c = new conexao();
                    MySqlCommand cmd = new MySqlCommand();
                    try{
                        cmd.Connection = c.Conecta();

                        cmd.CommandText = "UPDATE mec_tb_pessoas SET Pes_st_razaosocial ='" + txtRaSocial.Text + "',Pes_st_nomefantasia = '" + txtfantasia.Text + "' ,Pes_st_tipo= '" + comboTipo.Text + "',Pes_st_cnpj='" + txtcnpj.Text + "',Pes_st_bairro='" + txtbairro.Text + "',Pes_st_rua='" + txtrua.Text + "',Pes_st_complemento='" + txtcomple.Text + "',Pes_st_cidade='" + txtcidade.Text + "',Pes_st_uf='" + comboUf.Text + "',Pes_in_numero='" + txtnumero.Text + "' WHERE Pes_in_codigo='" + txtcodigo.Text + "'";

                        cmd.ExecuteNonQuery();
                        cmd.Connection = c.Desconecta();
                        MessageBox.Show("Alterado com sucesso");
                        display_Forne();

                    }
                    catch 
                    {
                        MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                  
                }
                    
            }
        }
        //deleta o fornecedor
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                MessageBox.Show("Selecione um fornecedor");

            }
            else
            {
                if (MessageBox.Show("Deseja efetuar a Exclusao?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CadastroPessoa cad = new CadastroPessoa();
                    cad.codigo = txtcodigo.Text;
                    cad.nomefantasia = txtfantasia.Text;
                    cad.razaosocial = txtRaSocial.Text;
                    cad.numero = txtnumero.Text;
                    cad.tipo = comboTipo.Text;
                    cad.cnpj = txtcnpj.Text;
                    cad.bairro = txtbairro.Text;
                    cad.rua = txtrua.Text;
                    cad.complemento = txtcomple.Text;
                    cad.cidade = txtcidade.Text;
                    cad.uf = comboUf.Text;

                    try
                    {


                        cad.delForne();

                        txtcodigo.Text = "";
                        txtfantasia.Text = "";
                        txtRaSocial.Text = "";
                        txtnumero.Text = "";
                        comboTipo.Text = "";
                        txtcnpj.Text = "";

                        txtbairro.Text = "";
                        txtrua.Text = "";
                        txtcomple.Text = "";
                        txtcidade.Text = "";
                        comboUf.Text = "";


                        MessageBox.Show("Deletado com sucesso");
                        display_Forne();
                        display_contatos();
                    }
                    catch
                    {
                        MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                  
            }
        }

       

        //tras no grid os fornecedores
        public void display_Forne()
        {
            try
            {
                MySqlConnection conn = conecta.Conecta();
                String query = "SELECT Pes_in_codigo As 'Codigo',Pes_st_razaosocial As 'Razao Social',Pes_st_nomefantasia As 'Nome Fantasia', Pes_st_cnpj As 'CNPJ',Pes_st_cidade As 'Cidade',Pes_st_bairro As 'Bairro',Pes_st_rua As 'Rua',Pes_in_numero As 'Numero',Pes_st_uf As 'UF',Pes_st_complemento As 'Complemento' FROM mec_tb_pessoas where  Pes_st_tipo in ('Fornecedor')";
                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dtg.DataSource = dt;
                conecta.Desconecta();
            }
            catch
            {
                MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtContatoForne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtContatoForne.Rows[e.RowIndex];

                textIdContato.Text = row.Cells["Codigo"].Value.ToString();
                txtTel.Text = row.Cells["Telefone"].Value.ToString();
                txtCel.Text = row.Cells["Celular"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();


            }
        }

        //add novo contato ao fornecedor
        private void btnAddContato_Click(object sender, EventArgs e)
        {
            // valida se foi selecionado um Fornecedor
            if (txtcodigo.Text == "")
            {

                MessageBox.Show("Selecione um Fornecedor");
            }
            else
            {
                if(textIdContato.Text == "")
                {
                    //Valida campos em branco
                    if(txtTel.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }else if(txtCel.Text == ""){
                        MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } else if (txtEmail.Text == ""){
                        MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        //efetua um cadastro novo
                        CadastroPessoa cad = new CadastroPessoa();

                        cad.codigo = txtcodigo.Text;
                        cad.telefone = txtTel.Text;
                        cad.celular = txtCel.Text;
                        cad.email = txtEmail.Text;
                        try
                        {
                            cad.AdNovoContato();
                            txtTel.Text = "";
                            txtCel.Text = "";
                            txtEmail.Text = "";
                            display_contatos();
                        }
                        catch
                        {
                            MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    


                }
                else
                {
                    MessageBox.Show("Contato ja existe!","",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                
            }
        }

        //altera o contato do fornecedor
        private void button1_Click(object sender, EventArgs e)
        {
            if (textIdContato.Text == "")
            {

                MessageBox.Show("Selecione um contato");
            }
            else
            {
                if (MessageBox.Show("Deseja efetuar a Alteração", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CadastroPessoa cad = new CadastroPessoa();
                    cad.idcontato = textIdContato.Text;
                    cad.telefone = txtTel.Text;
                    cad.celular =txtCel.Text;
                    cad.email = txtEmail.Text;
                    try
                    {


                        cad.alteraContato();
                        txtTel.Text = "";
                        txtCel.Text = "";
                        txtEmail.Text = "";
                        MessageBox.Show("contato alterado");
                        display_contatos();
                    }
                    catch
                    {
                        MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                    
            }
        }

        //deletar contato
        private void button4_Click(object sender, EventArgs e)
        {
            if (textIdContato.Text == "")
            {

                MessageBox.Show("Selecione um contato");
            }
            else
            {
                if (MessageBox.Show("Deseja efetuar a Exclusao?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CadastroPessoa cad = new CadastroPessoa();
                    cad.idcontato = textIdContato.Text;
                    cad.telefone =txtTel.Text;
                    cad.celular = txtCel.Text;
                    cad.email = txtEmail.Text;

                    try
                    {
                        cad.delContato();

                        txtTel.Text = "";
                        txtCel.Text = "";
                        txtEmail.Text = "";
                        MessageBox.Show("Contato Deletado");
                        display_contatos();
                    }
                    catch
                    {
                        MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                   
            }
        }

        //metodo que chma uma tela dentro da outra
        public void Abrirformhijo(object formhijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form gh = formhijo as Form;
            gh.TopLevel = false;
            gh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(gh);
            this.panel1.Tag = gh;
            gh.Show();


        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            panelPessoa.Visible = false;
            panel1.Visible = true;
            Abrirformhijo(new FormPessoa());

        }

        private void panelPessoa_Paint(object sender, PaintEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.txtbusca, "Digite a Razão Social");

            ToolTip toolTip2 = new ToolTip();
            toolTip1.SetToolTip(this.button1, "Volte para tela de Cadastro");
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              

                DataGridViewRow row = this.dtg.Rows[e.RowIndex];
            
                txtcodigo.Text = row.Cells["Codigo"].Value.ToString();
                //comboTipo.Text = row.Cells["Tipo"].Value.ToString();
                txtRaSocial.Text = row.Cells["Razao Social"].Value.ToString();
                txtfantasia.Text = row.Cells["Nome Fantasia"].Value.ToString();
                txtcnpj.Text = row.Cells["CNPJ"].Value.ToString();

                txtbairro.Text = row.Cells["Bairro"].Value.ToString();
                txtrua.Text = row.Cells["Rua"].Value.ToString();
                txtnumero.Text = row.Cells["Numero"].Value.ToString();
                txtcomple.Text = row.Cells["Complemento"].Value.ToString();
                txtcidade.Text = row.Cells["Cidade"].Value.ToString();
                comboUf.Text = row.Cells["UF"].Value.ToString();
              
                display_contatos();
                txtTel.Text = "";
                txtCel.Text = "";
                txtEmail.Text = "";
                textIdContato.Text = "";

            }

        }

        private void dtContatoForne_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtContatoForne.Rows[e.RowIndex];

                textIdContato.Text = row.Cells["Codigo"].Value.ToString();
               txtTel.Text = row.Cells["Telefone"].Value.ToString();
                txtCel.Text = row.Cells["Celular"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();


            }
        }
        public void ConsultaCEP(string cep)
        {

            using (var ws = new AtendeClienteClient())
            {


                if (!string.IsNullOrWhiteSpace(txtCep.Text))
                {
                    var resposta = ws.consultaCEP(cep);

                    if (resposta != null)
                    {

                        txtrua.Text = String.Format(" {0}", resposta.end);
                        txtbairro.Text = (String.Format(" {0}", resposta.bairro));
                        txtcidade.Text = (String.Format(" {0}", resposta.cidade));
                        comboUf.Text = (String.Format("{0}", resposta.uf));


                    }
                    else
                    {
                        MessageBox.Show("Cep não localizado...");
                    }
                }
                else
                {
                    MessageBox.Show("Informe um CEP válido");
                }
            }





        }
        private void button3_Click(object sender, EventArgs e)
        {

            var cep = txtCep.Text;
            ConsultaCEP(cep);
        }

        private void txtbusca_Click(object sender, EventArgs e)
        {
            txtbusca.Clear();
        }

        private void dtg_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        //trás no grid os contatos 
        public void display_contatos()
        {
            try
            {

                MySqlConnection conn = conecta.Conecta();
                String query = "SELECT cont_in_codigo as Codigo,pes_in_codigo as 'IDCliente',cont_in_tel as Telefone,cont_in_cel as Celular, cont_st_email as Email FROM mec_tb_contato where Pes_in_codigo='" + txtcodigo.Text + "'";
                Ca = new DataTable();
                ct = new MySqlDataAdapter(query, conn);
                ct.Fill(Ca);
                dtContatoForne.DataSource = Ca;
                conecta.Desconecta();
            }
            catch
            {
                MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        //exibe todos fornecedores
        private void btnexibir_Click(object sender, EventArgs e)
        {
            display_Forne();
        }
    }
}
