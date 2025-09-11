using EasyEncryption;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MiCommerce.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public int IdCategoria { get; set; }
        public int IdRespCadastro { get; set; }

        public bool cadastrar()
        {
            string comando = "INSERT INTO produtos (nome,preco,id_categoria,id_respcadastro) VALUES " + "(@nome,@preco,@id_categoria,@id_respcadastro)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@id_categoria", IdCategoria);
            cmd.Parameters.AddWithValue("@id_respcadastro", IdRespCadastro);

            cmd.Prepare();
            // O trecho abaixo irá retornar true caso o cadastro dê certo:
            // Em caso de erro, experimente comentar o try/catch e executar novamente o código;
            // Grande parte dos problemas estão associados à um comando SQL incorreto. Verifique a string comando.
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }


        public DataTable listar()
        {

            string comando = "SELECT * FROM produtos";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool Modificar()
        {

            string comando = "UPDATE produtos SET  nome = @nome, preco = @preco, id_categoria = @id_categoria, id_resp_cadastro = @id_resp_cadastro WHERE id = @id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@id_categoria", IdCategoria);
            cmd.Parameters.AddWithValue("@id_resp_cadastro", IdRespCadastro);
            cmd.Parameters.AddWithValue("@id", Id);

            int resultado = cmd.ExecuteNonQuery();


            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
        public bool Apagar()
        {
            string comando = "DELETE FROM produtos WHERE id = @id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }
        public bool Editar()
        {
            string comando = "SELECT * FROM produtos WHERE id = @id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
            try
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Nome = reader["nome"].ToString();
                        Preco = Convert.ToDouble(reader["preco"]);
                        IdCategoria = Convert.ToInt32(reader["id_categoria"]);
                        IdRespCadastro = Convert.ToInt32(reader["id_respcadastro"]);

                        conexaoBD.Desconectar(con);
                        return true; // Produto encontrado e dados carregados
                    }
                    else
                    {
                        conexaoBD.Desconectar(con);
                        return false; // Produto não encontrado
                    }
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false; // Erro na execução
            }
        }

}   } 
