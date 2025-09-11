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
        int idSelecionado = 0;
        public FormUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            // Mostrar as informaçoes do bd no datagridfive
            dgvUsuarios.DataSource = usuario;
            Atualizardgv();
        }
        public void Atualizardgv()
        {
            // mostrar as informacoes 
            dgvUsuarios.DataSource = usuario.listar();

        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha selecionada:
            int ls = dgvUsuarios.SelectedCells[0].RowIndex;

            // Colocar os valores das células no txbs de edição:
            txbNomeEditar.Text = dgvUsuarios.Rows[ls].Cells[1].Value.ToString();
            txbEmailEditar.Text = dgvUsuarios.Rows[ls].Cells[2].Value.ToString();

            // Armazenar o ID de quem foi selecionado:
            idSelecionado = (int)dgvUsuarios.Rows[ls].Cells[0].Value;

            // Ativar o grbEditar:
            grbEditar.Enabled = true;

            // Ajustes no grbApagar:
            lblDescricaoApagar.Text = $"Apagar: {dgvUsuarios.Rows[ls].Cells[1].Value}";

            // Ativar o grbApagar:
            grbApagar.Enabled = true;
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

            }
            else if (txbEmailCadastro.Text.Length < 7)
            {
                MessageBox.Show(" o email deve ter no minimo 7 caracteres.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbSenhaCadastro.Text.Length < 6)
            {
                MessageBox.Show(" A senha deve ter no minimo 6 caracteres.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //Fazer o cadastro
                Model.Usuario usuarioCadastro = new Model.Usuario();
                // SALVAR
                usuarioCadastro.NomeCompleto = txbNomeCadastro.Text;
                usuarioCadastro.Email = txbEmailCadastro.Text;
                usuarioCadastro.Senha = txbSenhaCadastro.Text;

                // Executar o insert
                if (usuarioCadastro.cadastrar())
                {
                    MessageBox.Show("usuario cadastrado com sucesso!", "show!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // atualizar o dgv:
                    Atualizardgv();

                    // apagar os campos de cadastros
                    txbNomeCadastro.Clear();
                    txbEmailCadastro.Clear();
                    txbSenhaCadastro.Clear();
                }
                else
                {
                    MessageBox.Show("falha ao cadastrar o usuario.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           






        }
        

        public void ResetarCampos()
        {
            Atualizardgv();
            

            // Limpar campos de edição:
            txbEmailEditar.Clear();
            txbSenhaEditar.Clear();
            txbNomeEditar.Clear();

            // Retornar o idSelecionado para 0
            idSelecionado = 0;

            // Retornar o texto padrão do "apagar":
            lblDescricaoApagar.Text = "Selecione o usuário que deseja apagar.";

            // Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailEditar.Text.Length < 7) // a@a.co
            {
                MessageBox.Show("O email deve ter no mínimo 7 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaEditar.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir com a edição:
                Model.Usuario usuarioEditar = new Model.Usuario();
                usuarioEditar.Id = idSelecionado;
                usuarioEditar.NomeCompleto = txbNomeEditar.Text;
                usuarioEditar.Email = txbEmailEditar.Text;
                usuarioEditar.Senha = txbSenhaEditar.Text;

                if (usuarioEditar.Modificar())
                {
                    MessageBox.Show("Usuário modificado com sucesso!", "Show!",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao modificar usuário!", "Erro",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este usuário?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Prosseguir com a exclusão...
                Model.Usuario usuarioApagar = new Model.Usuario();

                usuarioApagar.Id = idSelecionado;
                if (usuarioApagar.Apagar())
                {
                    MessageBox.Show("Usuário apagado com sucesso!", "Show!",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao apagar o usuário.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
