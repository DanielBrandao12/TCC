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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }
        User usu = new User();
        conexao c = new conexao();
        MySqlDataAdapter da;
        DataTable dt;
        public void exibirUsuarios()
        {
            try
            {
                MySqlConnection conn = c.Conecta();


                String query = "SELECT usu_in_codigo as 'Codigo',usu_st_login as 'Usuario' ,usu_date_data as 'Data de cadastro',usu_st_tipo as 'Tipo de Usuario' from mec_tb_usuario where usu_st_tipo IN ('Funcionario','Administrador') AND usu_st_status = 'Ativo'  ";
                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dataUser.DataSource = dt;
                c.Desconecta();
            }
            catch
            {
                MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            exibirUsuarios();
            
        }

        private void btnsalva_Click(object sender, EventArgs e)
        {
            usu.usuario = txtUser.Text;
            
            usu.senha = txtSenha.Text;
            usu.tipo = txtTipo.Text;
            if (txtSenha.Text != txtConfi.Text)
            {
                MessageBox.Show("Senha não conferem!","Importante",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                if (txtUser.Text == "")
                {

                    MessageBox.Show("Preencha o campo usuário", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (txtSenha.Text == "")
                {
                    MessageBox.Show("Insira uma senha", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    try
                    {
                        usu.cadastraUser();
                        MessageBox.Show("Cadastrado com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtUser.Text = "";
                        txtSenha.Text = "";
                        txtTipo.Text = "";
                        txtConfi.Text = "";
                        exibirUsuarios();
                    }
                    catch
                    {
                        MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
      
           


                
        }
        string idusuario,senha;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataUser.Rows[e.RowIndex];
               
                idusuario = row.Cells["Codigo"].Value.ToString();
                txtUser.Text = row.Cells["Usuario"].Value.ToString();
                txtTipo.Text = row.Cells["Tipo de Usuario"].Value.ToString();

                
                MySqlCommand cmd5 = new MySqlCommand();
                cmd5.Connection = c.Conecta();
                cmd5.CommandText = "SELECT usu_se_senha FROM mec_tb_usuario where usu_in_codigo = '"+idusuario+"'";
                MySqlDataReader dr = cmd5.ExecuteReader();

                if (dr.Read())
                {

                   senha = dr["usu_se_senha"].ToString();
                    txtSenha.Text = senha;
                    txtConfi.Text = senha;
                    cmd5.Connection = c.Desconecta();
                }

                btnAlt.Enabled = true;
                btnsalva.Enabled = false;
            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
           if(idusuario != null)
            {
                usu.idusu = idusuario;
                usu.usuario = txtUser.Text;
                usu.senha = txtSenha.Text;
                usu.tipo = txtTipo.Text;
                try
                {

                    usu.alterauser();
                    MessageBox.Show("alterado");
                    exibirUsuarios();
                    btnAlt.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("selecione um usuario");
            }



        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            if (idusuario != null)
            {
              
                    usu.idusu = idusuario;
                    usu.deletaUsuario();
                    MessageBox.Show("Usuario deletado");
                    exibirUsuarios();
               

            }
            else
            {
                MessageBox.Show("selecione um usuario");

            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {

        }
        string usuario;
        private void btnBusc_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = c.Conecta();
                String query = "SELECT *  FROM mec_tb_usuario where usu_st_login like'" + txtBusca.Text + "%'";
                dt = new DataTable();
                da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                //dtGridVeic.DataSource = dt;
                //conecta.Desconecta();

                foreach (DataRow dr in dt.Rows)
                {
                  usuario= txtBusca.Text;

                }
                c.Desconecta();
                if (txtBusca.Text == "")
                {
                    MessageBox.Show("Campo vazio");
                    txtBusca.Text = "";
                }
                else if (txtBusca.Text != usuario)
                {

                    MessageBox.Show("Usuario não existe");
                    txtBusca.Text = "";
                }
                else
                {
                    dataUser.DataSource = dt;
                    c.Desconecta();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão, Verifique seu Acesso a Internet", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtConfi.Text = "";
            txtUser.Text = "";
            btnsalva.Enabled = true;
            btnAlt.Enabled = false;
        }

        private void txtBusca_Click(object sender, EventArgs e)
        {
   txtBusca.Clear();
        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


           



        }
    }
}
