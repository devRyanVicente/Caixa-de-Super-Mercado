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
    public partial class Admin : Form
    {
        //
        SubRecibos RecibosView = new SubRecibos();
        SubContas CriarContaView = new SubContas();
        SubProdutos ProdutosView = new SubProdutos();
        //
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            lblIDPOR.Text = "";
        }

        private void novoFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarContaView.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutosView.ShowDialog();
        }

        private void lblIDPOR_Click(object sender, EventArgs e)
        {

        }

        private void recibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecibosView.ShowDialog();
        }

        private void verProdutos_Click(object sender, EventArgs e)
        {
            ProdutosView.ShowDialog();
        }
    }
}
