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
    public partial class Caixista : Form
    {
        Conexaoclass con = new Conexaoclass();
        MySqlCommand cmd;
        public Caixista()
        {
            DataTable dataCaixa = new DataTable();
            InitializeComponent();
        }
        private void EnviarParaRecibos()
        {
            con.AbrirCon();

            decimal valorTotalVenda = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                valorTotalVenda += Convert.ToDecimal(row.Cells["Total"].Value);
            }

            int idFuncionarioRecibo = Convert.ToInt32(lblIDCX.Text);

            DateTime dataCriadoRecibo = DateTime.Now;

            DateTime? dataUtilizadoRecibo = null;

            // Inserir os dados na tabela "recibos"
            string max = "UniqueID"; string from = "recibos";
            int iAutoID = con.LastId(max, from);
            string sqlInsertRecibo = "INSERT INTO recibos (UniqueID, ValorVendaTotal, IDFuncionarioRecibo, DataCriadoRecibo, DataUtilizadoRecibo) VALUES (@uniqueID,@valorTotalVenda, @idFuncionarioRecibo, @dataCriadoRecibo, @dataUtilizadoRecibo)";
            cmd = new MySqlCommand(sqlInsertRecibo, con.con);
            cmd.Parameters.AddWithValue("@uniqueID", iAutoID);
            cmd.Parameters.AddWithValue("@valorTotalVenda", valorTotalVenda);
            cmd.Parameters.AddWithValue("@idFuncionarioRecibo", idFuncionarioRecibo);
            cmd.Parameters.AddWithValue("@dataCriadoRecibo", dataCriadoRecibo);
            cmd.Parameters.AddWithValue("@dataUtilizadoRecibo", dataUtilizadoRecibo);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Recibo inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir recibo: " + ex.Message);
            }
            finally
            {
                con.FecharCon();
            }
        }

        public void ts()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "UniqueID";
            dataGridView1.Columns[1].Name = "IDProdutos";
            dataGridView1.Columns[2].Name = "NomeProduto";
            dataGridView1.Columns[3].Name = "Total";
            dataGridView1.Columns[4].Name = "ValorProduto";
            dataGridView1.Columns[5].Name = "Quantidade";
        }
        public void ConsultarProduto()
        {
            con.AbrirCon();
            string addid = txtIDAdicionar.Text;
            string sql = "SELECT * FROM produtos WHERE IDProduto = @idproduto";
            cmd = new MySqlCommand(sql, con.con); // inicializando cmd
            cmd.Parameters.AddWithValue("@idproduto", addid);
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                if (!reader.HasRows) // caso não tenha linhas
                {
                    MessageBox.Show("Produto Não Encontrado!");
                    txtIDAdicionar.Clear();
                }
                else
                {

                    lblNomeProduto.Text = reader["NomeProduto"].ToString();
                    lblPrecoProduto.Text = reader["ValorProduto"].ToString();
                    decimal value = decimal.Parse(lblPrecoProduto.Text);
                    decimal multi;
                    if (txtQuantidade.Text != "") { multi = decimal.Parse(txtQuantidade.Text); }
                    else { multi = 1; }
                    decimal total = decimal.Multiply(value, multi);
                    decimal valorTotalVenda = 0;
                    dataGridView1.Rows.Add(reader["UniqueID"].ToString(), reader["IDProduto"].ToString(), reader["NomeProduto"].ToString(), total.ToString(), reader["ValorProduto"].ToString(), multi.ToString());
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        valorTotalVenda += Convert.ToDecimal(row.Cells["Total"].Value);
                    }
                    lblValorTotal.Text = valorTotalVenda.ToString();

                    txtIDAdicionar.Clear();
                    txtQuantidade.Clear();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }

        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ConsultarProduto();
        }

        private void Caixista_Load(object sender, EventArgs e)
        {
            ts();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnviarTabela_Click(object sender, EventArgs e)
        {
            EnviarParaRecibos();
            dataGridView1.Rows.Clear();
            //
            lblNomeProduto.Text = "*";
            lblValorTotal.Text = "";
            lblPrecoProduto.Text = "";
            //
            txtQuantidade.Clear();
            txtIDAdicionar.Clear();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}