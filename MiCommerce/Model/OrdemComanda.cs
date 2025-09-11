using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCommerce.Model
{
    public class OrdemComanda
    {
        public int Id { get; set; }
        public int IdFicha { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public int IdResp { get; set; }
        public DateTime DaraAdic { get; set; }
        public bool Situacao { get; set; }

        // Listar (select na view_fichas)


        public DataTable listar()
        {
            string comando = "SELECT id, nome_completo, email FROM ordens_comandas";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);



            cmd.Prepare();


            DataTable tabela = new DataTable();

            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;


        }
        public bool cadastrar()
        {
            string comando = "INSERT INTO ordens_comandas (id_ficha,id_produto,quantidade,id_resp) VALUES " + "(@id_ficha,@id_produto,@quantidade,@id_resp)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_ficha", IdFicha);
            cmd.Parameters.AddWithValue("@id_produto", IdProduto);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@id_resp", IdResp);

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
    }
    
}
