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
    public partial class AlterarCliente : Form
    {
        public AlterarCliente()
        {
            InitializeComponent();
        }
        conexao conecta = new conexao();
        MySqlDataAdapter da,ct;
        DataTable dt,Ca;


        //Tras todos os clientes 
        public void display_data()
        {


            try
            {
                MySqlConnection conn = conecta.Conecta();
                String query = "SELECT Pes_in_codigo as 'Codigo',Pes_st_tipo as'Tipo',Pes_st_Nome as 'Nome',Pes_in_cpf as 'Cpf' ,Pes_st_sexo as 'Sexo',Pes_st_cidade as 'Cidade',Pes_st_bairro as 'Bairro',Pes_st_rua as 'Rua' ,Pes_in_numero as 'Numero', Pes_st_complemento as 'Complemento', Pes_st_uf as 'Uf' FROM mec_vw_cliente where  Pes_st_tipo in ('Cliente')";
                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dtg.DataSource = dt;
                conecta.Desconecta();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //trás no grid os contatos dos clientes
        public void display_cont()
        {
            try
            {
                MySqlConnection conn = conecta.Conecta();
                String query = "SELECT cont_in_codigo as Codigo,pes_in_codigo as 'IDCliente',cont_in_tel as Telefone,cont_in_cel as Celular, cont_st_email as Email FROM mec_tb_contato where Pes_in_codigo='" + txtcodigo.Text + "'";
                Ca = new DataTable();
                ct = new MySqlDataAdapter(query, conn);
                ct.Fill(Ca);
                dtContatos.DataSource = Ca;
                conecta.Desconecta();
            }catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AlterarPessoa_Load(object sender, EventArgs e)
        {

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            display_data();
        }

        //busca o fornecedor pelo nome
        private void btnbusca_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbusca.Text != "")
                {
                    MySqlConnection conn = conecta.Conecta();
                    String query = "SELECT Pes_in_codigo as Codigo,Pes_st_tipo as Tipo,Pes_st_Nome as Nome,Pes_in_cpf as Cpf ,Pes_st_sexo as Sexo,Pes_st_cidade as Cidade, Pes_st_Bairro as Bairro,Pes_st_rua as Rua ,Pes_in_numero as Numero, Pes_st_complemento as Complemento, Pes_st_uf as Uf FROM mec_vw_cliente where Pes_st_Nome like '" + txtbusca.Text + "%' and Pes_st_tipo in ('Cliente')";
                    dt = new DataTable();
                    da = new MySqlDataAdapter(query, conn);
                    da.Fill(dt);
                    dtg.DataSource = dt;
                    conecta.Desconecta();
                }
                else
                {
                    MessageBox.Show("Campo de busca Vazio", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        CadastroPessoa cad = new CadastroPessoa();
        //deleta o fornecedor

        private void btndeleteP_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {

                MessageBox.Show("Selecione um cliente");
            }
            else
            {
                if (MessageBox.Show("Deseja efetuar a Exclusao?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    cad.codigo = txtcodigo.Text;
                    cad.nome = txtnome.Text;
                    cad.numero = txtnumero.Text;
                    cad.tipo = comboTipo.Text;
                    cad.cpf = txtcpf.Text;
                    cad.bairro = txtbairro.Text;
                    cad.rua = txtrua.Text;
                    cad.complemento = txtcomple.Text;
                    cad.cidade = txtcidade.Text;
                    cad.uf = comboUf.Text;
                    cad.sexo = comboSexo.Text;
                    try
                    {
                       
                        cad.delCliente();
                        txtcodigo.Text = "";
                        txtnome.Text = "";
                        txtnumero.Text = "";
                        comboTipo.Text = "";
                        txtcpf.Text = "";

                        txtbairro.Text = "";
                        txtrua.Text = "";
                        txtcomple.Text = "";
                        txtcidade.Text = "";
                        comboUf.Text = "";
                        comboSexo.Text = "";

                        MessageBox.Show("Deletado com sucesso");
                        display_data();
                        display_cont();
                       
                    }
                    catch(System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                    
            }
        }

        //prenche o formulario com as informaçoes do grid 
        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtg.Rows[e.RowIndex];


                txtcodigo.Text = row.Cells["Codigo"].Value.ToString();
                comboTipo.Text = row.Cells["Tipo"].Value.ToString();
                txtnome.Text = row.Cells["Nome"].Value.ToString();
                txtcpf.Text = row.Cells["Cpf"].Value.ToString();
                comboSexo.Text = row.Cells["Sexo"].Value.ToString();
                txtbairro.Text = row.Cells["Bairro"].Value.ToString();

                txtrua.Text = row.Cells["Rua"].Value.ToString();
                txtnumero.Text = row.Cells["Numero"].Value.ToString();
                txtcomple.Text = row.Cells["Complemento"].Value.ToString();
                txtcidade.Text = row.Cells["Cidade"].Value.ToString();
                comboUf.Text = row.Cells["Uf"].Value.ToString();
                display_cont();
                txtTel.Text = "";
                txtCel.Text = "";
                txtEmail.Text = "";
                textIdContatoP.Text = "";
            }

        }

        // altera as informaçoes do Cliente

        private void btnsalvaP_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                MessageBox.Show("Slecione um cliente");

            }
            else
            {
                if (MessageBox.Show("Deseja efetuar a Alteração?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    conexao c = new conexao();
                    MySqlCommand cmd = new MySqlCommand();
                    try
                    {
                        cmd.Connection = c.Conecta();

                        cmd.CommandText = "UPDATE mec_tb_pessoas SET Pes_st_Nome='" + txtnome.Text + "',Pes_st_tipo= '" + comboTipo.Text + "',Pes_in_cpf='" + txtcpf.Text + "',Pes_st_bairro='" + txtbairro.Text + "',Pes_st_rua='" + txtrua.Text + "',Pes_st_complemento='" + txtcomple.Text + "',Pes_st_cidade='" + txtcidade.Text + "',Pes_st_uf='" + comboUf.Text + "',Pes_st_sexo='" + comboSexo.Text + "',Pes_in_numero='" + txtnumero.Text + "' WHERE Pes_in_codigo='" + txtcodigo.Text + "'";

                        cmd.ExecuteNonQuery();
                        cmd.Connection = c.Desconecta();

                        MessageBox.Show("Alterado com sucesso");
                        display_data();
                    }
                    catch
                    {
                        MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                   
            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        //preenche o formulario de contato com as informaços do grid
        private void dtContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtContatos.Rows[e.RowIndex];

                textIdContatoP.Text = row.Cells["Codigo"].Value.ToString();
                txtTel.Text = row.Cells["Telefone"].Value.ToString();
                txtCel.Text = row.Cells["Celular"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();


            }
        }

        //insere um novo contato
        private void btnAddContato_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {

                MessageBox.Show("Selecione um Cliente");
            }
            else
            {
                if(txtCel.Text =="")
                {
                    MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(txtTel.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos","Importante",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else if(txtEmail.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (textIdContatoP.Text == "")
                    {
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
                            MessageBox.Show("Contato Salvo");
                            display_cont();
                        }
                        catch
                        {
                            MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este contato ja existe", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        textIdContatoP.Text = "";
                        txtTel.Text = "";
                        txtCel.Text = "";
                        txtEmail.Text = "";
                    }
                }


              
                
                
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        //deleta o contato
        private void button4_Click(object sender, EventArgs e)
        {

            if (textIdContatoP.Text == "")
            {

                MessageBox.Show("Selecione um contato");
            }
            else
            {
                if (MessageBox.Show("Deseja efetuar a Exclusao?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CadastroPessoa cad = new CadastroPessoa();
                    cad.idcontato = textIdContatoP.Text;
                    cad.telefone = txtTel.Text;
                    cad.celular = txtCel.Text;
                    cad.email = txtEmail.Text;
                    try
                    {

                        cad.delContato();

                        txtTel.Text = "";
                        txtCel.Text = "";
                        txtEmail.Text = "";
                        MessageBox.Show("Contato Deletado");
                        display_cont();
                    }
                    catch
                    {
                        MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                    
            }
        }
        //altera contato da pessoa
        private void button1_Click(object sender, EventArgs e)
        {
            if (textIdContatoP.Text == "")
            {

                MessageBox.Show("Selecione um contato");
            }
            else
            {
                if (MessageBox.Show("Deseja efetuar a Alteração", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CadastroPessoa cad = new CadastroPessoa();
                    cad.idcontato = textIdContatoP.Text;
                    cad.telefone = txtTel.Text;
                    cad.celular = txtCel.Text;
                    cad.email = txtEmail.Text;

                    try
                    {
                        cad.alteraContato();
                        txtTel.Text = "";
                        txtCel.Text = "";
                        txtEmail.Text = "";
                        MessageBox.Show("contato alterado");
                        display_cont();
                    }
                    catch
                    {
                        MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                 

            }
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void dtg_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtContatos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
        //metodo que chma uma tela dentro da outra
        public void Abrirformhijo(object formhijo)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form gh = formhijo as Form;
            gh.TopLevel = false;
            gh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(gh);
            this.panel2.Tag = gh;
            gh.Show();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            Abrirformhijo(new FormPessoa());
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
        private void button2_Click(object sender, EventArgs e)
        {
            var cep = txtCep.Text;
            ConsultaCEP(cep);
        }

        private void txtrua_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbusca_Click(object sender, EventArgs e)
        {
            txtbusca.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtContatos_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

       


     
    }
}
