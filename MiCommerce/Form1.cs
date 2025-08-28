using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCommerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            // verificar se a pessoa digitou o email e senha:
            if (txbEmail.Text.Length < 6)
            {
                MessageBox.Show("digite um email valido!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(txbSenha.Text.Length < 4){
               MessageBox.Show("digite uma senha valida!" , "erro", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                // prosseguir..
                Model.Usuario usuario = new Model.Usuario();

                // colocar os valores dos csmpos nos atributos do usuario
                usuario.Email =txbEmail.Text;
                usuario.Senha = txbSenha.Text;

                DataTable resultado = usuario.Logar();

                if(resultado.Rows.Count ==0)
                {
                      MessageBox.Show("email e/ou senha invalidos!", "erro!",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //armazenar as infos vindas do bd no projeto "usuario"
                    usuario.Id = int.Parse(resultado.Rows[0]["id"].ToString());
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();

                    //mudar para o menu principal 
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    Hide(); //esconder a janela atual 
                    menuPrincipal.ShowDialog(); //mostrar o menuprincipal

                    Show();//mostrar a tela de login ao sair do menu principal

                }

            }
        }
    }
}
