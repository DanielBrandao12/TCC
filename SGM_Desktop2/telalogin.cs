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
    public partial class telalogin : Form
    {
        conexao conecta = new conexao();


  

        public telalogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void caixausuario_Click(object sender, EventArgs e)
        {
            caixausuario.Clear();
        }

        private void caixasenha_Click(object sender, EventArgs e)
        {
            caixasenha.Clear();
        }

        private void telalogin_Load(object sender, EventArgs e)
        {
          
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
         
            ValidaLog valida = new ValidaLog();

            valida.Verifica(caixausuario.Text, caixasenha.Text);
            string mensagem = valida.mensagem;
            try
            {
               
                if (valida.Tem)
                {
                    telaprincipal t = new telaprincipal();//instacia a tela princiapl
                    t.Usuarios = caixausuario.Text;//ai vairvel usuairos da principal recebe a o usuario digitado
                    t.Show();
                    Hide();
                    t.recebeUser();
                }
                else
                {
                    label1.Text = "Senha ou Usuario incorreto";

                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }







        }

        private void caixausuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
