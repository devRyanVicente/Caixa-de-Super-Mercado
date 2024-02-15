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
using System.Xml;

namespace Aplicativo_de_Caixa_de_Super_Mercado
{
    public partial class SubContas : Form
    {
        bool canselectgrid = true;
        Conexaoclass con = new Conexaoclass();
        MySqlCommand cmd;
        string oldAlterarIDProduto;
        public SubContas()
        {
            InitializeComponent();
        }

        private void SubCriarConta_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            /*
            string CriarIDFuncionario = txtIDFuncionario.Text;
            string CriarNomeFuncionario = txtNomeFuncionario.Text;
            string CriarSenhaFuncionario = txtSenhaDoFuncionario.Text;
            string CriarCargoFuncionario = boxCargoDoFuncionario.Text;
            DateTime DataCriar = DateTime.Now;
            bool bAutoIDBox = boxAutoID.Checked;
        //    con.criarcontasql(CriarIDFuncionario, CriarNomeFuncionario, CriarSenhaFuncionario, CriarCargoFuncionario, DataCriar, bAutoIDBox);
            txtNomeFuncionario.Text = "";
            txtSenhaDoFuncionario.Text = "";
            boxCargoDoFuncionario.Text = "";
            string max = "IDFuncionario"; string from = "funcionarios";
            txtIDFuncionario.Text = con.LastId(max, from).ToString();
            */
            canselectgrid = false;
            txtUniqueID.Text = "";
            txtIDFuncionario.Text = "";
            txtNomeFuncionario.Text = "";
            txtSenhaDoFuncionario.Text = "";
            boxCargoDoFuncionario.Text = "";
            txtDataFuncionarioLogin.Text = "";
            txtDataFuncionarioCriado.Text = "";
            if (boxAutoID.Checked == true)
            {
                string maxd = "IDFuncionario"; string fromd = "funcionarios";
                txtIDFuncionario.Text = con.LastId(maxd, fromd).ToString();
            }
            string max = "UniqueID"; string from = "funcionarios";
            txtUniqueID.Text = con.LastId(max, from).ToString();
            // Buttons
            btnCancelar.Visible = true;
            btnCriarConta.Visible = false;
            btnAlterarFuncionario.Visible = false;
            btnDeletarRegistro.Visible = false;
            // Sub-Buttons
            btnConfirmarCriarFuncionario.Visible = true;
            btnConfirmarAlteracao.Visible = false;
            btnConfirmarDeletarRegistro.Visible = false;
            btnCancelar.Visible = true;
            // Boxes
            boxAutoID.Visible = true;
            boxCargoDoFuncionario.Enabled = true;
            // textboxes
            txtNomeFuncionario.ReadOnly = false;
            txtSenhaDoFuncionario.ReadOnly = false;

        }

        private void boxAutoID_CheckedChanged(object sender, EventArgs e)
        {
            if (boxAutoID.Checked == true)
            {
                txtIDFuncionario.ReadOnly = true;
                txtIDFuncionario.Text = "";
                string max = "IDFuncionario"; string from = "funcionarios";
                txtIDFuncionario.Text = con.LastId(max, from).ToString();
            }
            else if (boxAutoID.Checked == false)
            {
                txtIDFuncionario.ReadOnly = false;
                txtIDFuncionario.Text = "";
            }
        }

        private void DataGridDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void AtualizarGrid()
        {
            MySqlCommand objCommand = null;
            string strSQL = "SELECT * FROM funcionarios";
            MySqlConnection cmd = null;
            try
            {
                con.AbrirCon();
                objCommand = new MySqlCommand(strSQL, con.con);
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                string nomeDaColuna = "NomeFuncionario";
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

        private void DataGridDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {/*
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string UniqueID = DataGridDB.Rows[e.RowIndex].Cells["UniqueID"].Value.ToString();
                txtUniqueID.Text = UniqueID;
                string IDFuncionario = DataGridDB.Rows[e.RowIndex].Cells["IDFuncionario"].Value.ToString();
                txtIDFuncionario.Text = IDFuncionario;
                string NomeFuncionario = DataGridDB.Rows[e.RowIndex].Cells["NomeFuncionario"].Value.ToString();
                txtNomeFuncionario.Text = NomeFuncionario;
                string SenhaFuncionario = DataGridDB.Rows[e.RowIndex].Cells["SenhaFuncionario"].Value.ToString();
                txtSenhaDoFuncionario.Text = SenhaFuncionario;
                string CargoFuncionario = DataGridDB.Rows[e.RowIndex].Cells["CargoFuncionario"].Value.ToString();
                boxCargoDoFuncionario.Text = CargoFuncionario;
                string DataUltimoLoginFuncionario = DataGridDB.Rows[e.RowIndex].Cells["DataUltimoLogin"].Value.ToString();
                txtDataFuncionarioLogin.Text = DataUltimoLoginFuncionario;
                string DataCriadoFuncionario = DataGridDB.Rows[e.RowIndex].Cells["DataFuncionarioCriado"].Value.ToString();
                txtDataFuncionarioCriado.Text = DataCriadoFuncionario;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnConfirmarCriarFuncionario_Click(object sender, EventArgs e)
        {
            canselectgrid = true;
            string CriarIDFuncionario = txtIDFuncionario.Text;
            string CriarNomeFuncionario = txtNomeFuncionario.Text;
            string CriarSenhaFuncionario = txtSenhaDoFuncionario.Text;
            string CriarCargoFuncionario = boxCargoDoFuncionario.Text;
            bool bAutoIDBox = boxAutoID.Checked;
            DateTime CriarDataFuncionario = DateTime.Now;
            string service = "Contas";
            string from = "funcionarios";
            string where = "IDFuncionario";
            if (CriarCargoFuncionario == "")
            {
                CriarCargoFuncionario = "NULL";
            }
            //
            // service, from, where, UniqueID, CriarID, CriarNome, DataCriar, Autoid(checkbox true or false), CriarCategoria (produto only), CriarValorProduto
            con.InsertSQL(service, from, where, CriarIDFuncionario, CriarNomeFuncionario, CriarDataFuncionario, bAutoIDBox, null, null, CriarSenhaFuncionario, CriarCargoFuncionario, null);
            //         con.criarprodutosql(CriarIDProduto, CriarNomeProduto, CriarCategoriaProduto, CriarValorProduto, CriarDataProduto, bAutoIDBox);
            //
            //
            string max1 = "IDFuncionario"; string from1 = "funcionarios";
            txtIDFuncionario.Text = con.LastId(max1, from1).ToString();
            // zerando os textos
            txtUniqueID.Text = "";
            //  txtIDFuncionario.Text = "";
            txtNomeFuncionario.Text = "";
            txtSenhaDoFuncionario.Text = "";
            boxCargoDoFuncionario.Text = ""; boxCargoDoFuncionario.Enabled = false;
            txtDataFuncionarioLogin.Text = "";
            txtDataFuncionarioCriado.Text = "";

            // Buttons
            btnCriarConta.Visible = true;
            btnAlterarFuncionario.Visible = true;
            btnDeletarRegistro.Visible = true;
            // Sub-Buttons
            btnConfirmarCriarFuncionario.Visible = false;
            btnConfirmarAlteracao.Visible = false;
            btnConfirmarDeletarRegistro.Visible = false;
            btnCancelar.Visible = false;
            // Boxes
            boxAutoID.Visible = false;
            // textboxes
            txtIDFuncionario.ReadOnly = true;
            txtNomeFuncionario.ReadOnly = true;
            txtSenhaDoFuncionario.ReadOnly = true;
            // atualizar grid
            AtualizarGrid();
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            canselectgrid = true;
            txtUniqueID.Text = "";
            txtIDFuncionario.Text = "";
            txtNomeFuncionario.Text = "";
            txtSenhaDoFuncionario.Text = "";
            boxCargoDoFuncionario.Text = ""; boxCargoDoFuncionario.Enabled = false;
            txtDataFuncionarioLogin.Text = "";
            txtDataFuncionarioCriado.Text = "";
            // Buttons
            btnCriarConta.Visible = true;
            btnAlterarFuncionario.Visible = true;
            btnDeletarRegistro.Visible = true;
            // Sub-Buttons
            btnConfirmarCriarFuncionario.Visible = false;
            btnConfirmarAlteracao.Visible = false;
            btnConfirmarDeletarRegistro.Visible = false;
            btnCancelar.Visible = false;
            // Boxes
            boxAutoID.Visible = false;
            // textboxes
            txtIDFuncionario.ReadOnly = true;
            txtNomeFuncionario.ReadOnly = true;
            txtSenhaDoFuncionario.ReadOnly = true;

        }

        private void btnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            canselectgrid = false;
            oldAlterarIDProduto = txtIDFuncionario.Text;
            // Buttons
            btnCriarConta.Visible = false;
            btnAlterarFuncionario.Visible = false;
            btnDeletarRegistro.Visible = false;
            btnCancelar.Visible = true;
            // Sub-Buttons
            btnConfirmarCriarFuncionario.Visible = false;
            btnConfirmarAlteracao.Visible = true;
            btnConfirmarDeletarRegistro.Visible = false;
            // Boxes
            boxAutoID.Visible = false;
            boxCargoDoFuncionario.Enabled = true;
            // textboxes
            txtIDFuncionario.ReadOnly = false;
            txtNomeFuncionario.ReadOnly = false;
            txtSenhaDoFuncionario.ReadOnly = false;
            // * cargos = readonly false

        }

        private void btnConfirmarAlteracao_Click(object sender, EventArgs e)
        {


            canselectgrid = true;
            string AlterarIDFuncionario = txtIDFuncionario.Text;
            string AlterarNomeFuncionario = txtNomeFuncionario.Text;
            string AlterarCargoFuncionario = boxCargoDoFuncionario.Text;
            string AlterarSenhaFuncionario = txtSenhaDoFuncionario.Text;
            DateTime AlterarDataProduto = DateTime.Now; // inutil nesse caso aqui mas irei deixar.

            string service = "Contas";
            string from = "funcionarios";
            string where = "IDFuncionario";

            con.UpdateSQL(service, from, where, AlterarIDFuncionario, AlterarNomeFuncionario, AlterarDataProduto, null, null, oldAlterarIDProduto, AlterarSenhaFuncionario, AlterarCargoFuncionario, null);


            //

            txtUniqueID.Text = "";
            txtIDFuncionario.Text = "";
            txtNomeFuncionario.Text = "";
            txtSenhaDoFuncionario.Text = "";
            boxCargoDoFuncionario.Text = ""; boxCargoDoFuncionario.Enabled = false;
            txtDataFuncionarioLogin.Text = "";
            txtDataFuncionarioCriado.Text = "";

            // Buttons
            btnCriarConta.Visible = true;
            btnAlterarFuncionario.Visible = true;
            btnDeletarRegistro.Visible = true;
            // Sub-Buttons
            btnConfirmarCriarFuncionario.Visible = false;
            btnConfirmarAlteracao.Visible = false;
            btnCancelar.Visible = false;
            btnConfirmarDeletarRegistro.Visible = false;
            // Boxes
            boxAutoID.Visible = false;
            // textboxes
            txtIDFuncionario.ReadOnly = true;
            txtNomeFuncionario.ReadOnly = true;
            txtSenhaDoFuncionario.ReadOnly = true;
            // update grid
            AtualizarGrid();
        }

        private void txtPesquisa_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarGrid();
            }
            if (e.KeyCode == Keys.Escape)
            {
                txtPesquisa.Text = "";
                AtualizarGrid();
            }
        }

        private void DataGridDB_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (canselectgrid == true)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string UniqueID = DataGridDB.Rows[e.RowIndex].Cells["UniqueID"].Value.ToString();
                    txtUniqueID.Text = UniqueID;
                    string IDFuncionario = DataGridDB.Rows[e.RowIndex].Cells["IDFuncionario"].Value.ToString();
                    txtIDFuncionario.Text = IDFuncionario;
                    string NomeFuncionario = DataGridDB.Rows[e.RowIndex].Cells["NomeFuncionario"].Value.ToString();
                    txtNomeFuncionario.Text = NomeFuncionario;
                    string SenhaFuncionario = DataGridDB.Rows[e.RowIndex].Cells["SenhaFuncionario"].Value.ToString();
                    txtSenhaDoFuncionario.Text = SenhaFuncionario;
                    string CargoFuncionario = DataGridDB.Rows[e.RowIndex].Cells["CargoFuncionario"].Value.ToString();
                    boxCargoDoFuncionario.Text = CargoFuncionario;
                    string DataUltimoLoginFuncionario = DataGridDB.Rows[e.RowIndex].Cells["DataUltimoLogin"].Value.ToString();
                    txtDataFuncionarioLogin.Text = DataUltimoLoginFuncionario;
                    string DataCriadoFuncionario = DataGridDB.Rows[e.RowIndex].Cells["DataFuncionarioCriado"].Value.ToString();
                    txtDataFuncionarioCriado.Text = DataCriadoFuncionario;
                }
            }else
            {

            }
        }

        private void btnDeletarRegistro_Click(object sender, EventArgs e)
        {
            //            from(coluna) where(nome da linha para pesquisar) var1(resposta da pesquisa)

            string var1 = txtIDFuncionario.Text;
            string from = "funcionarios";
            string where = "IDFuncionario";
            con.RemoverSQL(from, where, var1);
            AtualizarGrid();

            //
            txtUniqueID.Text = "";
            txtIDFuncionario.Text = "";
            txtNomeFuncionario.Text = "";
            txtSenhaDoFuncionario.Text = "";
            boxCargoDoFuncionario.Text = ""; boxCargoDoFuncionario.Enabled = false;
            txtDataFuncionarioLogin.Text = "";
            txtDataFuncionarioCriado.Text = "";
            // Buttons
            btnCriarConta.Visible = true;
            btnAlterarFuncionario.Visible = true;
            btnDeletarRegistro.Visible = true;
            // Sub-Buttons
            btnConfirmarCriarFuncionario.Visible = false;
            btnConfirmarAlteracao.Visible = false;
            btnConfirmarDeletarRegistro.Visible = false;
            btnCancelar.Visible = false;
            // Boxes
            boxAutoID.Visible = false;
            // textboxes
            txtIDFuncionario.ReadOnly = true;
            txtNomeFuncionario.ReadOnly = true;
            txtSenhaDoFuncionario.ReadOnly = true;
        }

        private void btnDeletarRegistro_Click_1(object sender, EventArgs e)
        {
            canselectgrid = false;
            // Buttons
            btnCriarConta.Visible = false;
            btnAlterarFuncionario.Visible = false;
            btnDeletarRegistro.Visible = false;
            // Sub-Buttons
            btnConfirmarCriarFuncionario.Visible = false;
            btnConfirmarAlteracao.Visible = false;
            btnCancelar.Visible = true;
            btnConfirmarDeletarRegistro.Visible = true;
            // Boxes
            boxAutoID.Visible = false;
            // textboxes
            txtIDFuncionario.ReadOnly = true;
            txtNomeFuncionario.ReadOnly = true;
            txtSenhaDoFuncionario.ReadOnly = true;
        }
    }
}
