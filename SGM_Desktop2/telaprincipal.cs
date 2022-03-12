using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace SGM_Desktop2
{
    public partial class telaprincipal : Form
    {
        public telaprincipal()
        {
            InitializeComponent();
            Abrirformhijo(new telaInicia());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //metodo que chma uma tela dentro da outra
        public void Abrirformhijo(object formhijo)
        {
            if (this.paineltelaprincipal.Controls.Count > 0)
                this.paineltelaprincipal.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.paineltelaprincipal.Controls.Add(fh);
            this.paineltelaprincipal.Tag = fh;
            fh.Show();


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maximizar.Visible = true;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            restaurar.Visible = true;
        }
        string user;
        conexao c = new conexao();
        MySqlDataAdapter da;
        DataTable dt;
        private string usuarios;

        public string Usuarios { get => usuarios; set => usuarios = value; }
        string usuarioVar, log;
        public void recebeUser()
        {
            telalogin tela = new telalogin();

            MySqlConnection conn = c.Conecta();
            usuarioVar = Usuarios;//label recebe varivel usuarios que recebeu o que foi digitado na tela de login
            String query = "SELECT * FROM mec_tb_usuario where usu_st_login ='" + usuarioVar + "' ";

            dt = new DataTable();
            da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                user = dr["usu_st_tipo"].ToString();
                log = dr["usu_st_login"].ToString();


            }
            if (user == "Funcionario")
            {
                btconfiguracao.Enabled = false;
                btfluxocaixa.Enabled = false;
            }
            else if (user == "Administrador")
            {
                btconfiguracao.Enabled = true;
                btcadastro.Enabled = true;
            }

            labelUser.Text = log;
            lstatus.Text = "Online";
            lstatus.ForeColor = System.Drawing.Color.Green;



        }


        private void telaprincipal_Load(object sender, EventArgs e)
        {
     
        

            menulateral.Width = 50;
         
        }

        private void listafechado_Click(object sender, EventArgs e)
        {
            menulateral.Width = 245;
            listafechado.Visible = false;

            
        }

        private void listaaberto_Click(object sender, EventArgs e)
        {
            menulateral.Width = 50;
            listafechado.Visible = true;

            btcadastro.Location = new Point(5, 146);
            mcadastro.Location = new Point(4, 146);
            submenucadastro.Visible = false;
            btestoque.Location = new Point(5, 199);
            mestoque.Location = new Point(4, 199);
            btfluxocaixa.Location = new Point(5, 252);
            mfluxocaixa.Location = new Point(4, 252);
            submenufluxocaixa.Visible = false;
            btservicos.Location = new Point(5, 305);
            mservicos.Location = new Point(4, 305);
            submenuservicos.Visible = false;
            btagenda.Location = new Point(5, 358);
            magenda.Location = new Point(4, 358);
            btconfiguracao.Location = new Point(5, 411);
            mconfiguracao.Location = new Point(4, 411);
            submenuconfiguracao.Visible = false;

        }
        public void abrefecha()
        {


        }

        private void btcadastro_Click(object sender, EventArgs e)
        {
           
            mcadastro.Show();
            mestoque.Hide();
            mfluxocaixa.Hide();
            mservicos.Hide();
            mconfiguracao.Hide();
            magenda.Hide();

            menulateral.Width = 245;
            listafechado.Visible = false;

            if (submenucadastro.Visible == true)
            {
                submenucadastro.Visible = false;
            }
            else
            {
                submenucadastro.Visible = true;
                submenufluxocaixa.Visible = false;
                submenuconfiguracao.Visible = false;
                submenuservicos.Visible = false;

            }

            btcadastro.Location = new Point(5, 146);
                mcadastro.Location = new Point(4, 146);
                    submenucadastro.Location = new Point(48, 191);
            btestoque.Location = new Point(5, 331);
                mestoque.Location = new Point(4, 331);
            btfluxocaixa.Location = new Point(5, 384);
                mfluxocaixa.Location = new Point(4, 384);
            btservicos.Location = new Point(5, 435);
            mservicos.Location = new Point(4, 435);
            btagenda.Location = new Point(5, 485);
            magenda.Location = new Point(4, 485);
            btconfiguracao.Location = new Point(5, 535);
            mconfiguracao.Location = new Point(4, 535);

            if (submenucadastro.Visible == false)
            {
                btcadastro.Location = new Point(5, 146);
                    mcadastro.Location = new Point(4, 146);
                btestoque.Location = new Point(5, 199);
                    mestoque.Location = new Point(4, 199);
                btfluxocaixa.Location = new Point(5, 252);
                    mfluxocaixa.Location = new Point(4, 252);
                btservicos.Location = new Point(5, 305);
                    mservicos.Location = new Point(4, 305);
                btagenda.Location = new Point(5, 358);
                magenda.Location = new Point(4, 358);
                btconfiguracao.Location = new Point(5, 411);
                mconfiguracao.Location = new Point(4, 411);
            }
            
            
        }
       

        private void btestoque_Click(object sender, EventArgs e)
        {
            
            mcadastro.Hide();
            mestoque.Show();
            mfluxocaixa.Hide();
            mservicos.Hide();
            mconfiguracao.Hide();
            magenda.Hide();

            
            btcadastro.Location = new Point(5, 146);
            mcadastro.Location = new Point(4, 146);
            submenucadastro.Visible = false;
            btestoque.Location = new Point(5, 199);
            mestoque.Location = new Point(4, 199);
            btfluxocaixa.Location = new Point(5, 252);
            mfluxocaixa.Location = new Point(4, 252);
            submenufluxocaixa.Visible = false;
            btservicos.Location = new Point(5, 305);
            mservicos.Location = new Point(4, 305);
            submenuservicos.Visible = false;
            btagenda.Location = new Point(5, 358);
            magenda.Location = new Point(4, 358);
            btconfiguracao.Location = new Point(5, 411);
            mconfiguracao.Location = new Point(4, 411);
            submenuconfiguracao.Visible = false;
            Abrirformhijo(new FormEstoque());

        }

        private void btfluxocaixa_Click(object sender, EventArgs e)
        {
            mcadastro.Hide();
            mestoque.Hide();
            mfluxocaixa.Show();
            mservicos.Hide();
            mconfiguracao.Hide();
            magenda.Hide();

            menulateral.Width = 245;
            listafechado.Visible = false;

            if (submenufluxocaixa.Visible == true)
            {
                submenufluxocaixa.Visible = false;
            }
            else
            {
                submenufluxocaixa.Visible = true;
                submenucadastro.Visible = false;
                submenuconfiguracao.Visible = false;
                submenuservicos.Visible = false;
            }

            btcadastro.Location = new Point(5, 146);
                mcadastro.Location = new Point(4, 146);
            btestoque.Location = new Point(5, 199);
                mestoque.Location = new Point(4, 199);
            btfluxocaixa.Location = new Point(5, 252);
                mfluxocaixa.Location = new Point(4, 252);
                    submenufluxocaixa.Location = new Point(48, 301);
            btservicos.Location = new Point(5, 394);
                mservicos.Location = new Point(4, 394);
            btagenda.Location = new Point(5, 448);
                magenda.Location = new Point(4, 448);
            btconfiguracao.Location = new Point(5, 500);
                mconfiguracao.Location = new Point(4, 500);

            if (submenufluxocaixa.Visible == false)
            {
                btcadastro.Location = new Point(5, 146);
                    mcadastro.Location = new Point(4, 146);
                btestoque.Location = new Point(5, 199);
                    mestoque.Location = new Point(4, 199);
                btfluxocaixa.Location = new Point(5, 252);
                    mfluxocaixa.Location = new Point(4, 252);
                btservicos.Location = new Point(5, 305);
                    mservicos.Location = new Point(4, 305);
                btagenda.Location = new Point(5, 358);
                magenda.Location = new Point(4, 358);
                btconfiguracao.Location = new Point(5, 411);
                mconfiguracao.Location = new Point(4, 411);
            }
        }

        private void btservicos_Click(object sender, EventArgs e)
        {
            mcadastro.Hide();
            mestoque.Hide();
            mfluxocaixa.Hide();
            mservicos.Show();
            mconfiguracao.Hide();
            magenda.Hide();

            menulateral.Width = 245;
            listafechado.Visible = false;

            if (submenuservicos.Visible == true)
            {
                submenuservicos.Visible = false;
            }
            else
            {
                submenuservicos.Visible = true;
                submenufluxocaixa.Visible = false;
                submenucadastro.Visible = false;
                submenuconfiguracao.Visible = false;                
            }

            btcadastro.Location = new Point(5, 146);
                mcadastro.Location = new Point(4, 146);
            btestoque.Location = new Point(5, 199);
                mestoque.Location = new Point(4, 199);
            btfluxocaixa.Location = new Point(5, 252);
                mfluxocaixa.Location = new Point(4, 252);
            btservicos.Location = new Point(5, 305);
                mservicos.Location = new Point(4, 305);
                    submenuservicos.Location = new Point(48, 354);
            btagenda.Location = new Point(5, 448);
                magenda.Location = new Point(4, 448);
            btconfiguracao.Location = new Point(5, 500);
                mconfiguracao.Location = new Point(4, 500);

            if (submenuservicos.Visible == false)
            {
                btcadastro.Location = new Point(5, 146);
                    mcadastro.Location = new Point(4, 146);
                btestoque.Location = new Point(5, 199);
                    mestoque.Location = new Point(4, 199);
                btfluxocaixa.Location = new Point(5, 252);
                    mfluxocaixa.Location = new Point(4, 252);
                btservicos.Location = new Point(5, 305);
                    mservicos.Location = new Point(4, 305);
                btagenda.Location = new Point(5, 358);
                magenda.Location = new Point(4, 358);
                btconfiguracao.Location = new Point(5, 411);
                mconfiguracao.Location = new Point(4, 411);
            }
            

        }

        
        private void btcriacao_Click(object sender, EventArgs e)
        {
            mcadastro.Hide();
            mestoque.Hide();
            mfluxocaixa.Hide();
            mservicos.Hide();
            mconfiguracao.Show();
            magenda.Hide();

            menulateral.Width = 245;
            listafechado.Visible = false;

            if (submenuconfiguracao.Visible == true)
            {
                submenuconfiguracao.Visible = false;
            }
            else
            {
                submenuconfiguracao.Visible = true;
                submenufluxocaixa.Visible = false;
                submenucadastro.Visible = false;                
                submenuservicos.Visible = false;
            }

            btcadastro.Location = new Point(5, 146);
                mcadastro.Location = new Point(4, 146);
            btestoque.Location = new Point(5, 199);
                mestoque.Location = new Point(4, 199);
            btfluxocaixa.Location = new Point(5, 252);
                mfluxocaixa.Location = new Point(4, 252);
            btservicos.Location = new Point(5, 305);
                mservicos.Location = new Point(4, 305);
            btagenda.Location = new Point(5, 358);
            magenda.Location = new Point(4, 358);
            btconfiguracao.Location = new Point(5, 411);
            mconfiguracao.Location = new Point(4, 411);
            submenuconfiguracao.Location = new Point(48, 454);

            if (submenuconfiguracao.Visible == false)
            {
                btcadastro.Location = new Point(5, 146);
                    mcadastro.Location = new Point(4, 146);
                btestoque.Location = new Point(5, 199);
                    mestoque.Location = new Point(4, 199);
                btfluxocaixa.Location = new Point(5, 252);
                    mfluxocaixa.Location = new Point(4, 252);
                btservicos.Location = new Point(5, 305);
                    mservicos.Location = new Point(4, 305);
                btagenda.Location = new Point(5, 358);
                magenda.Location = new Point(4, 358);
                btconfiguracao.Location = new Point(5, 411);
                mconfiguracao.Location = new Point(4, 411);
            }
            
        }

        private void btagenda_Click(object sender, EventArgs e)
        {
            mcadastro.Hide();
            mestoque.Hide();
            mfluxocaixa.Hide();
            mservicos.Hide();
            mconfiguracao.Hide();
            magenda.Show();

            btcadastro.Location = new Point(5, 146);
            mcadastro.Location = new Point(4, 146);
            submenucadastro.Visible = false;
            btestoque.Location = new Point(5, 199);
            mestoque.Location = new Point(4, 199);
            btfluxocaixa.Location = new Point(5, 252);
            mfluxocaixa.Location = new Point(4, 252);
            submenufluxocaixa.Visible = false;
            btservicos.Location = new Point(5, 305);
            mservicos.Location = new Point(4, 305);
            submenuservicos.Visible = false;
            btagenda.Location = new Point(5, 358);
            magenda.Location = new Point(4, 358);
            btconfiguracao.Location = new Point(5, 411);
            mconfiguracao.Location = new Point(4, 411);
            submenuconfiguracao.Visible = false;
            Abrirformhijo(new FormAgenda());
        }

        private void btchat_Click(object sender, EventArgs e)
        {
            mcadastro.Hide();
            mestoque.Hide();
            mfluxocaixa.Hide();
            mservicos.Hide();
            mconfiguracao.Hide();
            magenda.Hide();

            btcadastro.Location = new Point(5, 146);
            mcadastro.Location = new Point(4, 146);
            submenucadastro.Visible = false;
            btestoque.Location = new Point(5, 199);
            mestoque.Location = new Point(4, 199);
            btfluxocaixa.Location = new Point(5, 252);
            mfluxocaixa.Location = new Point(4, 252);
            submenufluxocaixa.Visible = false;
            btservicos.Location = new Point(5, 305);
            mservicos.Location = new Point(4, 305);
            submenuservicos.Visible = false;
            btagenda.Location = new Point(5, 358);
            magenda.Location = new Point(4, 358);
            btconfiguracao.Location = new Point(5, 411);
            mconfiguracao.Location = new Point(4, 411);
            submenuconfiguracao.Visible = false;
            Abrirformhijo(new FormChat());

        }

        private void btpessoa_Click(object sender, EventArgs e)
        {
            mpessoa.Show();
            mveiculos.Hide();
            mprodutos.Hide();
            Abrirformhijo(new FormPessoa());
        }

        private void btveiculos_Click(object sender, EventArgs e)
        {
            mpessoa.Hide();
            mveiculos.Show();
            mprodutos.Hide();
            Abrirformhijo(new FormVeiculo());
        }

        private void btprodutos_Click(object sender, EventArgs e)
        {
            mpessoa.Hide();
            mveiculos.Hide();
            mprodutos.Show();
            Abrirformhijo(new FormProduto());
        }

        private void btcontasapagar_Click(object sender, EventArgs e)
        {
            mcontasapagar.Show();
            mcontasareceber.Hide();
            Abrirformhijo(new FormContaPagar());
        }

        private void btcontasareceber_Click(object sender, EventArgs e)
        {
            mcontasapagar.Hide();
            mcontasareceber.Show();
            Abrirformhijo(new FormContaReceber());
        }

        private void btrelatorio_Click(object sender, EventArgs e)
        {
            mrelatorio.Show();
            mvendas.Hide();
            Abrirformhijo(new FormServicoRelatorio());
        }

        private void btvendas_Click(object sender, EventArgs e)
        {
            mrelatorio.Hide();
            mvendas.Show();
            Abrirformhijo(new FormServico());
        }
        

        private void btnovousuario_Click(object sender, EventArgs e)
        {
            mnovousuario.Show();
            Abrirformhijo(new FormUsuario());
        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void paineltelaprincipal_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new telaInicia());
       
        }

        private void menulateral_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            telalogin log  = new telalogin();//instacia a tela princiapl
            if (MessageBox.Show("Por favor Confirme para sair ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                log.Show();
                Hide();
            }
              
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }
    }
}
