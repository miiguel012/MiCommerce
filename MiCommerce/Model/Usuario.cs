using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCommerce.Model
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string NomeCompleto{ get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        

        /* Cadastrar 
         * logar
         * modiifcar 
         * remover 
         */

        
        
        public DataTable Logar()
        {

            string comando = "SELECT * FROM usuarios WHERE email = @email AND senha = @senha";
            /*
            Caso vá utilizar o WHERE, empregue o uso de caracteres coringas,
            semelhante ao apresentado no metódo Cadastrar() acima.
            */
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            // OBTER O HAST DA SENHA    
            string senhahash = EasyEncryption.SHA.ComputeSHA256Hash(Senha);

            //substituir os carcteres coringas()
            cmd.Parameters.AddWithValue("@email",Email);
            cmd.Parameters.AddWithValue("@senha",senhahash);

            cmd.Prepare();

            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;

            //tabela que vai receber o resultado do SELECT (logar)
            

        }
    }

        
    
}
