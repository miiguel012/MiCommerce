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
    public partial class FormUsuarios : Form
    {
         // objetos globais 
         Model.Usuario usuario;
        
        public FormUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            // Mostrar as informaçoes do bd no datagridfive
            dgvUsuarios.DataSource = usuario.listar();
        }

        private void txbSenhaCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txbNomeCadastro.Text.Length < 5)
            {
                MessageBox.Show("o nome deve ter no minimo 5 caraxeres.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else if (txbEmailCadastro.Text.Length < 7)
            {
                MessageBox.Show(" o email deve ter no minimo 7 caracteres.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else if (txbSenhaCadastro.Text.Length <6)
            {
                MessageBox.Show(" A senha deve ter no minimo 6 caracteres.","erro",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //Fazer o cadastro
                Model.Usuario usuarioCadastro = new Model.Usuario();
                // SALVAR
                usuarioCadastro.NomeCompleto = txbNomeCadastro.Text;
                usuarioCadastro.Email = txbEmailCadastro.Text;
                usuarioCadastro.Senha = txbSenhaCadastro.Text;

                if (usuarioCadastro.cadastrar())
                {
                    MessageBox.Show("usuario cadastrado com sucesso!", "show!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("falha ao cadastrar o usuario.", "erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            



           

        }
    }
}
