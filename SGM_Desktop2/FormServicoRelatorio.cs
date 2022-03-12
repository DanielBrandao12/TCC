using MySql.Data.MySqlClient;
using Root.Reports;
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
    public partial class FormServicoRelatorio : Form
    {
        public FormServicoRelatorio()
        {
            InitializeComponent();
        }
        conexao conecta = new conexao();
        MySqlDataAdapter da;
        DataTable dt;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExibeCli_Click(object sender, EventArgs e)
        {
            txtKmA.Text = "";
            txtKmP.Text = "";
            txtTipo.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtAno.Text = "";
            txtCodCli.Text = "";
            txtNomeCli.Text = "";
            txtCodVec.Text = "";
            txtCodSer.Text = "";
            txtData.Text = "";
            txtDescricao.Text = "";
            txtOb.Text = "";
            display_data();
            dataRelatorio.Visible = true;
            dataRelatorio.Enabled = true;

            datagrid.Visible = false;
            datagrid.Enabled = false;
        }
        public void display_data()
        {

            MySqlConnection conn = conecta.Conecta();
            String query = "SELECT Pes_in_codigo as 'Codigo Cliente',Pes_st_Nome as'Nome',Pes_in_cpf AS 'CPF' FROM mec_vw_cliente where  Pes_st_tipo in ('Cliente')";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            dataRelatorio.DataSource = dt;
            conecta.Desconecta();
        }
        public void display_data2()
        {

            MySqlConnection conn = conecta.Conecta();
            String query = "SELECT  serv_in_codigo as 'Codigo Servico',vec_in_codigo as 'Codigo Veiculo',pes_in_codigo as 'Codigo Cliente',serv_st_descricao as 'Descricao',Serv_re_Vdesc as 'Desconto',Serv_re_VServico as 'Valor Servico',Serv_date_data as 'Data Realizado' FROM mec_tb_servicos where pes_in_codigo='" + txtCodCli.Text+"' ";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            datagrid.DataSource = dt;
            conecta.Desconecta();
     
        }
        public void display_data3()
        {

            MySqlConnection conn = conecta.Conecta();
            String query = "SELECT serv_in_codigo,	rel_int_kmatual,rel_int_kmprevisto,	rel_st_observacoes,	rel_date_data FROM mec_tb_relatorio where serv_in_codigo='" + txtCodSer.Text + "'";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
           // datagrid.DataSource = dt;
            conecta.Desconecta();
            foreach (DataRow dr in dt.Rows)
            {
                txtKmA.Text = dr["rel_int_kmatual"].ToString();
                txtKmP.Text = dr["rel_int_kmprevisto"].ToString();
                txtOb.Text = dr["rel_st_observacoes"].ToString();
              //  datagrid.Enabled = false;
            }
        }
        public void exibirVeiculo()
        {

            MySqlConnection conn = conecta.Conecta();
            String query = "SELECT * FROM mec_tb_veiculos where vec_in_codigo='" + txtCodVec.Text + "'";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
           
            conecta.Desconecta();
            foreach (DataRow dr in dt.Rows)
            {
                txtTipo.Text = dr["Vec_st_tipo"].ToString();
                txtMarca.Text = dr["Vec_st_marca"].ToString();
                txtModelo.Text = dr["Vec_st_modelo"].ToString();
                txtPlaca.Text = dr["Vec_st_placa"].ToString();
                txtAno.Text = dr["Vec_in_ano"].ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormServicoRelatorio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

            vArq = vSalvar.SelectedPath + "\\" + txtPlaca.Text.Trim() + ".pdf";

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

                vPage.AddCB_MM(8, new RepString(vDrop2, "Relátorio")); // Centraliza

                vPage.AddCB_MM(19, new RepString(vDrop, "___________________________________________________________________"));
                vPage.AddCB_MM(27, new RepString(vDrop3, "Cliente")); // Centraliza
                vPage.AddCB_MM(30, new RepString(vDrop, "___________________________________________________________________"));

                vPage.AddCB_MM(55, 35, new RepString(vDrop, "Codigo Cliente: " + txtCodCli.Text));
                vPage.AddCB_MM(110, 35, new RepString(vDrop, "Nome do Cliente: " + txtNomeCli.Text));
               
                vPage.AddCB_MM(47, new RepString(vDrop3, "Veículo")); // Centraliza
                vPage.AddCB_MM(50, new RepString(vDrop, "___________________________________________________________________"));
                vPage.AddCB_MM(55, 55, new RepString(vDrop, "Codigo do Veículo: " + txtCodVec.Text));
                vPage.AddCB_MM(110, 55, new RepString(vDrop, " Tipo Veículo: " + txtTipo.Text));
                vPage.AddCB_MM(55, 60, new RepString(vDrop, " Placa do Veículo: "+txtPlaca.Text));
                vPage.AddCB_MM(110, 60, new RepString(vDrop, " Marca: "+txtMarca.Text));
                vPage.AddCB_MM(55, 65, new RepString(vDrop, " Modelo: "+txtModelo.Text));
                vPage.AddCB_MM(110, 65, new RepString(vDrop, " Ano: "+txtAno.Text));
                
                vPage.AddCB_MM(77, new RepString(vDrop3, "Serviço")); // Centraliza
                vPage.AddCB_MM(80, new RepString(vDrop, "___________________________________________________________________"));
                vPage.AddCB_MM(55, 85, new RepString(vDrop, " Codigo do serviço: "+txtCodSer.Text));
                vPage.AddCB_MM(110, 85, new RepString(vDrop, "Data do serviço: "+txtData.Text));
                vPage.AddCB_MM(55, 90, new RepString(vDrop, " KM Atual: "+txtKmA.Text));
                vPage.AddCB_MM(110, 90, new RepString(vDrop, " KM Proxima visita: "+txtKmP.Text));
                vPage.AddCB_MM(55, 100, new RepString(vDrop, "Serviço Realizado: " + txtDescricao.Text));

                vPage.AddCB_MM(140, new RepString(vDrop, "___________________________________________________________________"));


                // Salvar Arquivo no disco

                vPdf.Save(vArq);


                MessageBox.Show("Arquivo Gerado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKmA.Text = "";
                txtKmP.Text = "";
                txtTipo.Text = "";
                txtMarca.Text = "";
                txtModelo.Text = "";
                txtPlaca.Text = "";
                txtAno.Text = "";
                txtCodCli.Text = "";
                txtNomeCli.Text = "";
                txtCodVec.Text = "";
                txtCodSer.Text = "";
                txtData.Text = "";
                txtDescricao.Text = "";
                txtOb.Text = "";
                display_data();
                dataRelatorio.Visible = true;
                dataRelatorio.Enabled = true;

                datagrid.Visible = false;
                datagrid.Enabled = false;
            }

            catch (Exception ex)

            {

                MessageBox.Show("Erro ao Gerar arquivo !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void btnBuscaCli_Click(object sender, EventArgs e)
        {
            txtKmA.Text = "";
            txtKmP.Text = "";
            txtTipo.Text ="";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtAno.Text = "";
            txtCodCli.Text = "";
            txtNomeCli.Text = "";
            txtCodVec.Text = "";
            txtCodSer.Text = "";
            txtData.Text ="";
            txtDescricao.Text = "";
            MySqlConnection conn = conecta.Conecta();
            String query = "SELECT Pes_in_codigo as 'Codigo Cliente',Pes_st_Nome as'Nome',Pes_in_cpf AS 'CPF' FROM mec_vw_cliente where Pes_st_Nome like'" + txtbusca.Text + "%'";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            dataRelatorio.DataSource = dt;
            conecta.Desconecta();
        }

        private void dataRelatorio_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataRelatorio.Rows[e.RowIndex];


                txtCodCli.Text = row.Cells["Codigo Cliente"].Value.ToString();
                txtNomeCli.Text = row.Cells["Nome"].Value.ToString();
                display_data2();
                dataRelatorio.Visible = false;
                dataRelatorio.Enabled = false;

                datagrid.Visible = true;
                datagrid.Enabled = true;
                
            }



        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >=0)
            {
         
                DataGridViewRow row2 = this.datagrid.Rows[e.RowIndex];
                txtCodVec.Text = row2.Cells["Codigo Veiculo"].Value.ToString();
                txtCodSer.Text = row2.Cells["codigo Servico"].Value.ToString();
                txtData.Text = row2.Cells["Data Realizado"].Value.ToString();
                txtDescricao.Text = row2.Cells["Descricao"].Value.ToString();

                exibirVeiculo();
                display_data3();
                /* if (e.RowIndex >= 05)
                 {
                     DataGridViewRow row3 = this.dataRelatorio.Rows[e.RowIndex];
                     txtKmA.Text = row3.Cells["rel_int_kmatual"].Value.ToString();
                     txtKmP.Text = row3.Cells["rel_int_kmprevisto"].Value.ToString();
                     txtOb.Text = row3.Cells["rel_st_observacoes"].Value.ToString();
                 }*/


            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataRelatorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbusca_Click(object sender, EventArgs e)
        {
            txtbusca.Clear();
        }
    }
}
