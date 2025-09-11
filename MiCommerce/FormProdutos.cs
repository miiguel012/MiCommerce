using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCommerce
{
    public partial class FormProdutos : Form
    {
        Model.Usuario usuario;
        Model.Produto produto = new Model.Produto();
        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            dgvProdutos.DataSource = usuario;
            Atualizardgv();
            ListarCategoriascmb();
            int idSelecionado = 0;
        }
        public void Atualizardgv()
        {
            // mostrar as informacoes 
            dgvProdutos.DataSource = produto.listar();
        }
        public void ListarCategoriascmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            // Tabela p/ receber o resultado do Select:
            DataTable tabela = categoria.listar();

            foreach (DataRow dr in tabela.Rows)
            {
                // 1 - Salgados
                // 2 - Refrigerantes
                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCadastroEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");

            }
        }




        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ls = dgvProdutos.SelectedCells[0].RowIndex;
            int idSelecionado = 0;
            // Colocar os valores das células no txbs de edição:
            txbNomeEditar.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
            txbPrecoEditar.Text = dgvProdutos.Rows[ls].Cells[2].Value.ToString();

            // Armazenar o ID de quem foi selecionado:
             idSelecionado = (int)dgvProdutos.Rows[ls].Cells[0].Value;

            // Ativar o grbEditar:
            grbEditar.Enabled = true;

            // Ajustes no grbApagar:
            lblDescricaoApagar.Text = $"Apagar: {dgvProdutos.Rows[ls].Cells[1].Value}";

            // Ativar o grbApagar:
            grbApagar.Enabled = true;
        }
        

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txbNome.Text.Length < 5)
            {
                MessageBox.Show("o id deve ter no minimo 5 caraxeres.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbPrecoCadastro.Text.Length < 5)
            {
                MessageBox.Show(" o preco deve ter no minimo 5 caracteres.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbCategoriaCadastro.SelectedItem == null)
            {
                MessageBox.Show(" Escolha uma Categoria.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            else
            {
                //Fazer o cadastro
                Model.Produto produtosCadastro = new Model.Produto();

                produtosCadastro.Nome = txbNome.Text;
                produtosCadastro.Preco = double.Parse(txbPrecoCadastro.Text);
                string selecionado = cmbCategoriaCadastro.SelectedItem.ToString();
                string[] partes = selecionado.Split('-');
                int idCategoria = int.Parse(partes[0].Trim());
                produtosCadastro.IdCategoria = idCategoria;
                produtosCadastro.IdRespCadastro = usuario.Id;

                if (produtosCadastro.cadastrar())
                {
                    MessageBox.Show("produto cadastrado com sucesso!", "show!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // atualizar o dgv:
                    Atualizardgv();

                    txbNome.Clear();
                    txbPrecoCadastro.Clear();
                    cmbCategoriaCadastro.SelectedIndex = -1;

                }
                else
                {
                    MessageBox.Show("falha ao cadastrar o usuario.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text.Length == 0)
            {
                MessageBox.Show("Selecione um produto para editar.");
                return;
            }

            if (txbNomeEditar.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter pelo menos 5 caracteres.");
                return;
            }

            if (txbPrecoEditar.Text.Length > 6)
            {
                MessageBox.Show("Digite um preço válido.");
                return;
            }

            if (cmbCadastroEditar.SelectedItem == null)
            {
                MessageBox.Show("Escolha uma categoria.");
                return;
            }
            string selecionado = cmbCadastroEditar.SelectedItem.ToString();
            int idCategoria = int.Parse(selecionado.Split('-')[0].Trim());

           
            Model.Produto produtosEditar = new Model.Produto();
           
            produtosEditar.Nome = txbNomeEditar.Text.Trim();
            produtosEditar.Preco = Double.Parse(txbPrecoEditar.Text); 
            produtosEditar.IdCategoria = idCategoria;
            produtosEditar.IdRespCadastro = usuario.Id;

            if (produtosEditar.Editar())
            {
                MessageBox.Show("Produto editado com sucesso!");
                Atualizardgv();

                // Limpar campos
                txbNomeEditar.Clear();
                txbPrecoEditar.Clear();
                cmbCadastroEditar.SelectedIndex = -1;
               
            }
            else
            {
                MessageBox.Show("Erro ao editar o produto.");
            }
        }

        private void grbApagar_Enter(object sender, EventArgs e)
        {
            
        }
        public void ResetarCampos()
        {
            // Atualizar o dgv:
            AtualizarDgv();

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

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int idSelecionado = 0;
            // Perguntar se realmente quer apagar:
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







