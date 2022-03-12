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
using Root.Reports;

namespace SGM_Desktop2
{
    public partial class FormServico : Form
    {
        public FormServico()
        {
            InitializeComponent();


           


        }

        conexao c = new conexao();
        MySqlDataAdapter da, ct;
        DataTable dt;
        Vendas ven = new Vendas();


        double desconto, totalprod, valorser, valortotal,qtdeParcela,juros,valorParcela,res;
        private void Form1_Load(object sender, EventArgs e)
        {
            //carregar nomes de clientes no combobox,
            // linha 83 e 84 pegar id do nome selecionado no combobox e exibir no campo de texto
            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = c.Conecta();


            cmd3.CommandText = "Select Pes_in_codigo,Pes_st_Nome from mec_tb_pessoas where  Pes_st_tipo in ('Cliente')";


            MySqlDataReader dr = cmd3.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            clienteLista.ValueMember = "Pes_in_codigo";

            clienteLista.DisplayMember = "Pes_st_Nome";
            clienteLista.DataSource = dt;
            c.Desconecta();
            txtCodigoCli.Text = "";
            clienteLista.Text = "Selecione um Cliente";
            txtCodigoVec.Text = "";
            veiculoLista.Text = "";
            // ***********************************



           // txtValorParc.Enabled = false;
            //txtValorTotal.Enabled = false;
           
           



        }
      
        public void calculoDesconto()
        {
            //Calculo de desconto

            string valor5 = txtValorTotal.Text;//declara variavel
            valor5 = valor5.Replace("R$", "");// troca R$ por vazio
                            valor5 = valor5.Replace(".", "");//troca (ponto) por vazio
            valor5 = valor5.Replace(".", ",");//troca (virgula) por (ponto)
            Double.TryParse(valor5, out totalprod);

          
            string valor3 = txtValorS.Text;//declara variavel
            valor3 = valor3.Replace("R$", "");// troca R$ por vazio
                   valor3 = valor3.Replace(".", "");//troca (ponto) por vazio
            valor3 = valor3.Replace(".", ",");//troca (virgula) por (ponto)
            Double.TryParse(valor3, out valorser);
            Double.TryParse(txtdesconto.Text, out desconto);
             Double.TryParse(txtValorT.Text, out valortotal);
          
            valortotal = (totalprod + valorser) - desconto;

            //Se o parcelado for selecionado ele irá fazer esse calculo
            if (Parcelado.Checked == true)
            {
                Double.TryParse(txtqtdeParc.Text, out qtdeParcela);
                Double.TryParse(txtjuros.Text, out juros);
                string valor4 = txtValorParc.Text;//declara variavel
                valor3 = valor4.Replace("R$", "");// troca R$ por vazio
                                        valor4 = valor4.Replace(".", "");//troca (ponto) por vazio
                valor4 = valor4.Replace(".", ",");//troca (virgula) por (ponto)
                Double.TryParse(valor4, out valorParcela);

                //calculo quando for parcelado
                res = valortotal / qtdeParcela;
                valorParcela = ((juros / 100) * res) + res;
                valortotal = valorParcela * qtdeParcela;
                txtValorParc.Text = valorParcela.ToString("C");
                txtValorT.Text = valortotal.ToString("C");

            }
            else
            {
                txtValorT.Text = valortotal.ToString("C");
            }


        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clienteLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cli = clienteLista.SelectedValue;
            txtCodigoCli.Text = Convert.ToString(cli);
            c.Desconecta();
            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = c.Conecta();
            //traz apenas placa de veiculos do cliente selecionado
            cmd3.CommandText = "Select Pes_in_codigo,vec_in_codigo,Vec_st_placa from mec_tb_veiculos where Pes_in_codigo='" + txtCodigoCli.Text + "'";

            MySqlDataReader dr = cmd3.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
           
              

                      veiculoLista.ValueMember = "vec_in_codigo";
                veiculoLista.DisplayMember = "Vec_st_placa";
      
                veiculoLista.DataSource = dt;
                

            
          
            
            
            
        }
   

        private void button7_Click(object sender, EventArgs e)
        {
            //carregar nomes de clientes no combobox,
            // linha 83 e 84 pegar id do nome selecionado no combobox e exibir no campo de texto
            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = c.Conecta();


            cmd3.CommandText = "Select Pes_in_codigo,Pes_st_Nome from mec_tb_pessoas";
         

            MySqlDataReader dr = cmd3.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            clienteLista.ValueMember = "Pes_in_codigo";
            
            clienteLista.DisplayMember = "Pes_st_Nome";
            clienteLista.DataSource = dt;
            c.Desconecta();

       

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
 


        }
        double valortp, valorp,i;
        int qtde,qtdeProd, num=0,n;
        Estoque est = new Estoque();
        private void button10_Click(object sender, EventArgs e)
        {
           
            c.Desconecta();
            MySqlConnection conn = c.Conecta();
            var cod = Convert.ToString(txtCodVenda.Text);
           // String query = "Select Prod_in_codigo from mec_tb_itemven where Prod_in_codigo like '%" + cod + "%' ";
           String query = "Select Prod_in_codigo from mec_tb_itemven where Venda_in_codigo like '%" + cod + "%' ";
            dt = new DataTable();
            ct = new MySqlDataAdapter(query, conn);
            ct.Fill(dt);


            foreach (DataRow db in dt.Rows)
            {

                txtCo.Text = db["Prod_in_codigo"].ToString();

            }

            if (Convert.ToString(txtCo.Text) == Convert.ToString(txtCodigoProd.Text))
            {




                MessageBox.Show("Produto já existe, para alterar quantidade remova-o e adicione o item novamente");
                btnAddItem.Enabled = false;
                txtCo.Text = "";
                c.Desconecta();

            }
            else

            {
                c.Desconecta();
                //adicionando produto na tabela de itens 
                if (txtQtde.Text == "")
                {

                    MessageBox.Show("Insira uma quantidade valida");
              }else
                if (Convert.ToInt32(txtQtdeProd.Text) < Convert.ToInt32(txtQtde.Text))
                {

                    MessageBox.Show("Quantidade no estoque baixa, nãos erá possivel inserir produto");
                    txtQtde.Text = "";
                    pegarTexto();
                }
                else if (Convert.ToInt32(txtQtdeProd.Text) >= Convert.ToInt32(txtQtde.Text))
                {


            
                    string valor4 = txtValorTotal.Text;//declara variavel
                    valor4 = valor4.Replace("R$", "");// troca R$ por vazio
                    valor4 = valor4.Replace(".", "");//troca (ponto) por vazio
                    valor4 = valor4.Replace(".", ",");//troca (virgula) por (ponto)

                    Double.TryParse(valor4, out valortp);

                    string valor3 = txtValorProd.Text;//declara variavel
                    valor3 = valor3.Replace("R$", "");// troca R$ por vazio
                    valor3 = valor3.Replace(".", "");//troca (ponto) por vazio
                    valor3 = valor3.Replace(".", ",");//troca (virgula) por (ponto)

                    Double.TryParse(valor3, out valorp);
                  
                    int.TryParse(txtQtde.Text, out qtde);
                    int.TryParse(txtQtdeProd.Text, out qtdeProd);

                     
                    i = valortp;
                    while (i >= valortp)
                    {
                        valortp = (valorp * qtde) + i;

                    }
                   
                    
                   
                    txtValorTotal.Text = valortp.ToString("C");
                  
                   
                    ven.CodigoVenda = Convert.ToInt32(txtCodVenda.Text);
                    ven.CodigoCli = Convert.ToInt32(txtCodigoCli.Text);
                    ven.CodigoProd = Convert.ToInt32(txtCodigoProd.Text);
                    ven.Qtde = Convert.ToInt32(txtQtde.Text);
                    ven.novoItem();
                    est.CodProd1= Convert.ToInt32(txtCodigoProd.Text);
                    est.TipoMov1 = "Saída";
                    est.QtdeEs1= Convert.ToInt32(txtQtdeProd.Text);
                   
                    est.Qtde1= Convert.ToInt32(txtQtde.Text);

                    display_data();

                    MessageBox.Show("Produto inserido");
                    qtdeProd = qtdeProd - qtde;
                    ven.Qtde = qtdeProd;
                    est.QtdeNova1 = qtdeProd;
                    est.Movimento();
                    ven.baixaProduto();
                    txtQtdeProd.Text = qtdeProd.ToString();


                }

                for (int cont = 0; cont <= num; cont++)
                {
                    cont = num + 1;
                    num = cont;
                    txtcodIt.Text = Convert.ToString(num);

                }
                pegarTexto();



            }

            c.Desconecta();



        }
        //Metodo usado para pegar produtos adicionados e jogar no painel oculto
        public void pegarTexto()
        {
            if (num == 1)
            {
                txtCodigo1.Text = Convert.ToString(txtCodigoProd.Text);
                txtProduto1.Text = Convert.ToString(produtosLista.Text);
                txtValor1.Text = Convert.ToString(txtValorProd.Text);
                txtQtde1.Text = Convert.ToString(txtQtde.Text);
            }
            else
                          if (num == 2)
            {
                txtCodigo2.Text = Convert.ToString(txtCodigoProd.Text);
                txtProduto2.Text = Convert.ToString(produtosLista.Text);
                txtValor2.Text = Convert.ToString(txtValorProd.Text);
                txtQtde2.Text = Convert.ToString(txtQtde.Text);
            }
            else
                          if (num == 3)
            {
                txtCodigo3.Text = Convert.ToString(txtCodigoProd.Text);
                txtProduto3.Text = Convert.ToString(produtosLista.Text);
                txtValor3.Text = Convert.ToString(txtValorProd.Text);
                txtQtde3.Text = Convert.ToString(txtQtde.Text);
            }
            else
                          if (num == 4)
            {
                txtCodigo4.Text = Convert.ToString(txtCodigoProd.Text);
                txtProduto4.Text = Convert.ToString(produtosLista.Text);
                txtValor4.Text = Convert.ToString(txtValorProd.Text);
                txtQtde4.Text = Convert.ToString(txtQtde.Text);
            }
            else
                          if (num == 5)
            {
                txtCodigo5.Text = Convert.ToString(txtCodigoProd.Text);
                txtProduto5.Text = Convert.ToString(produtosLista.Text);
                txtValor5.Text = Convert.ToString(txtValorProd.Text);
                txtQtde5.Text = Convert.ToString(txtQtde.Text);
            }
            else
                          if (num == 6)
            {
                txtCodigo6.Text = Convert.ToString(txtCodigoProd.Text);
                txtProduto6.Text = Convert.ToString(produtosLista.Text);
                txtValor6.Text = Convert.ToString(txtValorProd.Text);
                txtQtde6.Text = Convert.ToString(txtQtde.Text);
            }
            else
                          if (num == 7)
            {
                txtCodigo7.Text = Convert.ToString(txtCodigoProd.Text);
                txtProduto7.Text = Convert.ToString(produtosLista.Text);
                txtValor7.Text = Convert.ToString(txtValorProd.Text);
                txtQtde7.Text = Convert.ToString(txtQtde.Text);
            }
            else
                   if (num == 8)
            {
                txtCodigo8.Text = Convert.ToString(txtCodigoProd.Text);
                txtProduto8.Text = Convert.ToString(produtosLista.Text);
                txtValor8.Text = Convert.ToString(txtValorProd.Text);
                txtQtde8.Text = Convert.ToString(txtQtde.Text);
            }
            else
                 if (num == 9)
            {
                txtCodigo9.Text = Convert.ToString(txtCodigoProd.Text);
                txtProduto9.Text = Convert.ToString(produtosLista.Text);
                txtValor9.Text = Convert.ToString(txtValorProd.Text);
                txtQtde9.Text = Convert.ToString(txtQtde.Text);
            }
            else
                 if (num == 10)
            {
                txtCodigo10.Text = Convert.ToString(txtCodigoProd.Text);
                txtProduto10.Text = Convert.ToString(produtosLista.Text);
                txtValor10.Text = Convert.ToString(txtValorProd.Text);
                txtQtde10.Text = Convert.ToString(txtQtde.Text);
            }
            else
                 if (num == 11)
            {
                txtCodigo11.Text = Convert.ToString(txtCodigoProd.Text);
                txtProduto11.Text = Convert.ToString(produtosLista.Text);
                txtValor11.Text = Convert.ToString(txtValorProd.Text);
                txtQtde11.Text = Convert.ToString(txtQtde.Text);
            }
            else
                 if (num == 12)
            {
                txtCodigo12.Text = Convert.ToString(txtCodigoProd.Text);
                txtProduto12.Text = Convert.ToString(produtosLista.Text);
                txtValor12.Text = Convert.ToString(txtValorProd.Text);
                txtQtde12.Text = Convert.ToString(txtQtde.Text);
            }
            else
                 if (num == 13)
            {
                txtCodigo13.Text = Convert.ToString(txtCodigoProd.Text);
                txtProduto13.Text = Convert.ToString(produtosLista.Text);
                txtValor13.Text = Convert.ToString(txtValorProd.Text);
                txtQtde13.Text = Convert.ToString(txtQtde.Text);
            }
            else
                 if (num == 14)
            {
                txtCodigo14.Text = Convert.ToString(txtCodigoProd.Text);
                txtProduto14.Text = Convert.ToString(produtosLista.Text);
                txtValor14.Text = Convert.ToString(txtValorProd.Text);
                txtQtde14.Text = Convert.ToString(txtQtde.Text);
            }
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = c.Conecta();
            //traz apenas placa de veiculos do cliente selecionado
            cmd3.CommandText = "Select Pes_in_codigo,vec_in_codigo,Vec_st_placa from mec_tb_veiculos where Pes_in_codigo='" + txtCodigoCli.Text + "'";

            MySqlDataReader dr = cmd3.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            veiculoLista.ValueMember = "vec_in_codigo";
          veiculoLista.DisplayMember = "Vec_st_placa";
            veiculoLista.DataSource = dt;
            c.Desconecta();

        }

        private void label10_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtdesc.Text == "")
            {
                MessageBox.Show("Preecha campo de serviço");

            }
            else if (txtdesconto.Text == "")
            {
                MessageBox.Show("Preecha campo de desconto");

            }
            else if (txtqtdeParc.Text == "")
            {
                MessageBox.Show("Preecha campo de quantidade de parcela");

            }
            else if (txtjuros.Text == "")
            {
                MessageBox.Show("Preecha campo de juros");

            }
            else if (txtDataVenc.Text == "")
            {
                MessageBox.Show("Preecha campo de data de vencimento");

            }
            else if (txtKmA.Text == "")
            {
                MessageBox.Show("Preecha campo de KM atual");

            }
            else if (txtKmP.Text == "")
            {
                MessageBox.Show("Preecha campo de KM proxima visita");

            }
            else if (txtValorS.Text == "")
            {
                MessageBox.Show("Preecha campo de valor de serviço");

            }
            else
            {

                //Vai criar relatorio em pdf
                // Variavel do Nome e caminho do arquivo

                string vArq = "";

                // Abre janela para usuário escolher a pasta onde o arquivo será gerado

                FolderBrowserDialog vSalvar = new FolderBrowserDialog();

                // Verifica se o usuário clicou em ok ou cancelar na janela de seleção da pasta

                if (vSalvar.ShowDialog() == DialogResult.Cancel)

                    return; // Cancela todo processo


                // Insere na variavel o caminho selecionado pelo usuário e concatena com o nome do arquivo

                vArq = vSalvar.SelectedPath + "\\" + clienteLista.Text.Trim() + ".pdf";

                try

                {

                    // Cria um objeto PDF

                    Report vPdf = new Report(new PdfFormatter());


                    // Define a fonte que sera usada no relatório PDF

                    FontDef vDef = new FontDef(vPdf, FontDef.StandardFont.TimesRoman);


                    FontProp vDrop = new FontProp(vDef, 8);
                    FontProp vDrop2 = new FontProp(vDef, 15);
                    FontProp vDrop3 = new FontProp(vDef, 12);


                    // Cria uma Nova Pagina

                    Page vPage = new Page(vPdf);

                    // Escreve no Arquivo

                    vPage.AddCB_MM(8, new RepString(vDrop2, "Relátorio de Vendas ")); // Centraliza

                    vPage.AddCB_MM(19, new RepString(vDrop, "___________________________________________________________________"));
                    vPage.AddCB_MM(27, new RepString(vDrop3, "Cliente")); // Centraliza
                    vPage.AddCB_MM(30, new RepString(vDrop, "___________________________________________________________________"));

                    vPage.AddCB_MM(50, 35, new RepString(vDrop, "Codigo Cliente: " + txtCodigoCli.Text));
                    vPage.AddCB_MM(105, 35, new RepString(vDrop, "Nome do Cliente: " + clienteLista.Text));
                    vPage.AddCB_MM(50, 42, new RepString(vDrop, " Placa do Veículo: "));
                    vPage.AddCB_MM(75, 42, new RepString(vDrop, veiculoLista.Text));
                    vPage.AddCB_MM(50, 48, new RepString(vDrop, " Serviço Realizado: "));
                    vPage.AddCB_MM(55, 55, new RepString(vDrop, txtdesc.Text));
                    vPage.AddCB_MM(65, new RepString(vDrop, "___________________________________________________________________"));
                    vPage.AddCB_MM(72, new RepString(vDrop3, "Venda ")); // Centraliza
                    vPage.AddCB_MM(75, new RepString(vDrop, "___________________________________________________________________"));
                    vPage.AddCB_MM(55, 80, new RepString(vDrop, "Código da Venda: " + txtCodVenda.Text));
                    vPage.AddCB_MM(115, 80, new RepString(vDrop, "Data: " + txtdata.Text));
                    vPage.AddCB_MM(82, new RepString(vDrop, "________________________________________________________________"));
                    vPage.AddCB_MM(45, 90, new RepString(vDrop, "Código"));
                    vPage.AddCB_MM(75, 90, new RepString(vDrop, "Nome"));
                    vPage.AddCB_MM(115, 90, new RepString(vDrop, "Valor"));
                    vPage.AddCB_MM(155, 90, new RepString(vDrop, "Quantidade"));
                    vPage.AddCB_MM(92, new RepString(vDrop, "________________________________________________________________"));

                    if (txtCodigo1.Text == "")
                    {
                        vPage.AddCB_MM(45, 100, new RepString(vDrop, ""));


                    }
                    else
                    {
                        vPage.AddCB_MM(45, 100, new RepString(vDrop, txtCodigo1.Text));
                        vPage.AddCB_MM(75, 100, new RepString(vDrop, txtProduto1.Text));
                        vPage.AddCB_MM(115, 100, new RepString(vDrop, txtValor1.Text));
                        vPage.AddCB_MM(155, 100, new RepString(vDrop, txtQtde1.Text));
                    }
                    if (txtCodigo2.Text == "")
                    {
                        vPage.AddCB_MM(45, 110, new RepString(vDrop, ""));
                    }
                    else
                    {
                        vPage.AddCB_MM(45, 110, new RepString(vDrop, txtCodigo2.Text));
                        vPage.AddCB_MM(75, 110, new RepString(vDrop, txtProduto2.Text));
                        vPage.AddCB_MM(115, 110, new RepString(vDrop, txtValor2.Text));
                        vPage.AddCB_MM(155, 110, new RepString(vDrop, txtQtde2.Text));
                    }
                    if (txtCodigo3.Text == "")
                    {
                        vPage.AddCB_MM(45, 120, new RepString(vDrop, ""));
                    }
                    else
                    {
                        vPage.AddCB_MM(45, 120, new RepString(vDrop, txtCodigo3.Text));
                        vPage.AddCB_MM(75, 120, new RepString(vDrop, txtProduto3.Text));
                        vPage.AddCB_MM(115, 120, new RepString(vDrop, txtValor3.Text));
                        vPage.AddCB_MM(155, 120, new RepString(vDrop, txtQtde3.Text));
                    }
                    if (txtCodigo4.Text == "")
                    {
                        vPage.AddCB_MM(45, 140, new RepString(vDrop, ""));
                    }
                    else
                    {
                        vPage.AddCB_MM(45, 140, new RepString(vDrop, txtCodigo4.Text));
                        vPage.AddCB_MM(75, 140, new RepString(vDrop, txtProduto4.Text));
                        vPage.AddCB_MM(115, 140, new RepString(vDrop, txtValor4.Text));
                        vPage.AddCB_MM(155, 140, new RepString(vDrop, txtQtde4.Text));
                    }
                    if (txtCodigo5.Text == "")
                    {
                        vPage.AddCB_MM(45, 150, new RepString(vDrop, ""));
                    }
                    else
                    {
                        vPage.AddCB_MM(45, 150, new RepString(vDrop, txtCodigo5.Text));
                        vPage.AddCB_MM(75, 150, new RepString(vDrop, txtProduto5.Text));
                        vPage.AddCB_MM(115, 150, new RepString(vDrop, txtValor5.Text));
                        vPage.AddCB_MM(155, 150, new RepString(vDrop, txtQtde5.Text));
                    }
                    if (txtCodigo6.Text == "")
                    {
                        vPage.AddCB_MM(45, 160, new RepString(vDrop, ""));
                    }
                    else
                    {
                        vPage.AddCB_MM(45, 160, new RepString(vDrop, txtCodigo6.Text));
                        vPage.AddCB_MM(75, 160, new RepString(vDrop, txtProduto6.Text));
                        vPage.AddCB_MM(115, 160, new RepString(vDrop, txtValor6.Text));
                        vPage.AddCB_MM(155, 160, new RepString(vDrop, txtQtde6.Text));
                    }
                    if (txtCodigo7.Text == "")
                    {
                        vPage.AddCB_MM(45, 170, new RepString(vDrop, ""));
                    }
                    else
                    {
                        vPage.AddCB_MM(45, 170, new RepString(vDrop, txtCodigo7.Text));
                        vPage.AddCB_MM(75, 170, new RepString(vDrop, txtProduto7.Text));
                        vPage.AddCB_MM(115, 170, new RepString(vDrop, txtValor7.Text));
                        vPage.AddCB_MM(155, 170, new RepString(vDrop, txtQtde7.Text));
                    }
                    if (txtCodigo8.Text == "")
                    {
                        vPage.AddCB_MM(45, 180, new RepString(vDrop, ""));
                    }
                    else
                    {
                        vPage.AddCB_MM(45, 180, new RepString(vDrop, txtCodigo8.Text));
                        vPage.AddCB_MM(75, 180, new RepString(vDrop, txtProduto8.Text));
                        vPage.AddCB_MM(115, 180, new RepString(vDrop, txtValor8.Text));
                        vPage.AddCB_MM(155, 180, new RepString(vDrop, txtQtde8.Text));
                    }
                    if (txtCodigo9.Text == "")
                    {
                        vPage.AddCB_MM(45, 190, new RepString(vDrop, ""));
                    }
                    else
                    {
                        vPage.AddCB_MM(45, 190, new RepString(vDrop, txtCodigo9.Text));
                        vPage.AddCB_MM(75, 190, new RepString(vDrop, txtProduto9.Text));
                        vPage.AddCB_MM(115, 190, new RepString(vDrop, txtValor9.Text));
                        vPage.AddCB_MM(155, 190, new RepString(vDrop, txtQtde9.Text));
                    }
                    if (txtCodigo10.Text == "")
                    {
                        vPage.AddCB_MM(45, 200, new RepString(vDrop, ""));
                    }
                    else
                    {
                        vPage.AddCB_MM(45, 200, new RepString(vDrop, txtCodigo10.Text));
                        vPage.AddCB_MM(75, 200, new RepString(vDrop, txtProduto10.Text));
                        vPage.AddCB_MM(115, 200, new RepString(vDrop, txtValor10.Text));
                        vPage.AddCB_MM(155, 200, new RepString(vDrop, txtQtde10.Text));
                    }
                    if (txtCodigo11.Text == "")
                    {
                        vPage.AddCB_MM(45, 210, new RepString(vDrop, ""));
                    }
                    else
                    {
                        vPage.AddCB_MM(45, 210, new RepString(vDrop, txtCodigo11.Text));
                        vPage.AddCB_MM(75, 210, new RepString(vDrop, txtProduto11.Text));
                        vPage.AddCB_MM(115, 210, new RepString(vDrop, txtValor11.Text));
                        vPage.AddCB_MM(155, 210, new RepString(vDrop, txtQtde11.Text));
                    }
                    if (txtCodigo12.Text == "")
                    {
                        vPage.AddCB_MM(45, 220, new RepString(vDrop, ""));
                    }
                    else
                    {
                        vPage.AddCB_MM(45, 220, new RepString(vDrop, txtCodigo12.Text));
                        vPage.AddCB_MM(75, 220, new RepString(vDrop, txtProduto12.Text));
                        vPage.AddCB_MM(115, 220, new RepString(vDrop, txtValor12.Text));
                        vPage.AddCB_MM(155, 220, new RepString(vDrop, txtQtde12.Text));
                    }
                    if (txtCodigo13.Text == "")
                    {
                        vPage.AddCB_MM(45, 230, new RepString(vDrop, ""));
                    }
                    else
                    {
                        vPage.AddCB_MM(45, 230, new RepString(vDrop, txtCodigo13.Text));
                        vPage.AddCB_MM(75, 230, new RepString(vDrop, txtProduto13.Text));
                        vPage.AddCB_MM(115, 230, new RepString(vDrop, txtValor13.Text));
                        vPage.AddCB_MM(155, 230, new RepString(vDrop, txtQtde13.Text));
                    }
                    if (txtCodigo14.Text == "")
                    {
                        vPage.AddCB_MM(45, 240, new RepString(vDrop, ""));
                    }
                    else
                    {
                        vPage.AddCB_MM(45, 240, new RepString(vDrop, txtCodigo14.Text));
                        vPage.AddCB_MM(75, 240, new RepString(vDrop, txtProduto14.Text));
                        vPage.AddCB_MM(115, 240, new RepString(vDrop, txtValor14.Text));
                        vPage.AddCB_MM(155, 240, new RepString(vDrop, txtQtde14.Text));
                        vPage.AddCB_MM(245, new RepString(vDrop, "____________________________________________________________________________"));
                    }
                    vPage.AddCB_MM(45, 250, new RepString(vDrop, "Valor Produtos:" + txtValorTotal.Text));
                    vPage.AddCB_MM(95, 250, new RepString(vDrop, "Valor Serviço:" + txtValorS.Text));
                    vPage.AddCB_MM(135, 250, new RepString(vDrop, "Desconto:R$" + txtdesconto.Text));
                    vPage.AddCB_MM(175, 250, new RepString(vDrop, "Valor Total:" + txtValorT.Text));
                    vPage.AddCB_MM(255, new RepString(vDrop, "____________________________________________________________________________"));

                    vPage.AddCB_MM(45, 260, new RepString(vDrop, "Pagamento  Parcelado"));
                    vPage.AddCB_MM(105, 260, new RepString(vDrop, "Quantidade de Parcela:" + txtqtdeParc.Text));
                    vPage.AddCB_MM(155, 260, new RepString(vDrop, "Juros:" + txtjuros.Text + " %"));
                    vPage.AddCB_MM(45, 270, new RepString(vDrop, "Valor da Parcela:" + txtValorParc.Text));
                    vPage.AddCB_MM(155, 270, new RepString(vDrop, "Vencimento da primeira parcela:" + txtDataVenc.Text));
                    vPage.AddCB_MM(275, new RepString(vDrop, "____________________________________________________________________________"));
                    vPage.AddCB_MM(50, 280, new RepString(vDrop, "Observação:" + txtOb.Text));
                    vPage.AddCB_MM(285, new RepString(vDrop, "____________________________________________________________________________"));
                    // Salvar Arquivo no disco

                    vPdf.Save(vArq);


                    MessageBox.Show("Arquivo Gerado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnConfirma.Enabled = true;
                    Color minhaCor = Color.FromArgb(46,49,50);
                    btnConfirma.BackColor = minhaCor;
                }

                catch (Exception ex)

                {

                    MessageBox.Show("Erro ao Gerar arquivo !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            
        }

        private void txtValorT_TextChanged(object sender, EventArgs e)
        {
           
               
            
        }

        private void Avista_CheckedChanged(object sender, EventArgs e)
        {
            //se for a vista vai bloquear os campos de texto 
     
            if (Avista.Checked == true)
            {
              
                txtqtdeParc.Text = "0";
                txtqtdeParc.ReadOnly = true;
                txtValorParc.Text ="0";
                txtValorParc.ReadOnly = true;
                txtDataVenc.Text = DateTime.Now.ToShortDateString();
                txtDataVenc.ReadOnly = true;
                txtjuros.Text = "0";
                txtjuros.ReadOnly = true;
            }else if (Avista.Checked == false)
            {
          
                txtqtdeParc.Text = "";
                txtqtdeParc.ReadOnly= false;
                txtValorParc.Text = "";
                txtValorParc.ReadOnly = false;
                txtDataVenc.Text = "";
                txtDataVenc.ReadOnly = false;
                txtjuros.Text = "";
                txtjuros.ReadOnly = false;
               
            } 
        
            //deixei o metodo aqui também para verificar o PArcelado se foi marcado
                calculoDesconto();
           
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            calculoDesconto();
        }

     
        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            groupbox1.Visible = false;
            groupBox3.Visible = true;
            txtdata.Text= DateTime.Now.ToShortDateString();
            btnConfirma.BackColor = System.Drawing.Color.White;
         

        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnVenda.Visible = false;
            groupBox3.Visible = false;
          
        }

        private void groupbox1_Enter(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
         
        }
       
        private void button3_Click_2(object sender, EventArgs e)
        {
           
        
   
           
       
                   
                    ven.CodigoVenda = Convert.ToInt32(txtCodVenda.Text);
        if (dtgProd.RowCount != 0)
        {
            // ven.limpaItem();
            MessageBox.Show("Antes de cancelar remova todos os itens inseridos");
        }
        else
        {
            ven.limpaVenda();
            txtValorProd.Text = "";
            txtQtdeProd.Text = "";
            txtQtde.Text = "";
            txtValorTotal.Text = "";
            txtCodItem.Text = "";

            clienteLista.Enabled = true;
            veiculoLista.Enabled = true;

            groupbox1.Visible = false;

            btnVenda.Visible = true;


        }

           




        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupbox1.Visible = true;
           
        }

        private void txtValorParc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtgProd_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            // Mensagem de confirmação, resolver isso na revisão
            /* if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja Confirmar venda?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
             {
                 //Sua rotina de exclusão
                 //Confirmando exclusão para o usuário
                 MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }*/

            if (txtdesc.Text == "")
            {
                MessageBox.Show("Preecha campo de serviço");

            }
             else if (txtdesconto.Text == "")
            {
                MessageBox.Show("Preecha campo de desconto");

            }
            else if (txtqtdeParc.Text == "")
            {
                MessageBox.Show("Preecha campo de quantidade de parcela");

            }
            else if (txtjuros.Text == "")
            {
                MessageBox.Show("Preecha campo de juros");

            }
            else if (txtDataVenc.Text == "")
            {
                MessageBox.Show("Preecha campo de data de vencimento");

            }
            else if (txtKmA.Text == "")
            {
                MessageBox.Show("Preecha campo de KM atual");

            }
            else if (txtKmP.Text == "")
            {
                MessageBox.Show("Preecha campo de KM proxima visita");

            }
            else if (txtValorS.Text == "")
            {
                MessageBox.Show("Preecha campo de valor de serviço");

            }
            else
            {
                Vendas ven = new Vendas();
                //Mudar variavel parcela para varchar




                ven.CodigoCli = Convert.ToInt32(txtCodigoCli.Text);
                ven.CodigoVeiculo = Convert.ToInt32(txtCodigoVec.Text);
                ven.CodigoVenda = Convert.ToInt32(txtCodVenda.Text);
                //ven.Data = Convert.ToDateTime(txtdata.Text);

                ven.Descricao = txtdesc.Text;
                string valor5 = txtValorS.Text;//declara variavel
                valor5 = valor5.Replace("R$", "");// troca R$ por vazio
                  valor5 = valor5.Replace(".", "");//troca (ponto) por vazio
                valor5 = valor5.Replace(".", ",");//troca (virgula) por (ponto)
                ven.ValorServico2 = valor5;
                ven.Desconto = txtdesconto.Text;

                string valor3 = txtValorT.Text;//declara variavel
                valor3 = valor3.Replace("R$", "");// troca R$ por vazio
                valor3 = valor3.Replace(".", "");//troca (ponto) por vazio
                valor3 = valor3.Replace(",", ".");//troca (virgula) por (ponto)
                ven.ValorTotal1 = valor3;
                ven.Observacao = txtOb.Text;
                ven.Juros = txtjuros.Text;

                ven.DataV = txtDataVenc.Text;
                string valor4 = txtValorParc.Text;//declara variavel
                valor4 = valor4.Replace("R$", "");// troca R$ por vazio
                valor4 = valor4.Replace(".", "");//troca (ponto) por vazio
                valor4 = valor4.Replace(",", ".");//troca (virgula) por (ponto)
                ven.ValorParc2 = valor4;

                ven.KmA1 = Convert.ToInt32(txtKmA.Text);
                ven.KmP1 = Convert.ToInt32(txtKmP.Text);


                if (Avista.Checked == true)
                {
                    ven.QtdeParc = Convert.ToInt32(txtqtdeParc.Text);

                    ven.Parcela = "A Vista";
                    ven.Status = "Pago";

                }
                else if (Parcelado.Checked == true)
                {
                    ven.QtdeParc = Convert.ToInt32(txtqtdeParc.Text);

                    ven.Parcela = "Parcelado";
                    ven.Status = "A pagar";
                    ven.Data = txtDataVenc.Text;
                    ven.itemParcela();

                }
                ven.gerarCR();
                ven.salvarServico();

                ven.confirmaVenda();

                MessageBox.Show("Venda Concluida com sucesso!");
                // ven.deletarItem();
                groupbox1.Visible = false;
                groupBox2.Visible = false;
               groupBox3.Visible = false;
               btnVenda.Visible = false;
               // clienteLista.Enabled = true;
               // veiculoLista.Enabled = true;
                panel2.Visible = true;
                Abrirformhijo(new FormServico());
             
            }
        }
        public void Abrirformhijo(object formhijo)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();


        }
        private void txtValorS_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtdesconto_MouseClick(object sender, MouseEventArgs e)
        {
            Double valor;
            string procuraponto = txtValorS.Text;
            if (procuraponto.Contains("."))
            {
                MessageBox.Show("Use virgula nos números");
                txtValorS.Text = "";
            }
            else //if (procuraponto.Contains(","))
            {

                Double.TryParse(txtValorS.Text, out valor);
                txtValorS.Text = valor.ToString("C");

            }
        }

        private void txtdesconto_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void txtCodVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorS_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
            //carregar nomes de produtos no combobox,

            /* cmd3.Connection = c.Conecta();


             cmd3.CommandText = "Select * from mec_tb_produtos";


             MySqlDataReader dr = cmd3.ExecuteReader();
             DataTable dt = new DataTable();
             dt.Load(dr);

             produtosLista.ValueMember = "Prod_in_codigo";

             produtosLista.DisplayMember = "prod_st_nome";

             produtosLista.DataSource = dt;
             c.Desconecta();


             valorprod();



             */

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
        //Remoção de itens adicionados 
            if (Convert.ToInt32(txtCodItem.Text) == 0)
            {
                MessageBox.Show("Selecione um item da tabela antes de remover!");
            }
            else
            {
                ven.CodigoProd = Convert.ToInt32(txtCodigoProd.Text);
                ven.deletarItem();
                string valor5 = txtValorTotal.Text;//declara variavel
                valor5 = valor5.Replace("R$", "");// troca R$ por vazio
                                                  valor5 = valor5.Replace(".", "");//troca (ponto) por vazio
                valor5 = valor5.Replace(".", ",");//troca (virgula) por (ponto)
                Double.TryParse(valor5, out valortp);
                string valor6 = txtValorProd.Text;//declara variavel
                valor6 = valor6.Replace("R$", "");// troca R$ por vazio
                                                  valor6= valor6.Replace(".", "");//troca (ponto) por vazio
                valor6 = valor6.Replace(".", ",");//troca (virgula) por (ponto)
                Double.TryParse(valor6, out valorp);

                int.TryParse(txtQtde.Text, out qtde);
                int.TryParse(txtQtdeProd.Text, out qtdeProd);
                //valor total recebe o valor do produto menos a quantidade inserida,
                i = valortp;
                while (i <= valortp)
                {
                    valortp = i -(valorp * qtde);

                }


                est.CodProd1 = Convert.ToInt32(txtCodigoProd.Text);
                est.TipoMov1 = "Entrada";
                est.QtdeEs1 = Convert.ToInt32(txtQtdeProd.Text);

                est.Qtde1 = Convert.ToInt32(txtQtde.Text);
                txtValorTotal.Text = valortp.ToString("C");
                qtdeProd = qtdeProd + qtde;
                ven.Qtde = qtdeProd;
                est.QtdeNova1 = qtdeProd;
                ven.baixaProduto();
                est.Movimento();
                txtQtdeProd.Text = qtdeProd.ToString();
                display_data();
                txtCodItem.Text = "0";
                MessageBox.Show("Produto deletado");
                btnAddItem.Enabled = true;
                
                txtQtdeProd.Enabled = true;
                txtValorProd.Enabled = true;
                txtQtde.Enabled = true;
            }
        }

        private void Parcelado_CheckedChanged(object sender, EventArgs e)
        {
           // System.Threading.Thread.Sleep(20000);

           
        }

        public void valorprod()
        {
          

            
           // cmd3.CommandText = "Select prod_re_valorvenda from mec_tb_produtos where Prod_in_codigo='" + txtCodigoProd.Text + "'";
            //cmd3.ExecuteNonQuery();
            DataTable bd = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.Fill(bd);


            /*MySqlDataAdapter da= new MySqlDataAdapter("Select prod_re_valorvenda from mec_tb_produtos where Prod_in_codigo='" + txtCodigoProd.Text + "'",c.Conecta());
            DataTable bd = new DataTable();*/
            foreach (DataRow dr in bd.Rows)
            {
               // txtValorProd.Text = bd["prod_re_valorvenda"].ToString();
            }
            c.Desconecta();

        }


        private void button2_Click_2(object sender, EventArgs e)
        {

            calculoDesconto();
        }
        Double valorV;
        private void produtosLista_SelectedIndexChanged(object sender, EventArgs e)
        {
         

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c.Conecta();
            cmd.CommandText = "Select * from mec_tb_produtos where prod_st_nome='"+produtosLista.SelectedItem.ToString()+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            
            foreach (DataRow dr in dt.Rows)
            {
            

                txtCodigoProd.Text = dr["Prod_in_codigo"].ToString();
                Double.TryParse(txtValorProd.Text, out valorV);
                valorV=Convert.ToDouble( dr["prod_re_valorvenda"].ToString());
                txtValorProd.Text = valorV.ToString("C");
                txtQtdeProd.Text = dr["prod_re_quantidade"].ToString();
                btnAddItem.Enabled = true;
                c.Desconecta();
            }


        }

        private void txtValorProd_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (veiculoLista.Text == "")
            {

                MessageBox.Show("Escolha uma cliente e veiculo");

            }
            else
            {
                //btnVenda.Visible = false;
                //recebe codigo de nova venda
                ven.novaVenda();
                clienteLista.Enabled = false;
                veiculoLista.Enabled = false;
                txtCodVenda.Text = Convert.ToString(ven.CodigoVenda);
                groupbox1.Visible = true;
                btnConfirma.Visible = true;

                c.Desconecta();
                // txtCodVenda.Text = Convert.ToString();
                MySqlCommand cmd3 = new MySqlCommand();



                //Carrega produtos no combo box

                cmd3.Connection = c.Conecta();
                cmd3.CommandText = "Select * from mec_tb_produtos";
                cmd3.ExecuteNonQuery();

                DataTable Ca = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd3);
                da.Fill(Ca);
                foreach (DataRow drr in Ca.Rows)
                {

                    produtosLista.Items.Add(drr["prod_st_nome"].ToString());

                }
                c.Desconecta();
                btnVenda.Visible = false;
            }
        }

        private void veiculoLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idVec = veiculoLista.SelectedValue;

            txtCodigoVec.Text = Convert.ToString(idVec);

        }
        //exibi itens adicionados  no grid 
        public void display_data()
        {


            MySqlConnection conn = c.Conecta();
            String query = "SELECT Item_int_codigo AS 'Codigo Item',Prod_in_codigo AS 'Codigo Produto',	Prod_st_nome as 'Produto',Item_int_qtde AS 'Quantidade' FROM mec_vw_itens  where Venda_in_codigo='" + txtCodVenda.Text+"'  ";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            dtgProd.DataSource = dt;
            c.Desconecta();
        }

        Double valorVen;
        private void dtgProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            //foreach (DataRow dr in dt.Rows)
            {
               DataGridViewRow row = this.dtgProd.Rows[e.RowIndex];


                txtCodigoProd.Text = row.Cells["Codigo Produto"].Value.ToString();
                txtQtde.Text = row.Cells["Quantidade"].Value.ToString();
                txtCodItem.Text = row.Cells["Codigo Item"].Value.ToString();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.Conecta();
                cmd.CommandText = "Select * from mec_tb_produtos where prod_in_codigo='" + txtCodigoProd.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Double.TryParse(txtValorProd.Text, out valorVen);
                    valorVen =Convert.ToDouble( dr["prod_re_valorvenda"].ToString());
                    txtValorProd.Text = valorVen.ToString("C");
                    
                    txtQtdeProd.Text = dr["prod_re_quantidade"].ToString();
                
                    c.Desconecta();
                    txtQtdeProd.Enabled = false;
                    txtValorProd.Enabled = false;
                    txtQtde.Enabled = false;
                }

                /*txtCodigoProd.Text = dr["Codigo Produto"].ToString();
                txtQtde.Text = dr["Quantidade"].ToString();
                txtCodItem.Text = dr["Codigo Item"].ToString();
                */


            }
            

        }
        }
    }

