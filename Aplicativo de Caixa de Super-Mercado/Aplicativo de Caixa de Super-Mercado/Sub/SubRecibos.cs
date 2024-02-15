using Conexao;
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

namespace Aplicativo_de_Caixa_de_Super_Mercado
{
    public partial class SubRecibos : Form
    {
        Conexaoclass con = new Conexaoclass();
        bool canselectgrid = true;
        public SubRecibos()
        {
            InitializeComponent();
        }
        public void AtualizarGrid()
        {
            MySqlCommand objCommand = null;
            string strSQL = "SELECT * FROM recibos";
            MySqlConnection cmd = null;
            try
            {
                con.AbrirCon();
                objCommand = new MySqlCommand(strSQL, con.con);
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                dataGridView1.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Erro ao Carregar GRID, a database existe?");
            }
            finally
            {

                if (con.con != null && con.con.State == ConnectionState.Open)
                {
                    con.con.Close();
                }
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (canselectgrid == true)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string UniqueID = dataGridView1.Rows[e.RowIndex].Cells["UniqueID"].Value.ToString();
                    txtUniqueID.Text = UniqueID;
                    string CategoriaProdutos = dataGridView1.Rows[e.RowIndex].Cells["ValorVendaTotal"].Value.ToString();
                    txtValorVenda.Text = CategoriaProdutos;
                    string IDFuncionarioRecibo = dataGridView1.Rows[e.RowIndex].Cells["IDFuncionarioRecibo"].Value.ToString();
                    txtIDFuncionario.Text = IDFuncionarioRecibo;
                    string DataCriadoRecibo = dataGridView1.Rows[e.RowIndex].Cells["DataCriadoRecibo"].Value.ToString();
                    txtDataCriado.Text = DataCriadoRecibo;
                    string DataUtilizadoRecibo = dataGridView1.Rows[e.RowIndex].Cells["DataUtilizadoRecibo"].Value.ToString();
                    txtUtilizadoRecibo.Text = DataUtilizadoRecibo;
                }
            }
        }

        private void SubRecibos_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnDevolução_Click(object sender, EventArgs e)
        {
            btnDevolucao.Visible = false;
            //
            btnConfirmarDevolucao.Visible = true;
            btnCancelar.Visible = true;
            //
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnDevolucao.Visible = true;
            //
            btnConfirmarDevolucao.Visible = false;
            btnCancelar.Visible = false;
            //
            AtualizarGrid();
        }

        private void btnConfirmarDevolucao_Click(object sender, EventArgs e)
        {
            string AlterarIDFuncionario = txtUniqueID.Text;
            DateTime AlterarDataProduto = DateTime.Now;

            string service = "Recibos";
            string from = "recibos";
            string where = "UniqueID";

            con.UpdateSQL(service, from, where, AlterarIDFuncionario, null, AlterarDataProduto, null, null, null, null, null, null);
            AtualizarGrid();

            btnDevolucao.Visible = true;
            //
            btnConfirmarDevolucao.Visible = false;
            btnCancelar.Visible = false;
            //
        }
    }
}
