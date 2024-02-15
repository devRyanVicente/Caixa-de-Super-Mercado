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

namespace Aplicativo_de_Caixa_de_Super_Mercado.SubAdmin
{
    public partial class SubCategorias : Form
    {
        bool canselectgrid = true;
        Conexaoclass con = new Conexaoclass();
        string oldAlterarID;
        public SubCategorias()
        {
            InitializeComponent();
        }

        public void AtualizarGrid()
        {
            MySqlCommand objCommand = null;
            string strSQL = "SELECT * FROM CategoriaProdutos";
            MySqlConnection cmd = null;
            try
            {
                con.AbrirCon();
                objCommand = new MySqlCommand(strSQL, con.con);
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                string nomeDaColuna = "CategoriaProdutos";
                string filtro = string.Format("[{0}] LIKE '%{1}%'", nomeDaColuna, txtPesquisa.Text);
                dtLista.DefaultView.RowFilter = filtro;
                DataGridDB.DataSource = dtLista;

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
        private void SubCriarCategorias_Load(object sender, EventArgs e)
        {
            AtualizarGrid();

        }

        private void btnConfirmarCriarProduto_Click(object sender, EventArgs e)
        {
            string CriarCategoria = txtCategoriaCriar.Text;
            string IDSearch = txtUniqueID.Text;
            DateTime CriarData = DateTime.Now;
            string service = "Categorias";
            string from = "CategoriaProdutos";
            string where = "CategoriaProdutos";

            //
            // service, from, where, UniqueID, CriarID, CriarNome, DataCriar, Autoid(checkbox true or false), CriarCategoria (produto only), CriarValorProduto
            con.InsertSQL(service, from, where, IDSearch, null, CriarData, false, null, null, null, null, CriarCategoria);
            //         con.criarprodutosql(CriarIDProduto, CriarNomeProduto, CriarCategoriaProduto, CriarValorProduto, CriarDataProduto, bAutoIDBox);            //
            //buttons
            btnCriarCategoria.Visible = true;
            btnEditarCategoria.Visible = true;
            btnRemoverCategoria.Visible = true;
            //sub buttons
            btnConfirmarCriarProduto.Visible = false;
            btnConfirmarEdicao.Visible = false;
            btnConfirmarRemocao.Visible = false;
            btnCancelar.Visible = false;
            // text
            txtCategoriaCriar.ReadOnly = true;
            txtUniqueID.Text = "";
            txtCategoriaCriar.Text = "";
            //
            canselectgrid = true;
            AtualizarGrid();
        }

        private void DataGridDB_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (canselectgrid == true)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string UniqueID = DataGridDB.Rows[e.RowIndex].Cells["UniqueID"].Value.ToString();
                    txtUniqueID.Text = UniqueID;
                    string CategoriaProdutos = DataGridDB.Rows[e.RowIndex].Cells["CategoriaProdutos"].Value.ToString();
                    txtCategoriaCriar.Text = CategoriaProdutos;
                }
            }
        }

        private void btnCriarCategoria_Click(object sender, EventArgs e)
        {
            canselectgrid = false;
            //buttons
            btnCriarCategoria.Visible = false;
            btnEditarCategoria.Visible = false;
            btnRemoverCategoria.Visible = false;
            //sub buttons
            btnConfirmarCriarProduto.Visible = true;
            btnConfirmarEdicao.Visible = false;
            btnConfirmarRemocao.Visible = false;
            btnCancelar.Visible = true;
            // text
            txtCategoriaCriar.ReadOnly = false;
            txtUniqueID.Text = "";
            txtCategoriaCriar.Text = "";
            //
            string maxUniqueID = "UniqueID"; string from = "CategoriaProdutos";
            txtUniqueID.Text = con.LastId(maxUniqueID, from).ToString();
            //
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            canselectgrid = false;
            oldAlterarID = txtUniqueID.Text;
            //buttons
            btnCriarCategoria.Visible = false;
            btnEditarCategoria.Visible = false;
            btnRemoverCategoria.Visible = false;
            //sub buttons
            btnConfirmarCriarProduto.Visible = false;
            btnConfirmarEdicao.Visible = true;
            btnConfirmarRemocao.Visible = false;
            btnCancelar.Visible = true;
            // text
            txtCategoriaCriar.ReadOnly = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //buttons
            btnCriarCategoria.Visible = true;
            btnEditarCategoria.Visible = true;
            btnRemoverCategoria.Visible = true;
            //sub buttons
            btnConfirmarCriarProduto.Visible = false;
            btnConfirmarEdicao.Visible = false;
            btnConfirmarRemocao.Visible = false;
            btnCancelar.Visible = false;
            // text
            txtCategoriaCriar.ReadOnly = true;
            txtUniqueID.Text = "";
            txtCategoriaCriar.Text = "";
            //
            canselectgrid = true;
        }

        private void btnConfirmarRemocao_Click(object sender, EventArgs e)
        {
            string var1 = txtUniqueID.Text;
            string from = "categoriaprodutos";
            string where = "UniqueID";
            con.RemoverSQL(from, where, var1);

            //buttons
            btnCriarCategoria.Visible = true;
            btnEditarCategoria.Visible = true;
            btnRemoverCategoria.Visible = true;
            //sub buttons
            btnConfirmarCriarProduto.Visible = false;
            btnConfirmarEdicao.Visible = false;
            btnConfirmarRemocao.Visible = false;
            btnCancelar.Visible = false;
            // text
            txtCategoriaCriar.ReadOnly = true;
            txtUniqueID.Text = "";
            txtCategoriaCriar.Text = "";
            //
            AtualizarGrid();
            canselectgrid = true;
        }

        private void btnRemoverCategoria_Click(object sender, EventArgs e)
        {
            canselectgrid = false;
            //buttons
            btnCriarCategoria.Visible = false;
            btnEditarCategoria.Visible = false;
            btnRemoverCategoria.Visible = false;
            //sub buttons
            btnConfirmarCriarProduto.Visible = false;
            btnConfirmarEdicao.Visible = false;
            btnConfirmarRemocao.Visible = true;
            btnCancelar.Visible = true;
            // text
            txtCategoriaCriar.ReadOnly = true;
        }

        private void btnConfirmarEdicao_Click(object sender, EventArgs e)
        {
            string AlterarCategoria = txtCategoriaCriar.Text;
            DateTime AlterarDataCategoria = DateTime.Now;

            string service = "Categorias";
            string from = "CategoriaProdutos";
            string where = "UniqueID";

            con.UpdateSQL(service, from, where, null, null, AlterarDataCategoria, null, null, oldAlterarID, null, null, AlterarCategoria);

            //buttons
            btnCriarCategoria.Visible = true;
            btnEditarCategoria.Visible = true;
            btnRemoverCategoria.Visible = true;
            //sub buttons
            btnConfirmarCriarProduto.Visible = false;
            btnConfirmarEdicao.Visible = false;
            btnConfirmarRemocao.Visible = false;
            btnCancelar.Visible = false;
            // text
            txtCategoriaCriar.ReadOnly = true;
            txtUniqueID.Text = "";
            txtCategoriaCriar.Text = "";
            //
            AtualizarGrid();
            canselectgrid = true;
        }

        private void DataGridDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisa_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarGrid();
            }
            if (e.KeyCode == Keys.Escape)
            {
                txtPesquisa.Clear();
            }
        }
    }
}
