using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
 


namespace SGM_Desktop2
{


    public partial class TabelaAddFornecedor : Form
    {
       private string con = "server=localhost;port=3306;user id=root;database=mecanica;password=";
        SqlConnection conectar = null;
        SqlCommand comando = null;

        public TabelaAddFornecedor()
        {
            InitializeComponent();
           
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TabelaAddFornecedor_Load(object sender, EventArgs e)
        {

        }

        public void listaGrid()
        {


            string strSQL = "SELECT * FROM mec_tb_pessoas";

            conectar = new SqlConnection(con);
            comando = new SqlCommand(strSQL, conectar);
            try
            {

                SqlDataAdapter objAdp = new SqlDataAdapter();
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                
                
            }
            catch
            {

                MessageBox.Show("Deu erro");
            }
        }

        private void btforn_Click(object sender, EventArgs e)
        {
            listaGrid();
        }
    }
}
