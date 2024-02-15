using MySql.Data.MySqlClient;
using Aplicativo_de_Caixa_de_Super_Mercado;
using System;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Security.Cryptography;
using Mysqlx.Resultset;

namespace Conexao
{
    class Conexaoclass()
    {
        MySqlCommand cmd;
        string conec = "SERVER=localhost; DATABASE=Central; UID=root; ConvertZeroDateTime=true;";
        public MySqlConnection con = null;
        public void AbrirCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void FecharCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AbrirConRecibo()
        {
            try
            {
                conec = "SERVER=localhost; DATABASE=Central; UID=root; ConvertZeroDateTime=true;";
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void FecharConRecibo()
        {
            try
            {
                conec = "SERVER=localhost; DATABASE=centralrecibo; UID=root; ConvertZeroDateTime=true;";
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public async Task<bool> LoopVerificarConexao()
        {
            HttpClient client = new HttpClient();
            while (true)
            {

                try
                {
                    HttpResponseMessage response = await client.GetAsync("http://localhost/phpmyadmin/");
                    response.EnsureSuccessStatusCode();
                    bool conexao = true;
                    return (conexao);
                }
                catch
                {
                    MessageBox.Show("Não existe Ligação a Database!\n\nVerifique seu XAMPP, Ative o Apache é MySQL!", "Erro na Conexão com a SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bool conexao = false;
                    return (conexao);

                }
            }

        }
        //          coluna 
        // service, from, where, UniqueID, CriarID, CriarNome, DataCriar, Autoid(checkbox true or false), CriarCategoria (produto only), CriarValorProduto
        public void InsertSQL(string service, string from, string where, string CriarID, string CriarNome, DateTime DataCriar, bool autoid, string CriarCategoriaProduto, string CriarValorProduto, string CriarSenhaFuncionario, string CriarCargoFuncionario, string CriarCategoria)
        {
            AbrirCon();
            string sql;
            // service can be : Produtos, Contas, Categorias, Recibos
            if (CriarNome != "")
            {

                sql = "SELECT COUNT(*) FROM " + from + " WHERE " + where + " = @criarid"; // verificação
                cmd = new MySqlCommand(sql, con); // inicializando cmd
                cmd.Parameters.AddWithValue("@criarid", CriarID);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Já existe um registro com o mesmo ID ou Nome.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (service == "Produtos")
                    {
                        if (CriarID == "" || autoid == true)
                        {
                            string maxUniqueID = "UniqueID";
                            int iAutoUniqueID = LastId(maxUniqueID, from);
                            string max = "IDProduto";
                            int iAutoID = LastId(max, from);
                            sql = "INSERT INTO " + from + " VALUES ("+iAutoUniqueID+", "+iAutoID+", @nomeproduto, @categoriaproduto, "+CriarValorProduto+", @datacriadoproduto)";
                            // UniqueID, IDProduto, NomeProduto, CategoriaProduto, ValorProduto, DataCriadoProduto
                            cmd = new MySqlCommand(sql, con);

                            cmd.Parameters.AddWithValue("@nomeproduto", CriarNome);
                            cmd.Parameters.AddWithValue("@categoriaproduto", CriarCategoriaProduto);
                            cmd.Parameters.AddWithValue("@datacriadoproduto", DataCriar);

                            //MessageBox.Show(sql);
                            cmd.ExecuteNonQuery(); // executa
                        }
                        else
                        {
                            // string max = "IDFuncionario"; 
                            string maxUniqueID = "UniqueID";
                            int iAutoUniqueID = LastId(maxUniqueID, from);
                            int IDFrmStrn = Int32.Parse(CriarID);

                            sql = "INSERT INTO " + from + " VALUES (" + iAutoUniqueID + ", " + CriarID + ", @nomeproduto, @categoriaproduto, " + CriarValorProduto + ", @datacriadoproduto)";
                            // UniqueID, IDProduto, NomeProduto, CategoriaProduto, ValorProduto, DataCriadoProduto
                            cmd = new MySqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@nomeproduto", CriarNome);
                            cmd.Parameters.AddWithValue("@categoriaproduto", CriarCategoriaProduto);
                            cmd.Parameters.AddWithValue("@datacriadoproduto", DataCriar);
                            //MessageBox.Show(sql);
                            cmd.ExecuteNonQuery(); // executa
                        }
                        MessageBox.Show("Resgistro Criado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (service == "Contas")
                    {
                        if (CriarID == "" || autoid == true)
                        {
                            // funcionarios == UniqueID, IDFuncionario, NomeFuncionario, SenhaFuncionario, CargoFuncionario, DataUltimoLogin, DataFuncionarioCriado
                            sql = "INSERT INTO " + from + " VALUES (@uniqueidfuncionario, @idfuncionario, @nomefuncionario, @senhafuncionario, @cargofuncionario, NULL, @datafuncionariocriado)";
                            // string max = "IDFuncionario"; 
                            string maxUniqueID = "UniqueID";
                            int iAutoUniqueID = LastId(maxUniqueID, from);
                            string max = "IDFuncionario";
                            int iAutoID = LastId(max, from);
                            // UniqueID, IDProduto, NomeProduto, CategoriaProduto, ValorProduto, DataCriadoProduto
                            cmd = new MySqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@uniqueidfuncionario", iAutoUniqueID);
                            cmd.Parameters.AddWithValue("@idfuncionario", iAutoID);
                            cmd.Parameters.AddWithValue("@nomefuncionario", CriarNome);
                            cmd.Parameters.AddWithValue("@senhafuncionario", CriarSenhaFuncionario);
                            cmd.Parameters.AddWithValue("@cargofuncionario", CriarCargoFuncionario);
                            cmd.Parameters.AddWithValue("@datafuncionariocriado", DataCriar);

                            cmd.ExecuteNonQuery(); // executa
                        }
                        else
                        {
                            // funcionarios == UniqueID, IDFuncionario, NomeFuncionario, SenhaFuncionario, CargoFuncionario, DataUltimoLogin, DataFuncionarioCriado
                            sql = "INSERT INTO " + from + " VALUES (@uniqueidfuncionario, @idfuncionario, @nomefuncionario, @senhafuncionario, @cargofuncionario, NULL, @datafuncionariocriado)";
                            string maxUniqueID = "UniqueID";
                            int iAutoUniqueID = LastId(maxUniqueID, from);
                            // UniqueID, IDProduto, NomeProduto, CategoriaProduto, ValorProduto, DataCriadoProduto
                            cmd = new MySqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@uniqueidfuncionario", iAutoUniqueID);
                            cmd.Parameters.AddWithValue("@idfuncionario", CriarID);
                            cmd.Parameters.AddWithValue("@nomefuncionario", CriarNome);
                            cmd.Parameters.AddWithValue("@senhafuncionario", CriarSenhaFuncionario);
                            cmd.Parameters.AddWithValue("@cargofuncionario", CriarCargoFuncionario);
                            cmd.Parameters.AddWithValue("@datafuncionariocriado", DataCriar);

                            cmd.ExecuteNonQuery(); // executa
                        }
                        MessageBox.Show("Resgistro Criado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (service == "Categorias")
                    {
                        string maxUniqueID = "UniqueID";
                        int iAutoUniqueID = LastId(maxUniqueID, from);
                        sql = "INSERT INTO " + from + " VALUES ("+iAutoUniqueID+", @categoriaproduto, @datacriadoproduto)";
                        cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@categoriaproduto", CriarCategoria);
                        cmd.Parameters.AddWithValue("@datacriadoproduto", DataCriar);

                        //MessageBox.Show(sql);
                        cmd.ExecuteNonQuery(); // executa
                    }
                
                }
           
            }
            else
            {
                MessageBox.Show("Algum Campo Não foi Preenchido.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void criarprodutosql(string CriarIDProduto, string CriarNomeProduto, string CriarCategoriaProduto, string CriarValorProduto, DateTime DataCriar, bool autoid)
        {
            AbrirCon();
            string sql;
            if (CriarNomeProduto != "")
            {

                sql = "SELECT COUNT(*) FROM produtos WHERE IDProdutos = @idproduto"; // verificação
                cmd = new MySqlCommand(sql, con); // inicializando cmd
                cmd.Parameters.AddWithValue("@idproduto", CriarIDProduto);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Já existe um registro com o mesmo ID ou Nome.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (CriarIDProduto == "" || autoid == true) // autoid 
                    {
                        sql = "INSERT INTO produtos VALUES (@uniqueid, @idprodutos, @nomeproduto, @categoriaproduto, @valorproduto, @datacriadofuncionario)";
                        string max = "IDProdutos"; string from = "produtos";
                        int iAutoID = LastId(max, from);
                        string uniquemax = "UniqueID"; string uniquefrom = "produtos";
                        int UniqueID = LastId(uniquemax, uniquefrom);
                        cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@uniqueid", UniqueID);
                        cmd.Parameters.AddWithValue("@idprodutos", iAutoID);
                        cmd.Parameters.AddWithValue("@nomeproduto", CriarNomeProduto);
                        cmd.Parameters.AddWithValue("@categoriaproduto", CriarCategoriaProduto);
                        cmd.Parameters.AddWithValue("@valorproduto", CriarValorProduto);
                        cmd.Parameters.AddWithValue("@datacriadofuncionario", DataCriar);

                        cmd.ExecuteNonQuery(); // executa
                    }
                    else
                    {
                        string uniquemax = "UniqueID"; string uniquefrom = "produtos";
                        int UniqueID = LastId(uniquemax, uniquefrom);
                        sql = "INSERT INTO produtos VALUES (@uniqueid, @idprodutos, @nomeproduto, @categoriaproduto, @valorproduto, @datacriadofuncionario)";
                        cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@uniqueid", UniqueID);
                        cmd.Parameters.AddWithValue("@idprodutos", CriarIDProduto);
                        cmd.Parameters.AddWithValue("@nomeproduto", CriarNomeProduto);
                        cmd.Parameters.AddWithValue("@categoriaproduto", CriarCategoriaProduto);
                        cmd.Parameters.AddWithValue("@valorproduto", CriarValorProduto);
                        cmd.Parameters.AddWithValue("@datacriadofuncionario", DataCriar);

                        cmd.ExecuteNonQuery(); // executa
                    }
                    MessageBox.Show("Resgistro Criado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FecharCon();
            }
            else
            {
                MessageBox.Show("Preencha os Campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int LastId(string max, string from)
        {
            try
            {
                AbrirCon();
                string sql = "SELECT MAX("+max+") FROM " + from;
               // MessageBox.Show(sql);
                MySqlCommand cmd = new MySqlCommand(sql, con);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value && result is IConvertible)
                {
                    // Converte para um inteiro
                    int ultimoId = Convert.ToInt32(result);
                    ultimoId++; // adicão automatica para o prox id lastid + 1
                    return ultimoId;
                }
                else
                {
                    MessageBox.Show("Registro Não Encontrado!\n\nVerifique a Database!\n\n Last ID Request", "Erro na Conexão com a SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
                return 0;

            }



        }
        public void UpdateSQL(string service, string from, string where, string CriarID, string CriarNome, DateTime DataCriar, string CriarCategoriaProduto, string CriarValorProduto, string oldAlterarIDProduto, string CriarSenhaFuncionario, string CriarCargoFuncionario, string CriarCategoria)
        {
            AbrirCon();
            string sql;
            // service can be : Produtos, Contas
            if (service == "Categorias")
            {
                sql = "UPDATE " + from + " SET CategoriaProdutos = @CriarCategoria WHERE UniqueID = @uniqueid";

                // UniqueID, IDProduto, NomeProduto, CategoriaProduto, ValorProduto, DataCriadoProduto
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CriarCategoria", CriarCategoria);
                cmd.Parameters.AddWithValue("@uniqueid", oldAlterarIDProduto);
                cmd.ExecuteNonQuery(); // executa
                MessageBox.Show("Sucesso.");

            } // fazer essa verificação primeiro ja que não temos o CriarID
            sql = "SELECT COUNT(*) FROM " + from + " WHERE " + where + " = @criarid"; // verificação
            cmd = new MySqlCommand(sql, con); // inicializando cmd
            cmd.Parameters.AddWithValue("@criarid", CriarID);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                //MessageBox.Show("Registro Antigo Encontrado!", "Aguarde", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sql = "SELECT UniqueID FROM " + from + " WHERE " + where + " = @oldalteraridproduto";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@oldalteraridproduto", oldAlterarIDProduto);
                string uniqueID = null;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uniqueID = reader.GetInt32("UniqueID").ToString(); // Supondo que UniqueID seja do tipo string
                    }
                }
                if (service == "Produtos")
                {
                   // MessageBox.Show(CriarValorProduto.ToString());
                    sql = "UPDATE "+from+" SET IDProduto = "+CriarID+ ", NomeProduto = @nomeproduto, CategoriaProduto = @categoriaproduto, ValorProduto = "+CriarValorProduto+" WHERE UniqueID = @uniqueid";

                    // UniqueID, IDProduto, NomeProduto, CategoriaProduto, ValorProduto, DataCriadoProduto
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@uniqueid", uniqueID);
                    cmd.Parameters.AddWithValue("@nomeproduto", CriarNome);
                    cmd.Parameters.AddWithValue("@categoriaproduto", CriarCategoriaProduto);
                    // cmd.Parameters.AddWithValue("@idproduto", CriarID);
                    //       cmd.Parameters.AddWithValue("@valorproduto", CriarValorProduto);
                    cmd.ExecuteNonQuery(); // executa


                }
                if (service == "Contas")
                {
                    {
                        // funcionarios == UniqueID, IDFuncionario, NomeFuncionario, SenhaFuncionario, CargoFuncionario, DataUltimoLogin, DataFuncionarioCriado
                        sql = "UPDATE "+from+" SET IDFuncionario = @idfuncionario, NomeFuncionario = @nomefuncionario, SenhaFuncionario = @senhafuncionario, CargoFuncionario = @cargofuncionario WHERE UniqueID = @uniqueid";

                        // UniqueID, IDProduto, NomeProduto, CategoriaProduto, ValorProduto, DataCriadoProduto
                        cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@uniqueid", uniqueID);
                        cmd.Parameters.AddWithValue("@idfuncionario", CriarID);
                        cmd.Parameters.AddWithValue("@nomefuncionario", CriarNome);
                        cmd.Parameters.AddWithValue("@senhafuncionario", CriarSenhaFuncionario);
                        cmd.Parameters.AddWithValue("@cargofuncionario", CriarCargoFuncionario);

                        cmd.ExecuteNonQuery(); // executa

                    }

                    MessageBox.Show("Resgistro Editado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (service == "Recibos")
                {
                    sql = "UPDATE "+from+" SET DataUtilizadoRecibo = @datautilizadorecibo WHERE UniqueID = @uniqueid";

                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@uniqueid", CriarID);
                    cmd.Parameters.AddWithValue("@datautilizadorecibo", DataCriar);
                    cmd.ExecuteNonQuery(); // executa
                }
               
            }
            else if (count == 0 && service != "Categorias")
    {
                MessageBox.Show("ERRO, algum Campo não foi Preenchido.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void UpdateSQLold(string from, string where, string IDProduto, string NomeProduto, string CategoriaProduto, string ValorProduto)
        {
            string UniqueID = null;
            try
            {
                // utilizando UniqueID ele troca as outras informações, IDProduto deve ser utilizado na verificação de produtos do caixa!
                AbrirCon();
                string sql = "UPDATE "+from+" SET IDProduto = @idproduto, NomeProduto = @nomeproduto, CategoriaProduto = @categoriaproduto, ValorProduto = @valorproduto WHERE "+where+" = @uniqueid";
                cmd = new MySqlCommand(sql, con); // inicializando cmd
                cmd.Parameters.AddWithValue("@idproduto", IDProduto);
                cmd.Parameters.AddWithValue("@nomeproduto", NomeProduto);
                cmd.Parameters.AddWithValue("@categoriaproduto", CategoriaProduto);
                cmd.Parameters.AddWithValue("@valorproduto", ValorProduto);
                cmd.Parameters.AddWithValue("@uniqueid", UniqueID);
                int linhasAfetadas = cmd.ExecuteNonQuery();
                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Registro alterado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro alterado. Verifique o ID selecionado.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void RemoverSQL(string from, string where, string var1) // from (coluna) where(nome da linha para pesquisar) var1 (resposta da pesquisa)
        {
            try
            {
                // searching on UniqueID
                // first of all by some OLD var == take UniqueID
             
                AbrirCon();
                string sql;
                sql = "SELECT UniqueID FROM " + from + " WHERE " + where + " = @oldvar";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@oldvar", var1);
                Int32 uniqueID;
                string sUniqueID;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uniqueID = reader.GetInt32("UniqueID");
                        sUniqueID = uniqueID.ToString();
                        sql = "DELETE FROM "+from+" WHERE "+where+" = @var1";
                        cmd = new MySqlCommand(sql, con); // inicializando cmd
                        cmd.Parameters.AddWithValue("@var1", sUniqueID);
                       
                    }

                }
                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Registro Removido com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro alterado.");

                }
            }

            catch (Exception)
            {

                throw;
            }
        }


        }
}
