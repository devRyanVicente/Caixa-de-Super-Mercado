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
using Conexao;
using System.Globalization;
using Aplicativo_de_Caixa_de_Super_Mercado.SubAdmin;

namespace Aplicativo_de_Caixa_de_Super_Mercado
{
    public partial class SubProdutos : Form
    {
        //
        SubCategorias CriarCategoriasView = new SubCategorias();
        //

        MySqlCommand cmd;
        bool canselectgrid = true;
        Conexaoclass con = new Conexaoclass();
        string oldAlterarIDProduto;
        public SubProdutos()
        {
            InitializeComponent();
        }
        public void CategoriaProdutosArray()
        {
            boxCategoriaProdutos.Items.Clear();
            con.AbrirCon();
            string sql = "SELECT CategoriaProdutos FROM CategoriaProdutos";
            cmd = new MySqlCommand(sql, con.con); // inicializando cmd
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Adicionar os valores da coluna "CategoriaProdutos" à Select Box
                    boxCategoriaProdutos.Items.Add(reader["CategoriaProdutos"].ToString());
                }
            }

        }

        private void SubProdutos_Load(object sender, EventArgs e)
        {
            boxAutoID.AutoCheck = true;
            AtualizarGrid();
            CategoriaProdutosArray();
        }

        public void AtualizarGrid()
        {
            MySqlCommand objCommand = null;
            string strSQL = "SELECT * FROM produtos";
            MySqlConnection cmd = null;
            try
            {
                con.AbrirCon();
                objCommand = new MySqlCommand(strSQL, con.con);
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                string nomeDaColuna = "NomeProduto";
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

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            // atualiza a categoria
            CategoriaProdutosArray();
            //
            oldAlterarIDProduto = txtIDProduto.Text;
            // Buttons
            btnCriarProduto.Visible = false;
            btnAlterarProduto.Visible = false;
            btnExcluirProduto.Visible = false;
            btnCancelarProdutos.Visible = true;
            //Sub Buttons
            btnConfirmarCriarProduto.Visible = false;
            btnConfirmarAlteracaoProduto.Visible = true;
            btnConfirmarExcluirProduto.Visible = false;
            // textboxes
            txtIDProduto.ReadOnly = false;
            txtNomeProduto.ReadOnly = false;
            txtValorProduto.ReadOnly = false;
            //
            boxCategoriaProdutos.Enabled = true;
            canselectgrid = false;
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            // Buttons
            btnCriarProduto.Visible = false;
            btnAlterarProduto.Visible = false;
            btnExcluirProduto.Visible = false;
            btnCancelarProdutos.Visible = true;
            //Sub Buttons
            btnConfirmarCriarProduto.Visible = false;
            btnConfirmarAlteracaoProduto.Visible = false;
            btnConfirmarExcluirProduto.Visible = true;
            // textboxes
            txtIDProduto.ReadOnly = true;
            txtNomeProduto.ReadOnly = true;
            txtValorProduto.ReadOnly = true;
            //
            boxCategoriaProdutos.Enabled = false;
            //
            canselectgrid = false;

        }

        private void btnCriarProduto_Click(object sender, EventArgs e)
        {
            // atualiza a Categoria
            CategoriaProdutosArray();
            // Buttons
            btnCriarProduto.Visible = false;
            btnAlterarProduto.Visible = false;
            btnExcluirProduto.Visible = false;
            btnCancelarProdutos.Visible = true;
            //Sub Buttons
            btnConfirmarCriarProduto.Visible = true;
            btnConfirmarAlteracaoProduto.Visible = false;
            btnConfirmarExcluirProduto.Visible = false;
            //Box
            boxAutoID.Visible = true;
            // textboxes
            txtIDProduto.ReadOnly = false;
            txtNomeProduto.ReadOnly = false;
            txtValorProduto.ReadOnly = false;
            //
            txtIDProduto.Text = "";
            txtIDProduto.Text = "";
            txtNomeProduto.Text = "";
            txtValorProduto.Text = "";
            //
            boxCategoriaProdutos.Enabled = true;
            canselectgrid = false;
            //
            if (boxAutoID.Checked == true)
            {
                txtIDProduto.ReadOnly = true;
                string max = "IDProduto"; string from = "produtos";
                txtIDProduto.Text = con.LastId(max, from).ToString();
            }


        }

        private void btnConfirmarExcluirProduto_Click(object sender, EventArgs e)
        {
            string var1 = txtIDProduto.Text;
            string from = "produtos";
            string where = "IDProduto";
            con.RemoverSQL(from, where, var1);
            AtualizarGrid();
            //
            // Buttons
            btnCriarProduto.Visible = true;
            btnAlterarProduto.Visible = true;
            btnExcluirProduto.Visible = true;
            btnCancelarProdutos.Visible = false;
            //Sub-Buttons
            btnConfirmarCriarProduto.Visible = false;
            btnConfirmarAlteracaoProduto.Visible = false;
            btnConfirmarExcluirProduto.Visible = false;
            //textboxes
            txtIDProduto.ReadOnly = true;
            txtNomeProduto.ReadOnly = true;
            txtValorProduto.ReadOnly = true;
            //
            txtIDProduto.Text = "";
            txtNomeProduto.Text = "";
            boxCategoriaProdutos.Text = "";
            txtValorProduto.Text = "";
            //
            boxCategoriaProdutos.Enabled = false;
            canselectgrid = true;
        }

        private void btnConfirmarAlteracaoProduto_Click(object sender, EventArgs e)
        {
            string AlterarIDProduto = txtIDProduto.Text;
            string AlterarNomeProduto = txtNomeProduto.Text;
            string AlterarCategoriaProduto = boxCategoriaProdutos.Text;
            string valorProdutoTexto = txtValorProduto.Text;

            string pValorProduto = (valorProdutoTexto.Replace(',', '.'));
            bool bAutoIDBox = boxAutoID.Checked;
            DateTime AlterarDataProduto = DateTime.Now;
            string UniqueID = null;
            //            oldAlterarIDProduto old id take UniqueID from oldAlterarIDProduto
            string service = "Produtos";
            string from = "produtos";
            string where = "IDProduto";

            con.UpdateSQL(service, from, where, AlterarIDProduto, AlterarNomeProduto, AlterarDataProduto, AlterarCategoriaProduto, pValorProduto, oldAlterarIDProduto, null, null, null);
            // Buttons
            btnCriarProduto.Visible = true;
            btnAlterarProduto.Visible = true;
            btnExcluirProduto.Visible = true;
            btnCancelarProdutos.Visible = true;
            //Sub Buttons
            btnConfirmarCriarProduto.Visible = false;
            btnConfirmarAlteracaoProduto.Visible = false;
            btnConfirmarExcluirProduto.Visible = false;
            // textboxes
            txtIDProduto.ReadOnly = true;
            txtNomeProduto.ReadOnly = true;
            txtValorProduto.ReadOnly = true;
            //
            boxCategoriaProdutos.Enabled = false;
            //
            canselectgrid = true;
            AtualizarGrid();
        }

        private void btnCancelarProdutos_Click(object sender, EventArgs e)
        {
            // Buttons
            btnCriarProduto.Visible = true;
            btnAlterarProduto.Visible = true;
            btnExcluirProduto.Visible = true;
            btnCancelarProdutos.Visible = false;
            //Sub Buttons
            btnConfirmarCriarProduto.Visible = false;
            btnConfirmarAlteracaoProduto.Visible = false;
            btnConfirmarExcluirProduto.Visible = false;
            // textboxes
            boxAutoID.Visible = false;
            txtIDProduto.ReadOnly = true;
            txtNomeProduto.ReadOnly = true;
            txtValorProduto.ReadOnly = true;
            //
            txtIDProduto.Text = "";
            txtNomeProduto.Text = "";
            boxCategoriaProdutos.Text = "";
            txtValorProduto.Text = "";
            //
            boxCategoriaProdutos.Enabled = false;
            canselectgrid = true;
        }

        private void btnConfirmarCriarProduto_Click(object sender, EventArgs e)
        {
            string CriarIDProduto = txtIDProduto.Text;
            string CriarNomeProduto = txtNomeProduto.Text;
            string CriarCategoriaProduto = boxCategoriaProdutos.Text;
            string CriarValorProduto = txtValorProduto.Text;
            bool bAutoIDBox = boxAutoID.Checked;
            DateTime CriarDataProduto = DateTime.Now;
            string UniqueID = null;
            string service = "Produtos";
            string from = "produtos";
            string where = "IDProduto";

            //
            // service, from, where, UniqueID, CriarID, CriarNome, DataCriar, Autoid(checkbox true or false), CriarCategoria (produto only), CriarValorProduto
            con.InsertSQL(service, from, where, CriarIDProduto, CriarNomeProduto, CriarDataProduto, bAutoIDBox, CriarCategoriaProduto, CriarValorProduto, null, null, null);
            //         con.criarprodutosql(CriarIDProduto, CriarNomeProduto, CriarCategoriaProduto, CriarValorProduto, CriarDataProduto, bAutoIDBox);
            AtualizarGrid();
            //
            txtIDProduto.Text = "";
            txtNomeProduto.Text = "";
            boxCategoriaProdutos.Text = "";
            txtValorProduto.Text = "";
            //
            string max1 = "IDProduto"; string from1 = "produtos";
            txtIDProduto.Text = con.LastId(max1, from1).ToString();
            //
            // Buttons
            btnCriarProduto.Visible = true;
            btnAlterarProduto.Visible = true;
            btnExcluirProduto.Visible = true;
            btnCancelarProdutos.Visible = false;
            //Sub Buttons
            btnConfirmarCriarProduto.Visible = false;
            btnConfirmarAlteracaoProduto.Visible = false;
            btnConfirmarExcluirProduto.Visible = false;
            // textboxes
            boxAutoID.Visible = false;
            txtIDProduto.ReadOnly = true;
            txtNomeProduto.ReadOnly = true;
            txtValorProduto.ReadOnly = true;
            //
            boxCategoriaProdutos.Enabled = false;
            canselectgrid = true;

        }

        private void boxAutoID_CheckedChanged(object sender, EventArgs e)
        {
            if (boxAutoID.Checked == false)
            {
                txtIDProduto.ReadOnly = false;
            }
            else if (boxAutoID.Checked == true)
            {
                txtIDProduto.ReadOnly = true;
                string max = "IDProduto"; string from = "produtos";
                txtIDProduto.Text = con.LastId(max, from).ToString();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void DataGridDB_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (canselectgrid == true)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string IDProduto = DataGridDB.Rows[e.RowIndex].Cells["IDProduto"].Value.ToString();
                    txtIDProduto.Text = IDProduto;
                    string nomeProduto = DataGridDB.Rows[e.RowIndex].Cells["NomeProduto"].Value.ToString();
                    txtNomeProduto.Text = nomeProduto;
                    string CategoriaProduto = DataGridDB.Rows[e.RowIndex].Cells["CategoriaProduto"].Value.ToString();
                    boxCategoriaProdutos.Text = CategoriaProduto;
                    string valorProduto = DataGridDB.Rows[e.RowIndex].Cells["ValorProduto"].Value.ToString();
                    txtValorProduto.Text = valorProduto;

                }
            }
        }

        private void btnEditCategoria_Click(object sender, EventArgs e)
        {
            CriarCategoriasView.ShowDialog();
            CategoriaProdutosArray();
        }
    }
}
