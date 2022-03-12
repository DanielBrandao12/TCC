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
using System.Text.RegularExpressions;
using System.IO;

namespace SGM_Desktop2
{
    public partial class FormVeiculo : Form
    {
        public FormVeiculo()
        {
            InitializeComponent();
        }
        
        conexao conecta = new conexao();
        MySqlDataAdapter da, ct;
        DataTable dt, Ca;

        public void display_data()
        {
            try
            {
                MySqlConnection conn = conecta.Conecta();
                String query = "SELECT Pes_in_codigo As'Codigo', Pes_st_Nome As 'Nome', Pes_in_cpf As 'Cpf',Pes_st_cidade As 'Cidade',Pes_st_bairro As 'Bairro',Pes_st_rua As 'Rua',Pes_in_numero As 'Numero',Pes_st_uf As 'Uf' FROM mec_vw_cliente where  Pes_st_tipo in ('Cliente')";
                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dtGridVeic.DataSource = dt;
                conecta.Desconecta();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public void display_veic()
        {
            try
            {
                VeicoId.Text = "0";
                MySqlConnection conn = conecta.Conecta();
                String query = "SELECT Vec_in_codigo As 'CodigoVeiculo', Pes_in_codigo AS 'CodigoCliente',Pes_st_Nome As 'Nome',Pes_in_cpf As 'Cpf',Vec_st_tipo As 'Tipo', Vec_st_marca As 'Marca',Vec_st_modelo As 'Modelo',Vec_st_placa As 'Placa', Vec_in_ano As 'Ano',Vec_st_foto As 'Caminho' FROM mec_vw_veiculos where  Pes_in_codigo = '" + textIDCliente.Text + "' ";
                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dtGridVeic.DataSource = dt;

                conecta.Desconecta();
            }
            catch
            {
                MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadVeiculo v = new CadVeiculo();

            v.id = textIDCliente.Text;
            v.tipo = tipoVec.Text;
            v.marca = txtMarca.Text;
            v.modelo = txtModelo.Text;
            v.placa = txtPlaca.Text;
            v.ano = txtAno.Text;

            //verifica se foi selecionado um cliente
            if (textIDCliente.Text != "")
            {
                   //verifica se todos os campos foram preencidos
                    if(tipoVec.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }else if(txtMarca.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }else if(txtModelo.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }else if(txtPlaca.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }else if(txtAno.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        try
                        {
                          
                            v.CadastrarV();
                            MessageBox.Show("Veiculo Cadastrado Com Sucesso ", textIDCliente.Text);
                            display_veic();

                            VeicoId.Text = "";
                            tipoVec.Text = "";
                            txtMarca.Text = "";
                            txtModelo.Text = "";
                            txtPlaca.Text = "";
                            txtAno.Text = "";
                            txtimagem.Text = "";
                            image1.Image = null;
                        }
                        catch
                        {
                            MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                       

                    }
                
             

                
            }
            else
            {
                MessageBox.Show("Selecione no Gride um Cliente ", textIDCliente.Text);

            }



            conecta.Desconecta();



        }

        private void btExibeVei_Click(object sender, EventArgs e)
        {
            
            display_data();
            VeicoId.Text = "";
            tipoVec.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtPlaca.Text = "";
            txtAno.Text = "";
            textIDCliente.Text = "";
            image1.Image = null;
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 13)
            {
                e.Handled = true;
                MessageBox.Show("Porfavor preencha Corretamente !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void FormVeiculo_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btVolta, "Volta par Gride Cliente");
            display_data();
          
            

        }

        private void btexVeic_Click(object sender, EventArgs e)
        {
            tipoVec.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtPlaca.Text = "";
            txtAno.Text = "";
            textIDCliente.Text = "0";

          

            display_veic();
        }

        private void btDelveic_Click(object sender, EventArgs e)
        {
            CadVeiculo veic = new CadVeiculo();


            veic.idVeiculo = VeicoId.Text;
            veic.marca = txtMarca.Text;
            veic.modelo = txtModelo.Text;
            veic.placa = txtPlaca.Text;
            veic.tipo = tipoVec.Text;
            veic.ano = txtAno.Text;

            //verifica se foi selecionado um veiculo
            if (VeicoId.Text != "")
            {
                if (MessageBox.Show("Deseja efetuar a Exclusão", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    veic.delVeic();
                    VeicoId.Text = "";
                    txtMarca.Text = "";
                    txtModelo.Text = "";
                    txtPlaca.Text = "";
                    tipoVec.Text = "";
                    txtAno.Text = "";
                    try
                    {

                        //se o caminho da imagem conter um url entao ele exlui do diretorio
                        if (txtimagem.Text != "")
                        {
                            System.IO.File.Delete(txtimagem.Text);
                        }
                        image1.Image = null;

                        MessageBox.Show("Deletado com sucesso");
                        display_veic();

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
                MessageBox.Show("Selecione um Veiculo", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btAlteraVeic_Click(object sender, EventArgs e)
        {
            CadVeiculo veic = new CadVeiculo();

            veic.idVeiculo = VeicoId.Text;
            veic.marca = txtMarca.Text;
            veic.modelo = txtModelo.Text;
            veic.placa = txtPlaca.Text;
            veic.tipo = tipoVec.Text;
            veic.ano = txtAno.Text;
            //verifica se foi selecionado um veiculo
            if(VeicoId.Text != "")
            {
                
                if (MessageBox.Show("Deseja efetuar a Alteração", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try {
                      
                        veic.AlterVeic();
                        MessageBox.Show("Alterado com sucesso");
                        display_veic();
                        conecta.Desconecta();
                    } catch (Exception) {

                   MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

               
                    
                }
                    
            }
            else
            {

                MessageBox.Show("Selecione um Veiculo","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btUploadVeic_Click(object sender, EventArgs e)
        {

            if (VeicoId.Text != "")
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG giles(*.png)|*.png| All files(*.*)|*.*";

                //esse If permite fechar o openFileDialog
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(dialog.FileName);
                    Bitmap bmmp2 = new Bitmap(bmp, image1.Size);

                    image1.Image = bmmp2;
                   
                    //armazena o caminho na textbox
                    txtimagem.Text = Application.StartupPath.ToString() + "//fotos//" + VeicoId.Text + ".jpg";
                }
                





            }
            else
            {
                MessageBox.Show("Porfavor selecione um Veiculo", "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            conecta.Desconecta();


        }

        private void btSalvarveic_Click(object sender, EventArgs e)
        {
            conexao c = new conexao();
            if(VeicoId.Text != "")
            {
                MySqlCommand cmd5 = new MySqlCommand();
                cmd5.Connection = c.Conecta();
                string caminho = txtimagem.Text;
                if (txtimagem.Text != "")
                {
                    if (MessageBox.Show("Deseja Inserir ou Alterar a foto", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //salva a imagem no diretorio
                        image1.Image.Save(Application.StartupPath.ToString() + "//fotos//" + VeicoId.Text + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

                        cmd5.CommandText = "UPDATE mec_tb_veiculos SET Vec_st_foto = @caminho where  vec_in_codigo = '" + VeicoId.Text + "'";
                        cmd5.Parameters.AddWithValue("caminho", caminho);
                        cmd5.ExecuteNonQuery();
                        MessageBox.Show("Foto Inserida");
                        display_veic();
                        cmd5.Connection = c.Desconecta();

                    }
                    else
                    {
                        cmd5.Connection = c.Desconecta();


                        cmd5.Connection = c.Conecta();


                        cmd5.CommandText = "SELECT* FROM mec_vw_veiculos where  Vec_in_codigo = '" + VeicoId.Text + "' ";
                        MySqlDataReader dr = cmd5.ExecuteReader();

                        if (dr.Read())
                        {
                            txtimagem.Text = dr["Vec_st_foto"].ToString();
                            image1.ImageLocation = txtimagem.Text;
                            cmd5.Connection = c.Desconecta();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma imagem","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("Para inserir uma foto é necessario Selecionar um veiculo", "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

            conecta.Desconecta();
        }

       

        private void dtGridVeic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (VeicoId.Text == "")
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = this.dtGridVeic.Rows[e.RowIndex];
                        textIDCliente.Text = row.Cells["Codigo"].Value.ToString();
                        display_veic();
                    }
                }
                else if (VeicoId.Text != "")
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = this.dtGridVeic.Rows[e.RowIndex];


                        VeicoId.Text = row.Cells["CodigoVeiculo"].Value.ToString();
                        textIDCliente.Text = row.Cells["CodigoCliente"].Value.ToString();
                        txtMarca.Text = row.Cells["Marca"].Value.ToString();
                        txtModelo.Text = row.Cells["Modelo"].Value.ToString();
                        txtPlaca.Text = row.Cells["Placa"].Value.ToString();
                        txtAno.Text = row.Cells["Ano"].Value.ToString();
                        tipoVec.Text = row.Cells["Tipo"].Value.ToString();
                        txtimagem.Text = row.Cells["Caminho"].Value.ToString();

                        image1.ImageLocation = txtimagem.Text;
                        btCadVeic.Enabled = false;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " Erro, selecione outro cliente " );
                display_data();
            }
        }

        private void dtGridVeic_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btLimp_Click(object sender, EventArgs e)
        {
            VeicoId.Text = "";
            tipoVec.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtAno.Text = "";
            txtimagem.Text = "";
            image1.Image = null;
            btCadVeic.Enabled = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            display_data();
        }

        private void btVolta_Click(object sender, EventArgs e)
        {
            display_data();
            VeicoId.Text = "";
            tipoVec.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtPlaca.Text = "";
            txtAno.Text = "";
            textIDCliente.Text = "";
            image1.Image = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBVeic_Click(object sender, EventArgs e)
        {
            textBVeic.Clear();
        }

        string cliente;
        private void btBuscaVei_Click(object sender, EventArgs e)
        {



            VeicoId.Text = "";
           // textIDCliente.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            tipoVec.Text = "";
            txtAno.Text = "";
            ///textBVeic.Text = "";

            try { 
            MySqlConnection conn = conecta.Conecta();
            String query = "SELECT Pes_in_codigo As'Codigo', Pes_st_Nome As 'Nome', Pes_in_cpf As 'Cpf',Pes_st_cidade As 'Cidade',Pes_st_bairro As 'Bairro',Pes_st_rua As 'Rua',Pes_in_numero As 'Numero',Pes_st_uf As 'Uf' FROM mec_vw_cliente where  Pes_st_Nome like'"+textBVeic.Text+"%'";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            //dtGridVeic.DataSource = dt;
            //conecta.Desconecta();

            foreach (DataRow dr in dt.Rows)
            {
                cliente = textBVeic.Text;

            }
            conecta.Desconecta();
            if (textBVeic.Text == "")
            {
                MessageBox.Show("Campo vazio");
                textBVeic.Text = "";
            }
            else if (textBVeic.Text != cliente)
            {

                MessageBox.Show("Clinete não existe");
                textBVeic.Text = "";
            }
            else
            {

                dtGridVeic.DataSource = dt;
                    textBVeic.Text = "";
                    conecta.Desconecta();
            }

            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            }
         
    }

   
}
