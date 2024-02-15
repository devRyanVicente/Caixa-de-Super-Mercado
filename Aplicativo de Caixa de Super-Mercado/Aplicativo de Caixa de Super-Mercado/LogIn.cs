using Conexao;
using MySql.Data.MySqlClient;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Aplicativo_de_Caixa_de_Super_Mercado
{
    public partial class LogIn : Form
    {
        string IDFunc;
        Conexaoclass con = new Conexaoclass();
        MySqlCommand cmd;
        //
        Caixista CaixaView = new Caixista();
        Admin AdminView = new Admin();
        //
        public LogIn()
        {
            InitializeComponent();
        }
        public string VoltarInfo()
        {
            return IDFunc;
        }
        public void EntrarConta()
        {
            string sIDEntrar = txtIDEntrar.Text.ToString();
            IDFunc = sIDEntrar;
            string sSenhaEntrar = txtSenhaEntrar.Text.ToString();
            DateTime DataLogin = DateTime.Now;
            if (sIDEntrar == "" || sSenhaEntrar == "")
            {
                MessageBox.Show("Erro Preencha os Campos!");
            }
            if (sIDEntrar != "" && sSenhaEntrar != "")
            {
                con.AbrirCon();
                string sql = "SELECT * FROM funcionarios WHERE IDFuncionario = @sIDEntrar AND SenhaFuncionario = @sSenhaEntrar";
                cmd = new MySqlCommand(sql, con.con); // inicializando cmd
                cmd.Parameters.AddWithValue("@sIDEntrar", sIDEntrar);
                cmd.Parameters.AddWithValue("@sSenhaEntrar", sSenhaEntrar);
                //verificar id e senha
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    string sCargoEntrarConta;
                    sql = "UPDATE funcionarios SET DataUltimoLogin = @DataLogin WHERE IDFuncionario = @sIDEntrar";
                    cmd = new MySqlCommand(sql, con.con); // inicializando cmd
                    cmd.Parameters.AddWithValue("@sIDEntrar", sIDEntrar);
                    cmd.Parameters.AddWithValue("@DataLogin", DataLogin);
                    cmd.ExecuteNonQuery(); // executa | Write DataLogin!
                                           
                    sql = "SELECT CargoFuncionario FROM funcionarios WHERE IDFuncionario = @sIDEntrar";
                    cmd = new MySqlCommand(sql, con.con); // inicializando cmd
                    cmd.Parameters.AddWithValue("@sIDEntrar", sIDEntrar);
                    cmd.ExecuteNonQuery();// executa |  mostrar formulario dependendo do cargo!
                    //Cargos {Caixista, Gerente, Admin)
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                        if (reader.Read())
                        {
                         sCargoEntrarConta = reader["CargoFuncionario"].ToString();
                            txtIDEntrar.Text = "";
                            txtSenhaEntrar.Text = "";
                        }
                        else
                        {
                         sCargoEntrarConta = "Desconhecido";
                        }
                    // fazer verificação dupla em task para ter certeza que o funcionario existe!
                    // fazer verificação dupla em task para ter certeza que o funcionario existe! é
                    if (sCargoEntrarConta == "Caixista")
                    {
                        con.FecharCon();
                        CaixaView.lblIDCX.Text = sIDEntrar;
                        CaixaView.ShowDialog(); 
                    }
                    else if (sCargoEntrarConta == "Admin")
                    {
                        con.FecharCon();
                        AdminView.lblIDPOR.Text = sIDEntrar;
                        AdminView.ShowDialog();
                        
                    }
                    else if (sCargoEntrarConta == "Desconhecido"){
                        con.FecharCon();
                        MessageBox.Show("Seu Cargo não foi Encontrado, Você editou no codigo?", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Registro Não Encontrado! Verifique com o Gerente", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.FecharCon();
                }
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            EntrarConta();
        }
        private async Task LoopVerificarConexao()
        {
            while (true)
            {
                bool conexaoativada = await con.LoopVerificarConexao();
                txtconexaoativaoudesativa.BackColor = Color.Gray;
                txtconexaoativaoudesativa.Invoke((MethodInvoker)delegate
                {
                    txtconexaoativaoudesativa.Text = conexaoativada ? "Ativa!" : "Desativada!";
                    txtconexaoativaoudesativa.BackColor = conexaoativada ? Color.Green : Color.Red;
                });
                await Task.Delay(TimeSpan.FromSeconds(5));
            }
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            LoopVerificarConexao();
        }
    }
}