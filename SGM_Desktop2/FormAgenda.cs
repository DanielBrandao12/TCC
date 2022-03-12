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
    public partial class FormAgenda : Form
    {
        public FormAgenda()
        {
            InitializeComponent();
        }
        conexao c = new conexao();
        MySqlDataAdapter da;
        DataTable dt ;
        string idClient;
        string idusu;

        public void dtgAgenda()
        {
           // try
          //  {

                MySqlConnection conn = c.Conecta();
                DateTime dtt = DateTime.Parse(dataAgenda.Text);
                string str2 = dtt.ToString("yyyy/MM/dd");

                String query = "SELECT agen_in_codigo As 'Codigo', agen_st_nome As 'Nome Cliente', agen_in_contato As 'Contato', agen_dt_data As 'Data', agen_tm_hora As 'Hora',agen_st_descricao As 'Drescricao', agen_in_Funcionario As 'Funcionario' FROM mec_tb_agenda where agen_dt_data ='" + str2 + "'";
                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dtgAgen.DataSource = dt;
                c.Desconecta();
          //  }
            //catch {

               // MessageBox.Show("Nenhum agendamento para o dia de hoje", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          //  }

        }

        private void comboConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cont = comboConta.SelectedValue;
            
                }

        private void comboboxNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            var codCli = comboboxNome.SelectedValue;
            idClient = Convert.ToString(codCli);
            c.Desconecta();
            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = c.Conecta();
            //traz apenas placa de veiculos do cliente selecionado
            cmd3.CommandText = "Select cont_in_codigo,cont_in_cel from mec_tb_contato where Pes_in_codigo='" + idClient+ "'";

            MySqlDataReader dr = cmd3.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            comboConta.ValueMember = "cont_in_codigo";
            comboConta.DisplayMember = "cont_in_cel";
            comboConta.DataSource = dt;
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            try
            {
            
                MySqlCommand cmd3 = new MySqlCommand();
                cmd3.Connection = c.Conecta();


                cmd3.CommandText = "Select Pes_in_codigo,Pes_st_Nome from mec_tb_pessoas where  Pes_st_tipo in ('Cliente')";
                MySqlDataReader dr = cmd3.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                comboboxNome.ValueMember = "Pes_in_codigo";

                comboboxNome.DisplayMember = "Pes_st_Nome";
                comboboxNome.DataSource = dt;
              
              
                comboboxNome.Text = "Cliente";
                comboConta.Text = "Contato";

                //traz os usuarios

                cmd3.CommandText = "Select usu_in_codigo,usu_st_login from mec_tb_usuario where usu_st_tipo='Funcionario'";
                    MySqlDataReader drr = cmd3.ExecuteReader();
                    DataTable dat = new DataTable();
                    dat.Load(drr);
                    comboBoxAtribuir.ValueMember = "usu_in_codigo";
                    comboBoxAtribuir.DisplayMember = "usu_st_login";
                    comboBoxAtribuir.DataSource = dat;
                    cmd3.Connection = c.Desconecta();
               
            
                   
               
              
                ////// traz no gride os agendamentos do dia
                ///

                MySqlConnection conn = c.Conecta();
                string dtt = DateTime.Now.ToShortDateString();
                string str1 = DateTime.Parse(dtt).ToString("yyyy-MM-dd");

                String query = "SELECT agen_in_codigo As 'Codigo', agen_st_nome As 'Nome Cliente', agen_in_contato As 'Contato',agen_dt_data As 'Data', agen_tm_hora As 'Hora',agen_st_descricao As 'Drescricao', agen_in_Funcionario As 'Funcionario' FROM mec_tb_agenda where agen_dt_data = '" + str1 + "'"; ;
                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dtgAgen.DataSource = dt;
                c.Desconecta();

                if (dtgAgen.RowCount == 0)
                {

                    c.Desconecta();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void comboBoxAtribuir_SelectedIndexChanged(object sender, EventArgs e)
        {
     

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agenda ag = new Agenda();

            var codusu = comboBoxAtribuir.SelectedValue;

            idusu = Convert.ToString(codusu);
            ag.IdUsuario = idusu;
         
            


           
            ag.idClien = idClient;
           
            
            ag.nome = comboboxNome.Text;
            ag.contato = comboConta.Text;
            ag.Data = dateAgen.Text;
            ag.Hora = horamarca.Text;
            ag.descricao = txtDescricao.Text;
            ag.atribuir = comboBoxAtribuir.Text;

            if (txtDescricao.Text != "")
            {
                if (MessageBox.Show("Deseja efetuar o Agendamento?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                   
                        ag.agenCliente();

                        MessageBox.Show("Agendamento Realizado");
                       // txtDescricao.Text = "";
                        c.Desconecta();
                        dtgAgenda();
                     
                 
                   
                }
            }
            else
            {
                MessageBox.Show("Informe a descrição do serviço", "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


           


        }

        private void btBuscaData_Click(object sender, EventArgs e)
        {
            try
            {
                dtgAgenda();
            }
            catch 
            {
                //MessageBox.Show("Houve algum erro, limpe os campos");
                c.Desconecta();

            }

        }

        private void dataAgenda_ValueChanged(object sender, EventArgs e)
        {
           
            }

        private void dtgAgen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agenda ag = new Agenda();

            if (textIDagenda.Text != "")
            {

                if (MessageBox.Show("Deseja Desmarcar este Agendamento", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ag.IdAgenda = textIDagenda.Text;
                    try
                    {
                        ag.desmarcar();

                        MessageBox.Show("horario desmarcado");
                        dtgAgenda();
                        textIDagenda.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

             
              

            }
            else
            {
                MessageBox.Show("Selecione uma Data no Gride", "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
          

        }

        private void dtgAgen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dtgAgen.Rows[e.RowIndex];


                textIDagenda.Text = row.Cells["Codigo"].Value.ToString();
                comboboxNome.Text = row.Cells["Nome Cliente"].Value.ToString();
                comboConta.Text = row.Cells["Contato"].Value.ToString();
                comboBoxAtribuir.Text = row.Cells["Funcionario"].Value.ToString();
                txtDescricao.Text = row.Cells["Drescricao"].Value.ToString();
                dateAgen.Text = row.Cells["Data"].Value.ToString();
                horamarca.Text = row.Cells["Hora"].Value.ToString();
                button1.Enabled = false;
            }

        }

        private void btexibAgen_Click(object sender, EventArgs e)
        {
            try
            {


                MySqlConnection conn = c.Conecta();
                string dtt = DateTime.Now.ToShortDateString();
                string str1 = DateTime.Parse(dtt).ToString("yyyy-MM-dd");

                String query = "SELECT agen_in_codigo As 'Codigo', agen_st_nome As 'Nome Cliente', agen_in_contato As 'Contato',agen_dt_data As 'Data', agen_tm_hora As 'Hora',agen_st_descricao As 'Drescricao', agen_in_Funcionario As 'Funcionario' FROM mec_tb_agenda ";
                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dtgAgen.DataSource = dt;
                c.Desconecta();
            }
            catch
            {
                MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btLimp_Click(object sender, EventArgs e)
        {
            textIDagenda.Text = "";
            comboboxNome.Text = "Cliente";
            comboConta.Text = "Contato";
            comboBoxAtribuir.Text = "Funcionario";
            txtDescricao.Text = "";
            button1.Enabled = true;
        }
    }
}
