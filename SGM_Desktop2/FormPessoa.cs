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

    using SGM_Desktop2.webCEP;
    using System.Runtime.InteropServices;

    public partial class FormPessoa : Form
    {
        [DllImport("wininet.dll")]

        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);//variavel para verificação de conexao com internet
        CadastroPessoa cad = new CadastroPessoa();
        conexao conecta = new conexao();
        public FormPessoa()
        {

            
            InitializeComponent();
     

        }
        //metodo que chma uma tela dentro da outra
        public void Abrirformhijo(object formhijo)
        {
            if (this.panelPessoa.Controls.Count > 0)
                this.panelPessoa.Controls.RemoveAt(0);
            Form gh = formhijo as Form;
            gh.TopLevel = false;
            gh.Dock = DockStyle.Fill;
            this.panelPessoa.Controls.Add(gh);
            this.panelPessoa.Tag = gh;
            gh.Show();


        }

        private void subForm1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboTipo.Text = "Fornecedor";
            comboTipo.Enabled = false;
        
            txtcpf.Visible = false;
            labelcpf.Visible = false;
            comboSexo.Visible = false;
            labelsexo.Visible = false;
            txtnome.Visible = false;
            labelnome.Visible = false;

            txtcnpj.Visible = true;
            labelcnpj.Visible = true;
            txtfantasia.Visible = true;
            txtrazao.Visible = true;
            labelrazao.Visible = true;
            labelfantasia.Visible = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboTipo.Text = "Cliente";
            comboTipo.Enabled = false;
         
            txtcnpj.Visible = false;
            labelcnpj.Visible = false;
            txtfantasia.Visible = false;
            txtrazao.Visible = false;
            labelrazao.Visible = false;
            labelfantasia.Visible = false;

            txtcpf.Visible = true;
            labelcpf.Visible = true;
            comboSexo.Visible = true;
            labelsexo.Visible = true;
            txtnome.Visible = true;
            labelnome.Visible = true;
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string valor = txtcpf.Text;

            string valor2 = txtcnpj.Text;

      


            if (radioPf.Checked)
            {
            
                if (comboTipo.Text == "")
                {
                    MessageBox.Show("Preencha o campo TIPO");
                }
                else
               if (txtnome.Text == "")
                {
                    MessageBox.Show("Preencha o campo Nome");

                }
                else if (txtcpf.Text == "   .   .   -")
                {

                    MessageBox.Show("Preencha o campo CPF");

                }else if (comboSexo.Text == "")
                {
                    MessageBox.Show("Preencha o campo Sexo");

                }
            
                    else if (txtcidade.Text == "")
                {
                    MessageBox.Show("Preencha o campo cidade");


                }
                else if (comboUf.Text == "")
                {

                    MessageBox.Show("Preencha o campo UF");
                }
                else
                if (txtbairro.Text == "")
                {

                    MessageBox.Show("Preencha o campo Bairro");
                }
                else if (txtrua.Text == "")
                {

                    MessageBox.Show("Preencha o campo Rua");
                }
                else if (txtnumero.Text == "")
                {

                    MessageBox.Show("Preencha o campo numero");
                }
            


                else
                {

                    if (ValidaCpf.IsCpf(valor))
                    {
                        MessageBox.Show("O número é um CPF Válido !");


                        try
                        {
                            cad.nome = txtnome.Text;
                        cad.numero = txtnumero.Text;
                        cad.tipo = comboTipo.Text;
                        cad.cpf = valor;
                        cad.bairro = txtbairro.Text;
                        cad.rua = txtrua.Text;
                        cad.complemento = txtcomple.Text;
                        cad.cidade = txtcidade.Text;
                        cad.uf = comboUf.Text;
                        cad.sexo = comboSexo.Text;
                        cad.telefone = txtTelefone.Text;
                        cad.celular = txtCel.Text;
                        cad.email = txtEmail.Text;

                            cad.CadPf();
                            MessageBox.Show("Cadastrado com sucesso!");
                            txtnome.Text = "";

                            txtnumero.Text = "";
                            txtcpf.Text = "";
                            txtbairro.Text = "";
                            txtrua.Text = "";
                            txtnumero.Text = "";
                            txtcomple.Text = "";
                            txtcidade.Text = "";
                            comboUf.Text = "";
                            txtTelefone.Text = "";
                            txtCel.Text = "";
                            txtEmail.Text = "";
                        }
                        catch
                        {
                            MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {

                        MessageBox.Show("O número é um CPF Inválido !");
                    }
                }
            }
            else if (radioPj.Checked)
            {
               
                if (comboTipo.Text == "")
                {
                    MessageBox.Show("Preencha o campo TIPO");
                }else

                if (txtrazao.Text == "")
                {
                    MessageBox.Show("Preencha o campo Razao Social");

                }
                else if (txtfantasia.Text == "")
                {
                    MessageBox.Show("Preencha o campo Nome Fantasia");

                }
                else if (txtcnpj.Text == "  .   .   /    -")
                {

                    MessageBox.Show("Preencha o campo CNPJ");
                }
                else if (txtcidade.Text == "")
                {
                    MessageBox.Show("Preencha o campo cidade");


                }
                else if (comboUf.Text == "")
                {

                    MessageBox.Show("Preencha o campo UF");
                }

                else if (txtbairro.Text == "")
                {

                    MessageBox.Show("Preencha o campo Bairro");
                }
                else if (txtrua.Text == "")
                {

                    MessageBox.Show("Preencha o campo Rua");
                }
                else if (txtnumero.Text == "")
                {

                    MessageBox.Show("Preencha o campo numero");
                }
               
                else

                {
                    

                    if (ValidaCnpj.IsCnpj(valor2))
                    {
                        MessageBox.Show("O número é um CNPJ Válido !");
                        cad.tipo = comboTipo.Text;
                        cad.razaosocial = txtrazao.Text;
                        cad.nomefantasia = txtfantasia.Text;
                        cad.cnpj = valor2;
                        cad.bairro = txtbairro.Text;
                        cad.rua = txtrua.Text;
                        cad.numero = txtnumero.Text;
                        cad.complemento = txtcomple.Text;
                        cad.cidade = txtcidade.Text;
                        cad.uf = comboUf.Text;
                        cad.telefone = txtTelefone.Text;
                        cad.celular = txtCel.Text;
                        cad.email = txtEmail.Text;

                        cad.cadPj();
                        MessageBox.Show("Cadastrado com sucesso!");
                        txtrazao.Text = "";
                        txtfantasia.Text = "";
                        txtcnpj.Text = "";
                        txtbairro.Text = "";
                        txtrua.Text = "";
                        txtnumero.Text = "";
                        txtcomple.Text = "";
                        txtcidade.Text = "";
                        comboUf.Text = "";
                        txtTelefone.Text = "";
                        txtCel.Text = "";
                        txtEmail.Text = "";
                    }
                    else
                    {

                        MessageBox.Show("O número é um CNPJ Inválido !");
                    }
                }

            }
            else
            {
                MessageBox.Show("Selecione Pessoa Fisíca ou Jurídica");
            }

        }

        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
      
        }
        public void ConsultaCEP(string cep)
        {


            using (var ws = new AtendeClienteClient())
            {


                if (!string.IsNullOrWhiteSpace(txtCep.Text))
                {

                    try
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
                    catch
                    {
                        MessageBox.Show("Erro, CEP inválido");

                    }


                }
                else
                {
                    MessageBox.Show("Informe um CEP válido");
                }

            }

        }
        int desc;
        private void button2_Click(object sender, EventArgs e)
        {
            string NomeDaVariavel = txtCep.Text;//variavel para contar caracteres


            //length conta numero de caracteres, necessario para saber se o cep digitado possue a quantidade de caractere correta
            if (Convert.ToInt32(NomeDaVariavel.Length) == 8)
            {
                if (InternetGetConnectedState(out desc, 0) == true)
                {
                    var cep = txtCep.Text;
                    ConsultaCEP(cep);
                }

                else
                {
                    MessageBox.Show("Sem conexão com a internet");

                }
            }
            else
            {
                MessageBox.Show("Falta digitos CEP inválido");

            }




        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
         
        }
        

        
        private void btnAlteraP_Click(object sender, EventArgs e)
        {
            //AlterarCliente atCli = new AlterarCliente();
           // atCli.Show();
            panelPessoa1.Visible = false;
            Abrirformhijo(new AlterarCliente());
        
        }

        private void btnAdContato_Click(object sender, EventArgs e)
        {

        }

        private void panelPessoa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //AlteraFornecedor atCli = new AlteraFornecedor();
           // atCli.Show();
             panelPessoa1.Visible = false;
              Abrirformhijo(new AlteraFornecedor());
        }

        private void panelPessoa_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
